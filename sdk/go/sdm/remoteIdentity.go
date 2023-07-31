// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package sdm

import (
	"context"
	"reflect"

	"errors"
	"github.com/pierskarsenbarg/pulumi-sdm/sdk/go/sdm/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// RemoteIdentities define the username to be used for a specific account
//
//	when connecting to a remote resource using that group.
//
// ## Import
//
// RemoteIdentity can be imported using the id, e.g.,
//
// ```sh
//
//	$ pulumi import sdm:index/remoteIdentity:RemoteIdentity example i-12345678
//
// ```
type RemoteIdentity struct {
	pulumi.CustomResourceState

	// The account for this remote identity.
	AccountId pulumi.StringOutput `pulumi:"accountId"`
	// The remote identity group.
	RemoteIdentityGroupId pulumi.StringOutput `pulumi:"remoteIdentityGroupId"`
	// The username to be used as the remote identity for this account.
	Username pulumi.StringOutput `pulumi:"username"`
}

// NewRemoteIdentity registers a new resource with the given unique name, arguments, and options.
func NewRemoteIdentity(ctx *pulumi.Context,
	name string, args *RemoteIdentityArgs, opts ...pulumi.ResourceOption) (*RemoteIdentity, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AccountId == nil {
		return nil, errors.New("invalid value for required argument 'AccountId'")
	}
	if args.RemoteIdentityGroupId == nil {
		return nil, errors.New("invalid value for required argument 'RemoteIdentityGroupId'")
	}
	if args.Username == nil {
		return nil, errors.New("invalid value for required argument 'Username'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource RemoteIdentity
	err := ctx.RegisterResource("sdm:index/remoteIdentity:RemoteIdentity", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRemoteIdentity gets an existing RemoteIdentity resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRemoteIdentity(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RemoteIdentityState, opts ...pulumi.ResourceOption) (*RemoteIdentity, error) {
	var resource RemoteIdentity
	err := ctx.ReadResource("sdm:index/remoteIdentity:RemoteIdentity", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering RemoteIdentity resources.
type remoteIdentityState struct {
	// The account for this remote identity.
	AccountId *string `pulumi:"accountId"`
	// The remote identity group.
	RemoteIdentityGroupId *string `pulumi:"remoteIdentityGroupId"`
	// The username to be used as the remote identity for this account.
	Username *string `pulumi:"username"`
}

type RemoteIdentityState struct {
	// The account for this remote identity.
	AccountId pulumi.StringPtrInput
	// The remote identity group.
	RemoteIdentityGroupId pulumi.StringPtrInput
	// The username to be used as the remote identity for this account.
	Username pulumi.StringPtrInput
}

func (RemoteIdentityState) ElementType() reflect.Type {
	return reflect.TypeOf((*remoteIdentityState)(nil)).Elem()
}

type remoteIdentityArgs struct {
	// The account for this remote identity.
	AccountId string `pulumi:"accountId"`
	// The remote identity group.
	RemoteIdentityGroupId string `pulumi:"remoteIdentityGroupId"`
	// The username to be used as the remote identity for this account.
	Username string `pulumi:"username"`
}

// The set of arguments for constructing a RemoteIdentity resource.
type RemoteIdentityArgs struct {
	// The account for this remote identity.
	AccountId pulumi.StringInput
	// The remote identity group.
	RemoteIdentityGroupId pulumi.StringInput
	// The username to be used as the remote identity for this account.
	Username pulumi.StringInput
}

func (RemoteIdentityArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*remoteIdentityArgs)(nil)).Elem()
}

type RemoteIdentityInput interface {
	pulumi.Input

	ToRemoteIdentityOutput() RemoteIdentityOutput
	ToRemoteIdentityOutputWithContext(ctx context.Context) RemoteIdentityOutput
}

func (*RemoteIdentity) ElementType() reflect.Type {
	return reflect.TypeOf((**RemoteIdentity)(nil)).Elem()
}

func (i *RemoteIdentity) ToRemoteIdentityOutput() RemoteIdentityOutput {
	return i.ToRemoteIdentityOutputWithContext(context.Background())
}

func (i *RemoteIdentity) ToRemoteIdentityOutputWithContext(ctx context.Context) RemoteIdentityOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RemoteIdentityOutput)
}

// RemoteIdentityArrayInput is an input type that accepts RemoteIdentityArray and RemoteIdentityArrayOutput values.
// You can construct a concrete instance of `RemoteIdentityArrayInput` via:
//
//	RemoteIdentityArray{ RemoteIdentityArgs{...} }
type RemoteIdentityArrayInput interface {
	pulumi.Input

	ToRemoteIdentityArrayOutput() RemoteIdentityArrayOutput
	ToRemoteIdentityArrayOutputWithContext(context.Context) RemoteIdentityArrayOutput
}

type RemoteIdentityArray []RemoteIdentityInput

func (RemoteIdentityArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*RemoteIdentity)(nil)).Elem()
}

func (i RemoteIdentityArray) ToRemoteIdentityArrayOutput() RemoteIdentityArrayOutput {
	return i.ToRemoteIdentityArrayOutputWithContext(context.Background())
}

func (i RemoteIdentityArray) ToRemoteIdentityArrayOutputWithContext(ctx context.Context) RemoteIdentityArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RemoteIdentityArrayOutput)
}

