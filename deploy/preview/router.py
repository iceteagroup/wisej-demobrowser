"""
Wisej.NET Cloud - preview router for one pull request.

Why a router instead of @modal.web_server: web_server makes Modal decide when
the app is "ready", with a hard init cap and no visibility. A slow-starting .NET
app trips that cap, Modal kills the container and retries, and the browser sees
an endless redirect loop with nothing to show the user.

Here the router is a tiny Python ASGI app that cold-starts in about a second and
always answers immediately. It owns the wait: it creates a Sandbox running the
Wisej app, polls it, and reports real progress to the loading page until the app
is serving. We decide how long to wait, not the platform.

Deployed per PR as `wisej-demobrowser-pr-<N>`.
"""

import json
import os
import time
import urllib.error
import urllib.request

import modal

PR_NUMBER = os.environ.get("PR_NUMBER", "local")
APP_NAME = f"wisej-demobrowser-pr-{PR_NUMBER}"

# One stable base image shared by every PR, plus that PR's payload read from a
# Volume at container start. Nothing here is per-PR-built, so the router can
# never boot a stale image ID, and this module never touches the repository -
# it is re-imported inside its own container where the repo does not exist.
BASE_IMAGE_NAME = "wisej-preview-base"
VOLUME_NAME = "wisej-previews"
PAYLOAD_DIR = f"/previews/pr-{PR_NUMBER}"

# How long we're willing to wait for the app to serve before calling it failed.
BOOT_BUDGET_SECONDS = int(os.environ.get("BOOT_BUDGET_SECONDS", 600))

# Hard ceiling Modal enforces on the sandbox process itself.
SANDBOX_MAX_LIFETIME = 6 * 60 * 60

# reap() runs every minute, so this is "shut down after N minutes with zero
# Wisej sessions". More than one poll so a momentary blip can't kill a preview
# somebody is using.
EMPTY_POLLS_BEFORE_REAP = int(os.environ.get("EMPTY_POLLS_BEFORE_REAP", 5))

# Backstop for a sandbox that never reports zero - an app that cancels its
# session timeout, or one whose status endpoint is unreachable.
MAX_SANDBOX_AGE_SECONDS = int(os.environ.get("MAX_SANDBOX_AGE_SECONDS", 6 * 60 * 60))

CPU = 2.0
MEMORY_MB = 4096
APP_PORT = 8080

app = modal.App(APP_NAME)

wisej_image = modal.Image.from_name(BASE_IMAGE_NAME)
volume = modal.Volume.from_name(VOLUME_NAME, create_if_missing=True)

router_image = modal.Image.debian_slim().pip_install("fastapi[standard]")

# Tracks the current sandbox for this PR across router invocations.
state = modal.Dict.from_name(f"{APP_NAME}-state", create_if_missing=True)


# Measured on this image: Modal spends ~180s creating the sandbox (almost all of
# it pulling the image to a cold worker), then the app is serving 2.4s later.
# The pull dominates, so the UI should say so rather than pretend otherwise.
STEPS = [
    ("create", "Requesting a preview container"),
    ("pull", "Pulling the application image (this is the slow part)"),
    ("boot", "Starting .NET and waiting for Kestrel"),
    ("ready", "Preview is ready"),
]


def _probe(url: str, timeout: float = 5.0):
    """One quick attempt. Any HTTP answer means the app is up."""
    try:
        with urllib.request.urlopen(url, timeout=timeout) as r:
            return r.status
    except urllib.error.HTTPError as e:
        return e.code  # 3xx/4xx still means something is serving
    except Exception:
        return None


def _open_connections(sandbox_id: str):
    """Count established TCP connections to the app port, from inside the box.

    Deliberately asks the kernel rather than the application. The platform has
    to work for any customer app exactly as it is - requiring each one to expose
    a status endpoint would only ever work for apps that had agreed in advance.

    /proc/net/tcp is read directly because the runtime image has neither ss nor
    netstat. Columns are: sl, local_address, rem_address, st, ... - local
    address is HEX_IP:HEX_PORT and st 01 is ESTABLISHED.

    Returns None if the sandbox can't be reached, which means "unknown", not
    "idle".
    """
    port_hex = f"{APP_PORT:04X}"
    script = (
        "cat /proc/net/tcp /proc/net/tcp6 2>/dev/null "
        f"| awk '$4==\"01\" && $2 ~ /:{port_hex}$/' | wc -l"
    )
    try:
        proc = modal.Sandbox.from_id(sandbox_id).exec("bash", "-c", script)
        return int(proc.stdout.read().strip())
    except Exception:  # noqa: BLE001 - treated as "don't know"
        return None


