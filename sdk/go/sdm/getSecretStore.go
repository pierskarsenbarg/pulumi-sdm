// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package sdm

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-sdm/sdk/go/sdm/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// A SecretStore is a server where resource secrets (passwords, keys) are stored.
//
//	Coming soon support for HashiCorp Vault and AWS Secret Store.
func LookupSecretStore(ctx *pulumi.Context, args *LookupSecretStoreArgs, opts ...pulumi.InvokeOption) (*LookupSecretStoreResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupSecretStoreResult
	err := ctx.Invoke("sdm:index/getSecretStore:getSecretStore", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getSecretStore.
type LookupSecretStoreArgs struct {
	// Unique identifier of the SecretStore.
	Id *string `pulumi:"id"`
	// Unique human-readable name of the SecretStore.
	Name *string `pulumi:"name"`
	// Tags is a map of key, value pairs.
	Tags map[string]string `pulumi:"tags"`
	// a filter to select all items of a certain subtype. See the [filter documentation](https://www.strongdm.com/docs/automation/getting-started/filters) for more information.
	Type *string `pulumi:"type"`
}

// A collection of values returned by getSecretStore.
type LookupSecretStoreResult struct {
	// Unique identifier of the SecretStore.
	Id *string `pulumi:"id"`
	// a list of strings of ids of data sources that match the given arguments.
	Ids []string `pulumi:"ids"`
	// Unique human-readable name of the SecretStore.
	Name *string `pulumi:"name"`
	// A single element list containing a map, where each key lists one of the following objects:
	// * active_directory_store:
	SecretStores []GetSecretStoreSecretStore `pulumi:"secretStores"`
	// Tags is a map of key, value pairs.
	Tags map[string]string `pulumi:"tags"`
	Type *string           `pulumi:"type"`
}

func LookupSecretStoreOutput(ctx *pulumi.Context, args LookupSecretStoreOutputArgs, opts ...pulumi.InvokeOption) LookupSecretStoreResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupSecretStoreResult, error) {
			args := v.(LookupSecretStoreArgs)
			r, err := LookupSecretStore(ctx, &args, opts...)
			var s LookupSecretStoreResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupSecretStoreResultOutput)
}

// A collection of arguments for invoking getSecretStore.
type LookupSecretStoreOutputArgs struct {
	// Unique identifier of the SecretStore.
	Id pulumi.StringPtrInput `pulumi:"id"`
	// Unique human-readable name of the SecretStore.
	Name pulumi.StringPtrInput `pulumi:"name"`
	// Tags is a map of key, value pairs.
	Tags pulumi.StringMapInput `pulumi:"tags"`
	// a filter to select all items of a certain subtype. See the [filter documentation](https://www.strongdm.com/docs/automation/getting-started/filters) for more information.
	Type pulumi.StringPtrInput `pulumi:"type"`
}

func (LookupSecretStoreOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupSecretStoreArgs)(nil)).Elem()
}

// A collection of values returned by getSecretStore.
type LookupSecretStoreResultOutput struct{ *pulumi.OutputState }

func (LookupSecretStoreResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupSecretStoreResult)(nil)).Elem()
}

func (o LookupSecretStoreResultOutput) ToLookupSecretStoreResultOutput() LookupSecretStoreResultOutput {
	return o
}

func (o LookupSecretStoreResultOutput) ToLookupSecretStoreResultOutputWithContext(ctx context.Context) LookupSecretStoreResultOutput {
	return o
}

// Unique identifier of the SecretStore.
func (o LookupSecretStoreResultOutput) Id() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupSecretStoreResult) *string { return v.Id }).(pulumi.StringPtrOutput)
}

// a list of strings of ids of data sources that match the given arguments.
func (o LookupSecretStoreResultOutput) Ids() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupSecretStoreResult) []string { return v.Ids }).(pulumi.StringArrayOutput)
}

// Unique human-readable name of the SecretStore.
func (o LookupSecretStoreResultOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupSecretStoreResult) *string { return v.Name }).(pulumi.StringPtrOutput)
}

// A single element list containing a map, where each key lists one of the following objects:
// * active_directory_store:
func (o LookupSecretStoreResultOutput) SecretStores() GetSecretStoreSecretStoreArrayOutput {
	return o.ApplyT(func(v LookupSecretStoreResult) []GetSecretStoreSecretStore { return v.SecretStores }).(GetSecretStoreSecretStoreArrayOutput)
}

// Tags is a map of key, value pairs.
func (o LookupSecretStoreResultOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupSecretStoreResult) map[string]string { return v.Tags }).(pulumi.StringMapOutput)
}

func (o LookupSecretStoreResultOutput) Type() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupSecretStoreResult) *string { return v.Type }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupSecretStoreResultOutput{})
}