// RemoteIdentityMapInput is an input type that accepts RemoteIdentityMap and RemoteIdentityMapOutput values.
// You can construct a concrete instance of `RemoteIdentityMapInput` via:
//
//	RemoteIdentityMap{ "key": RemoteIdentityArgs{...} }
type RemoteIdentityMapInput interface {
	pulumi.Input

	ToRemoteIdentityMapOutput() RemoteIdentityMapOutput
	ToRemoteIdentityMapOutputWithContext(context.Context) RemoteIdentityMapOutput
}

type RemoteIdentityMap map[string]RemoteIdentityInput

func (RemoteIdentityMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*RemoteIdentity)(nil)).Elem()
}

func (i RemoteIdentityMap) ToRemoteIdentityMapOutput() RemoteIdentityMapOutput {
	return i.ToRemoteIdentityMapOutputWithContext(context.Background())
}

func (i RemoteIdentityMap) ToRemoteIdentityMapOutputWithContext(ctx context.Context) RemoteIdentityMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RemoteIdentityMapOutput)
}

type RemoteIdentityOutput struct{ *pulumi.OutputState }

func (RemoteIdentityOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**RemoteIdentity)(nil)).Elem()
}

func (o RemoteIdentityOutput) ToRemoteIdentityOutput() RemoteIdentityOutput {
	return o
}

func (o RemoteIdentityOutput) ToRemoteIdentityOutputWithContext(ctx context.Context) RemoteIdentityOutput {
	return o
}

// The account for this remote identity.
func (o RemoteIdentityOutput) AccountId() pulumi.StringOutput {
	return o.ApplyT(func(v *RemoteIdentity) pulumi.StringOutput { return v.AccountId }).(pulumi.StringOutput)
}

// The remote identity group.
func (o RemoteIdentityOutput) RemoteIdentityGroupId() pulumi.StringOutput {
	return o.ApplyT(func(v *RemoteIdentity) pulumi.StringOutput { return v.RemoteIdentityGroupId }).(pulumi.StringOutput)
}

// The username to be used as the remote identity for this account.
func (o RemoteIdentityOutput) Username() pulumi.StringOutput {
	return o.ApplyT(func(v *RemoteIdentity) pulumi.StringOutput { return v.Username }).(pulumi.StringOutput)
}

type RemoteIdentityArrayOutput struct{ *pulumi.OutputState }

func (RemoteIdentityArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*RemoteIdentity)(nil)).Elem()
}

func (o RemoteIdentityArrayOutput) ToRemoteIdentityArrayOutput() RemoteIdentityArrayOutput {
	return o
}

func (o RemoteIdentityArrayOutput) ToRemoteIdentityArrayOutputWithContext(ctx context.Context) RemoteIdentityArrayOutput {
	return o
}

func (o RemoteIdentityArrayOutput) Index(i pulumi.IntInput) RemoteIdentityOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *RemoteIdentity {
		return vs[0].([]*RemoteIdentity)[vs[1].(int)]
	}).(RemoteIdentityOutput)
}

type RemoteIdentityMapOutput struct{ *pulumi.OutputState }

func (RemoteIdentityMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*RemoteIdentity)(nil)).Elem()
}

func (o RemoteIdentityMapOutput) ToRemoteIdentityMapOutput() RemoteIdentityMapOutput {
	return o
}

func (o RemoteIdentityMapOutput) ToRemoteIdentityMapOutputWithContext(ctx context.Context) RemoteIdentityMapOutput {
	return o
}

func (o RemoteIdentityMapOutput) MapIndex(k pulumi.StringInput) RemoteIdentityOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *RemoteIdentity {
		return vs[0].(map[string]*RemoteIdentity)[vs[1].(string)]
	}).(RemoteIdentityOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*RemoteIdentityInput)(nil)).Elem(), &RemoteIdentity{})
	pulumi.RegisterInputType(reflect.TypeOf((*RemoteIdentityArrayInput)(nil)).Elem(), RemoteIdentityArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*RemoteIdentityMapInput)(nil)).Elem(), RemoteIdentityMap{})
	pulumi.RegisterOutputType(RemoteIdentityOutput{})
	pulumi.RegisterOutputType(RemoteIdentityArrayOutput{})
	pulumi.RegisterOutputType(RemoteIdentityMapOutput{})
}
