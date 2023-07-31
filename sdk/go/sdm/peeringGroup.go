// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package sdm

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-sdm/sdk/go/sdm/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// PeeringGroups are the building blocks used for explicit network topology making.
//
//	They may be linked to other peering groups. Sets of PeeringGroupResource and PeeringGroupNode can be attached to a peering group.
//
// This resource can be imported using the import command.
//
// ## Import
//
// PeeringGroup can be imported using the id, e.g.,
//
// ```sh
//
//	$ pulumi import sdm:index/peeringGroup:PeeringGroup example g-12345678
//
// ```
type PeeringGroup struct {
	pulumi.CustomResourceState

	// Unique human-readable name of the PeeringGroup.
	Name pulumi.StringOutput `pulumi:"name"`
}

// NewPeeringGroup registers a new resource with the given unique name, arguments, and options.
func NewPeeringGroup(ctx *pulumi.Context,
	name string, args *PeeringGroupArgs, opts ...pulumi.ResourceOption) (*PeeringGroup, error) {
	if args == nil {
		args = &PeeringGroupArgs{}
	}

	opts = internal.PkgResourceDefaultOpts(opts)
	var resource PeeringGroup
	err := ctx.RegisterResource("sdm:index/peeringGroup:PeeringGroup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPeeringGroup gets an existing PeeringGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPeeringGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PeeringGroupState, opts ...pulumi.ResourceOption) (*PeeringGroup, error) {
	var resource PeeringGroup
	err := ctx.ReadResource("sdm:index/peeringGroup:PeeringGroup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PeeringGroup resources.
type peeringGroupState struct {
	// Unique human-readable name of the PeeringGroup.
	Name *string `pulumi:"name"`
}

type PeeringGroupState struct {
	// Unique human-readable name of the PeeringGroup.
	Name pulumi.StringPtrInput
}

func (PeeringGroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*peeringGroupState)(nil)).Elem()
}

type peeringGroupArgs struct {
	// Unique human-readable name of the PeeringGroup.
	Name *string `pulumi:"name"`
}

// The set of arguments for constructing a PeeringGroup resource.
type PeeringGroupArgs struct {
	// Unique human-readable name of the PeeringGroup.
	Name pulumi.StringPtrInput
}

func (PeeringGroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*peeringGroupArgs)(nil)).Elem()
}

type PeeringGroupInput interface {
	pulumi.Input

	ToPeeringGroupOutput() PeeringGroupOutput
	ToPeeringGroupOutputWithContext(ctx context.Context) PeeringGroupOutput
}

func (*PeeringGroup) ElementType() reflect.Type {
	return reflect.TypeOf((**PeeringGroup)(nil)).Elem()
}

func (i *PeeringGroup) ToPeeringGroupOutput() PeeringGroupOutput {
	return i.ToPeeringGroupOutputWithContext(context.Background())
}

func (i *PeeringGroup) ToPeeringGroupOutputWithContext(ctx context.Context) PeeringGroupOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PeeringGroupOutput)
}

// PeeringGroupArrayInput is an input type that accepts PeeringGroupArray and PeeringGroupArrayOutput values.
// You can construct a concrete instance of `PeeringGroupArrayInput` via:
//
//	PeeringGroupArray{ PeeringGroupArgs{...} }
type PeeringGroupArrayInput interface {
	pulumi.Input

	ToPeeringGroupArrayOutput() PeeringGroupArrayOutput
	ToPeeringGroupArrayOutputWithContext(context.Context) PeeringGroupArrayOutput
}

type PeeringGroupArray []PeeringGroupInput

func (PeeringGroupArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*PeeringGroup)(nil)).Elem()
}

func (i PeeringGroupArray) ToPeeringGroupArrayOutput() PeeringGroupArrayOutput {
	return i.ToPeeringGroupArrayOutputWithContext(context.Background())
}

func (i PeeringGroupArray) ToPeeringGroupArrayOutputWithContext(ctx context.Context) PeeringGroupArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PeeringGroupArrayOutput)
}

// PeeringGroupMapInput is an input type that accepts PeeringGroupMap and PeeringGroupMapOutput values.
// You can construct a concrete instance of `PeeringGroupMapInput` via:
//
//	PeeringGroupMap{ "key": PeeringGroupArgs{...} }
type PeeringGroupMapInput interface {
	pulumi.Input

	ToPeeringGroupMapOutput() PeeringGroupMapOutput
	ToPeeringGroupMapOutputWithContext(context.Context) PeeringGroupMapOutput
}

type PeeringGroupMap map[string]PeeringGroupInput

func (PeeringGroupMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*PeeringGroup)(nil)).Elem()
}

func (i PeeringGroupMap) ToPeeringGroupMapOutput() PeeringGroupMapOutput {
	return i.ToPeeringGroupMapOutputWithContext(context.Background())
}

func (i PeeringGroupMap) ToPeeringGroupMapOutputWithContext(ctx context.Context) PeeringGroupMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PeeringGroupMapOutput)
}

type PeeringGroupOutput struct{ *pulumi.OutputState }

func (PeeringGroupOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**PeeringGroup)(nil)).Elem()
}

func (o PeeringGroupOutput) ToPeeringGroupOutput() PeeringGroupOutput {
	return o
}

func (o PeeringGroupOutput) ToPeeringGroupOutputWithContext(ctx context.Context) PeeringGroupOutput {
	return o
}

// Unique human-readable name of the PeeringGroup.
func (o PeeringGroupOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *PeeringGroup) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

type PeeringGroupArrayOutput struct{ *pulumi.OutputState }

func (PeeringGroupArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*PeeringGroup)(nil)).Elem()
}

func (o PeeringGroupArrayOutput) ToPeeringGroupArrayOutput() PeeringGroupArrayOutput {
	return o
}

func (o PeeringGroupArrayOutput) ToPeeringGroupArrayOutputWithContext(ctx context.Context) PeeringGroupArrayOutput {
	return o
}

func (o PeeringGroupArrayOutput) Index(i pulumi.IntInput) PeeringGroupOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *PeeringGroup {
		return vs[0].([]*PeeringGroup)[vs[1].(int)]
	}).(PeeringGroupOutput)
}

type PeeringGroupMapOutput struct{ *pulumi.OutputState }

func (PeeringGroupMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*PeeringGroup)(nil)).Elem()
}

func (o PeeringGroupMapOutput) ToPeeringGroupMapOutput() PeeringGroupMapOutput {
	return o
}

func (o PeeringGroupMapOutput) ToPeeringGroupMapOutputWithContext(ctx context.Context) PeeringGroupMapOutput {
	return o
}

func (o PeeringGroupMapOutput) MapIndex(k pulumi.StringInput) PeeringGroupOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *PeeringGroup {
		return vs[0].(map[string]*PeeringGroup)[vs[1].(string)]
	}).(PeeringGroupOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*PeeringGroupInput)(nil)).Elem(), &PeeringGroup{})
	pulumi.RegisterInputType(reflect.TypeOf((*PeeringGroupArrayInput)(nil)).Elem(), PeeringGroupArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*PeeringGroupMapInput)(nil)).Elem(), PeeringGroupMap{})
	pulumi.RegisterOutputType(PeeringGroupOutput{})
	pulumi.RegisterOutputType(PeeringGroupArrayOutput{})
	pulumi.RegisterOutputType(PeeringGroupMapOutput{})
}
