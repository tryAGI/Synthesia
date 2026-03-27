#!/usr/bin/env bash
set -euo pipefail

dotnet tool update --global autosdk.cli --prerelease || dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://api.synthesia.io/api/openapi/swagger.json

# Fix auth: convert apiKey → http/bearer for AutoSDK constructor generation
# Also add top-level security array
jq '
  .components.securitySchemes = {
    "BearerAuth": {
      "type": "http",
      "scheme": "bearer"
    }
  } |
  .security = [{"BearerAuth": []}]
' openapi.yaml > openapi.fixed.yaml && mv openapi.fixed.yaml openapi.yaml

autosdk generate openapi.yaml \
  --namespace Synthesia \
  --clientClassName SynthesiaClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
