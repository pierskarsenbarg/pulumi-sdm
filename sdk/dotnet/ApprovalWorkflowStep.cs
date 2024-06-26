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
    /// <summary>
    /// ApprovalWorkflowStep links an approval workflow step to an ApprovalWorkflow
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
    ///     var approvalWorkflowStepExample = new Sdm.ApprovalWorkflowStep("approvalWorkflowStepExample", new()
    ///     {
    ///         ApprovalFlowId = "af-343865",
    ///     });
    /// 
    /// });
    /// ```
    /// This resource can be imported using the import command.
    /// 
    /// ## Import
    /// 
    /// A ApprovalWorkflowStep can be imported using the id, e.g.,
    /// 
    /// ```sh
    /// $ pulumi import sdm:index/approvalWorkflowStep:ApprovalWorkflowStep example afs-12345678
    /// ```
    /// </summary>
    [SdmResourceType("sdm:index/approvalWorkflowStep:ApprovalWorkflowStep")]
    public partial class ApprovalWorkflowStep : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The approval flow id specified the approval workfflow that this step belongs to
        /// </summary>
        [Output("approvalFlowId")]
        public Output<string> ApprovalFlowId { get; private set; } = null!;


        /// <summary>
        /// Create a ApprovalWorkflowStep resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ApprovalWorkflowStep(string name, ApprovalWorkflowStepArgs args, CustomResourceOptions? options = null)
            : base("sdm:index/approvalWorkflowStep:ApprovalWorkflowStep", name, args ?? new ApprovalWorkflowStepArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ApprovalWorkflowStep(string name, Input<string> id, ApprovalWorkflowStepState? state = null, CustomResourceOptions? options = null)
            : base("sdm:index/approvalWorkflowStep:ApprovalWorkflowStep", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ApprovalWorkflowStep resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ApprovalWorkflowStep Get(string name, Input<string> id, ApprovalWorkflowStepState? state = null, CustomResourceOptions? options = null)
        {
            return new ApprovalWorkflowStep(name, id, state, options);
        }
    }

    public sealed class ApprovalWorkflowStepArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The approval flow id specified the approval workfflow that this step belongs to
        /// </summary>
        [Input("approvalFlowId", required: true)]
        public Input<string> ApprovalFlowId { get; set; } = null!;

        public ApprovalWorkflowStepArgs()
        {
        }
        public static new ApprovalWorkflowStepArgs Empty => new ApprovalWorkflowStepArgs();
    }

    public sealed class ApprovalWorkflowStepState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The approval flow id specified the approval workfflow that this step belongs to
        /// </summary>
        [Input("approvalFlowId")]
        public Input<string>? ApprovalFlowId { get; set; }

        public ApprovalWorkflowStepState()
        {
        }
        public static new ApprovalWorkflowStepState Empty => new ApprovalWorkflowStepState();
    }
}
