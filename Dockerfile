# Wisej.NET Cloud - preview container for Wisej.DemoBrowser (net8.0 target).
#
# The build context is the whole repository: Wisej.DemoBrowser.csproj has ~103
# ProjectReferences spread across Demos/, so a targeted restore isn't practical.

# ---------- build ----------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY . .

# UseAppHost=false: we launch through `dotnet Wisej.DemoBrowser.dll`, so the
# native apphost executable is dead weight.
RUN dotnet publish Wisej.DemoBrowser/Wisej.DemoBrowser.csproj \
        --framework net8.0 \
        --configuration Release \
        --output /app/publish \
        -p:UseAppHost=false

# ---------- runtime ----------
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

# Wisej measures text server-side to autosize controls. Without fontconfig and
# a font set present, the layout engine gets bad metrics and the UI renders
# with wrong control sizes.
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

EXPOSE 8080

ENTRYPOINT ["dotnet", "Wisej.DemoBrowser.dll"]
