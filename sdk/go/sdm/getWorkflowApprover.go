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

// WorkflowApprover is an account with the ability to approve requests bound to a workflow.
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
//			_, err := sdm.LookupWorkflowApprover(ctx, &sdm.LookupWorkflowApproverArgs{
//				ApproverId: pulumi.StringRef("a-2496542"),
//				WorkflowId: pulumi.StringRef("aw-541894"),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func LookupWorkflowApprover(ctx *pulumi.Context, args *LookupWorkflowApproverArgs, opts ...pulumi.InvokeOption) (*LookupWorkflowApproverResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupWorkflowApproverResult
	err := ctx.Invoke("sdm:index/getWorkflowApprover:getWorkflowApprover", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getWorkflowApprover.
type LookupWorkflowApproverArgs struct {
	// The approver id.
	ApproverId *string `pulumi:"approverId"`
	// Unique identifier of the WorkflowApprover.
	Id *string `pulumi:"id"`
	// The workflow id.
	WorkflowId *string `pulumi:"workflowId"`
}

// A collection of values returned by getWorkflowApprover.
type LookupWorkflowApproverResult struct {
	// The approver id.
	ApproverId *string `pulumi:"approverId"`
	// Unique identifier of the WorkflowApprover.
	Id *string `pulumi:"id"`
	// a list of strings of ids of data sources that match the given arguments.
	Ids []string `pulumi:"ids"`
	// A list where each element has the following attributes:
	WorkflowApprovers []GetWorkflowApproverWorkflowApprover `pulumi:"workflowApprovers"`
	// The workflow id.
	WorkflowId *string `pulumi:"workflowId"`
}

func LookupWorkflowApproverOutput(ctx *pulumi.Context, args LookupWorkflowApproverOutputArgs, opts ...pulumi.InvokeOption) LookupWorkflowApproverResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupWorkflowApproverResult, error) {
			args := v.(LookupWorkflowApproverArgs)
			r, err := LookupWorkflowApprover(ctx, &args, opts...)
			var s LookupWorkflowApproverResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupWorkflowApproverResultOutput)
}

// A collection of arguments for invoking getWorkflowApprover.
type LookupWorkflowApproverOutputArgs struct {
	// The approver id.
	ApproverId pulumi.StringPtrInput `pulumi:"approverId"`
	// Unique identifier of the WorkflowApprover.
	Id pulumi.StringPtrInput `pulumi:"id"`
	// The workflow id.
	WorkflowId pulumi.StringPtrInput `pulumi:"workflowId"`
}

func (LookupWorkflowApproverOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupWorkflowApproverArgs)(nil)).Elem()
}

// A collection of values returned by getWorkflowApprover.
type LookupWorkflowApproverResultOutput struct{ *pulumi.OutputState }

func (LookupWorkflowApproverResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupWorkflowApproverResult)(nil)).Elem()
}

func (o LookupWorkflowApproverResultOutput) ToLookupWorkflowApproverResultOutput() LookupWorkflowApproverResultOutput {
	return o
}

func (o LookupWorkflowApproverResultOutput) ToLookupWorkflowApproverResultOutputWithContext(ctx context.Context) LookupWorkflowApproverResultOutput {
	return o
}

func (o LookupWorkflowApproverResultOutput) ToOutput(ctx context.Context) pulumix.Output[LookupWorkflowApproverResult] {
	return pulumix.Output[LookupWorkflowApproverResult]{
		OutputState: o.OutputState,
	}
}

// The approver id.
func (o LookupWorkflowApproverResultOutput) ApproverId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupWorkflowApproverResult) *string { return v.ApproverId }).(pulumi.StringPtrOutput)
}

// Unique identifier of the WorkflowApprover.
func (o LookupWorkflowApproverResultOutput) Id() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupWorkflowApproverResult) *string { return v.Id }).(pulumi.StringPtrOutput)
}

// a list of strings of ids of data sources that match the given arguments.
func (o LookupWorkflowApproverResultOutput) Ids() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupWorkflowApproverResult) []string { return v.Ids }).(pulumi.StringArrayOutput)
}

// A list where each element has the following attributes:
func (o LookupWorkflowApproverResultOutput) WorkflowApprovers() GetWorkflowApproverWorkflowApproverArrayOutput {
	return o.ApplyT(func(v LookupWorkflowApproverResult) []GetWorkflowApproverWorkflowApprover { return v.WorkflowApprovers }).(GetWorkflowApproverWorkflowApproverArrayOutput)
}

// The workflow id.
func (o LookupWorkflowApproverResultOutput) WorkflowId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupWorkflowApproverResult) *string { return v.WorkflowId }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupWorkflowApproverResultOutput{})
}
