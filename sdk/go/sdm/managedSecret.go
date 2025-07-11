// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package sdm

import (
	"context"
	"reflect"

	"errors"
	"github.com/pierskarsenbarg/pulumi-sdm/sdk/go/sdm/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// ManagedSecret contains details about managed secret
// This resource can be imported using the import command.
//
// ## Import
//
// A ManagedSecret can be imported using the id, e.g.,
//
// ```sh
// $ pulumi import sdm:index/managedSecret:ManagedSecret example ms-12345678
// ```
type ManagedSecret struct {
	pulumi.CustomResourceState

	// public part of the secret value
	Config pulumi.StringOutput `pulumi:"config"`
	// Timestamp of when secret is going to be rotated
	ExpiresAt pulumi.StringOutput `pulumi:"expiresAt"`
	// Timestamp of when secret was last rotated
	LastRotatedAt pulumi.StringOutput `pulumi:"lastRotatedAt"`
	// Unique human-readable name of the Managed Secret.
	Name pulumi.StringOutput `pulumi:"name"`
	// An ID of a Secret Engine linked with the Managed Secret.
	SecretEngineId pulumi.StringOutput `pulumi:"secretEngineId"`
	// Path in a secret store.
	SecretStorePath pulumi.StringOutput `pulumi:"secretStorePath"`
	// Tags is a map of key, value pairs.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Sensitive value of the secret.
	Value pulumi.StringPtrOutput `pulumi:"value"`
}

// NewManagedSecret registers a new resource with the given unique name, arguments, and options.
func NewManagedSecret(ctx *pulumi.Context,
	name string, args *ManagedSecretArgs, opts ...pulumi.ResourceOption) (*ManagedSecret, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.SecretEngineId == nil {
		return nil, errors.New("invalid value for required argument 'SecretEngineId'")
	}
	if args.Value != nil {
		args.Value = pulumi.ToSecret(args.Value).(pulumi.StringPtrInput)
	}
	secrets := pulumi.AdditionalSecretOutputs([]string{
		"value",
	})
	opts = append(opts, secrets)
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource ManagedSecret
	err := ctx.RegisterResource("sdm:index/managedSecret:ManagedSecret", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetManagedSecret gets an existing ManagedSecret resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetManagedSecret(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ManagedSecretState, opts ...pulumi.ResourceOption) (*ManagedSecret, error) {
	var resource ManagedSecret
	err := ctx.ReadResource("sdm:index/managedSecret:ManagedSecret", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ManagedSecret resources.
type managedSecretState struct {
	// public part of the secret value
	Config *string `pulumi:"config"`
	// Timestamp of when secret is going to be rotated
	ExpiresAt *string `pulumi:"expiresAt"`
	// Timestamp of when secret was last rotated
	LastRotatedAt *string `pulumi:"lastRotatedAt"`
	// Unique human-readable name of the Managed Secret.
	Name *string `pulumi:"name"`
	// An ID of a Secret Engine linked with the Managed Secret.
	SecretEngineId *string `pulumi:"secretEngineId"`
	// Path in a secret store.
	SecretStorePath *string `pulumi:"secretStorePath"`
	// Tags is a map of key, value pairs.
	Tags map[string]string `pulumi:"tags"`
	// Sensitive value of the secret.
	Value *string `pulumi:"value"`
}

type ManagedSecretState struct {
	// public part of the secret value
	Config pulumi.StringPtrInput
	// Timestamp of when secret is going to be rotated
	ExpiresAt pulumi.StringPtrInput
	// Timestamp of when secret was last rotated
	LastRotatedAt pulumi.StringPtrInput
	// Unique human-readable name of the Managed Secret.
	Name pulumi.StringPtrInput
	// An ID of a Secret Engine linked with the Managed Secret.
	SecretEngineId pulumi.StringPtrInput
	// Path in a secret store.
	SecretStorePath pulumi.StringPtrInput
	// Tags is a map of key, value pairs.
	Tags pulumi.StringMapInput
	// Sensitive value of the secret.
	Value pulumi.StringPtrInput
}

func (ManagedSecretState) ElementType() reflect.Type {
	return reflect.TypeOf((*managedSecretState)(nil)).Elem()
}

type managedSecretArgs struct {
	// Unique human-readable name of the Managed Secret.
	Name *string `pulumi:"name"`
	// An ID of a Secret Engine linked with the Managed Secret.
	SecretEngineId string `pulumi:"secretEngineId"`
	// Tags is a map of key, value pairs.
	Tags map[string]string `pulumi:"tags"`
	// Sensitive value of the secret.
	Value *string `pulumi:"value"`
}

// The set of arguments for constructing a ManagedSecret resource.
type ManagedSecretArgs struct {
	// Unique human-readable name of the Managed Secret.
	Name pulumi.StringPtrInput
	// An ID of a Secret Engine linked with the Managed Secret.
	SecretEngineId pulumi.StringInput
	// Tags is a map of key, value pairs.
	Tags pulumi.StringMapInput
	// Sensitive value of the secret.
	Value pulumi.StringPtrInput
}

func (ManagedSecretArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*managedSecretArgs)(nil)).Elem()
}

type ManagedSecretInput interface {
	pulumi.Input

	ToManagedSecretOutput() ManagedSecretOutput
	ToManagedSecretOutputWithContext(ctx context.Context) ManagedSecretOutput
}

func (*ManagedSecret) ElementType() reflect.Type {
	return reflect.TypeOf((**ManagedSecret)(nil)).Elem()
}

func (i *ManagedSecret) ToManagedSecretOutput() ManagedSecretOutput {
	return i.ToManagedSecretOutputWithContext(context.Background())
}

func (i *ManagedSecret) ToManagedSecretOutputWithContext(ctx context.Context) ManagedSecretOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ManagedSecretOutput)
}

// ManagedSecretArrayInput is an input type that accepts ManagedSecretArray and ManagedSecretArrayOutput values.
// You can construct a concrete instance of `ManagedSecretArrayInput` via:
//
//	ManagedSecretArray{ ManagedSecretArgs{...} }
type ManagedSecretArrayInput interface {
	pulumi.Input

	ToManagedSecretArrayOutput() ManagedSecretArrayOutput
	ToManagedSecretArrayOutputWithContext(context.Context) ManagedSecretArrayOutput
}

type ManagedSecretArray []ManagedSecretInput

func (ManagedSecretArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ManagedSecret)(nil)).Elem()
}

