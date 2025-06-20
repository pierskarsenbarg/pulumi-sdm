// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package sdm

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-sdm/sdk/go/sdm/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// PeeringGroupPeer represents the link between two PeeringGroups
// This resource can be imported using the import command.
//
// ## Import
//
// A PeeringGroupPeer can be imported using the id, e.g.,
//
// ```sh
// $ pulumi import sdm:index/peeringGroupPeer:PeeringGroupPeer example gp-12345678
// ```
type PeeringGroupPeer struct {
	pulumi.CustomResourceState

	// Group ID from which the link will originate.
	GroupId pulumi.StringOutput `pulumi:"groupId"`
	// Peering Group ID to which Group ID will link.
	PeersWithGroupId pulumi.StringOutput `pulumi:"peersWithGroupId"`
}

// NewPeeringGroupPeer registers a new resource with the given unique name, arguments, and options.
func NewPeeringGroupPeer(ctx *pulumi.Context,
	name string, args *PeeringGroupPeerArgs, opts ...pulumi.ResourceOption) (*PeeringGroupPeer, error) {
	if args == nil {
		args = &PeeringGroupPeerArgs{}
	}

	opts = internal.PkgResourceDefaultOpts(opts)
	var resource PeeringGroupPeer
	err := ctx.RegisterResource("sdm:index/peeringGroupPeer:PeeringGroupPeer", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPeeringGroupPeer gets an existing PeeringGroupPeer resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPeeringGroupPeer(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PeeringGroupPeerState, opts ...pulumi.ResourceOption) (*PeeringGroupPeer, error) {
	var resource PeeringGroupPeer
	err := ctx.ReadResource("sdm:index/peeringGroupPeer:PeeringGroupPeer", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PeeringGroupPeer resources.
type peeringGroupPeerState struct {
	// Group ID from which the link will originate.
	GroupId *string `pulumi:"groupId"`
	// Peering Group ID to which Group ID will link.
	PeersWithGroupId *string `pulumi:"peersWithGroupId"`
}

type PeeringGroupPeerState struct {
	// Group ID from which the link will originate.
	GroupId pulumi.StringPtrInput
	// Peering Group ID to which Group ID will link.
	PeersWithGroupId pulumi.StringPtrInput
}

func (PeeringGroupPeerState) ElementType() reflect.Type {
	return reflect.TypeOf((*peeringGroupPeerState)(nil)).Elem()
}

type peeringGroupPeerArgs struct {
	// Group ID from which the link will originate.
	GroupId *string `pulumi:"groupId"`
	// Peering Group ID to which Group ID will link.
	PeersWithGroupId *string `pulumi:"peersWithGroupId"`
}

// The set of arguments for constructing a PeeringGroupPeer resource.
type PeeringGroupPeerArgs struct {
	// Group ID from which the link will originate.
	GroupId pulumi.StringPtrInput
	// Peering Group ID to which Group ID will link.
	PeersWithGroupId pulumi.StringPtrInput
}

func (PeeringGroupPeerArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*peeringGroupPeerArgs)(nil)).Elem()
}

type PeeringGroupPeerInput interface {
	pulumi.Input

	ToPeeringGroupPeerOutput() PeeringGroupPeerOutput
	ToPeeringGroupPeerOutputWithContext(ctx context.Context) PeeringGroupPeerOutput
}

func (*PeeringGroupPeer) ElementType() reflect.Type {
	return reflect.TypeOf((**PeeringGroupPeer)(nil)).Elem()
}

func (i *PeeringGroupPeer) ToPeeringGroupPeerOutput() PeeringGroupPeerOutput {
	return i.ToPeeringGroupPeerOutputWithContext(context.Background())
}

func (i *PeeringGroupPeer) ToPeeringGroupPeerOutputWithContext(ctx context.Context) PeeringGroupPeerOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PeeringGroupPeerOutput)
}

// PeeringGroupPeerArrayInput is an input type that accepts PeeringGroupPeerArray and PeeringGroupPeerArrayOutput values.
// You can construct a concrete instance of `PeeringGroupPeerArrayInput` via:
//
//	PeeringGroupPeerArray{ PeeringGroupPeerArgs{...} }
type PeeringGroupPeerArrayInput interface {
	pulumi.Input

	ToPeeringGroupPeerArrayOutput() PeeringGroupPeerArrayOutput
	ToPeeringGroupPeerArrayOutputWithContext(context.Context) PeeringGroupPeerArrayOutput
}

type PeeringGroupPeerArray []PeeringGroupPeerInput

func (PeeringGroupPeerArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*PeeringGroupPeer)(nil)).Elem()
}

func (i PeeringGroupPeerArray) ToPeeringGroupPeerArrayOutput() PeeringGroupPeerArrayOutput {
	return i.ToPeeringGroupPeerArrayOutputWithContext(context.Background())
}

