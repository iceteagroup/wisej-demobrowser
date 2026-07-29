"""Publish the shared runtime image that every preview Sandbox runs.

This is the ONLY image in the system. It changes when the .NET runtime or the
OS packages change - not when application code changes - so it is built rarely
and shared by every PR.

A PR's application code is a ~75MB directory on a Volume, published straight
from CI with `modal volume put`. Nothing about a PR requires an image build,
which is what keeps image count flat and makes cleanup a file delete.

    modal run deploy/preview/base_image.py

Nothing in this module is repo-relative. Modal re-imports modules that define
Functions inside a container where the repository does not exist, and a
repo-relative path at module scope crash-loops the Function instead of erroring
usefully - a mistake worth not repeating.
"""

import modal

BASE_IMAGE_NAME = "wisej-preview-base"

app = modal.App("wisej-preview-base-builder")

# Wisej measures text server-side to autosize controls, so fontconfig and a
# font set must be present or controls render at the wrong size.
base_image = (
    modal.Image.from_registry("mcr.microsoft.com/dotnet/aspnet:8.0", add_python="3.12")
    .apt_install("libfontconfig1", "fonts-liberation", "fonts-dejavu-core")
    .env({
        "ASPNETCORE_URLS": "http://0.0.0.0:8080",
        "DOTNET_gcServer": "0",
        "DOTNET_EnableDiagnostics": "0",
    })
)


@app.local_entrypoint()
def main():
    base_image.build(app)
    base_image.publish(BASE_IMAGE_NAME)
    print(f"published {BASE_IMAGE_NAME}:latest")
