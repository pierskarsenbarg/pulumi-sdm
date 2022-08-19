// Copyright 2016-2018, Pulumi Corporation.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

package sdm

import (
	"fmt"
	"path/filepath"

	"github.com/pierskarsenbarg/pulumi-sdm/provider/pkg/version"
	"github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfbridge"
	shim "github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfshim"
	shimv2 "github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfshim/sdk-v2"
	"github.com/pulumi/pulumi/sdk/v3/go/common/resource"
	"github.com/strongdm/terraform-provider-sdm/sdm"
)

// all of the token components used below.
const (
	// This variable controls the default name of the package in the package
	// registries for nodejs and python:
	mainPkg = "sdm"
	// modules:
	mainMod = "index" // the sdm module
)

// preConfigureCallback is called before the providerConfigure function of the underlying provider.
// It should validate that the provider can be configured, and provide actionable errors in the case
// it cannot be. Configuration variables can be read from `vars` using the `stringValue` function -
// for example `stringValue(vars, "accessKey")`.
func preConfigureCallback(vars resource.PropertyMap, c shim.ResourceConfig) error {
	return nil
}

// Provider returns additional overlaid schema and metadata associated with the provider..
func Provider() tfbridge.ProviderInfo {
	// Instantiate the Terraform provider
	p := shimv2.NewProvider(sdm.Provider())

	// Create a Pulumi provider mapping
	prov := tfbridge.ProviderInfo{
		P:    p,
		Name: "sdm",
		// DisplayName is a way to be able to change the casing of the provider
		// name when being displayed on the Pulumi registry
		DisplayName: "StrongDM",
		// The default publisher for all packages is Pulumi.
		// Change this to your personal name (or a company name) that you
		// would like to be shown in the Pulumi Registry if this package is published
		// there.
		Publisher: "Piers Karsenbarg",
		// LogoURL is optional but useful to help identify your package in the Pulumi Registry
		// if this package is published there.
		//
		// You may host a logo on a domain you control or add an SVG logo for your package
		// in your repository and use the raw content URL for that file as your logo URL.
		LogoURL: "",
		// PluginDownloadURL is an optional URL used to download the Provider
		// for use in Pulumi programs
		// e.g https://github.com/org/pulumi-provider-name/releases/
		PluginDownloadURL: "https://github.com/pierskarsenbarg/pulumi-sdm/releases/download/v${VERSION}",
		Description:       "A Pulumi package for creating and managing StrongDM cloud resources.",
		// category/cloud tag helps with categorizing the package in the Pulumi Registry.
		// For all available categories, see `Keywords` in
		// https://www.pulumi.com/docs/guides/pulumi-packages/schema/#package.
		Keywords:   []string{"pulumi", "sdm", "category/cloud"},
		License:    "Apache-2.0",
		Homepage:   "https://github.com/pierskarsenbarg/pulumi-sdm",
		Repository: "https://github.com/pierskarsenbarg/pulumi-sdm",
		// The GitHub Org for the provider - defaults to `terraform-providers`
		GitHubOrg: "strongdm",
		Config:    map[string]*tfbridge.SchemaInfo{
			// Add any required configuration here, or remove the example below if
			// no additional points are required.
			// "region": {
			// 	Type: tfbridge.MakeType("region", "Region"),
			// 	Default: &tfbridge.DefaultInfo{
			// 		EnvVars: []string{"AWS_REGION", "AWS_DEFAULT_REGION"},
			// 	},
			// },
			// "api_access_key": {
			// 	Default: &tfbridge.DefaultInfo{
			// 		EnvVars: []string{"SDM_API_ACCESS_KEY"},
			// 	},
			// },
			// "api_secret_key": {
			// 	Default: &tfbridge.DefaultInfo{
			// 		EnvVars: []string{"SDM_API_SECRET_KEY"},
			// 	},
			// },
		},
		PreConfigureCallback: preConfigureCallback,
		Resources: map[string]*tfbridge.ResourceInfo{
			// Map each resource in the Terraform provider to a Pulumi type. Two examples
			// are below - the single line form is the common case. The multi-line form is
			// needed only if you wish to override types or other default options.
			//
			// "aws_iam_role": {Tok: tfbridge.MakeResource(mainPkg, mainMod, "IamRole")}
			//
			// "aws_acm_certificate": {
			// 	Tok: tfbridge.MakeResource(mainPkg, mainMod, "Certificate"),
			// 	Fields: map[string]*tfbridge.SchemaInfo{
			// 		"tags": {Type: tfbridge.MakeType(mainPkg, "Tags")},
			// 	},
			// },
			"sdm_account":            {Tok: tfbridge.MakeResource(mainPkg, mainMod, "Account")},
			"sdm_account_attachment": {Tok: tfbridge.MakeResource(mainPkg, mainMod, "AccountAttachment")},
			"sdm_node":               {Tok: tfbridge.MakeResource(mainPkg, mainMod, "Node")},
			"sdm_remote_identity":    {Tok: tfbridge.MakeResource(mainPkg, mainMod, "RemoteIdentity")},
			"sdm_resource":           {Tok: tfbridge.MakeResource(mainPkg, mainMod, "Resource")},
			"sdm_role":               {Tok: tfbridge.MakeResource(mainPkg, mainMod, "Role")},
			"sdm_secret_store":       {Tok: tfbridge.MakeResource(mainPkg, mainMod, "SecretStore")},
		},
		DataSources: map[string]*tfbridge.DataSourceInfo{
			// Map each resource in the Terraform provider to a Pulumi function. An example
			// is below.
			// "aws_ami": {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getAmi")},
			"sdm_account":               {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getAccount")},
			"sdm_account_attachment":    {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getAccountAttachment")},
			"sdm_node":                  {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getNode")},
			"sdm_remote_identity":       {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getRemoteIdentity")},
			"sdm_remote_identity_group": {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getRemoteIdentityGroup")},
			"sdm_resource":              {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getResource")},
			"sdm_role":                  {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getRole")},
			"sdm_secret_store":          {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getSecretStore")},
			"sdm_ssh_ca_pubkey":         {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getSshCaPubkey")},
		},
		JavaScript: &tfbridge.JavaScriptInfo{
			// List any npm dependencies and their versions
			Dependencies: map[string]string{
				"@pulumi/pulumi": "^3.0.0",
			},
			DevDependencies: map[string]string{
				"@types/node": "^10.0.0", // so we can access strongly typed node definitions.
				"@types/mime": "^2.0.0",
			},
			PackageName: "@pierskarsenbarg/sdm",
			// See the documentation for tfbridge.OverlayInfo for how to lay out this
			// section, or refer to the AWS provider. Delete this section if there are
			// no overlay files.
			//Overlay: &tfbridge.OverlayInfo{},
		},
		Python: &tfbridge.PythonInfo{
			// List any Python dependencies and their version ranges
			Requires: map[string]string{
				"pulumi": ">=3.0.0,<4.0.0",
			},
		},
		Golang: &tfbridge.GolangInfo{
			ImportBasePath: filepath.Join(
				fmt.Sprintf("github.com/pierskarsenbarg/pulumi-%[1]s/sdk/", mainPkg),
				tfbridge.GetModuleMajorVersion(version.Version),
				"go",
				mainPkg,
			),
			GenerateResourceContainerTypes: true,
		},
		CSharp: &tfbridge.CSharpInfo{
			RootNamespace: "PiersKarsenbarg",
			PackageReferences: map[string]string{
				"Pulumi": "3.*",
			},
		},
	}

	prov.SetAutonaming(255, "-")

	return prov
}
