// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package sdm

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-sdm/sdk/v2/go/sdm/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// PeeringGroupNode represents the attachment between a PeeringGroup and a Node.
// This resource can be imported using the import command.
//
// ## Import
//
// PeeringGroupNode can be imported using the id, e.g.,
//
// ```sh
//
//	$ pulumi import sdm:index/peeringGroupNode:PeeringGroupNode example gn-12345678
//
// ```
type PeeringGroupNode struct {
	pulumi.CustomResourceState

	// Peering Group ID to which the node will be attached to.
	GroupId pulumi.StringOutput `pulumi:"groupId"`
	// Node ID to be attached.
	NodeId pulumi.StringOutput `pulumi:"nodeId"`
}

// NewPeeringGroupNode registers a new resource with the given unique name, arguments, and options.
func NewPeeringGroupNode(ctx *pulumi.Context,
	name string, args *PeeringGroupNodeArgs, opts ...pulumi.ResourceOption) (*PeeringGroupNode, error) {
	if args == nil {
		args = &PeeringGroupNodeArgs{}
	}

	opts = internal.PkgResourceDefaultOpts(opts)
	var resource PeeringGroupNode
	err := ctx.RegisterResource("sdm:index/peeringGroupNode:PeeringGroupNode", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPeeringGroupNode gets an existing PeeringGroupNode resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPeeringGroupNode(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PeeringGroupNodeState, opts ...pulumi.ResourceOption) (*PeeringGroupNode, error) {
	var resource PeeringGroupNode
	err := ctx.ReadResource("sdm:index/peeringGroupNode:PeeringGroupNode", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PeeringGroupNode resources.
type peeringGroupNodeState struct {
	// Peering Group ID to which the node will be attached to.
	GroupId *string `pulumi:"groupId"`
	// Node ID to be attached.
	NodeId *string `pulumi:"nodeId"`
}

type PeeringGroupNodeState struct {
	// Peering Group ID to which the node will be attached to.
	GroupId pulumi.StringPtrInput
	// Node ID to be attached.
	NodeId pulumi.StringPtrInput
}

func (PeeringGroupNodeState) ElementType() reflect.Type {
	return reflect.TypeOf((*peeringGroupNodeState)(nil)).Elem()
}

type peeringGroupNodeArgs struct {
	// Peering Group ID to which the node will be attached to.
	GroupId *string `pulumi:"groupId"`
	// Node ID to be attached.
	NodeId *string `pulumi:"nodeId"`
}

// The set of arguments for constructing a PeeringGroupNode resource.
type PeeringGroupNodeArgs struct {
	// Peering Group ID to which the node will be attached to.
	GroupId pulumi.StringPtrInput
	// Node ID to be attached.
	NodeId pulumi.StringPtrInput
}

func (PeeringGroupNodeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*peeringGroupNodeArgs)(nil)).Elem()
}

type PeeringGroupNodeInput interface {
	pulumi.Input

	ToPeeringGroupNodeOutput() PeeringGroupNodeOutput
	ToPeeringGroupNodeOutputWithContext(ctx context.Context) PeeringGroupNodeOutput
}

func (*PeeringGroupNode) ElementType() reflect.Type {
	return reflect.TypeOf((**PeeringGroupNode)(nil)).Elem()
}

func (i *PeeringGroupNode) ToPeeringGroupNodeOutput() PeeringGroupNodeOutput {
	return i.ToPeeringGroupNodeOutputWithContext(context.Background())
}

func (i *PeeringGroupNode) ToPeeringGroupNodeOutputWithContext(ctx context.Context) PeeringGroupNodeOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PeeringGroupNodeOutput)
}

// PeeringGroupNodeArrayInput is an input type that accepts PeeringGroupNodeArray and PeeringGroupNodeArrayOutput values.
// You can construct a concrete instance of `PeeringGroupNodeArrayInput` via:
//
//	PeeringGroupNodeArray{ PeeringGroupNodeArgs{...} }
type PeeringGroupNodeArrayInput interface {
	pulumi.Input

	ToPeeringGroupNodeArrayOutput() PeeringGroupNodeArrayOutput
	ToPeeringGroupNodeArrayOutputWithContext(context.Context) PeeringGroupNodeArrayOutput
}

type PeeringGroupNodeArray []PeeringGroupNodeInput

func (PeeringGroupNodeArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*PeeringGroupNode)(nil)).Elem()
}

func (i PeeringGroupNodeArray) ToPeeringGroupNodeArrayOutput() PeeringGroupNodeArrayOutput {
	return i.ToPeeringGroupNodeArrayOutputWithContext(context.Background())
}

