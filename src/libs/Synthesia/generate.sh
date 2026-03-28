#!/usr/bin/env bash
set -euo pipefail

dotnet tool update --global autosdk.cli --prerelease || dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://api.synthesia.io/api/openapi/swagger.json

# Auth: --security-scheme overrides the spec's apiKey auth with standard HTTP bearer.
autosdk generate openapi.yaml \
  --namespace Synthesia \
  --clientClassName SynthesiaClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
