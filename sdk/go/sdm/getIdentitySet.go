// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package sdm

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-sdm/sdk/go/sdm/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// A IdentitySet defines a group of identity aliases.
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
//			_, err := sdm.LookupIdentitySet(ctx, &sdm.LookupIdentitySetArgs{
//				Name: pulumi.StringRef("default"),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func LookupIdentitySet(ctx *pulumi.Context, args *LookupIdentitySetArgs, opts ...pulumi.InvokeOption) (*LookupIdentitySetResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupIdentitySetResult
	err := ctx.Invoke("sdm:index/getIdentitySet:getIdentitySet", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getIdentitySet.
type LookupIdentitySetArgs struct {
	// Unique identifier of the IdentitySet.
	Id *string `pulumi:"id"`
	// Unique human-readable name of the IdentitySet.
	Name *string `pulumi:"name"`
}

// A collection of values returned by getIdentitySet.
type LookupIdentitySetResult struct {
	// Unique identifier of the IdentitySet.
	Id *string `pulumi:"id"`
	// A list where each element has the following attributes:
	IdentitySets []GetIdentitySetIdentitySet `pulumi:"identitySets"`
	// a list of strings of ids of data sources that match the given arguments.
	Ids []string `pulumi:"ids"`
	// Unique human-readable name of the IdentitySet.
	Name *string `pulumi:"name"`
}

func LookupIdentitySetOutput(ctx *pulumi.Context, args LookupIdentitySetOutputArgs, opts ...pulumi.InvokeOption) LookupIdentitySetResultOutput {
	return pulumi.ToOutputWithContext(ctx.Context(), args).
		ApplyT(func(v interface{}) (LookupIdentitySetResultOutput, error) {
			args := v.(LookupIdentitySetArgs)
			options := pulumi.InvokeOutputOptions{InvokeOptions: internal.PkgInvokeDefaultOpts(opts)}
			return ctx.InvokeOutput("sdm:index/getIdentitySet:getIdentitySet", args, LookupIdentitySetResultOutput{}, options).(LookupIdentitySetResultOutput), nil
		}).(LookupIdentitySetResultOutput)
}

// A collection of arguments for invoking getIdentitySet.
type LookupIdentitySetOutputArgs struct {
	// Unique identifier of the IdentitySet.
	Id pulumi.StringPtrInput `pulumi:"id"`
	// Unique human-readable name of the IdentitySet.
	Name pulumi.StringPtrInput `pulumi:"name"`
}

func (LookupIdentitySetOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupIdentitySetArgs)(nil)).Elem()
}

// A collection of values returned by getIdentitySet.
type LookupIdentitySetResultOutput struct{ *pulumi.OutputState }

func (LookupIdentitySetResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupIdentitySetResult)(nil)).Elem()
}

func (o LookupIdentitySetResultOutput) ToLookupIdentitySetResultOutput() LookupIdentitySetResultOutput {
	return o
}

func (o LookupIdentitySetResultOutput) ToLookupIdentitySetResultOutputWithContext(ctx context.Context) LookupIdentitySetResultOutput {
	return o
}

// Unique identifier of the IdentitySet.
func (o LookupIdentitySetResultOutput) Id() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupIdentitySetResult) *string { return v.Id }).(pulumi.StringPtrOutput)
}

// A list where each element has the following attributes:
func (o LookupIdentitySetResultOutput) IdentitySets() GetIdentitySetIdentitySetArrayOutput {
	return o.ApplyT(func(v LookupIdentitySetResult) []GetIdentitySetIdentitySet { return v.IdentitySets }).(GetIdentitySetIdentitySetArrayOutput)
}

// a list of strings of ids of data sources that match the given arguments.
func (o LookupIdentitySetResultOutput) Ids() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupIdentitySetResult) []string { return v.Ids }).(pulumi.StringArrayOutput)
}

// Unique human-readable name of the IdentitySet.
func (o LookupIdentitySetResultOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupIdentitySetResult) *string { return v.Name }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupIdentitySetResultOutput{})
}