func (i PeeringGroupNodeArray) ToPeeringGroupNodeArrayOutputWithContext(ctx context.Context) PeeringGroupNodeArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PeeringGroupNodeArrayOutput)
}

// PeeringGroupNodeMapInput is an input type that accepts PeeringGroupNodeMap and PeeringGroupNodeMapOutput values.
// You can construct a concrete instance of `PeeringGroupNodeMapInput` via:
//
//	PeeringGroupNodeMap{ "key": PeeringGroupNodeArgs{...} }
type PeeringGroupNodeMapInput interface {
	pulumi.Input

	ToPeeringGroupNodeMapOutput() PeeringGroupNodeMapOutput
	ToPeeringGroupNodeMapOutputWithContext(context.Context) PeeringGroupNodeMapOutput
}

type PeeringGroupNodeMap map[string]PeeringGroupNodeInput

func (PeeringGroupNodeMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*PeeringGroupNode)(nil)).Elem()
}

func (i PeeringGroupNodeMap) ToPeeringGroupNodeMapOutput() PeeringGroupNodeMapOutput {
	return i.ToPeeringGroupNodeMapOutputWithContext(context.Background())
}

func (i PeeringGroupNodeMap) ToPeeringGroupNodeMapOutputWithContext(ctx context.Context) PeeringGroupNodeMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PeeringGroupNodeMapOutput)
}

type PeeringGroupNodeOutput struct{ *pulumi.OutputState }

func (PeeringGroupNodeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**PeeringGroupNode)(nil)).Elem()
}

func (o PeeringGroupNodeOutput) ToPeeringGroupNodeOutput() PeeringGroupNodeOutput {
	return o
}

func (o PeeringGroupNodeOutput) ToPeeringGroupNodeOutputWithContext(ctx context.Context) PeeringGroupNodeOutput {
	return o
}

// Peering Group ID to which the node will be attached to.
func (o PeeringGroupNodeOutput) GroupId() pulumi.StringOutput {
	return o.ApplyT(func(v *PeeringGroupNode) pulumi.StringOutput { return v.GroupId }).(pulumi.StringOutput)
}

// Node ID to be attached.
func (o PeeringGroupNodeOutput) NodeId() pulumi.StringOutput {
	return o.ApplyT(func(v *PeeringGroupNode) pulumi.StringOutput { return v.NodeId }).(pulumi.StringOutput)
}

type PeeringGroupNodeArrayOutput struct{ *pulumi.OutputState }

func (PeeringGroupNodeArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*PeeringGroupNode)(nil)).Elem()
}

func (o PeeringGroupNodeArrayOutput) ToPeeringGroupNodeArrayOutput() PeeringGroupNodeArrayOutput {
	return o
}

func (o PeeringGroupNodeArrayOutput) ToPeeringGroupNodeArrayOutputWithContext(ctx context.Context) PeeringGroupNodeArrayOutput {
	return o
}

func (o PeeringGroupNodeArrayOutput) Index(i pulumi.IntInput) PeeringGroupNodeOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *PeeringGroupNode {
		return vs[0].([]*PeeringGroupNode)[vs[1].(int)]
	}).(PeeringGroupNodeOutput)
}

type PeeringGroupNodeMapOutput struct{ *pulumi.OutputState }

func (PeeringGroupNodeMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*PeeringGroupNode)(nil)).Elem()
}

func (o PeeringGroupNodeMapOutput) ToPeeringGroupNodeMapOutput() PeeringGroupNodeMapOutput {
	return o
}

func (o PeeringGroupNodeMapOutput) ToPeeringGroupNodeMapOutputWithContext(ctx context.Context) PeeringGroupNodeMapOutput {
	return o
}

func (o PeeringGroupNodeMapOutput) MapIndex(k pulumi.StringInput) PeeringGroupNodeOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *PeeringGroupNode {
		return vs[0].(map[string]*PeeringGroupNode)[vs[1].(string)]
	}).(PeeringGroupNodeOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*PeeringGroupNodeInput)(nil)).Elem(), &PeeringGroupNode{})
	pulumi.RegisterInputType(reflect.TypeOf((*PeeringGroupNodeArrayInput)(nil)).Elem(), PeeringGroupNodeArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*PeeringGroupNodeMapInput)(nil)).Elem(), PeeringGroupNodeMap{})
	pulumi.RegisterOutputType(PeeringGroupNodeOutput{})
	pulumi.RegisterOutputType(PeeringGroupNodeArrayOutput{})
	pulumi.RegisterOutputType(PeeringGroupNodeMapOutput{})
}
