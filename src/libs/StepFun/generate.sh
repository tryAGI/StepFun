#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# Hand-maintained OpenAPI spec based on StepFun docs. The advertised Mintlify
# OpenAPI URL currently returns a sample Plant Store document, not StepFun APIs.
# https://platform.stepfun.ai/docs/en/api-reference/chat/chat-completion-create
install_autosdk_cli
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace StepFun \
  --clientClassName StepFunClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
