#!/usr/bin/env bash
set -euo pipefail

# Hand-maintained OpenAPI spec based on StepFun docs. The advertised Mintlify
# OpenAPI URL currently returns a sample Plant Store document, not StepFun APIs.
# https://platform.stepfun.ai/docs/en/api-reference/chat/chat-completion-create

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace StepFun \
  --clientClassName StepFunClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