@app.function(image=router_image, schedule=modal.Period(minutes=1), timeout=300)
def reap():
    """Shut the sandbox down once nobody has the app open.

    Uses open TCP connections to the app port as the idle signal. That is
    deliberately generic: it works for any customer app, unmodified, with no
    cooperation required. Anything that depends on the app exposing a status
    endpoint only works for apps that opted in, which is not a platform.

    The tradeoff is honest: this measures "connected", not "interacting". A
    parked browser tab keeps a WebSocket open and so keeps the preview alive.
    That is the same semantics Fly and Koyeb use, and it is the right default -
    it never kills a preview somebody still has on screen.

    A Wisej app could report Application.SessionCount for a sharper signal
    (real sessions rather than sockets). That belongs in the framework, so
    every app gets it, and would be an optional refinement here - never a
    requirement.

    Requires EMPTY_POLLS_BEFORE_REAP consecutive zero readings so a blip
    doesn't kill a live preview. Unreachable means 'unknown', not 'idle'.
    """
    rec = state.get("sandbox") or {}
    if not rec.get("id"):
        return

    age = time.time() - rec.get("created_at", rec.get("started", time.time()))
    conns = _open_connections(rec["id"])

    empty = state.get("empty_polls") or 0
    empty = empty + 1 if conns == 0 else 0
    state["empty_polls"] = empty

    idle = empty >= EMPTY_POLLS_BEFORE_REAP
    too_old = age > MAX_SANDBOX_AGE_SECONDS
    if not (idle or too_old):
        return

    reason = f"{empty} idle polls" if idle else f"age {age / 60:.0f} min"
    try:
        modal.Sandbox.from_id(rec["id"]).terminate()
        print(f"reaped {rec['id']} ({reason}, connections={conns})")
    except Exception as exc:  # noqa: BLE001 - best effort
        print(f"reap failed for {rec['id']}: {exc}")
    state["sandbox"] = None
    state["pending"] = None
    state["empty_polls"] = 0


@app.function(image=router_image, timeout=SANDBOX_MAX_LIFETIME)
def ensure_sandbox(started: float):
    """Create the sandbox out of band.

    Sandbox.create() blocks for ~180s while Modal pulls the image. Calling it
    inline from the status endpoint would hang the very request whose whole job
    is to respond instantly, so it runs as a spawned Function and publishes its
    result through the shared Dict.
    """
    sb_app = modal.App.lookup(f"{APP_NAME}-sandboxes", create_if_missing=True)

    # Copy the payload to local disk before running it. Volumes are network
    # backed, and Wisej's resource init does many small reads across themes and
    # resources - served straight off the Volume that init measured 36.8s, with
    # every request after it in the tens of milliseconds. Copying ~75MB once
    # costs a couple of seconds and makes every subsequent read local.
    sb = modal.Sandbox.create(
        "bash", "-c",
        f"cp -r {PAYLOAD_DIR} /app && cd /app && exec dotnet Wisej.DemoBrowser.dll",
        image=wisej_image,
        app=sb_app,
        volumes={"/previews": volume},
        cpu=CPU,
        memory=MEMORY_MB,
        encrypted_ports=[APP_PORT],
        timeout=SANDBOX_MAX_LIFETIME,
    )
    state["sandbox"] = {
        "id": sb.object_id,
        "started": started,
        "created_at": time.time(),
        "url": sb.tunnels()[APP_PORT].url,
        "ready_at": None,
    }
    state["pending"] = None
    return sb.object_id


def _status():
    """Advance the boot state machine by one step and describe it."""
    now = time.time()
    rec = state.get("sandbox") or {}

    if rec.get("id"):
        try:
            if modal.Sandbox.from_id(rec["id"]).poll() is not None:
                rec = {}  # it exited; start over
                state["sandbox"] = None
        except Exception:
            rec = {}
            state["sandbox"] = None

    if not rec.get("id"):
        pending = state.get("pending")
        if not pending:
            started = now
            ensure_sandbox.spawn(started)
            state["pending"] = {"started": started}
        else:
            started = pending["started"]

        elapsed = now - started
        failed = elapsed > BOOT_BUDGET_SECONDS
        active = "create" if elapsed < 10 else "pull"
        return _render(active, elapsed, ready=False, failed=failed,
                       url=None, sandbox_id=None)

    state["last_seen"] = now
    elapsed = now - rec["started"]

    if not rec.get("ready_at"):
        if _probe(rec["url"]) is not None:
            rec["ready_at"] = now
            state["sandbox"] = rec

    ready = bool(rec.get("ready_at"))
    failed = (not ready) and elapsed > BOOT_BUDGET_SECONDS
    active = "ready" if ready else "boot"
    return _render(active, elapsed, ready, failed, rec["url"], rec["id"])


def _render(active, elapsed, ready, failed, url, sandbox_id):

    order = [s[0] for s in STEPS]
    steps = []
    for key, label in STEPS:
        if ready and key != "ready":
            st = "done"
        elif key == active:
            st = "failed" if failed else "active"
        elif order.index(key) < order.index(active):
            st = "done"
        else:
            st = "pending"
        steps.append({"id": key, "label": label, "state": st})

    return {
        "state": "failed" if failed else ("ready" if ready else "booting"),
        "elapsed": round(elapsed, 1),
        "budget": BOOT_BUDGET_SECONDS,
        "steps": steps,
        "url": url if ready else None,
        "sandboxId": sandbox_id,
        "pr": PR_NUMBER,
        "error": (
            f"The app did not start within {BOOT_BUDGET_SECONDS}s."
            if failed else None
        ),
    }


