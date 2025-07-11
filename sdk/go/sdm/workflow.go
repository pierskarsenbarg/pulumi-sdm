// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package sdm

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-sdm/sdk/go/sdm/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Workflows are the collection of rules that define the resources to which access can be requested,
//
//	the users that can request that access, and the mechanism for approving those requests which can either
//	but automatic approval or a set of users authorized to approve the requests.
//
// ## Import
//
// A Workflow can be imported using the id, e.g.,
//
// ```sh
// $ pulumi import sdm:index/workflow:Workflow example aw-12345678
// ```
type Workflow struct {
	pulumi.CustomResourceState

	// Fixed Duration of access requests bound to this workflow. If fixed duration is provided, max duration must be empty. If neither max nor fixed duration are provided, requests that bind to this workflow will use the organization-level settings.
	AccessRequestFixedDuration pulumi.StringPtrOutput `pulumi:"accessRequestFixedDuration"`
	// Maximum Duration of access requests bound to this workflow. If max duration is provided, fixed duration must be empty. If neither max nor fixed duration are provided, requests that bind to this workflow will use the organization-level settings.
	AccessRequestMaxDuration pulumi.StringPtrOutput `pulumi:"accessRequestMaxDuration"`
	// AccessRules is a list of access rules defining the resources this Workflow provides access to.
	AccessRules pulumi.StringOutput `pulumi:"accessRules"`
	// Optional approval flow ID identifies an approval flow that linked to the workflow
	ApprovalFlowId pulumi.StringPtrOutput `pulumi:"approvalFlowId"`
	// Optional auto grant setting to automatically approve requests or not, defaults to false.
	//
	// Deprecated: auto_grant is deprecated, see docs for more info
	AutoGrant pulumi.BoolPtrOutput `pulumi:"autoGrant"`
	// Optional description of the Workflow.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Optional enabled state for workflow. This setting may be overridden by the system if the workflow doesn't meet the requirements to be enabled or if other conditions prevent enabling the workflow. The requirements to enable a workflow are that the workflow must be either set up for with auto grant enabled or have one or more WorkflowApprovers created for the workflow.
	Enabled pulumi.BoolPtrOutput `pulumi:"enabled"`
	// Unique human-readable name of the Workflow.
	Name pulumi.StringOutput `pulumi:"name"`
	// Optional weight for workflow to specify it's priority in matching a request.
	Weight pulumi.IntOutput `pulumi:"weight"`
}

