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

// A Role has a list of access rules which determine which Resources the members
//
//	of the Role have access to. An Account can be a member of multiple Roles via
//	AccountAttachments.
func LookupRole(ctx *pulumi.Context, args *LookupRoleArgs, opts ...pulumi.InvokeOption) (*LookupRoleResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupRoleResult
	err := ctx.Invoke("sdm:index/getRole:getRole", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getRole.
type LookupRoleArgs struct {
	// Unique identifier of the Role.
	Id *string `pulumi:"id"`
	// Unique human-readable name of the Role.
	Name *string `pulumi:"name"`
	// Tags is a map of key, value pairs.
	Tags map[string]string `pulumi:"tags"`
}

// A collection of values returned by getRole.
type LookupRoleResult struct {
	// Unique identifier of the Role.
	Id *string `pulumi:"id"`
	// a list of strings of ids of data sources that match the given arguments.
	Ids []string `pulumi:"ids"`
	// Managed By is a read only field for what service manages this role, e.g. StrongDM, Okta, Azure.
	ManagedBy string `pulumi:"managedBy"`
	// Unique human-readable name of the Role.
	Name *string `pulumi:"name"`
	// A list where each element has the following attributes:
	Roles []GetRoleRole `pulumi:"roles"`
	// Tags is a map of key, value pairs.
	Tags map[string]string `pulumi:"tags"`
}

func LookupRoleOutput(ctx *pulumi.Context, args LookupRoleOutputArgs, opts ...pulumi.InvokeOption) LookupRoleResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupRoleResult, error) {
			args := v.(LookupRoleArgs)
			r, err := LookupRole(ctx, &args, opts...)
			var s LookupRoleResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupRoleResultOutput)
}

// A collection of arguments for invoking getRole.
type LookupRoleOutputArgs struct {
	// Unique identifier of the Role.
	Id pulumi.StringPtrInput `pulumi:"id"`
	// Unique human-readable name of the Role.
	Name pulumi.StringPtrInput `pulumi:"name"`
	// Tags is a map of key, value pairs.
	Tags pulumi.StringMapInput `pulumi:"tags"`
}

func (LookupRoleOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupRoleArgs)(nil)).Elem()
}

// A collection of values returned by getRole.
type LookupRoleResultOutput struct{ *pulumi.OutputState }

func (LookupRoleResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupRoleResult)(nil)).Elem()
}

func (o LookupRoleResultOutput) ToLookupRoleResultOutput() LookupRoleResultOutput {
	return o
}

func (o LookupRoleResultOutput) ToLookupRoleResultOutputWithContext(ctx context.Context) LookupRoleResultOutput {
	return o
}

func (o LookupRoleResultOutput) ToOutput(ctx context.Context) pulumix.Output[LookupRoleResult] {
	return pulumix.Output[LookupRoleResult]{
		OutputState: o.OutputState,
	}
}

// Unique identifier of the Role.
func (o LookupRoleResultOutput) Id() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupRoleResult) *string { return v.Id }).(pulumi.StringPtrOutput)
}

// a list of strings of ids of data sources that match the given arguments.
func (o LookupRoleResultOutput) Ids() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupRoleResult) []string { return v.Ids }).(pulumi.StringArrayOutput)
}

// Managed By is a read only field for what service manages this role, e.g. StrongDM, Okta, Azure.
func (o LookupRoleResultOutput) ManagedBy() pulumi.StringOutput {
	return o.ApplyT(func(v LookupRoleResult) string { return v.ManagedBy }).(pulumi.StringOutput)
}

// Unique human-readable name of the Role.
func (o LookupRoleResultOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupRoleResult) *string { return v.Name }).(pulumi.StringPtrOutput)
}

// A list where each element has the following attributes:
func (o LookupRoleResultOutput) Roles() GetRoleRoleArrayOutput {
	return o.ApplyT(func(v LookupRoleResult) []GetRoleRole { return v.Roles }).(GetRoleRoleArrayOutput)
}

// Tags is a map of key, value pairs.
func (o LookupRoleResultOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupRoleResult) map[string]string { return v.Tags }).(pulumi.StringMapOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupRoleResultOutput{})
}
