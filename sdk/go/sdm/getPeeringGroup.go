// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package sdm

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-sdm/sdk/v2/go/sdm/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// PeeringGroups are the building blocks used for explicit network topology making.
//
//	They may be linked to other peering groups. Sets of PeeringGroupResource and PeeringGroupNode can be attached to a peering group.
func LookupPeeringGroup(ctx *pulumi.Context, args *LookupPeeringGroupArgs, opts ...pulumi.InvokeOption) (*LookupPeeringGroupResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupPeeringGroupResult
	err := ctx.Invoke("sdm:index/getPeeringGroup:getPeeringGroup", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getPeeringGroup.
type LookupPeeringGroupArgs struct {
	// Unique identifier of the PeeringGroup.
	Id *string `pulumi:"id"`
	// Unique human-readable name of the PeeringGroup.
	Name *string `pulumi:"name"`
}

// A collection of values returned by getPeeringGroup.
type LookupPeeringGroupResult struct {
	// Unique identifier of the PeeringGroup.
	Id *string `pulumi:"id"`
	// a list of strings of ids of data sources that match the given arguments.
	Ids []string `pulumi:"ids"`
	// Unique human-readable name of the PeeringGroup.
	Name *string `pulumi:"name"`
	// A list where each element has the following attributes:
	PeeringGroups []GetPeeringGroupPeeringGroup `pulumi:"peeringGroups"`
}

func LookupPeeringGroupOutput(ctx *pulumi.Context, args LookupPeeringGroupOutputArgs, opts ...pulumi.InvokeOption) LookupPeeringGroupResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupPeeringGroupResult, error) {
			args := v.(LookupPeeringGroupArgs)
			r, err := LookupPeeringGroup(ctx, &args, opts...)
			var s LookupPeeringGroupResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupPeeringGroupResultOutput)
}

// A collection of arguments for invoking getPeeringGroup.
type LookupPeeringGroupOutputArgs struct {
	// Unique identifier of the PeeringGroup.
	Id pulumi.StringPtrInput `pulumi:"id"`
	// Unique human-readable name of the PeeringGroup.
	Name pulumi.StringPtrInput `pulumi:"name"`
}

func (LookupPeeringGroupOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupPeeringGroupArgs)(nil)).Elem()
}

// A collection of values returned by getPeeringGroup.
type LookupPeeringGroupResultOutput struct{ *pulumi.OutputState }

func (LookupPeeringGroupResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupPeeringGroupResult)(nil)).Elem()
}

func (o LookupPeeringGroupResultOutput) ToLookupPeeringGroupResultOutput() LookupPeeringGroupResultOutput {
	return o
}

func (o LookupPeeringGroupResultOutput) ToLookupPeeringGroupResultOutputWithContext(ctx context.Context) LookupPeeringGroupResultOutput {
	return o
}

// Unique identifier of the PeeringGroup.
func (o LookupPeeringGroupResultOutput) Id() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupPeeringGroupResult) *string { return v.Id }).(pulumi.StringPtrOutput)
}

// a list of strings of ids of data sources that match the given arguments.
func (o LookupPeeringGroupResultOutput) Ids() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupPeeringGroupResult) []string { return v.Ids }).(pulumi.StringArrayOutput)
}

// Unique human-readable name of the PeeringGroup.
func (o LookupPeeringGroupResultOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupPeeringGroupResult) *string { return v.Name }).(pulumi.StringPtrOutput)
}

// A list where each element has the following attributes:
func (o LookupPeeringGroupResultOutput) PeeringGroups() GetPeeringGroupPeeringGroupArrayOutput {
	return o.ApplyT(func(v LookupPeeringGroupResult) []GetPeeringGroupPeeringGroup { return v.PeeringGroups }).(GetPeeringGroupPeeringGroupArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupPeeringGroupResultOutput{})
}
