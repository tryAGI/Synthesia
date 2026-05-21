#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://api.synthesia.io/api/openapi/swagger.json

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location --retry 5 --retry-delay 10 --retry-all-errors \
  --output openapi.yaml \
  https://api.synthesia.io/api/openapi/swagger.json

# Auth: --security-scheme overrides the spec's apiKey auth with standard HTTP bearer.
autosdk generate openapi.yaml \
  --namespace Synthesia \
  --clientClassName SynthesiaClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
