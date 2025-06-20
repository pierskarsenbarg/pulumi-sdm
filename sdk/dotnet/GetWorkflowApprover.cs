// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Sdm
{
    public static class GetWorkflowApprover
    {
        /// <summary>
        /// WorkflowApprover is an account or a role with the ability to approve requests bound to a workflow.
        /// This data source is deprecated.
        /// </summary>
        public static Task<GetWorkflowApproverResult> InvokeAsync(GetWorkflowApproverArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetWorkflowApproverResult>("sdm:index/getWorkflowApprover:getWorkflowApprover", args ?? new GetWorkflowApproverArgs(), options.WithDefaults());

        /// <summary>
        /// WorkflowApprover is an account or a role with the ability to approve requests bound to a workflow.
        /// This data source is deprecated.
        /// </summary>
        public static Output<GetWorkflowApproverResult> Invoke(GetWorkflowApproverInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetWorkflowApproverResult>("sdm:index/getWorkflowApprover:getWorkflowApprover", args ?? new GetWorkflowApproverInvokeArgs(), options.WithDefaults());

        /// <summary>
        /// WorkflowApprover is an account or a role with the ability to approve requests bound to a workflow.
        /// This data source is deprecated.
        /// </summary>
        public static Output<GetWorkflowApproverResult> Invoke(GetWorkflowApproverInvokeArgs args, InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetWorkflowApproverResult>("sdm:index/getWorkflowApprover:getWorkflowApprover", args ?? new GetWorkflowApproverInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetWorkflowApproverArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The approver account id.
        /// </summary>
        [Input("accountId")]
        public string? AccountId { get; set; }

        /// <summary>
        /// Unique identifier of the WorkflowApprover.
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The approver role id
        /// </summary>
        [Input("roleId")]
        public string? RoleId { get; set; }

        /// <summary>
        /// The workflow id.
        /// </summary>
        [Input("workflowId")]
        public string? WorkflowId { get; set; }

        public GetWorkflowApproverArgs()
        {
        }
        public static new GetWorkflowApproverArgs Empty => new GetWorkflowApproverArgs();
    }

    public sealed class GetWorkflowApproverInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The approver account id.
        /// </summary>
        [Input("accountId")]
        public Input<string>? AccountId { get; set; }

        /// <summary>
        /// Unique identifier of the WorkflowApprover.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// The approver role id
        /// </summary>
        [Input("roleId")]
        public Input<string>? RoleId { get; set; }

        /// <summary>
        /// The workflow id.
        /// </summary>
        [Input("workflowId")]
        public Input<string>? WorkflowId { get; set; }

        public GetWorkflowApproverInvokeArgs()
        {
        }
        public static new GetWorkflowApproverInvokeArgs Empty => new GetWorkflowApproverInvokeArgs();
    }


    [OutputType]
    public sealed class GetWorkflowApproverResult
    {
        /// <summary>
        /// The approver account id.
        /// </summary>
        public readonly string? AccountId;
        /// <summary>
        /// Unique identifier of the WorkflowApprover.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// a list of strings of ids of data sources that match the given arguments.
        /// </summary>
        public readonly ImmutableArray<string> Ids;
        /// <summary>
        /// The approver role id
        /// </summary>
        public readonly string? RoleId;
        /// <summary>
        /// A list where each element has the following attributes:
        /// </summary>
        public readonly ImmutableArray<Outputs.GetWorkflowApproverWorkflowApproverResult> WorkflowApprovers;
        /// <summary>
        /// The workflow id.
        /// </summary>
        public readonly string? WorkflowId;

        [OutputConstructor]
        private GetWorkflowApproverResult(
            string? accountId,

            string? id,

            ImmutableArray<string> ids,

            string? roleId,

            ImmutableArray<Outputs.GetWorkflowApproverWorkflowApproverResult> workflowApprovers,

            string? workflowId)
        {
            AccountId = accountId;
            Id = id;
            Ids = ids;
            RoleId = roleId;
            WorkflowApprovers = workflowApprovers;
            WorkflowId = workflowId;
        }
    }
}