// NewWorkflow registers a new resource with the given unique name, arguments, and options.
func NewWorkflow(ctx *pulumi.Context,
	name string, args *WorkflowArgs, opts ...pulumi.ResourceOption) (*Workflow, error) {
	if args == nil {
		args = &WorkflowArgs{}
	}

	opts = internal.PkgResourceDefaultOpts(opts)
	var resource Workflow
	err := ctx.RegisterResource("sdm:index/workflow:Workflow", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWorkflow gets an existing Workflow resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWorkflow(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WorkflowState, opts ...pulumi.ResourceOption) (*Workflow, error) {
	var resource Workflow
	err := ctx.ReadResource("sdm:index/workflow:Workflow", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Workflow resources.
type workflowState struct {
	// Fixed Duration of access requests bound to this workflow. If fixed duration is provided, max duration must be empty. If neither max nor fixed duration are provided, requests that bind to this workflow will use the organization-level settings.
	AccessRequestFixedDuration *string `pulumi:"accessRequestFixedDuration"`
	// Maximum Duration of access requests bound to this workflow. If max duration is provided, fixed duration must be empty. If neither max nor fixed duration are provided, requests that bind to this workflow will use the organization-level settings.
	AccessRequestMaxDuration *string `pulumi:"accessRequestMaxDuration"`
	// AccessRules is a list of access rules defining the resources this Workflow provides access to.
	AccessRules *string `pulumi:"accessRules"`
	// Optional approval flow ID identifies an approval flow that linked to the workflow
	ApprovalFlowId *string `pulumi:"approvalFlowId"`
	// Optional auto grant setting to automatically approve requests or not, defaults to false.
	//
	// Deprecated: auto_grant is deprecated, see docs for more info
	AutoGrant *bool `pulumi:"autoGrant"`
	// Optional description of the Workflow.
	Description *string `pulumi:"description"`
	// Optional enabled state for workflow. This setting may be overridden by the system if the workflow doesn't meet the requirements to be enabled or if other conditions prevent enabling the workflow. The requirements to enable a workflow are that the workflow must be either set up for with auto grant enabled or have one or more WorkflowApprovers created for the workflow.
	Enabled *bool `pulumi:"enabled"`
	// Unique human-readable name of the Workflow.
	Name *string `pulumi:"name"`
	// Optional weight for workflow to specify it's priority in matching a request.
	Weight *int `pulumi:"weight"`
}

type WorkflowState struct {
	// Fixed Duration of access requests bound to this workflow. If fixed duration is provided, max duration must be empty. If neither max nor fixed duration are provided, requests that bind to this workflow will use the organization-level settings.
	AccessRequestFixedDuration pulumi.StringPtrInput
	// Maximum Duration of access requests bound to this workflow. If max duration is provided, fixed duration must be empty. If neither max nor fixed duration are provided, requests that bind to this workflow will use the organization-level settings.
	AccessRequestMaxDuration pulumi.StringPtrInput
	// AccessRules is a list of access rules defining the resources this Workflow provides access to.
	AccessRules pulumi.StringPtrInput
	// Optional approval flow ID identifies an approval flow that linked to the workflow
	ApprovalFlowId pulumi.StringPtrInput
	// Optional auto grant setting to automatically approve requests or not, defaults to false.
	//
	// Deprecated: auto_grant is deprecated, see docs for more info
	AutoGrant pulumi.BoolPtrInput
	// Optional description of the Workflow.
	Description pulumi.StringPtrInput
	// Optional enabled state for workflow. This setting may be overridden by the system if the workflow doesn't meet the requirements to be enabled or if other conditions prevent enabling the workflow. The requirements to enable a workflow are that the workflow must be either set up for with auto grant enabled or have one or more WorkflowApprovers created for the workflow.
	Enabled pulumi.BoolPtrInput
	// Unique human-readable name of the Workflow.
	Name pulumi.StringPtrInput
	// Optional weight for workflow to specify it's priority in matching a request.
	Weight pulumi.IntPtrInput
}

func (WorkflowState) ElementType() reflect.Type {
	return reflect.TypeOf((*workflowState)(nil)).Elem()
}

type workflowArgs struct {
	// Fixed Duration of access requests bound to this workflow. If fixed duration is provided, max duration must be empty. If neither max nor fixed duration are provided, requests that bind to this workflow will use the organization-level settings.
	AccessRequestFixedDuration *string `pulumi:"accessRequestFixedDuration"`
	// Maximum Duration of access requests bound to this workflow. If max duration is provided, fixed duration must be empty. If neither max nor fixed duration are provided, requests that bind to this workflow will use the organization-level settings.
	AccessRequestMaxDuration *string `pulumi:"accessRequestMaxDuration"`
	// AccessRules is a list of access rules defining the resources this Workflow provides access to.
	AccessRules *string `pulumi:"accessRules"`
	// Optional approval flow ID identifies an approval flow that linked to the workflow
	ApprovalFlowId *string `pulumi:"approvalFlowId"`
	// Optional auto grant setting to automatically approve requests or not, defaults to false.
	//
	// Deprecated: auto_grant is deprecated, see docs for more info
	AutoGrant *bool `pulumi:"autoGrant"`
	// Optional description of the Workflow.
	Description *string `pulumi:"description"`
	// Optional enabled state for workflow. This setting may be overridden by the system if the workflow doesn't meet the requirements to be enabled or if other conditions prevent enabling the workflow. The requirements to enable a workflow are that the workflow must be either set up for with auto grant enabled or have one or more WorkflowApprovers created for the workflow.
	Enabled *bool `pulumi:"enabled"`
	// Unique human-readable name of the Workflow.
	Name *string `pulumi:"name"`
	// Optional weight for workflow to specify it's priority in matching a request.
	Weight *int `pulumi:"weight"`
}

// The set of arguments for constructing a Workflow resource.
type WorkflowArgs struct {
	// Fixed Duration of access requests bound to this workflow. If fixed duration is provided, max duration must be empty. If neither max nor fixed duration are provided, requests that bind to this workflow will use the organization-level settings.
	AccessRequestFixedDuration pulumi.StringPtrInput
	// Maximum Duration of access requests bound to this workflow. If max duration is provided, fixed duration must be empty. If neither max nor fixed duration are provided, requests that bind to this workflow will use the organization-level settings.
	AccessRequestMaxDuration pulumi.StringPtrInput
	// AccessRules is a list of access rules defining the resources this Workflow provides access to.
	AccessRules pulumi.StringPtrInput
	// Optional approval flow ID identifies an approval flow that linked to the workflow
	ApprovalFlowId pulumi.StringPtrInput
	// Optional auto grant setting to automatically approve requests or not, defaults to false.
	//
	// Deprecated: auto_grant is deprecated, see docs for more info
	AutoGrant pulumi.BoolPtrInput
	// Optional description of the Workflow.
	Description pulumi.StringPtrInput
	// Optional enabled state for workflow. This setting may be overridden by the system if the workflow doesn't meet the requirements to be enabled or if other conditions prevent enabling the workflow. The requirements to enable a workflow are that the workflow must be either set up for with auto grant enabled or have one or more WorkflowApprovers created for the workflow.
	Enabled pulumi.BoolPtrInput
	// Unique human-readable name of the Workflow.
	Name pulumi.StringPtrInput
	// Optional weight for workflow to specify it's priority in matching a request.
	Weight pulumi.IntPtrInput
}

func (WorkflowArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*workflowArgs)(nil)).Elem()
}

type WorkflowInput interface {
	pulumi.Input

	ToWorkflowOutput() WorkflowOutput
	ToWorkflowOutputWithContext(ctx context.Context) WorkflowOutput
}

func (*Workflow) ElementType() reflect.Type {
	return reflect.TypeOf((**Workflow)(nil)).Elem()
}

func (i *Workflow) ToWorkflowOutput() WorkflowOutput {
	return i.ToWorkflowOutputWithContext(context.Background())
}

func (i *Workflow) ToWorkflowOutputWithContext(ctx context.Context) WorkflowOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WorkflowOutput)
}