func (i ManagedSecretArray) ToManagedSecretArrayOutput() ManagedSecretArrayOutput {
	return i.ToManagedSecretArrayOutputWithContext(context.Background())
}

func (i ManagedSecretArray) ToManagedSecretArrayOutputWithContext(ctx context.Context) ManagedSecretArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ManagedSecretArrayOutput)
}

// ManagedSecretMapInput is an input type that accepts ManagedSecretMap and ManagedSecretMapOutput values.
// You can construct a concrete instance of `ManagedSecretMapInput` via:
//
//	ManagedSecretMap{ "key": ManagedSecretArgs{...} }
type ManagedSecretMapInput interface {
	pulumi.Input

	ToManagedSecretMapOutput() ManagedSecretMapOutput
	ToManagedSecretMapOutputWithContext(context.Context) ManagedSecretMapOutput
}

type ManagedSecretMap map[string]ManagedSecretInput

func (ManagedSecretMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ManagedSecret)(nil)).Elem()
}

func (i ManagedSecretMap) ToManagedSecretMapOutput() ManagedSecretMapOutput {
	return i.ToManagedSecretMapOutputWithContext(context.Background())
}

func (i ManagedSecretMap) ToManagedSecretMapOutputWithContext(ctx context.Context) ManagedSecretMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ManagedSecretMapOutput)
}

type ManagedSecretOutput struct{ *pulumi.OutputState }

func (ManagedSecretOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ManagedSecret)(nil)).Elem()
}

