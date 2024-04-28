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

// WorkflowApprover is an account or a role with the ability to approve requests bound to a workflow.
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
//			_, err := sdm.NewWorkflowApprover(ctx, "workflowApproverAccountExample", &sdm.WorkflowApproverArgs{
//				AccountId:  pulumi.String("a-234605"),
//				WorkflowId: pulumi.String("aw-6799234"),
//			})
//			if err != nil {
//				return err
//			}
//			_, err = sdm.NewWorkflowApprover(ctx, "workflowApproverRoleExample", &sdm.WorkflowApproverArgs{
//				RoleId:     pulumi.String("r-542982"),
//				WorkflowId: pulumi.String("aw-1935694"),
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
// A WorkflowApprover can be imported using the id, e.g.,
//
// ```sh
// $ pulumi import sdm:index/workflowApprover:WorkflowApprover example nt-12345678
// ```
type WorkflowApprover struct {
	pulumi.CustomResourceState

	// The approver account id.
	AccountId pulumi.StringPtrOutput `pulumi:"accountId"`
	// The approver role id
	RoleId pulumi.StringPtrOutput `pulumi:"roleId"`
	// The workflow id.
	WorkflowId pulumi.StringOutput `pulumi:"workflowId"`
}

// NewWorkflowApprover registers a new resource with the given unique name, arguments, and options.
func NewWorkflowApprover(ctx *pulumi.Context,
	name string, args *WorkflowApproverArgs, opts ...pulumi.ResourceOption) (*WorkflowApprover, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.WorkflowId == nil {
		return nil, errors.New("invalid value for required argument 'WorkflowId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource WorkflowApprover
	err := ctx.RegisterResource("sdm:index/workflowApprover:WorkflowApprover", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWorkflowApprover gets an existing WorkflowApprover resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWorkflowApprover(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WorkflowApproverState, opts ...pulumi.ResourceOption) (*WorkflowApprover, error) {
	var resource WorkflowApprover
	err := ctx.ReadResource("sdm:index/workflowApprover:WorkflowApprover", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WorkflowApprover resources.
type workflowApproverState struct {
	// The approver account id.
	AccountId *string `pulumi:"accountId"`
	// The approver role id
	RoleId *string `pulumi:"roleId"`
	// The workflow id.
	WorkflowId *string `pulumi:"workflowId"`
}

type WorkflowApproverState struct {
	// The approver account id.
	AccountId pulumi.StringPtrInput
	// The approver role id
	RoleId pulumi.StringPtrInput
	// The workflow id.
	WorkflowId pulumi.StringPtrInput
}

func (WorkflowApproverState) ElementType() reflect.Type {
	return reflect.TypeOf((*workflowApproverState)(nil)).Elem()
}

type workflowApproverArgs struct {
	// The approver account id.
	AccountId *string `pulumi:"accountId"`
	// The approver role id
	RoleId *string `pulumi:"roleId"`
	// The workflow id.
	WorkflowId string `pulumi:"workflowId"`
}

// The set of arguments for constructing a WorkflowApprover resource.
type WorkflowApproverArgs struct {
	// The approver account id.
	AccountId pulumi.StringPtrInput
	// The approver role id
	RoleId pulumi.StringPtrInput
	// The workflow id.
	WorkflowId pulumi.StringInput
}

func (WorkflowApproverArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*workflowApproverArgs)(nil)).Elem()
}

type WorkflowApproverInput interface {
	pulumi.Input

	ToWorkflowApproverOutput() WorkflowApproverOutput
	ToWorkflowApproverOutputWithContext(ctx context.Context) WorkflowApproverOutput
}

func (*WorkflowApprover) ElementType() reflect.Type {
	return reflect.TypeOf((**WorkflowApprover)(nil)).Elem()
}

func (i *WorkflowApprover) ToWorkflowApproverOutput() WorkflowApproverOutput {
	return i.ToWorkflowApproverOutputWithContext(context.Background())
}

func (i *WorkflowApprover) ToWorkflowApproverOutputWithContext(ctx context.Context) WorkflowApproverOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WorkflowApproverOutput)
}

// WorkflowApproverArrayInput is an input type that accepts WorkflowApproverArray and WorkflowApproverArrayOutput values.
// You can construct a concrete instance of `WorkflowApproverArrayInput` via:
//
//	WorkflowApproverArray{ WorkflowApproverArgs{...} }
type WorkflowApproverArrayInput interface {
	pulumi.Input

	ToWorkflowApproverArrayOutput() WorkflowApproverArrayOutput
	ToWorkflowApproverArrayOutputWithContext(context.Context) WorkflowApproverArrayOutput
}

type WorkflowApproverArray []WorkflowApproverInput

func (WorkflowApproverArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*WorkflowApprover)(nil)).Elem()
}

