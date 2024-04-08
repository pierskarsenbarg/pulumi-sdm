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
    public static class GetWorkflow
    {
        /// <summary>
        /// Workflows are the collection of rules that define the resources to which access can be requested,
        ///  the users that can request that access, and the mechanism for approving those requests which can either
        ///  but automatic approval or a set of users authorized to approve the requests.
        /// ## Example Usage
        /// 
        /// &lt;!--Start PulumiCodeChooser --&gt;
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Sdm = Pulumi.Sdm;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var workflowQuery = Sdm.GetWorkflow.Invoke(new()
        ///     {
        ///         AutoGrant = true,
        ///         Name = "workflow example",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetWorkflowResult> InvokeAsync(GetWorkflowArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetWorkflowResult>("sdm:index/getWorkflow:getWorkflow", args ?? new GetWorkflowArgs(), options.WithDefaults());

        /// <summary>
        /// Workflows are the collection of rules that define the resources to which access can be requested,
        ///  the users that can request that access, and the mechanism for approving those requests which can either
        ///  but automatic approval or a set of users authorized to approve the requests.
        /// ## Example Usage
        /// 
        /// &lt;!--Start PulumiCodeChooser --&gt;
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Sdm = Pulumi.Sdm;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var workflowQuery = Sdm.GetWorkflow.Invoke(new()
        ///     {
        ///         AutoGrant = true,
        ///         Name = "workflow example",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetWorkflowResult> Invoke(GetWorkflowInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetWorkflowResult>("sdm:index/getWorkflow:getWorkflow", args ?? new GetWorkflowInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetWorkflowArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Optional approval flow ID identifies an approval flow that linked to the workflow
        /// </summary>
        [Input("approvalFlowId")]
        public string? ApprovalFlowId { get; set; }

        /// <summary>
        /// Optional auto grant setting to automatically approve requests or not, defaults to false.
        /// </summary>
        [Input("autoGrant")]
        public bool? AutoGrant { get; set; }

        /// <summary>
        /// Optional description of the Workflow.
        /// </summary>
        [Input("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Optional enabled state for workflow. This setting may be overridden by the system if the workflow doesn't meet the requirements to be enabled or if other conditions prevent enabling the workflow. The requirements to enable a workflow are that the workflow must be either set up for with auto grant enabled or have one or more WorkflowApprovers created for the workflow.
        /// </summary>
        [Input("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Unique identifier of the Workflow.
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Unique human-readable name of the Workflow.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Optional weight for workflow to specify it's priority in matching a request.
        /// </summary>
        [Input("weight")]
        public int? Weight { get; set; }

        public GetWorkflowArgs()
        {
        }
        public static new GetWorkflowArgs Empty => new GetWorkflowArgs();
    }

    public sealed class GetWorkflowInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Optional approval flow ID identifies an approval flow that linked to the workflow
        /// </summary>
        [Input("approvalFlowId")]
        public Input<string>? ApprovalFlowId { get; set; }

        /// <summary>
        /// Optional auto grant setting to automatically approve requests or not, defaults to false.
        /// </summary>
        [Input("autoGrant")]
        public Input<bool>? AutoGrant { get; set; }

        /// <summary>
        /// Optional description of the Workflow.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Optional enabled state for workflow. This setting may be overridden by the system if the workflow doesn't meet the requirements to be enabled or if other conditions prevent enabling the workflow. The requirements to enable a workflow are that the workflow must be either set up for with auto grant enabled or have one or more WorkflowApprovers created for the workflow.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// Unique identifier of the Workflow.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Unique human-readable name of the Workflow.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Optional weight for workflow to specify it's priority in matching a request.
        /// </summary>
        [Input("weight")]
        public Input<int>? Weight { get; set; }

        public GetWorkflowInvokeArgs()
        {
        }
        public static new GetWorkflowInvokeArgs Empty => new GetWorkflowInvokeArgs();
    }


    [OutputType]
    public sealed class GetWorkflowResult
    {
        /// <summary>
        /// Optional approval flow ID identifies an approval flow that linked to the workflow
        /// </summary>
        public readonly string? ApprovalFlowId;
        /// <summary>
        /// Optional auto grant setting to automatically approve requests or not, defaults to false.
        /// </summary>
        public readonly bool? AutoGrant;
        /// <summary>
        /// Optional description of the Workflow.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Optional enabled state for workflow. This setting may be overridden by the system if the workflow doesn't meet the requirements to be enabled or if other conditions prevent enabling the workflow. The requirements to enable a workflow are that the workflow must be either set up for with auto grant enabled or have one or more WorkflowApprovers created for the workflow.
        /// </summary>
        public readonly bool? Enabled;
        /// <summary>
        /// Unique identifier of the Workflow.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// a list of strings of ids of data sources that match the given arguments.
        /// </summary>
        public readonly ImmutableArray<string> Ids;
        /// <summary>
        /// Unique human-readable name of the Workflow.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Optional weight for workflow to specify it's priority in matching a request.
        /// </summary>
        public readonly int? Weight;
        /// <summary>
        /// A list where each element has the following attributes:
        /// </summary>
        public readonly ImmutableArray<Outputs.GetWorkflowWorkflowResult> Workflows;

        [OutputConstructor]
        private GetWorkflowResult(
            string? approvalFlowId,

            bool? autoGrant,

            string? description,

            bool? enabled,

            string? id,

            ImmutableArray<string> ids,

            string? name,

            int? weight,

            ImmutableArray<Outputs.GetWorkflowWorkflowResult> workflows)
        {
            ApprovalFlowId = approvalFlowId;
            AutoGrant = autoGrant;
            Description = description;
            Enabled = enabled;
            Id = id;
            Ids = ids;
            Name = name;
            Weight = weight;
            Workflows = workflows;
        }
    }
}
