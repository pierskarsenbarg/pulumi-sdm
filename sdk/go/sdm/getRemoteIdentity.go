// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package sdm

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-sdm/sdk/go/sdm/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// RemoteIdentities define the username to be used for a specific account
//
//	when connecting to a remote resource using that group.
//
// ## Example Usage
//
// <!--Start PulumiCodeChooser -->
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
//			_, err := sdm.LookupRemoteIdentity(ctx, &sdm.LookupRemoteIdentityArgs{
//				Id:       pulumi.StringRef("i-0900909"),
//				Username: pulumi.StringRef("user"),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
// <!--End PulumiCodeChooser -->
func LookupRemoteIdentity(ctx *pulumi.Context, args *LookupRemoteIdentityArgs, opts ...pulumi.InvokeOption) (*LookupRemoteIdentityResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupRemoteIdentityResult
	err := ctx.Invoke("sdm:index/getRemoteIdentity:getRemoteIdentity", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getRemoteIdentity.
type LookupRemoteIdentityArgs struct {
	// The account for this remote identity.
	AccountId *string `pulumi:"accountId"`
	// Unique identifier of the RemoteIdentity.
	Id *string `pulumi:"id"`
	// The remote identity group.
	RemoteIdentityGroupId *string `pulumi:"remoteIdentityGroupId"`
	// The username to be used as the remote identity for this account.
	Username *string `pulumi:"username"`
}

// A collection of values returned by getRemoteIdentity.
type LookupRemoteIdentityResult struct {
	// The account for this remote identity.
	AccountId *string `pulumi:"accountId"`
	// Unique identifier of the RemoteIdentity.
	Id *string `pulumi:"id"`
	// a list of strings of ids of data sources that match the given arguments.
	Ids []string `pulumi:"ids"`
	// A list where each element has the following attributes:
	RemoteIdentities []GetRemoteIdentityRemoteIdentity `pulumi:"remoteIdentities"`
	// The remote identity group.
	RemoteIdentityGroupId *string `pulumi:"remoteIdentityGroupId"`
	// The username to be used as the remote identity for this account.
	Username *string `pulumi:"username"`
}

func LookupRemoteIdentityOutput(ctx *pulumi.Context, args LookupRemoteIdentityOutputArgs, opts ...pulumi.InvokeOption) LookupRemoteIdentityResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupRemoteIdentityResult, error) {
			args := v.(LookupRemoteIdentityArgs)
			r, err := LookupRemoteIdentity(ctx, &args, opts...)
			var s LookupRemoteIdentityResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupRemoteIdentityResultOutput)
}

// A collection of arguments for invoking getRemoteIdentity.
type LookupRemoteIdentityOutputArgs struct {
	// The account for this remote identity.
	AccountId pulumi.StringPtrInput `pulumi:"accountId"`
	// Unique identifier of the RemoteIdentity.
	Id pulumi.StringPtrInput `pulumi:"id"`
	// The remote identity group.
	RemoteIdentityGroupId pulumi.StringPtrInput `pulumi:"remoteIdentityGroupId"`
	// The username to be used as the remote identity for this account.
	Username pulumi.StringPtrInput `pulumi:"username"`
}

func (LookupRemoteIdentityOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupRemoteIdentityArgs)(nil)).Elem()
}

// A collection of values returned by getRemoteIdentity.
type LookupRemoteIdentityResultOutput struct{ *pulumi.OutputState }

func (LookupRemoteIdentityResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupRemoteIdentityResult)(nil)).Elem()
}

func (o LookupRemoteIdentityResultOutput) ToLookupRemoteIdentityResultOutput() LookupRemoteIdentityResultOutput {
	return o
}

func (o LookupRemoteIdentityResultOutput) ToLookupRemoteIdentityResultOutputWithContext(ctx context.Context) LookupRemoteIdentityResultOutput {
	return o
}

// The account for this remote identity.
func (o LookupRemoteIdentityResultOutput) AccountId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupRemoteIdentityResult) *string { return v.AccountId }).(pulumi.StringPtrOutput)
}

// Unique identifier of the RemoteIdentity.
func (o LookupRemoteIdentityResultOutput) Id() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupRemoteIdentityResult) *string { return v.Id }).(pulumi.StringPtrOutput)
}

// a list of strings of ids of data sources that match the given arguments.
func (o LookupRemoteIdentityResultOutput) Ids() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupRemoteIdentityResult) []string { return v.Ids }).(pulumi.StringArrayOutput)
}

// A list where each element has the following attributes:
func (o LookupRemoteIdentityResultOutput) RemoteIdentities() GetRemoteIdentityRemoteIdentityArrayOutput {
	return o.ApplyT(func(v LookupRemoteIdentityResult) []GetRemoteIdentityRemoteIdentity { return v.RemoteIdentities }).(GetRemoteIdentityRemoteIdentityArrayOutput)
}

// The remote identity group.
func (o LookupRemoteIdentityResultOutput) RemoteIdentityGroupId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupRemoteIdentityResult) *string { return v.RemoteIdentityGroupId }).(pulumi.StringPtrOutput)
}

// The username to be used as the remote identity for this account.
func (o LookupRemoteIdentityResultOutput) Username() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupRemoteIdentityResult) *string { return v.Username }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupRemoteIdentityResultOutput{})
}