func (i WorkflowApproverArray) ToWorkflowApproverArrayOutput() WorkflowApproverArrayOutput {
	return i.ToWorkflowApproverArrayOutputWithContext(context.Background())
}

func (i WorkflowApproverArray) ToWorkflowApproverArrayOutputWithContext(ctx context.Context) WorkflowApproverArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WorkflowApproverArrayOutput)
}

// WorkflowApproverMapInput is an input type that accepts WorkflowApproverMap and WorkflowApproverMapOutput values.
// You can construct a concrete instance of `WorkflowApproverMapInput` via:
//
//	WorkflowApproverMap{ "key": WorkflowApproverArgs{...} }
type WorkflowApproverMapInput interface {
	pulumi.Input

	ToWorkflowApproverMapOutput() WorkflowApproverMapOutput
	ToWorkflowApproverMapOutputWithContext(context.Context) WorkflowApproverMapOutput
}

type WorkflowApproverMap map[string]WorkflowApproverInput

func (WorkflowApproverMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*WorkflowApprover)(nil)).Elem()
}

func (i WorkflowApproverMap) ToWorkflowApproverMapOutput() WorkflowApproverMapOutput {
	return i.ToWorkflowApproverMapOutputWithContext(context.Background())
}

func (i WorkflowApproverMap) ToWorkflowApproverMapOutputWithContext(ctx context.Context) WorkflowApproverMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WorkflowApproverMapOutput)
}

type WorkflowApproverOutput struct{ *pulumi.OutputState }

func (WorkflowApproverOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**WorkflowApprover)(nil)).Elem()
}

func (o WorkflowApproverOutput) ToWorkflowApproverOutput() WorkflowApproverOutput {
	return o
}

func (o WorkflowApproverOutput) ToWorkflowApproverOutputWithContext(ctx context.Context) WorkflowApproverOutput {
	return o
}

// The approver account id.
func (o WorkflowApproverOutput) AccountId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *WorkflowApprover) pulumi.StringPtrOutput { return v.AccountId }).(pulumi.StringPtrOutput)
}

// The approver role id
func (o WorkflowApproverOutput) RoleId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *WorkflowApprover) pulumi.StringPtrOutput { return v.RoleId }).(pulumi.StringPtrOutput)
}

// The workflow id.
func (o WorkflowApproverOutput) WorkflowId() pulumi.StringOutput {
	return o.ApplyT(func(v *WorkflowApprover) pulumi.StringOutput { return v.WorkflowId }).(pulumi.StringOutput)
}

type WorkflowApproverArrayOutput struct{ *pulumi.OutputState }

func (WorkflowApproverArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*WorkflowApprover)(nil)).Elem()
}

func (o WorkflowApproverArrayOutput) ToWorkflowApproverArrayOutput() WorkflowApproverArrayOutput {
	return o
}

func (o WorkflowApproverArrayOutput) ToWorkflowApproverArrayOutputWithContext(ctx context.Context) WorkflowApproverArrayOutput {
	return o
}

func (o WorkflowApproverArrayOutput) Index(i pulumi.IntInput) WorkflowApproverOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *WorkflowApprover {
		return vs[0].([]*WorkflowApprover)[vs[1].(int)]
	}).(WorkflowApproverOutput)
}

type WorkflowApproverMapOutput struct{ *pulumi.OutputState }

func (WorkflowApproverMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*WorkflowApprover)(nil)).Elem()
}

func (o WorkflowApproverMapOutput) ToWorkflowApproverMapOutput() WorkflowApproverMapOutput {
	return o
}

func (o WorkflowApproverMapOutput) ToWorkflowApproverMapOutputWithContext(ctx context.Context) WorkflowApproverMapOutput {
	return o
}

func (o WorkflowApproverMapOutput) MapIndex(k pulumi.StringInput) WorkflowApproverOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *WorkflowApprover {
		return vs[0].(map[string]*WorkflowApprover)[vs[1].(string)]
	}).(WorkflowApproverOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*WorkflowApproverInput)(nil)).Elem(), &WorkflowApprover{})
	pulumi.RegisterInputType(reflect.TypeOf((*WorkflowApproverArrayInput)(nil)).Elem(), WorkflowApproverArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*WorkflowApproverMapInput)(nil)).Elem(), WorkflowApproverMap{})
	pulumi.RegisterOutputType(WorkflowApproverOutput{})
	pulumi.RegisterOutputType(WorkflowApproverArrayOutput{})
	pulumi.RegisterOutputType(WorkflowApproverMapOutput{})
}
