"""Build the Wisej preview image and publish it under a name.

Kept separate from router.py on purpose. The router is re-imported inside its
own container, where the repository does not exist - so anything that needs the
repo (a Dockerfile path, a build context) must not live in that module. Here we
build once in CI and publish a name; the router only ever looks the name up.

    modal run deploy/preview/build_image.py
"""

import os
from pathlib import Path

import modal

HERE = Path(__file__).resolve().parent
REPO_ROOT = HERE.parents[1]

PR_NUMBER = os.environ.get("PR_NUMBER", "local")
IMAGE_NAME = f"wisej-demobrowser-pr-{PR_NUMBER}"

BUILD_CONTEXT_IGNORE = [
    ".git", ".git/**", ".github", ".github/**", ".vs", ".vs/**",
    "**/bin/**", "**/obj/**", "**/*.user", "**/*.suo",
]

app = modal.App("wisej-image-builder")

image = modal.Image.from_dockerfile(
    str(HERE / "Dockerfile"),
    context_dir=str(REPO_ROOT),
    add_python="3.12",
    ignore=BUILD_CONTEXT_IGNORE,
)


@app.local_entrypoint()
def main():
    image.build(app)
    image.publish(IMAGE_NAME)
    print(f"published image {IMAGE_NAME}:latest")
