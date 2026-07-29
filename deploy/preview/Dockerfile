# Wisej.NET Cloud - preview container for Wisej.DemoBrowser (net8.0 target).
#
# Self-contained: nothing here affects the normal solution build. The build
# context is the repository root (Wisej.DemoBrowser.csproj has ~103
# ProjectReferences across Demos/, so a targeted restore isn't practical).

# ---------- build ----------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY . .

# Measured: the app boots and serves 2.4s after its container exists, while
# Modal spends ~180s pulling the image. Startup is not the problem - image size
# is - so optimise for a smaller image, not faster JIT.
#
# Deliberately NOT using PublishReadyToRun: it precompiles IL to native and
# roughly doubles assembly size, which makes the pull (the actual bottleneck)
# worse to fix a startup cost we don't have.
#
#   --runtime linux-x64  prunes runtimes/ down to one RID; a portable publish
#                        ships alpine/osx/win/wasm/mips native assets we can't use
#   SatelliteResourceLanguages  drops 14 localised resource folders
RUN dotnet publish Wisej.DemoBrowser/Wisej.DemoBrowser.csproj \
        --framework net8.0 \
        --configuration Release \
        --runtime linux-x64 \
        --no-self-contained \
        --output /app/publish \
        -p:SatelliteResourceLanguages=en \
        -p:EnableUnsafeBinaryFormatterSerialization=true \
        -p:UseAppHost=false

# ---------- runtime ----------
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

# Wisej measures text server-side to autosize controls. Without fontconfig and
# a font set present, the layout engine gets bad metrics and controls render at
# the wrong size.
RUN apt-get update \
 && apt-get install -y --no-install-recommends \
        libfontconfig1 \
        fonts-liberation \
        fonts-dejavu-core \
 && rm -rf /var/lib/apt/lists/*

WORKDIR /app
COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://0.0.0.0:8080 \
    DOTNET_gcServer=0

# Skips a startup probe for a diagnostic pipe we never use.
ENV DOTNET_EnableDiagnostics=0

EXPOSE 8080

ENTRYPOINT ["dotnet", "Wisej.DemoBrowser.dll"]
