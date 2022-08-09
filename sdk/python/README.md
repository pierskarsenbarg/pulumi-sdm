# StrongDM Resource Provider

The StrongDM Resource Provider lets you manage [StrongDM](http://strongdm.com) resources.

## Installing

This package is available for several languages/platforms:

### Node.js (JavaScript/TypeScript)

To use from JavaScript or TypeScript in Node.js, install using either `npm`:

```bash
npm install @pierskarsenbarg/sdm
```

or `yarn`:

```bash
yarn add @pierskarsenbarg/sdm
```

### Python

To use from Python, install using `pip`:

```bash
pip install pulumi-sdm
```

### Go

To use from Go, use `go get` to grab the latest version of the library:

```bash
go get github.com/pierskarsenbarg/pulumi-sdm/sdk/go/...
```

### .NET

To use from .NET, install using `dotnet add package`:

```bash
dotnet add package PiersKarsenbarg.Sdm
```

## Configuration

The following configuration points are available for the `sdm` provider:

- `sdm:apiAccessKey` (environment: `SDM_API_ACCESS_KEY`) - the API key for `Strong DM`
- `sdm:apiSecretKey` (environment: `SDM_API_SECRET_KEY`) - the corresponding secret key for the above API key

## Todo

* Add Java language support
* Add YAML language support

<!-- ## Reference

For detailed reference documentation, please visit [the Pulumi registry](https://www.pulumi.com/registry/packages/foo/api-docs/). -->
