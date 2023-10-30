// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package sdm

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-sdm/sdk/go/sdm/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumix"
)

// A SecretStore is a server where resource secrets (passwords, keys) are stored.
//
//	Coming soon support for HashiCorp Vault and AWS Secret Store.
//
// This resource can be imported using the import command.
//
// ## Import
//
// A SecretStore can be imported using the id, e.g.,
//
// ```sh
//
//	$ pulumi import sdm:index/secretStore:SecretStore example se-12345678
//
// ```
type SecretStore struct {
	pulumi.CustomResourceState

	Aws            SecretStoreAwsPtrOutput            `pulumi:"aws"`
	AzureStore     SecretStoreAzureStorePtrOutput     `pulumi:"azureStore"`
	CyberarkConjur SecretStoreCyberarkConjurPtrOutput `pulumi:"cyberarkConjur"`
	CyberarkPam    SecretStoreCyberarkPamPtrOutput    `pulumi:"cyberarkPam"`
	// CyberarkPAMExperimentalStore is currently unstable, and its API may change, or it may be removed, without a major
	// version bump.
	CyberarkPamExperimental SecretStoreCyberarkPamExperimentalPtrOutput `pulumi:"cyberarkPamExperimental"`
	DelineaStore            SecretStoreDelineaStorePtrOutput            `pulumi:"delineaStore"`
	GcpStore                SecretStoreGcpStorePtrOutput                `pulumi:"gcpStore"`
	VaultApprole            SecretStoreVaultApprolePtrOutput            `pulumi:"vaultApprole"`
	VaultTls                SecretStoreVaultTlsPtrOutput                `pulumi:"vaultTls"`
	VaultToken              SecretStoreVaultTokenPtrOutput              `pulumi:"vaultToken"`
}