func (o ManagedSecretOutput) ToManagedSecretOutput() ManagedSecretOutput {
	return o
}

func (o ManagedSecretOutput) ToManagedSecretOutputWithContext(ctx context.Context) ManagedSecretOutput {
	return o
}

// public part of the secret value
func (o ManagedSecretOutput) Config() pulumi.StringOutput {
	return o.ApplyT(func(v *ManagedSecret) pulumi.StringOutput { return v.Config }).(pulumi.StringOutput)
}

// Timestamp of when secret is going to be rotated
func (o ManagedSecretOutput) ExpiresAt() pulumi.StringOutput {
	return o.ApplyT(func(v *ManagedSecret) pulumi.StringOutput { return v.ExpiresAt }).(pulumi.StringOutput)
}

// Timestamp of when secret was last rotated
func (o ManagedSecretOutput) LastRotatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v *ManagedSecret) pulumi.StringOutput { return v.LastRotatedAt }).(pulumi.StringOutput)
}

// Unique human-readable name of the Managed Secret.
func (o ManagedSecretOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *ManagedSecret) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// An ID of a Secret Engine linked with the Managed Secret.
func (o ManagedSecretOutput) SecretEngineId() pulumi.StringOutput {
	return o.ApplyT(func(v *ManagedSecret) pulumi.StringOutput { return v.SecretEngineId }).(pulumi.StringOutput)
}

// Path in a secret store.
func (o ManagedSecretOutput) SecretStorePath() pulumi.StringOutput {
	return o.ApplyT(func(v *ManagedSecret) pulumi.StringOutput { return v.SecretStorePath }).(pulumi.StringOutput)
}

// Tags is a map of key, value pairs.
func (o ManagedSecretOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v *ManagedSecret) pulumi.StringMapOutput { return v.Tags }).(pulumi.StringMapOutput)
}

// Sensitive value of the secret.
func (o ManagedSecretOutput) Value() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ManagedSecret) pulumi.StringPtrOutput { return v.Value }).(pulumi.StringPtrOutput)
}

type ManagedSecretArrayOutput struct{ *pulumi.OutputState }

func (ManagedSecretArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ManagedSecret)(nil)).Elem()
}

func (o ManagedSecretArrayOutput) ToManagedSecretArrayOutput() ManagedSecretArrayOutput {
	return o
}

func (o ManagedSecretArrayOutput) ToManagedSecretArrayOutputWithContext(ctx context.Context) ManagedSecretArrayOutput {
	return o
}

func (o ManagedSecretArrayOutput) Index(i pulumi.IntInput) ManagedSecretOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ManagedSecret {
		return vs[0].([]*ManagedSecret)[vs[1].(int)]
	}).(ManagedSecretOutput)
}

type ManagedSecretMapOutput struct{ *pulumi.OutputState }

func (ManagedSecretMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ManagedSecret)(nil)).Elem()
}

func (o ManagedSecretMapOutput) ToManagedSecretMapOutput() ManagedSecretMapOutput {
	return o
}

func (o ManagedSecretMapOutput) ToManagedSecretMapOutputWithContext(ctx context.Context) ManagedSecretMapOutput {
	return o
}

func (o ManagedSecretMapOutput) MapIndex(k pulumi.StringInput) ManagedSecretOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ManagedSecret {
		return vs[0].(map[string]*ManagedSecret)[vs[1].(string)]
	}).(ManagedSecretOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ManagedSecretInput)(nil)).Elem(), &ManagedSecret{})
	pulumi.RegisterInputType(reflect.TypeOf((*ManagedSecretArrayInput)(nil)).Elem(), ManagedSecretArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ManagedSecretMapInput)(nil)).Elem(), ManagedSecretMap{})
	pulumi.RegisterOutputType(ManagedSecretOutput{})
	pulumi.RegisterOutputType(ManagedSecretArrayOutput{})
	pulumi.RegisterOutputType(ManagedSecretMapOutput{})
}
