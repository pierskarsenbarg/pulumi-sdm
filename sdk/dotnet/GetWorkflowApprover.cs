// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
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
        /// WorkflowApprover is an account with the ability to approve requests bound to a workflow.
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Sdm = Pulumi.Sdm;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var workflowApproverQuery = Sdm.GetWorkflowApprover.Invoke(new()
        ///     {
        ///         ApproverId = "a-2496542",
        ///         WorkflowId = "aw-541894",
        ///     });
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetWorkflowApproverResult> InvokeAsync(GetWorkflowApproverArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetWorkflowApproverResult>("sdm:index/getWorkflowApprover:getWorkflowApprover", args ?? new GetWorkflowApproverArgs(), options.WithDefaults());

        /// <summary>
        /// WorkflowApprover is an account with the ability to approve requests bound to a workflow.
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Sdm = Pulumi.Sdm;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var workflowApproverQuery = Sdm.GetWorkflowApprover.Invoke(new()
        ///     {
        ///         ApproverId = "a-2496542",
        ///         WorkflowId = "aw-541894",
        ///     });
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetWorkflowApproverResult> Invoke(GetWorkflowApproverInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetWorkflowApproverResult>("sdm:index/getWorkflowApprover:getWorkflowApprover", args ?? new GetWorkflowApproverInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetWorkflowApproverArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The approver id.
        /// </summary>
        [Input("approverId")]
        public string? ApproverId { get; set; }

        /// <summary>
        /// Unique identifier of the WorkflowApprover.
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

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
        /// The approver id.
        /// </summary>
        [Input("approverId")]
        public Input<string>? ApproverId { get; set; }

        /// <summary>
        /// Unique identifier of the WorkflowApprover.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

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
        /// The approver id.
        /// </summary>
        public readonly string? ApproverId;
        /// <summary>
        /// Unique identifier of the WorkflowApprover.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// a list of strings of ids of data sources that match the given arguments.
        /// </summary>
        public readonly ImmutableArray<string> Ids;
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
            string? approverId,

            string? id,

            ImmutableArray<string> ids,

            ImmutableArray<Outputs.GetWorkflowApproverWorkflowApproverResult> workflowApprovers,

            string? workflowId)
        {
            ApproverId = approverId;
            Id = id;
            Ids = ids;
            WorkflowApprovers = workflowApprovers;
            WorkflowId = workflowId;
        }
    }
}