// NewSecretStore registers a new resource with the given unique name, arguments, and options.
func NewSecretStore(ctx *pulumi.Context,
	name string, args *SecretStoreArgs, opts ...pulumi.ResourceOption) (*SecretStore, error) {
	if args == nil {
		args = &SecretStoreArgs{}
	}

	opts = internal.PkgResourceDefaultOpts(opts)
	var resource SecretStore
	err := ctx.RegisterResource("sdm:index/secretStore:SecretStore", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSecretStore gets an existing SecretStore resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSecretStore(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SecretStoreState, opts ...pulumi.ResourceOption) (*SecretStore, error) {
	var resource SecretStore
	err := ctx.ReadResource("sdm:index/secretStore:SecretStore", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SecretStore resources.
type secretStoreState struct {
	Aws            *SecretStoreAws            `pulumi:"aws"`
	AzureStore     *SecretStoreAzureStore     `pulumi:"azureStore"`
	CyberarkConjur *SecretStoreCyberarkConjur `pulumi:"cyberarkConjur"`
	CyberarkPam    *SecretStoreCyberarkPam    `pulumi:"cyberarkPam"`
	// CyberarkPAMExperimentalStore is currently unstable, and its API may change, or it may be removed, without a major
	// version bump.
	CyberarkPamExperimental *SecretStoreCyberarkPamExperimental `pulumi:"cyberarkPamExperimental"`
	DelineaStore            *SecretStoreDelineaStore            `pulumi:"delineaStore"`
	GcpStore                *SecretStoreGcpStore                `pulumi:"gcpStore"`
	VaultApprole            *SecretStoreVaultApprole            `pulumi:"vaultApprole"`
	VaultTls                *SecretStoreVaultTls                `pulumi:"vaultTls"`
	VaultToken              *SecretStoreVaultToken              `pulumi:"vaultToken"`
}

type SecretStoreState struct {
	Aws            SecretStoreAwsPtrInput
	AzureStore     SecretStoreAzureStorePtrInput
	CyberarkConjur SecretStoreCyberarkConjurPtrInput
	CyberarkPam    SecretStoreCyberarkPamPtrInput
	// CyberarkPAMExperimentalStore is currently unstable, and its API may change, or it may be removed, without a major
	// version bump.
	CyberarkPamExperimental SecretStoreCyberarkPamExperimentalPtrInput
	DelineaStore            SecretStoreDelineaStorePtrInput
	GcpStore                SecretStoreGcpStorePtrInput
	VaultApprole            SecretStoreVaultApprolePtrInput
	VaultTls                SecretStoreVaultTlsPtrInput
	VaultToken              SecretStoreVaultTokenPtrInput
}

func (SecretStoreState) ElementType() reflect.Type {
	return reflect.TypeOf((*secretStoreState)(nil)).Elem()
}

type secretStoreArgs struct {
	Aws            *SecretStoreAws            `pulumi:"aws"`
	AzureStore     *SecretStoreAzureStore     `pulumi:"azureStore"`
	CyberarkConjur *SecretStoreCyberarkConjur `pulumi:"cyberarkConjur"`
	CyberarkPam    *SecretStoreCyberarkPam    `pulumi:"cyberarkPam"`
	// CyberarkPAMExperimentalStore is currently unstable, and its API may change, or it may be removed, without a major
	// version bump.
	CyberarkPamExperimental *SecretStoreCyberarkPamExperimental `pulumi:"cyberarkPamExperimental"`
	DelineaStore            *SecretStoreDelineaStore            `pulumi:"delineaStore"`
	GcpStore                *SecretStoreGcpStore                `pulumi:"gcpStore"`
	VaultApprole            *SecretStoreVaultApprole            `pulumi:"vaultApprole"`
	VaultTls                *SecretStoreVaultTls                `pulumi:"vaultTls"`
	VaultToken              *SecretStoreVaultToken              `pulumi:"vaultToken"`
}

// The set of arguments for constructing a SecretStore resource.
type SecretStoreArgs struct {
	Aws            SecretStoreAwsPtrInput
	AzureStore     SecretStoreAzureStorePtrInput
	CyberarkConjur SecretStoreCyberarkConjurPtrInput
	CyberarkPam    SecretStoreCyberarkPamPtrInput
	// CyberarkPAMExperimentalStore is currently unstable, and its API may change, or it may be removed, without a major
	// version bump.
	CyberarkPamExperimental SecretStoreCyberarkPamExperimentalPtrInput
	DelineaStore            SecretStoreDelineaStorePtrInput
	GcpStore                SecretStoreGcpStorePtrInput
	VaultApprole            SecretStoreVaultApprolePtrInput
	VaultTls                SecretStoreVaultTlsPtrInput
	VaultToken              SecretStoreVaultTokenPtrInput
}

func (SecretStoreArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*secretStoreArgs)(nil)).Elem()
}

type SecretStoreInput interface {
	pulumi.Input

	ToSecretStoreOutput() SecretStoreOutput
	ToSecretStoreOutputWithContext(ctx context.Context) SecretStoreOutput
}

func (*SecretStore) ElementType() reflect.Type {
	return reflect.TypeOf((**SecretStore)(nil)).Elem()
}

func (i *SecretStore) ToSecretStoreOutput() SecretStoreOutput {
	return i.ToSecretStoreOutputWithContext(context.Background())
}

func (i *SecretStore) ToSecretStoreOutputWithContext(ctx context.Context) SecretStoreOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SecretStoreOutput)
}

func (i *SecretStore) ToOutput(ctx context.Context) pulumix.Output[*SecretStore] {
	return pulumix.Output[*SecretStore]{
		OutputState: i.ToSecretStoreOutputWithContext(ctx).OutputState,
	}
}

// SecretStoreArrayInput is an input type that accepts SecretStoreArray and SecretStoreArrayOutput values.
// You can construct a concrete instance of `SecretStoreArrayInput` via:
//
//	SecretStoreArray{ SecretStoreArgs{...} }
type SecretStoreArrayInput interface {
	pulumi.Input

	ToSecretStoreArrayOutput() SecretStoreArrayOutput
	ToSecretStoreArrayOutputWithContext(context.Context) SecretStoreArrayOutput
}

