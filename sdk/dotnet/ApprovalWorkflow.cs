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
    /// <summary>
    /// ApprovalWorkflows are the mechanism by which requests for access can be viewed by authorized
    ///  approvers and be approved or denied.
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Sdm = PiersKarsenbarg.Sdm;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var manualApprovalWorkflow = new Sdm.ApprovalWorkflow("manualApprovalWorkflow", new()
    ///     {
    ///         ApprovalMode = "manual",
    ///         ApprovalSteps = new[]
    ///         {
    ///             new Sdm.Inputs.ApprovalWorkflowApprovalStepArgs
    ///             {
    ///                 Approvers = new[]
    ///                 {
    ///                     new Sdm.Inputs.ApprovalWorkflowApprovalStepApproverArgs
    ///                     {
    ///                         AccountId = "a-1234abc",
    ///                     },
    ///                     new Sdm.Inputs.ApprovalWorkflowApprovalStepApproverArgs
    ///                     {
    ///                         Reference = "manager-of-requester",
    ///                     },
    ///                 },
    ///                 Quantifier = "any",
    ///                 SkipAfter = "1h0m0s",
    ///             },
    ///             new Sdm.Inputs.ApprovalWorkflowApprovalStepArgs
    ///             {
    ///                 Approvers = new[]
    ///                 {
    ///                     new Sdm.Inputs.ApprovalWorkflowApprovalStepApproverArgs
    ///                     {
    ///                         RoleId = "r-1234abc",
    ///                     },
    ///                     new Sdm.Inputs.ApprovalWorkflowApprovalStepApproverArgs
    ///                     {
    ///                         AccountId = "a-5678def",
    ///                     },
    ///                     new Sdm.Inputs.ApprovalWorkflowApprovalStepApproverArgs
    ///                     {
    ///                         Reference = "manager-of-manager-of-requester",
    ///                     },
    ///                 },
    ///                 Quantifier = "all",
    ///                 SkipAfter = "0s",
    ///             },
    ///         },
    ///     });
    /// 
    ///     var autoGrantApprovalWorkflow = new Sdm.ApprovalWorkflow("autoGrantApprovalWorkflow", new()
    ///     {
    ///         ApprovalMode = "automatic",
    ///     });
    /// 
    /// });
    /// ```
    /// This resource can be imported using the import command.
    /// 
    /// ## Import
    /// 
    /// A ApprovalWorkflow can be imported using the id, e.g.,
    /// 
    /// ```sh
    /// $ pulumi import sdm:index/approvalWorkflow:ApprovalWorkflow example af-12345678
    /// ```
    /// </summary>
    [SdmResourceType("sdm:index/approvalWorkflow:ApprovalWorkflow")]
    public partial class ApprovalWorkflow : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Approval mode of the ApprovalWorkflow
        /// </summary>
        [Output("approvalMode")]
        public Output<string> ApprovalMode { get; private set; } = null!;

        /// <summary>
        /// The approval steps of this approval workflow
        /// </summary>
        [Output("approvalSteps")]
        public Output<ImmutableArray<Outputs.ApprovalWorkflowApprovalStep>> ApprovalSteps { get; private set; } = null!;

        /// <summary>
        /// Optional description of the ApprovalWorkflow.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Unique human-readable name of the ApprovalWorkflow.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;


        /// <summary>
        /// Create a ApprovalWorkflow resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ApprovalWorkflow(string name, ApprovalWorkflowArgs args, CustomResourceOptions? options = null)
            : base("sdm:index/approvalWorkflow:ApprovalWorkflow", name, args ?? new ApprovalWorkflowArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ApprovalWorkflow(string name, Input<string> id, ApprovalWorkflowState? state = null, CustomResourceOptions? options = null)
            : base("sdm:index/approvalWorkflow:ApprovalWorkflow", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/pierskarsenbarg/pulumi-sdm",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ApprovalWorkflow resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ApprovalWorkflow Get(string name, Input<string> id, ApprovalWorkflowState? state = null, CustomResourceOptions? options = null)
        {
            return new ApprovalWorkflow(name, id, state, options);
        }
    }

    public sealed class ApprovalWorkflowArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Approval mode of the ApprovalWorkflow
        /// </summary>
        [Input("approvalMode", required: true)]
        public Input<string> ApprovalMode { get; set; } = null!;

        [Input("approvalSteps")]
        private InputList<Inputs.ApprovalWorkflowApprovalStepArgs>? _approvalSteps;

        /// <summary>
        /// The approval steps of this approval workflow
        /// </summary>
        public InputList<Inputs.ApprovalWorkflowApprovalStepArgs> ApprovalSteps
        {
            get => _approvalSteps ?? (_approvalSteps = new InputList<Inputs.ApprovalWorkflowApprovalStepArgs>());
            set => _approvalSteps = value;
        }

        /// <summary>
        /// Optional description of the ApprovalWorkflow.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Unique human-readable name of the ApprovalWorkflow.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public ApprovalWorkflowArgs()
        {
        }
        public static new ApprovalWorkflowArgs Empty => new ApprovalWorkflowArgs();
    }

    public sealed class ApprovalWorkflowState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Approval mode of the ApprovalWorkflow
        /// </summary>
        [Input("approvalMode")]
        public Input<string>? ApprovalMode { get; set; }

        [Input("approvalSteps")]
        private InputList<Inputs.ApprovalWorkflowApprovalStepGetArgs>? _approvalSteps;

        /// <summary>
        /// The approval steps of this approval workflow
        /// </summary>
        public InputList<Inputs.ApprovalWorkflowApprovalStepGetArgs> ApprovalSteps
        {
            get => _approvalSteps ?? (_approvalSteps = new InputList<Inputs.ApprovalWorkflowApprovalStepGetArgs>());
            set => _approvalSteps = value;
        }

        /// <summary>
        /// Optional description of the ApprovalWorkflow.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Unique human-readable name of the ApprovalWorkflow.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public ApprovalWorkflowState()
        {
        }
        public static new ApprovalWorkflowState Empty => new ApprovalWorkflowState();
    }
}
