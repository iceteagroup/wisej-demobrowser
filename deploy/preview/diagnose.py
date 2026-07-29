"""Find out what .NET startup actually costs inside a Modal Sandbox.

Unlike @modal.web_server, a Sandbox lets us watch the whole boot and decide
ourselves how long to wait. Run with:  modal run deploy/preview/diagnose.py
"""

import time
import urllib.error
import urllib.request
from pathlib import Path

import modal

HERE = Path(__file__).resolve().parent
REPO_ROOT = HERE.parents[1]

BUILD_CONTEXT_IGNORE = [
    ".git", ".git/**", ".github", ".github/**", ".vs", ".vs/**",
    "**/bin/**", "**/obj/**", "**/*.user", "**/*.suo",
]

app = modal.App("wisej-diagnose")

image = modal.Image.from_dockerfile(
    str(HERE / "Dockerfile"),
    context_dir=str(REPO_ROOT),
    add_python="3.12",
    ignore=BUILD_CONTEXT_IGNORE,
)


@app.local_entrypoint()
def main():
    t0 = time.time()
    print("creating sandbox...")

    sb = modal.Sandbox.create(
        "bash",
        "-c",
        "cd /app && exec dotnet Wisej.DemoBrowser.dll",
        image=image,
        app=app,
        cpu=2.0,
        memory=4096,
        encrypted_ports=[8080],
        timeout=900,
    )
    created = time.time() - t0
    print(f"sandbox created in {created:.1f}s (id={sb.object_id})")

    url = sb.tunnels()[8080].url
    print(f"tunnel: {url}")

    deadline = time.time() + 600
    first_ok = None
    last_err = None
    attempts = 0

    while time.time() < deadline:
        attempts += 1
        try:
            req = urllib.request.Request(url, method="GET")
            with urllib.request.urlopen(req, timeout=15) as r:
                first_ok = time.time() - t0
                body = r.read(400)
                print(f"\n*** SERVING after {first_ok:.1f}s total "
                      f"({attempts} attempts) -> HTTP {r.status}")
                print(f"first bytes: {body[:200]!r}")
                break
        except urllib.error.HTTPError as e:
            # A 3xx/4xx still means something is listening and answering.
            first_ok = time.time() - t0
            print(f"\n*** RESPONDING after {first_ok:.1f}s -> HTTP {e.code}")
            break
        except Exception as e:  # noqa: BLE001 - diagnostic
            last_err = e
            time.sleep(3)

    if first_ok is None:
        print(f"\n*** NEVER RESPONDED within 600s. last error: {last_err}")

    # Whatever happened, look inside: is dotnet alive, is anything on 8080?
    print("\n--- ps ---")
    try:
        p = sb.exec("bash", "-c", "ps aux | grep -i dotnet | grep -v grep")
        print(p.stdout.read())
    except Exception as e:  # noqa: BLE001
        print(f"exec failed: {e}")

    print("--- listening sockets ---")
    try:
        p = sb.exec("bash", "-c", "ss -ltnp 2>/dev/null || netstat -ltnp 2>/dev/null || echo 'no ss/netstat'")
        print(p.stdout.read())
    except Exception as e:  # noqa: BLE001
        print(f"exec failed: {e}")

    print("--- local curl from inside ---")
    try:
        p = sb.exec("bash", "-c", "time (exec 3<>/dev/tcp/127.0.0.1/8080 && echo 'port open') 2>&1")
        print(p.stdout.read())
    except Exception as e:  # noqa: BLE001
        print(f"exec failed: {e}")

    print("\nterminating sandbox")
    sb.terminate()