// WorkflowArrayInput is an input type that accepts WorkflowArray and WorkflowArrayOutput values.
// You can construct a concrete instance of `WorkflowArrayInput` via:
//
//	WorkflowArray{ WorkflowArgs{...} }
type WorkflowArrayInput interface {
	pulumi.Input

	ToWorkflowArrayOutput() WorkflowArrayOutput
	ToWorkflowArrayOutputWithContext(context.Context) WorkflowArrayOutput
}

type WorkflowArray []WorkflowInput

func (WorkflowArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Workflow)(nil)).Elem()
}

func (i WorkflowArray) ToWorkflowArrayOutput() WorkflowArrayOutput {
	return i.ToWorkflowArrayOutputWithContext(context.Background())
}

func (i WorkflowArray) ToWorkflowArrayOutputWithContext(ctx context.Context) WorkflowArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WorkflowArrayOutput)
}

// WorkflowMapInput is an input type that accepts WorkflowMap and WorkflowMapOutput values.
// You can construct a concrete instance of `WorkflowMapInput` via:
//
//	WorkflowMap{ "key": WorkflowArgs{...} }
type WorkflowMapInput interface {
	pulumi.Input

	ToWorkflowMapOutput() WorkflowMapOutput
	ToWorkflowMapOutputWithContext(context.Context) WorkflowMapOutput
}

type WorkflowMap map[string]WorkflowInput

func (WorkflowMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Workflow)(nil)).Elem()
}

func (i WorkflowMap) ToWorkflowMapOutput() WorkflowMapOutput {
	return i.ToWorkflowMapOutputWithContext(context.Background())
}

func (i WorkflowMap) ToWorkflowMapOutputWithContext(ctx context.Context) WorkflowMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WorkflowMapOutput)
}

type WorkflowOutput struct{ *pulumi.OutputState }

func (WorkflowOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Workflow)(nil)).Elem()
}

func (o WorkflowOutput) ToWorkflowOutput() WorkflowOutput {
	return o
}

func (o WorkflowOutput) ToWorkflowOutputWithContext(ctx context.Context) WorkflowOutput {
	return o
}

