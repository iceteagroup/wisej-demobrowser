"""
Wisej.NET Cloud - one preview environment per pull request.

Deployed by .github/workflows/preview.yml as `wisej-demobrowser-pr-<N>`, which
gives each PR a stable URL that can be posted to the PR before any container
exists. Modal holds the app at zero containers until someone opens that URL,
then boots a container and holds the request until the app is serving. The
container is torn down after SCALEDOWN_WINDOW seconds with no requests in
flight; a second viewer arriving just resets that timer.
"""

import os
import subprocess

import modal

PR_NUMBER = os.environ.get("PR_NUMBER", "local")

# Idle shutdown. Modal permits 2 seconds to 20 minutes, so 20 minutes is the
# ceiling for "kill after X minutes of inactivity" using the platform's own
# mechanism. Going longer would mean tracking activity ourselves.
SCALEDOWN_WINDOW = int(os.environ.get("SCALEDOWN_WINDOW", 20 * 60))

# Wisej keeps each user's component tree in server memory, so every viewer of
# a given PR has to land on the same process. One container, many concurrent
# requests into it.
MAX_CONTAINERS = 1
MAX_CONCURRENT_REQUESTS = 200

# Per-input timeout. A Wisej session holds a WebSocket open for its whole life
# and Modal counts that as one long-running input, so this is effectively a
# ceiling on session length. Worth measuring against real usage.
REQUEST_TIMEOUT = 60 * 60

# The .NET app has ~103 project assemblies to load before Kestrel binds.
STARTUP_TIMEOUT = 240

app = modal.App(f"wisej-demobrowser-pr-{PR_NUMBER}")

image = modal.Image.from_dockerfile("Dockerfile", context_dir=".")


@app.function(
    image=image,
    max_containers=MAX_CONTAINERS,
    scaledown_window=SCALEDOWN_WINDOW,
    timeout=REQUEST_TIMEOUT,
)
@modal.concurrent(max_inputs=MAX_CONCURRENT_REQUESTS)
@modal.web_server(port=8080, startup_timeout=STARTUP_TIMEOUT)
def serve():
    # The image ENTRYPOINT isn't used under Modal - Modal runs its own agent as
    # PID 1 - so start Kestrel ourselves and let web_server poll port 8080.
    subprocess.Popen(["dotnet", "Wisej.DemoBrowser.dll"], cwd="/app")
