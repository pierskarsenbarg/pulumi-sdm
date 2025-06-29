// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package sdm

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-sdm/sdk/go/sdm/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// PeeringGroupResource represents the attachment between a PeeringGroup and a Resource.
// This resource can be imported using the import command.
//
// ## Import
//
// A PeeringGroupResource can be imported using the id, e.g.,
//
// ```sh
// $ pulumi import sdm:index/peeringGroupResource:PeeringGroupResource example gr-12345678
// ```
type PeeringGroupResource struct {
	pulumi.CustomResourceState

	// Peering Group ID to which the resource will be attached to.
	GroupId pulumi.StringOutput `pulumi:"groupId"`
	// Resource ID to be attached.
	ResourceId pulumi.StringOutput `pulumi:"resourceId"`
}

// NewPeeringGroupResource registers a new resource with the given unique name, arguments, and options.
func NewPeeringGroupResource(ctx *pulumi.Context,
	name string, args *PeeringGroupResourceArgs, opts ...pulumi.ResourceOption) (*PeeringGroupResource, error) {
	if args == nil {
		args = &PeeringGroupResourceArgs{}
	}

	opts = internal.PkgResourceDefaultOpts(opts)
	var resource PeeringGroupResource
	err := ctx.RegisterResource("sdm:index/peeringGroupResource:PeeringGroupResource", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPeeringGroupResource gets an existing PeeringGroupResource resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPeeringGroupResource(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PeeringGroupResourceState, opts ...pulumi.ResourceOption) (*PeeringGroupResource, error) {
	var resource PeeringGroupResource
	err := ctx.ReadResource("sdm:index/peeringGroupResource:PeeringGroupResource", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PeeringGroupResource resources.
type peeringGroupResourceState struct {
	// Peering Group ID to which the resource will be attached to.
	GroupId *string `pulumi:"groupId"`
	// Resource ID to be attached.
	ResourceId *string `pulumi:"resourceId"`
}

type PeeringGroupResourceState struct {
	// Peering Group ID to which the resource will be attached to.
	GroupId pulumi.StringPtrInput
	// Resource ID to be attached.
	ResourceId pulumi.StringPtrInput
}

func (PeeringGroupResourceState) ElementType() reflect.Type {
	return reflect.TypeOf((*peeringGroupResourceState)(nil)).Elem()
}

type peeringGroupResourceArgs struct {
	// Peering Group ID to which the resource will be attached to.
	GroupId *string `pulumi:"groupId"`
	// Resource ID to be attached.
	ResourceId *string `pulumi:"resourceId"`
}

// The set of arguments for constructing a PeeringGroupResource resource.
type PeeringGroupResourceArgs struct {
	// Peering Group ID to which the resource will be attached to.
	GroupId pulumi.StringPtrInput
	// Resource ID to be attached.
	ResourceId pulumi.StringPtrInput
}

func (PeeringGroupResourceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*peeringGroupResourceArgs)(nil)).Elem()
}

type PeeringGroupResourceInput interface {
	pulumi.Input

	ToPeeringGroupResourceOutput() PeeringGroupResourceOutput
	ToPeeringGroupResourceOutputWithContext(ctx context.Context) PeeringGroupResourceOutput
}

func (*PeeringGroupResource) ElementType() reflect.Type {
	return reflect.TypeOf((**PeeringGroupResource)(nil)).Elem()
}

func (i *PeeringGroupResource) ToPeeringGroupResourceOutput() PeeringGroupResourceOutput {
	return i.ToPeeringGroupResourceOutputWithContext(context.Background())
}

func (i *PeeringGroupResource) ToPeeringGroupResourceOutputWithContext(ctx context.Context) PeeringGroupResourceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PeeringGroupResourceOutput)
}

// PeeringGroupResourceArrayInput is an input type that accepts PeeringGroupResourceArray and PeeringGroupResourceArrayOutput values.
// You can construct a concrete instance of `PeeringGroupResourceArrayInput` via:
//
//	PeeringGroupResourceArray{ PeeringGroupResourceArgs{...} }
type PeeringGroupResourceArrayInput interface {
	pulumi.Input

	ToPeeringGroupResourceArrayOutput() PeeringGroupResourceArrayOutput
	ToPeeringGroupResourceArrayOutputWithContext(context.Context) PeeringGroupResourceArrayOutput
}

type PeeringGroupResourceArray []PeeringGroupResourceInput

func (PeeringGroupResourceArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*PeeringGroupResource)(nil)).Elem()
}

func (i PeeringGroupResourceArray) ToPeeringGroupResourceArrayOutput() PeeringGroupResourceArrayOutput {
	return i.ToPeeringGroupResourceArrayOutputWithContext(context.Background())
}