type SecretStoreArray []SecretStoreInput

func (SecretStoreArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*SecretStore)(nil)).Elem()
}

func (i SecretStoreArray) ToSecretStoreArrayOutput() SecretStoreArrayOutput {
	return i.ToSecretStoreArrayOutputWithContext(context.Background())
}

func (i SecretStoreArray) ToSecretStoreArrayOutputWithContext(ctx context.Context) SecretStoreArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SecretStoreArrayOutput)
}

func (i SecretStoreArray) ToOutput(ctx context.Context) pulumix.Output[[]*SecretStore] {
	return pulumix.Output[[]*SecretStore]{
		OutputState: i.ToSecretStoreArrayOutputWithContext(ctx).OutputState,
	}
}

// SecretStoreMapInput is an input type that accepts SecretStoreMap and SecretStoreMapOutput values.
// You can construct a concrete instance of `SecretStoreMapInput` via:
//
//	SecretStoreMap{ "key": SecretStoreArgs{...} }
type SecretStoreMapInput interface {
	pulumi.Input

	ToSecretStoreMapOutput() SecretStoreMapOutput
	ToSecretStoreMapOutputWithContext(context.Context) SecretStoreMapOutput
}

type SecretStoreMap map[string]SecretStoreInput

func (SecretStoreMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*SecretStore)(nil)).Elem()
}

func (i SecretStoreMap) ToSecretStoreMapOutput() SecretStoreMapOutput {
	return i.ToSecretStoreMapOutputWithContext(context.Background())
}

func (i SecretStoreMap) ToSecretStoreMapOutputWithContext(ctx context.Context) SecretStoreMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SecretStoreMapOutput)
}

func (i SecretStoreMap) ToOutput(ctx context.Context) pulumix.Output[map[string]*SecretStore] {
	return pulumix.Output[map[string]*SecretStore]{
		OutputState: i.ToSecretStoreMapOutputWithContext(ctx).OutputState,
	}
}

type SecretStoreOutput struct{ *pulumi.OutputState }

func (SecretStoreOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**SecretStore)(nil)).Elem()
}

func (o SecretStoreOutput) ToSecretStoreOutput() SecretStoreOutput {
	return o
}

func (o SecretStoreOutput) ToSecretStoreOutputWithContext(ctx context.Context) SecretStoreOutput {
	return o
}

func (o SecretStoreOutput) ToOutput(ctx context.Context) pulumix.Output[*SecretStore] {
	return pulumix.Output[*SecretStore]{
		OutputState: o.OutputState,
	}
}

func (o SecretStoreOutput) Aws() SecretStoreAwsPtrOutput {
	return o.ApplyT(func(v *SecretStore) SecretStoreAwsPtrOutput { return v.Aws }).(SecretStoreAwsPtrOutput)
}

func (o SecretStoreOutput) AzureStore() SecretStoreAzureStorePtrOutput {
	return o.ApplyT(func(v *SecretStore) SecretStoreAzureStorePtrOutput { return v.AzureStore }).(SecretStoreAzureStorePtrOutput)
}

func (o SecretStoreOutput) CyberarkConjur() SecretStoreCyberarkConjurPtrOutput {
	return o.ApplyT(func(v *SecretStore) SecretStoreCyberarkConjurPtrOutput { return v.CyberarkConjur }).(SecretStoreCyberarkConjurPtrOutput)
}

func (o SecretStoreOutput) CyberarkPam() SecretStoreCyberarkPamPtrOutput {
	return o.ApplyT(func(v *SecretStore) SecretStoreCyberarkPamPtrOutput { return v.CyberarkPam }).(SecretStoreCyberarkPamPtrOutput)
}

