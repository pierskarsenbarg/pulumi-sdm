# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## What This Is

A Pulumi resource provider for StrongDM, built using the Pulumi Terraform Bridge. It wraps `terraform-provider-sdm` and exposes it to Pulumi with multi-language SDKs (Go, Node.js, Python, .NET).

## Build & Test Commands

```bash
make provider          # Build the provider binary only
make build_sdks        # Regenerate all language SDKs (must be checked in on PRs with code changes)
make build             # Build provider + SDKs without linting
make development       # Full build including linting
make lint_provider     # Lint the provider Go code
make test              # Run integration tests

# Individual SDK builds
make build_nodejs
make build_python
make build_go
make build_dotnet
```

Running integration tests (require real StrongDM credentials via `SDM_API_ACCESS_KEY` / `SDM_API_SECRET_KEY`):

```bash
cd examples
go test -v -tags=all -parallel 4 -timeout 2h
go test -v -tags=nodejs -run TestAccNodejs -timeout 2h   # single language
go test -v -run TestFoo -tags=all -timeout 2h            # single test
```

After modifying provider Go dependencies, run `go mod tidy` inside `provider/`.

## Architecture

### Code Generation Flow

1. `provider/cmd/pulumi-tfgen-sdm` reads the Terraform provider schema and generates `schema.json`
2. `generate.go` embeds `schema.json` into `schema.go` (compiled into the provider binary)
3. `provider/cmd/pulumi-resource-sdm` is the main provider binary Pulumi invokes at runtime
4. SDKs under `sdk/` are generated artifacts — do not edit them directly

### Provider Configuration (`provider/resources.go`)

This is the main file to edit when modifying provider behavior. It returns a `tfbridge.ProviderInfo` that:
- Maps Terraform resource names to Pulumi tokens via `tfbridge.MakeResource()`
- Overrides field names (e.g., `"policy"` → `"policyContent"` to avoid collisions)
- Configures per-language package metadata (npm package name, Python package name, Go module path, NuGet package ID)

### SDK Structure

`sdk/` contains generated code — it is checked into the repo and must be regenerated (`make build_sdks`) whenever `provider/resources.go` or the upstream Terraform provider changes.

## Provider Configuration

Users configure the provider with:
- `sdm:apiAccessKey` / env `SDM_API_ACCESS_KEY`
- `sdm:apiSecretKey` / env `SDM_API_SECRET_KEY`