func (i PeeringGroupPeerArray) ToPeeringGroupPeerArrayOutputWithContext(ctx context.Context) PeeringGroupPeerArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PeeringGroupPeerArrayOutput)
}

// PeeringGroupPeerMapInput is an input type that accepts PeeringGroupPeerMap and PeeringGroupPeerMapOutput values.
// You can construct a concrete instance of `PeeringGroupPeerMapInput` via:
//
//	PeeringGroupPeerMap{ "key": PeeringGroupPeerArgs{...} }
type PeeringGroupPeerMapInput interface {
	pulumi.Input

	ToPeeringGroupPeerMapOutput() PeeringGroupPeerMapOutput
	ToPeeringGroupPeerMapOutputWithContext(context.Context) PeeringGroupPeerMapOutput
}

type PeeringGroupPeerMap map[string]PeeringGroupPeerInput

func (PeeringGroupPeerMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*PeeringGroupPeer)(nil)).Elem()
}

func (i PeeringGroupPeerMap) ToPeeringGroupPeerMapOutput() PeeringGroupPeerMapOutput {
	return i.ToPeeringGroupPeerMapOutputWithContext(context.Background())
}

func (i PeeringGroupPeerMap) ToPeeringGroupPeerMapOutputWithContext(ctx context.Context) PeeringGroupPeerMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PeeringGroupPeerMapOutput)
}

type PeeringGroupPeerOutput struct{ *pulumi.OutputState }

func (PeeringGroupPeerOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**PeeringGroupPeer)(nil)).Elem()
}

func (o PeeringGroupPeerOutput) ToPeeringGroupPeerOutput() PeeringGroupPeerOutput {
	return o
}

func (o PeeringGroupPeerOutput) ToPeeringGroupPeerOutputWithContext(ctx context.Context) PeeringGroupPeerOutput {
	return o
}

// Group ID from which the link will originate.
func (o PeeringGroupPeerOutput) GroupId() pulumi.StringOutput {
	return o.ApplyT(func(v *PeeringGroupPeer) pulumi.StringOutput { return v.GroupId }).(pulumi.StringOutput)
}

// Peering Group ID to which Group ID will link.
func (o PeeringGroupPeerOutput) PeersWithGroupId() pulumi.StringOutput {
	return o.ApplyT(func(v *PeeringGroupPeer) pulumi.StringOutput { return v.PeersWithGroupId }).(pulumi.StringOutput)
}

type PeeringGroupPeerArrayOutput struct{ *pulumi.OutputState }

func (PeeringGroupPeerArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*PeeringGroupPeer)(nil)).Elem()
}

func (o PeeringGroupPeerArrayOutput) ToPeeringGroupPeerArrayOutput() PeeringGroupPeerArrayOutput {
	return o
}

func (o PeeringGroupPeerArrayOutput) ToPeeringGroupPeerArrayOutputWithContext(ctx context.Context) PeeringGroupPeerArrayOutput {
	return o
}

func (o PeeringGroupPeerArrayOutput) Index(i pulumi.IntInput) PeeringGroupPeerOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *PeeringGroupPeer {
		return vs[0].([]*PeeringGroupPeer)[vs[1].(int)]
	}).(PeeringGroupPeerOutput)
}

type PeeringGroupPeerMapOutput struct{ *pulumi.OutputState }

func (PeeringGroupPeerMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*PeeringGroupPeer)(nil)).Elem()
}

func (o PeeringGroupPeerMapOutput) ToPeeringGroupPeerMapOutput() PeeringGroupPeerMapOutput {
	return o
}

func (o PeeringGroupPeerMapOutput) ToPeeringGroupPeerMapOutputWithContext(ctx context.Context) PeeringGroupPeerMapOutput {
	return o
}

func (o PeeringGroupPeerMapOutput) MapIndex(k pulumi.StringInput) PeeringGroupPeerOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *PeeringGroupPeer {
		return vs[0].(map[string]*PeeringGroupPeer)[vs[1].(string)]
	}).(PeeringGroupPeerOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*PeeringGroupPeerInput)(nil)).Elem(), &PeeringGroupPeer{})
	pulumi.RegisterInputType(reflect.TypeOf((*PeeringGroupPeerArrayInput)(nil)).Elem(), PeeringGroupPeerArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*PeeringGroupPeerMapInput)(nil)).Elem(), PeeringGroupPeerMap{})
	pulumi.RegisterOutputType(PeeringGroupPeerOutput{})
	pulumi.RegisterOutputType(PeeringGroupPeerArrayOutput{})
	pulumi.RegisterOutputType(PeeringGroupPeerMapOutput{})
}
