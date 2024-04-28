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

// ApprovalWorkflows are the mechanism by which requests for access can be viewed by authorized
//
//	approvers and be approved or denied.
//
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
//			_, err := sdm.NewApprovalWorkflow(ctx, "manualApprovalWorkflow", &sdm.ApprovalWorkflowArgs{
//				ApprovalMode: pulumi.String("manual"),
//			})
//			if err != nil {
//				return err
//			}
//			_, err = sdm.NewApprovalWorkflow(ctx, "autoGrantApprovalWorkflow", &sdm.ApprovalWorkflowArgs{
//				ApprovalMode: pulumi.String("automatic"),
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
// This resource can be imported using the import command.
//
// ## Import
//
// A ApprovalWorkflow can be imported using the id, e.g.,
//
// ```sh
// $ pulumi import sdm:index/approvalWorkflow:ApprovalWorkflow example af-12345678
// ```
type ApprovalWorkflow struct {
	pulumi.CustomResourceState

	// Approval mode of the ApprovalWorkflow
	ApprovalMode pulumi.StringOutput `pulumi:"approvalMode"`
	// Optional description of the ApprovalWorkflow.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Unique human-readable name of the ApprovalWorkflow.
	Name pulumi.StringOutput `pulumi:"name"`
}

// NewApprovalWorkflow registers a new resource with the given unique name, arguments, and options.
func NewApprovalWorkflow(ctx *pulumi.Context,
	name string, args *ApprovalWorkflowArgs, opts ...pulumi.ResourceOption) (*ApprovalWorkflow, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ApprovalMode == nil {
		return nil, errors.New("invalid value for required argument 'ApprovalMode'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource ApprovalWorkflow
	err := ctx.RegisterResource("sdm:index/approvalWorkflow:ApprovalWorkflow", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetApprovalWorkflow gets an existing ApprovalWorkflow resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetApprovalWorkflow(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ApprovalWorkflowState, opts ...pulumi.ResourceOption) (*ApprovalWorkflow, error) {
	var resource ApprovalWorkflow
	err := ctx.ReadResource("sdm:index/approvalWorkflow:ApprovalWorkflow", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ApprovalWorkflow resources.
type approvalWorkflowState struct {
	// Approval mode of the ApprovalWorkflow
	ApprovalMode *string `pulumi:"approvalMode"`
	// Optional description of the ApprovalWorkflow.
	Description *string `pulumi:"description"`
	// Unique human-readable name of the ApprovalWorkflow.
	Name *string `pulumi:"name"`
}

type ApprovalWorkflowState struct {
	// Approval mode of the ApprovalWorkflow
	ApprovalMode pulumi.StringPtrInput
	// Optional description of the ApprovalWorkflow.
	Description pulumi.StringPtrInput
	// Unique human-readable name of the ApprovalWorkflow.
	Name pulumi.StringPtrInput
}

func (ApprovalWorkflowState) ElementType() reflect.Type {
	return reflect.TypeOf((*approvalWorkflowState)(nil)).Elem()
}

type approvalWorkflowArgs struct {
	// Approval mode of the ApprovalWorkflow
	ApprovalMode string `pulumi:"approvalMode"`
	// Optional description of the ApprovalWorkflow.
	Description *string `pulumi:"description"`
	// Unique human-readable name of the ApprovalWorkflow.
	Name *string `pulumi:"name"`
}

// The set of arguments for constructing a ApprovalWorkflow resource.
type ApprovalWorkflowArgs struct {
	// Approval mode of the ApprovalWorkflow
	ApprovalMode pulumi.StringInput
	// Optional description of the ApprovalWorkflow.
	Description pulumi.StringPtrInput
	// Unique human-readable name of the ApprovalWorkflow.
	Name pulumi.StringPtrInput
}

func (ApprovalWorkflowArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*approvalWorkflowArgs)(nil)).Elem()
}

type ApprovalWorkflowInput interface {
	pulumi.Input

	ToApprovalWorkflowOutput() ApprovalWorkflowOutput
	ToApprovalWorkflowOutputWithContext(ctx context.Context) ApprovalWorkflowOutput
}

func (*ApprovalWorkflow) ElementType() reflect.Type {
	return reflect.TypeOf((**ApprovalWorkflow)(nil)).Elem()
}

func (i *ApprovalWorkflow) ToApprovalWorkflowOutput() ApprovalWorkflowOutput {
	return i.ToApprovalWorkflowOutputWithContext(context.Background())
}

func (i *ApprovalWorkflow) ToApprovalWorkflowOutputWithContext(ctx context.Context) ApprovalWorkflowOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ApprovalWorkflowOutput)
}

// ApprovalWorkflowArrayInput is an input type that accepts ApprovalWorkflowArray and ApprovalWorkflowArrayOutput values.
// You can construct a concrete instance of `ApprovalWorkflowArrayInput` via:
//
//	ApprovalWorkflowArray{ ApprovalWorkflowArgs{...} }
type ApprovalWorkflowArrayInput interface {
	pulumi.Input

	ToApprovalWorkflowArrayOutput() ApprovalWorkflowArrayOutput
	ToApprovalWorkflowArrayOutputWithContext(context.Context) ApprovalWorkflowArrayOutput
}

type ApprovalWorkflowArray []ApprovalWorkflowInput

func (ApprovalWorkflowArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ApprovalWorkflow)(nil)).Elem()
}