// CyberarkPAMExperimentalStore is currently unstable, and its API may change, or it may be removed, without a major
// version bump.
func (o SecretStoreOutput) CyberarkPamExperimental() SecretStoreCyberarkPamExperimentalPtrOutput {
	return o.ApplyT(func(v *SecretStore) SecretStoreCyberarkPamExperimentalPtrOutput { return v.CyberarkPamExperimental }).(SecretStoreCyberarkPamExperimentalPtrOutput)
}

func (o SecretStoreOutput) DelineaStore() SecretStoreDelineaStorePtrOutput {
	return o.ApplyT(func(v *SecretStore) SecretStoreDelineaStorePtrOutput { return v.DelineaStore }).(SecretStoreDelineaStorePtrOutput)
}

func (o SecretStoreOutput) GcpStore() SecretStoreGcpStorePtrOutput {
	return o.ApplyT(func(v *SecretStore) SecretStoreGcpStorePtrOutput { return v.GcpStore }).(SecretStoreGcpStorePtrOutput)
}

func (o SecretStoreOutput) VaultApprole() SecretStoreVaultApprolePtrOutput {
	return o.ApplyT(func(v *SecretStore) SecretStoreVaultApprolePtrOutput { return v.VaultApprole }).(SecretStoreVaultApprolePtrOutput)
}

func (o SecretStoreOutput) VaultTls() SecretStoreVaultTlsPtrOutput {
	return o.ApplyT(func(v *SecretStore) SecretStoreVaultTlsPtrOutput { return v.VaultTls }).(SecretStoreVaultTlsPtrOutput)
}

func (o SecretStoreOutput) VaultToken() SecretStoreVaultTokenPtrOutput {
	return o.ApplyT(func(v *SecretStore) SecretStoreVaultTokenPtrOutput { return v.VaultToken }).(SecretStoreVaultTokenPtrOutput)
}

type SecretStoreArrayOutput struct{ *pulumi.OutputState }

func (SecretStoreArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*SecretStore)(nil)).Elem()
}

func (o SecretStoreArrayOutput) ToSecretStoreArrayOutput() SecretStoreArrayOutput {
	return o
}

func (o SecretStoreArrayOutput) ToSecretStoreArrayOutputWithContext(ctx context.Context) SecretStoreArrayOutput {
	return o
}

func (o SecretStoreArrayOutput) ToOutput(ctx context.Context) pulumix.Output[[]*SecretStore] {
	return pulumix.Output[[]*SecretStore]{
		OutputState: o.OutputState,
	}
}

func (o SecretStoreArrayOutput) Index(i pulumi.IntInput) SecretStoreOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *SecretStore {
		return vs[0].([]*SecretStore)[vs[1].(int)]
	}).(SecretStoreOutput)
}

type SecretStoreMapOutput struct{ *pulumi.OutputState }

func (SecretStoreMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*SecretStore)(nil)).Elem()
}

func (o SecretStoreMapOutput) ToSecretStoreMapOutput() SecretStoreMapOutput {
	return o
}

func (o SecretStoreMapOutput) ToSecretStoreMapOutputWithContext(ctx context.Context) SecretStoreMapOutput {
	return o
}

func (o SecretStoreMapOutput) ToOutput(ctx context.Context) pulumix.Output[map[string]*SecretStore] {
	return pulumix.Output[map[string]*SecretStore]{
		OutputState: o.OutputState,
	}
}

func (o SecretStoreMapOutput) MapIndex(k pulumi.StringInput) SecretStoreOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *SecretStore {
		return vs[0].(map[string]*SecretStore)[vs[1].(string)]
	}).(SecretStoreOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*SecretStoreInput)(nil)).Elem(), &SecretStore{})
	pulumi.RegisterInputType(reflect.TypeOf((*SecretStoreArrayInput)(nil)).Elem(), SecretStoreArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*SecretStoreMapInput)(nil)).Elem(), SecretStoreMap{})
	pulumi.RegisterOutputType(SecretStoreOutput{})
	pulumi.RegisterOutputType(SecretStoreArrayOutput{})
	pulumi.RegisterOutputType(SecretStoreMapOutput{})
}