func (i PeeringGroupResourceArray) ToPeeringGroupResourceArrayOutputWithContext(ctx context.Context) PeeringGroupResourceArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PeeringGroupResourceArrayOutput)
}

// PeeringGroupResourceMapInput is an input type that accepts PeeringGroupResourceMap and PeeringGroupResourceMapOutput values.
// You can construct a concrete instance of `PeeringGroupResourceMapInput` via:
//
//	PeeringGroupResourceMap{ "key": PeeringGroupResourceArgs{...} }
type PeeringGroupResourceMapInput interface {
	pulumi.Input

	ToPeeringGroupResourceMapOutput() PeeringGroupResourceMapOutput
	ToPeeringGroupResourceMapOutputWithContext(context.Context) PeeringGroupResourceMapOutput
}

type PeeringGroupResourceMap map[string]PeeringGroupResourceInput

func (PeeringGroupResourceMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*PeeringGroupResource)(nil)).Elem()
}

func (i PeeringGroupResourceMap) ToPeeringGroupResourceMapOutput() PeeringGroupResourceMapOutput {
	return i.ToPeeringGroupResourceMapOutputWithContext(context.Background())
}

func (i PeeringGroupResourceMap) ToPeeringGroupResourceMapOutputWithContext(ctx context.Context) PeeringGroupResourceMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PeeringGroupResourceMapOutput)
}

type PeeringGroupResourceOutput struct{ *pulumi.OutputState }

func (PeeringGroupResourceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**PeeringGroupResource)(nil)).Elem()
}

func (o PeeringGroupResourceOutput) ToPeeringGroupResourceOutput() PeeringGroupResourceOutput {
	return o
}

func (o PeeringGroupResourceOutput) ToPeeringGroupResourceOutputWithContext(ctx context.Context) PeeringGroupResourceOutput {
	return o
}

// Peering Group ID to which the resource will be attached to.
func (o PeeringGroupResourceOutput) GroupId() pulumi.StringOutput {
	return o.ApplyT(func(v *PeeringGroupResource) pulumi.StringOutput { return v.GroupId }).(pulumi.StringOutput)
}

// Resource ID to be attached.
func (o PeeringGroupResourceOutput) ResourceId() pulumi.StringOutput {
	return o.ApplyT(func(v *PeeringGroupResource) pulumi.StringOutput { return v.ResourceId }).(pulumi.StringOutput)
}

type PeeringGroupResourceArrayOutput struct{ *pulumi.OutputState }

func (PeeringGroupResourceArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*PeeringGroupResource)(nil)).Elem()
}

func (o PeeringGroupResourceArrayOutput) ToPeeringGroupResourceArrayOutput() PeeringGroupResourceArrayOutput {
	return o
}

func (o PeeringGroupResourceArrayOutput) ToPeeringGroupResourceArrayOutputWithContext(ctx context.Context) PeeringGroupResourceArrayOutput {
	return o
}

func (o PeeringGroupResourceArrayOutput) Index(i pulumi.IntInput) PeeringGroupResourceOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *PeeringGroupResource {
		return vs[0].([]*PeeringGroupResource)[vs[1].(int)]
	}).(PeeringGroupResourceOutput)
}

type PeeringGroupResourceMapOutput struct{ *pulumi.OutputState }

func (PeeringGroupResourceMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*PeeringGroupResource)(nil)).Elem()
}

func (o PeeringGroupResourceMapOutput) ToPeeringGroupResourceMapOutput() PeeringGroupResourceMapOutput {
	return o
}

func (o PeeringGroupResourceMapOutput) ToPeeringGroupResourceMapOutputWithContext(ctx context.Context) PeeringGroupResourceMapOutput {
	return o
}

func (o PeeringGroupResourceMapOutput) MapIndex(k pulumi.StringInput) PeeringGroupResourceOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *PeeringGroupResource {
		return vs[0].(map[string]*PeeringGroupResource)[vs[1].(string)]
	}).(PeeringGroupResourceOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*PeeringGroupResourceInput)(nil)).Elem(), &PeeringGroupResource{})
	pulumi.RegisterInputType(reflect.TypeOf((*PeeringGroupResourceArrayInput)(nil)).Elem(), PeeringGroupResourceArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*PeeringGroupResourceMapInput)(nil)).Elem(), PeeringGroupResourceMap{})
	pulumi.RegisterOutputType(PeeringGroupResourceOutput{})
	pulumi.RegisterOutputType(PeeringGroupResourceArrayOutput{})
	pulumi.RegisterOutputType(PeeringGroupResourceMapOutput{})
}
