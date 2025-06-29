// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package sdm

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-sdm/sdk/go/sdm/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// A RemoteIdentityGroup defines a group of remote identities.
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
//			_, err := sdm.GetRemoteIdentityGroup(ctx, &sdm.GetRemoteIdentityGroupArgs{
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
func GetRemoteIdentityGroup(ctx *pulumi.Context, args *GetRemoteIdentityGroupArgs, opts ...pulumi.InvokeOption) (*GetRemoteIdentityGroupResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetRemoteIdentityGroupResult
	err := ctx.Invoke("sdm:index/getRemoteIdentityGroup:getRemoteIdentityGroup", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getRemoteIdentityGroup.
type GetRemoteIdentityGroupArgs struct {
	// Unique identifier of the RemoteIdentityGroup.
	Id *string `pulumi:"id"`
	// Unique human-readable name of the RemoteIdentityGroup.
	Name *string `pulumi:"name"`
}

// A collection of values returned by getRemoteIdentityGroup.
type GetRemoteIdentityGroupResult struct {
	// Unique identifier of the RemoteIdentityGroup.
	Id *string `pulumi:"id"`
	// a list of strings of ids of data sources that match the given arguments.
	Ids []string `pulumi:"ids"`
	// Unique human-readable name of the RemoteIdentityGroup.
	Name *string `pulumi:"name"`
	// A list where each element has the following attributes:
	RemoteIdentityGroups []GetRemoteIdentityGroupRemoteIdentityGroup `pulumi:"remoteIdentityGroups"`
}

func GetRemoteIdentityGroupOutput(ctx *pulumi.Context, args GetRemoteIdentityGroupOutputArgs, opts ...pulumi.InvokeOption) GetRemoteIdentityGroupResultOutput {
	return pulumi.ToOutputWithContext(ctx.Context(), args).
		ApplyT(func(v interface{}) (GetRemoteIdentityGroupResultOutput, error) {
			args := v.(GetRemoteIdentityGroupArgs)
			options := pulumi.InvokeOutputOptions{InvokeOptions: internal.PkgInvokeDefaultOpts(opts)}
			return ctx.InvokeOutput("sdm:index/getRemoteIdentityGroup:getRemoteIdentityGroup", args, GetRemoteIdentityGroupResultOutput{}, options).(GetRemoteIdentityGroupResultOutput), nil
		}).(GetRemoteIdentityGroupResultOutput)
}

// A collection of arguments for invoking getRemoteIdentityGroup.
type GetRemoteIdentityGroupOutputArgs struct {
	// Unique identifier of the RemoteIdentityGroup.
	Id pulumi.StringPtrInput `pulumi:"id"`
	// Unique human-readable name of the RemoteIdentityGroup.
	Name pulumi.StringPtrInput `pulumi:"name"`
}

func (GetRemoteIdentityGroupOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetRemoteIdentityGroupArgs)(nil)).Elem()
}

// A collection of values returned by getRemoteIdentityGroup.
type GetRemoteIdentityGroupResultOutput struct{ *pulumi.OutputState }

func (GetRemoteIdentityGroupResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetRemoteIdentityGroupResult)(nil)).Elem()
}

func (o GetRemoteIdentityGroupResultOutput) ToGetRemoteIdentityGroupResultOutput() GetRemoteIdentityGroupResultOutput {
	return o
}

func (o GetRemoteIdentityGroupResultOutput) ToGetRemoteIdentityGroupResultOutputWithContext(ctx context.Context) GetRemoteIdentityGroupResultOutput {
	return o
}

// Unique identifier of the RemoteIdentityGroup.
func (o GetRemoteIdentityGroupResultOutput) Id() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetRemoteIdentityGroupResult) *string { return v.Id }).(pulumi.StringPtrOutput)
}

// a list of strings of ids of data sources that match the given arguments.
func (o GetRemoteIdentityGroupResultOutput) Ids() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetRemoteIdentityGroupResult) []string { return v.Ids }).(pulumi.StringArrayOutput)
}

// Unique human-readable name of the RemoteIdentityGroup.
func (o GetRemoteIdentityGroupResultOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetRemoteIdentityGroupResult) *string { return v.Name }).(pulumi.StringPtrOutput)
}

// A list where each element has the following attributes:
func (o GetRemoteIdentityGroupResultOutput) RemoteIdentityGroups() GetRemoteIdentityGroupRemoteIdentityGroupArrayOutput {
	return o.ApplyT(func(v GetRemoteIdentityGroupResult) []GetRemoteIdentityGroupRemoteIdentityGroup {
		return v.RemoteIdentityGroups
	}).(GetRemoteIdentityGroupRemoteIdentityGroupArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(GetRemoteIdentityGroupResultOutput{})
}
