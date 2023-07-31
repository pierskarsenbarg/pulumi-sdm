// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package sdm

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-sdm/sdk/go/sdm/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// A Resource is a database, server, cluster, website, or cloud that strongDM
//
//	delegates access to.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/pierskarsenbarg/pulumi-sdm/sdk/go/sdm"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := sdm.LookupResource(ctx, &sdm.LookupResourceArgs{
//				Name: pulumi.StringRef("us-west*"),
//				Tags: map[string]interface{}{
//					"env":    "dev",
//					"region": "us-west",
//				},
//				Type: pulumi.StringRef("mysql"),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func LookupResource(ctx *pulumi.Context, args *LookupResourceArgs, opts ...pulumi.InvokeOption) (*LookupResourceResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupResourceResult
	err := ctx.Invoke("sdm:index/getResource:getResource", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getResource.
type LookupResourceArgs struct {
	// The host to dial to initiate a connection from the egress node to this resource.
	Hostname *string `pulumi:"hostname"`
	// Unique identifier of the Resource.
	Id *string `pulumi:"id"`
	// Unique human-readable name of the Resource.
	Name *string `pulumi:"name"`
	// The port to dial to initiate a connection from the egress node to this resource.
	Port *int `pulumi:"port"`
	// Tags is a map of key, value pairs.
	Tags map[string]interface{} `pulumi:"tags"`
	// a filter to select all items of a certain subtype. See the [filter documentation](https://www.strongdm.com/docs/automation/getting-started/filters for more information.
	Type *string `pulumi:"type"`
	// The username to authenticate with.
	Username *string `pulumi:"username"`
}

// A collection of values returned by getResource.
type LookupResourceResult struct {
	// The host to dial to initiate a connection from the egress node to this resource.
	Hostname *string `pulumi:"hostname"`
	// Unique identifier of the Resource.
	Id *string `pulumi:"id"`
	// a list of strings of ids of data sources that match the given arguments.
	Ids []string `pulumi:"ids"`
	// Unique human-readable name of the Resource.
	Name *string `pulumi:"name"`
	// The port to dial to initiate a connection from the egress node to this resource.
	Port *int `pulumi:"port"`
	// A single element list containing a map, where each key lists one of the following objects:
	// * aks:
	Resources []GetResourceResource `pulumi:"resources"`
	// Tags is a map of key, value pairs.
	Tags map[string]interface{} `pulumi:"tags"`
	Type *string                `pulumi:"type"`
	// The username to authenticate with.
	Username *string `pulumi:"username"`
}

func LookupResourceOutput(ctx *pulumi.Context, args LookupResourceOutputArgs, opts ...pulumi.InvokeOption) LookupResourceResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupResourceResult, error) {
			args := v.(LookupResourceArgs)
			r, err := LookupResource(ctx, &args, opts...)
			var s LookupResourceResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupResourceResultOutput)
}

// A collection of arguments for invoking getResource.
type LookupResourceOutputArgs struct {
	// The host to dial to initiate a connection from the egress node to this resource.
	Hostname pulumi.StringPtrInput `pulumi:"hostname"`
	// Unique identifier of the Resource.
	Id pulumi.StringPtrInput `pulumi:"id"`
	// Unique human-readable name of the Resource.
	Name pulumi.StringPtrInput `pulumi:"name"`
	// The port to dial to initiate a connection from the egress node to this resource.
	Port pulumi.IntPtrInput `pulumi:"port"`
	// Tags is a map of key, value pairs.
	Tags pulumi.MapInput `pulumi:"tags"`
	// a filter to select all items of a certain subtype. See the [filter documentation](https://www.strongdm.com/docs/automation/getting-started/filters for more information.
	Type pulumi.StringPtrInput `pulumi:"type"`
	// The username to authenticate with.
	Username pulumi.StringPtrInput `pulumi:"username"`
}

func (LookupResourceOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupResourceArgs)(nil)).Elem()
}

// A collection of values returned by getResource.
type LookupResourceResultOutput struct{ *pulumi.OutputState }

func (LookupResourceResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupResourceResult)(nil)).Elem()
}

func (o LookupResourceResultOutput) ToLookupResourceResultOutput() LookupResourceResultOutput {
	return o
}

func (o LookupResourceResultOutput) ToLookupResourceResultOutputWithContext(ctx context.Context) LookupResourceResultOutput {
	return o
}

// The host to dial to initiate a connection from the egress node to this resource.
func (o LookupResourceResultOutput) Hostname() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupResourceResult) *string { return v.Hostname }).(pulumi.StringPtrOutput)
}

// Unique identifier of the Resource.
func (o LookupResourceResultOutput) Id() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupResourceResult) *string { return v.Id }).(pulumi.StringPtrOutput)
}

// a list of strings of ids of data sources that match the given arguments.
func (o LookupResourceResultOutput) Ids() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupResourceResult) []string { return v.Ids }).(pulumi.StringArrayOutput)
}

// Unique human-readable name of the Resource.
func (o LookupResourceResultOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupResourceResult) *string { return v.Name }).(pulumi.StringPtrOutput)
}

// The port to dial to initiate a connection from the egress node to this resource.
func (o LookupResourceResultOutput) Port() pulumi.IntPtrOutput {
	return o.ApplyT(func(v LookupResourceResult) *int { return v.Port }).(pulumi.IntPtrOutput)
}

// A single element list containing a map, where each key lists one of the following objects:
// * aks:
func (o LookupResourceResultOutput) Resources() GetResourceResourceArrayOutput {
	return o.ApplyT(func(v LookupResourceResult) []GetResourceResource { return v.Resources }).(GetResourceResourceArrayOutput)
}

// Tags is a map of key, value pairs.
func (o LookupResourceResultOutput) Tags() pulumi.MapOutput {
	return o.ApplyT(func(v LookupResourceResult) map[string]interface{} { return v.Tags }).(pulumi.MapOutput)
}

func (o LookupResourceResultOutput) Type() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupResourceResult) *string { return v.Type }).(pulumi.StringPtrOutput)
}

// The username to authenticate with.
func (o LookupResourceResultOutput) Username() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupResourceResult) *string { return v.Username }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupResourceResultOutput{})
}
