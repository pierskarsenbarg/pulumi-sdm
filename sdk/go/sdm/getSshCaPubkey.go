// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package sdm

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-sdm/sdk/go/sdm/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// The SSH CA Pubkey is a public key used for setting up SSH resources.
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
//			sshPubkeyQuery, err := sdm.GetSshCaPubkey(ctx, &sdm.GetSshCaPubkeyArgs{}, nil)
//			if err != nil {
//				return err
//			}
//			ctx.Export("sshca", sshPubkeyQuery.PublicKey)
//			return nil
//		})
//	}
//
// ```
func GetSshCaPubkey(ctx *pulumi.Context, args *GetSshCaPubkeyArgs, opts ...pulumi.InvokeOption) (*GetSshCaPubkeyResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetSshCaPubkeyResult
	err := ctx.Invoke("sdm:index/getSshCaPubkey:getSshCaPubkey", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getSshCaPubkey.
type GetSshCaPubkeyArgs struct {
	// a generated id representing this request.
	Id *string `pulumi:"id"`
	// the SSH Certificate Authority public key.
	PublicKey *string `pulumi:"publicKey"`
}

// A collection of values returned by getSshCaPubkey.
type GetSshCaPubkeyResult struct {
	// a generated id representing this request.
	Id *string `pulumi:"id"`
	// the SSH Certificate Authority public key.
	PublicKey *string `pulumi:"publicKey"`
}

func GetSshCaPubkeyOutput(ctx *pulumi.Context, args GetSshCaPubkeyOutputArgs, opts ...pulumi.InvokeOption) GetSshCaPubkeyResultOutput {
	return pulumi.ToOutputWithContext(ctx.Context(), args).
		ApplyT(func(v interface{}) (GetSshCaPubkeyResultOutput, error) {
			args := v.(GetSshCaPubkeyArgs)
			options := pulumi.InvokeOutputOptions{InvokeOptions: internal.PkgInvokeDefaultOpts(opts)}
			return ctx.InvokeOutput("sdm:index/getSshCaPubkey:getSshCaPubkey", args, GetSshCaPubkeyResultOutput{}, options).(GetSshCaPubkeyResultOutput), nil
		}).(GetSshCaPubkeyResultOutput)
}

// A collection of arguments for invoking getSshCaPubkey.
type GetSshCaPubkeyOutputArgs struct {
	// a generated id representing this request.
	Id pulumi.StringPtrInput `pulumi:"id"`
	// the SSH Certificate Authority public key.
	PublicKey pulumi.StringPtrInput `pulumi:"publicKey"`
}

func (GetSshCaPubkeyOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetSshCaPubkeyArgs)(nil)).Elem()
}

// A collection of values returned by getSshCaPubkey.
type GetSshCaPubkeyResultOutput struct{ *pulumi.OutputState }

func (GetSshCaPubkeyResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetSshCaPubkeyResult)(nil)).Elem()
}

func (o GetSshCaPubkeyResultOutput) ToGetSshCaPubkeyResultOutput() GetSshCaPubkeyResultOutput {
	return o
}

func (o GetSshCaPubkeyResultOutput) ToGetSshCaPubkeyResultOutputWithContext(ctx context.Context) GetSshCaPubkeyResultOutput {
	return o
}

// a generated id representing this request.
func (o GetSshCaPubkeyResultOutput) Id() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetSshCaPubkeyResult) *string { return v.Id }).(pulumi.StringPtrOutput)
}

// the SSH Certificate Authority public key.
func (o GetSshCaPubkeyResultOutput) PublicKey() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetSshCaPubkeyResult) *string { return v.PublicKey }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetSshCaPubkeyResultOutput{})
}