// Fixed Duration of access requests bound to this workflow. If fixed duration is provided, max duration must be empty. If neither max nor fixed duration are provided, requests that bind to this workflow will use the organization-level settings.
func (o WorkflowOutput) AccessRequestFixedDuration() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Workflow) pulumi.StringPtrOutput { return v.AccessRequestFixedDuration }).(pulumi.StringPtrOutput)
}

// Maximum Duration of access requests bound to this workflow. If max duration is provided, fixed duration must be empty. If neither max nor fixed duration are provided, requests that bind to this workflow will use the organization-level settings.
func (o WorkflowOutput) AccessRequestMaxDuration() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Workflow) pulumi.StringPtrOutput { return v.AccessRequestMaxDuration }).(pulumi.StringPtrOutput)
}

// AccessRules is a list of access rules defining the resources this Workflow provides access to.
func (o WorkflowOutput) AccessRules() pulumi.StringOutput {
	return o.ApplyT(func(v *Workflow) pulumi.StringOutput { return v.AccessRules }).(pulumi.StringOutput)
}

// Optional approval flow ID identifies an approval flow that linked to the workflow
func (o WorkflowOutput) ApprovalFlowId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Workflow) pulumi.StringPtrOutput { return v.ApprovalFlowId }).(pulumi.StringPtrOutput)
}

// Optional auto grant setting to automatically approve requests or not, defaults to false.
//
// Deprecated: auto_grant is deprecated, see docs for more info
func (o WorkflowOutput) AutoGrant() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *Workflow) pulumi.BoolPtrOutput { return v.AutoGrant }).(pulumi.BoolPtrOutput)
}

// Optional description of the Workflow.
func (o WorkflowOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Workflow) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// Optional enabled state for workflow. This setting may be overridden by the system if the workflow doesn't meet the requirements to be enabled or if other conditions prevent enabling the workflow. The requirements to enable a workflow are that the workflow must be either set up for with auto grant enabled or have one or more WorkflowApprovers created for the workflow.
func (o WorkflowOutput) Enabled() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *Workflow) pulumi.BoolPtrOutput { return v.Enabled }).(pulumi.BoolPtrOutput)
}

// Unique human-readable name of the Workflow.
func (o WorkflowOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *Workflow) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Optional weight for workflow to specify it's priority in matching a request.
func (o WorkflowOutput) Weight() pulumi.IntOutput {
	return o.ApplyT(func(v *Workflow) pulumi.IntOutput { return v.Weight }).(pulumi.IntOutput)
}

type WorkflowArrayOutput struct{ *pulumi.OutputState }

func (WorkflowArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Workflow)(nil)).Elem()
}

func (o WorkflowArrayOutput) ToWorkflowArrayOutput() WorkflowArrayOutput {
	return o
}

func (o WorkflowArrayOutput) ToWorkflowArrayOutputWithContext(ctx context.Context) WorkflowArrayOutput {
	return o
}

func (o WorkflowArrayOutput) Index(i pulumi.IntInput) WorkflowOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Workflow {
		return vs[0].([]*Workflow)[vs[1].(int)]
	}).(WorkflowOutput)
}

type WorkflowMapOutput struct{ *pulumi.OutputState }

func (WorkflowMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Workflow)(nil)).Elem()
}

func (o WorkflowMapOutput) ToWorkflowMapOutput() WorkflowMapOutput {
	return o
}

func (o WorkflowMapOutput) ToWorkflowMapOutputWithContext(ctx context.Context) WorkflowMapOutput {
	return o
}

func (o WorkflowMapOutput) MapIndex(k pulumi.StringInput) WorkflowOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Workflow {
		return vs[0].(map[string]*Workflow)[vs[1].(string)]
	}).(WorkflowOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*WorkflowInput)(nil)).Elem(), &Workflow{})
	pulumi.RegisterInputType(reflect.TypeOf((*WorkflowArrayInput)(nil)).Elem(), WorkflowArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*WorkflowMapInput)(nil)).Elem(), WorkflowMap{})
	pulumi.RegisterOutputType(WorkflowOutput{})
	pulumi.RegisterOutputType(WorkflowArrayOutput{})
	pulumi.RegisterOutputType(WorkflowMapOutput{})
}