func (i ApprovalWorkflowArray) ToApprovalWorkflowArrayOutput() ApprovalWorkflowArrayOutput {
	return i.ToApprovalWorkflowArrayOutputWithContext(context.Background())
}

func (i ApprovalWorkflowArray) ToApprovalWorkflowArrayOutputWithContext(ctx context.Context) ApprovalWorkflowArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ApprovalWorkflowArrayOutput)
}

// ApprovalWorkflowMapInput is an input type that accepts ApprovalWorkflowMap and ApprovalWorkflowMapOutput values.
// You can construct a concrete instance of `ApprovalWorkflowMapInput` via:
//
//	ApprovalWorkflowMap{ "key": ApprovalWorkflowArgs{...} }
type ApprovalWorkflowMapInput interface {
	pulumi.Input

	ToApprovalWorkflowMapOutput() ApprovalWorkflowMapOutput
	ToApprovalWorkflowMapOutputWithContext(context.Context) ApprovalWorkflowMapOutput
}

type ApprovalWorkflowMap map[string]ApprovalWorkflowInput

func (ApprovalWorkflowMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ApprovalWorkflow)(nil)).Elem()
}

func (i ApprovalWorkflowMap) ToApprovalWorkflowMapOutput() ApprovalWorkflowMapOutput {
	return i.ToApprovalWorkflowMapOutputWithContext(context.Background())
}

func (i ApprovalWorkflowMap) ToApprovalWorkflowMapOutputWithContext(ctx context.Context) ApprovalWorkflowMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ApprovalWorkflowMapOutput)
}

type ApprovalWorkflowOutput struct{ *pulumi.OutputState }

func (ApprovalWorkflowOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ApprovalWorkflow)(nil)).Elem()
}

func (o ApprovalWorkflowOutput) ToApprovalWorkflowOutput() ApprovalWorkflowOutput {
	return o
}

func (o ApprovalWorkflowOutput) ToApprovalWorkflowOutputWithContext(ctx context.Context) ApprovalWorkflowOutput {
	return o
}

// Approval mode of the ApprovalWorkflow
func (o ApprovalWorkflowOutput) ApprovalMode() pulumi.StringOutput {
	return o.ApplyT(func(v *ApprovalWorkflow) pulumi.StringOutput { return v.ApprovalMode }).(pulumi.StringOutput)
}

// Optional description of the ApprovalWorkflow.
func (o ApprovalWorkflowOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ApprovalWorkflow) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// Unique human-readable name of the ApprovalWorkflow.
func (o ApprovalWorkflowOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *ApprovalWorkflow) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

type ApprovalWorkflowArrayOutput struct{ *pulumi.OutputState }

func (ApprovalWorkflowArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ApprovalWorkflow)(nil)).Elem()
}

func (o ApprovalWorkflowArrayOutput) ToApprovalWorkflowArrayOutput() ApprovalWorkflowArrayOutput {
	return o
}

func (o ApprovalWorkflowArrayOutput) ToApprovalWorkflowArrayOutputWithContext(ctx context.Context) ApprovalWorkflowArrayOutput {
	return o
}

func (o ApprovalWorkflowArrayOutput) Index(i pulumi.IntInput) ApprovalWorkflowOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ApprovalWorkflow {
		return vs[0].([]*ApprovalWorkflow)[vs[1].(int)]
	}).(ApprovalWorkflowOutput)
}

type ApprovalWorkflowMapOutput struct{ *pulumi.OutputState }

func (ApprovalWorkflowMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ApprovalWorkflow)(nil)).Elem()
}

func (o ApprovalWorkflowMapOutput) ToApprovalWorkflowMapOutput() ApprovalWorkflowMapOutput {
	return o
}

func (o ApprovalWorkflowMapOutput) ToApprovalWorkflowMapOutputWithContext(ctx context.Context) ApprovalWorkflowMapOutput {
	return o
}

func (o ApprovalWorkflowMapOutput) MapIndex(k pulumi.StringInput) ApprovalWorkflowOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ApprovalWorkflow {
		return vs[0].(map[string]*ApprovalWorkflow)[vs[1].(string)]
	}).(ApprovalWorkflowOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ApprovalWorkflowInput)(nil)).Elem(), &ApprovalWorkflow{})
	pulumi.RegisterInputType(reflect.TypeOf((*ApprovalWorkflowArrayInput)(nil)).Elem(), ApprovalWorkflowArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ApprovalWorkflowMapInput)(nil)).Elem(), ApprovalWorkflowMap{})
	pulumi.RegisterOutputType(ApprovalWorkflowOutput{})
	pulumi.RegisterOutputType(ApprovalWorkflowArrayOutput{})
	pulumi.RegisterOutputType(ApprovalWorkflowMapOutput{})
}