@app.function(image=router_image, min_containers=0, scaledown_window=300)
@modal.concurrent(max_inputs=100)
@modal.asgi_app()
def serve():
    from fastapi import FastAPI
    from fastapi.responses import HTMLResponse, JSONResponse

    web = FastAPI()

    @web.get("/api/status")
    async def api_status():
        try:
            return JSONResponse(_status())
        except Exception as exc:  # noqa: BLE001 - surface it to the UI
            return JSONResponse(
                {"state": "failed", "error": str(exc), "steps": [],
                 "elapsed": 0, "url": None},
                status_code=200,
            )

    @web.get("/")
    async def index():
        return HTMLResponse(LOADING_PAGE.replace("__PR__", str(PR_NUMBER)))

    return web


LOADING_PAGE = r"""<!doctype html>
<html lang="en">
<head>
<meta charset="utf-8"/>
<meta name="viewport" content="width=device-width,initial-scale=1"/>
<title>Starting preview - PR #__PR__</title>
<style>
  :root { color-scheme: light dark; }
  * { box-sizing: border-box; }
  body {
    margin:0; min-height:100vh; display:grid; place-items:center;
    font: 15px/1.5 ui-sans-serif, system-ui, -apple-system, "Segoe UI", sans-serif;
    background:#0f1115; color:#e6e8ee;
  }
  .card {
    width:min(560px, 92vw); background:#171a21; border:1px solid #262b36;
    border-radius:14px; padding:28px 30px;
    box-shadow:0 12px 40px rgba(0,0,0,.45);
  }
  h1 { margin:0 0 4px; font-size:17px; font-weight:600; letter-spacing:-.01em; }
  .sub { margin:0 0 22px; color:#8b93a7; font-size:13px; }
  ul { list-style:none; margin:0; padding:0; }
  li { display:flex; align-items:center; gap:12px; padding:9px 0; font-size:14px; }
  .dot {
    width:18px; height:18px; border-radius:50%; flex:0 0 18px;
    border:2px solid #333a49; position:relative;
  }
  .done .dot { background:#2ea56b; border-color:#2ea56b; }
  .done .dot::after {
    content:""; position:absolute; left:5px; top:2px; width:4px; height:9px;
    border:solid #fff; border-width:0 2px 2px 0; transform:rotate(45deg);
  }
  .active .dot { border-color:#4c8dff; border-top-color:transparent;
                 animation:spin .8s linear infinite; }
  .failed .dot { background:#d8503f; border-color:#d8503f; }
  .pending { color:#5e6579; }
  .active { color:#e6e8ee; }
  @keyframes spin { to { transform:rotate(360deg); } }
  .meta { margin-top:20px; padding-top:16px; border-top:1px solid #262b36;
          display:flex; justify-content:space-between; color:#6f778b; font-size:12px; }
  code { font-family:ui-monospace, SFMono-Regular, Menlo, monospace; font-size:11px; }
  .err { margin-top:16px; padding:12px 14px; border-radius:8px;
         background:#2a1614; border:1px solid #5b2b24; color:#f0b4ab; font-size:13px; }
</style>
</head>
<body>
<div id="root"></div>
<script src="https://unpkg.com/react@18/umd/react.production.min.js" crossorigin></script>
<script src="https://unpkg.com/react-dom@18/umd/react-dom.production.min.js" crossorigin></script>
<script>
const h = React.createElement;

function Row(s) {
  return h('li', {key: s.id, className: s.state},
    h('span', {className: 'dot'}),
    h('span', null, s.label));
}

function App() {
  const [d, setD] = React.useState({state:'booting', steps:[], elapsed:0, budget:600});

  React.useEffect(() => {
    let stop = false;
    async function tick() {
      try {
        const r = await fetch('/api/status', {cache:'no-store'});
        const j = await r.json();
        if (stop) return;
        setD(j);
        if (j.state === 'ready' && j.url) { window.location.replace(j.url); return; }
      } catch (e) { /* router still waking; keep polling */ }
      if (!stop) setTimeout(tick, 2000);
    }
    tick();
    return () => { stop = true; };
  }, []);

  return h('div', {className:'card'},
    h('h1', null, 'Starting your preview'),
    h('p', {className:'sub'},
      'Wisej.NET Cloud is bringing up a container for pull request #__PR__. ' +
      'This happens on first open and takes a moment.'),
    h('ul', null, (d.steps || []).map(Row)),
    d.error ? h('div', {className:'err'}, d.error) : null,
    h('div', {className:'meta'},
      h('span', null, Math.round(d.elapsed || 0) + 's elapsed'),
      d.sandboxId ? h('code', null, d.sandboxId) : null));
}

ReactDOM.createRoot(document.getElementById('root')).render(h(App));
</script>
</body>
</html>
"""
