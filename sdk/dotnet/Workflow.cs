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
    /// Workflows are the collection of rules that define the resources to which access can be requested,
    ///  the users that can request that access, and the mechanism for approving those requests which can either
    ///  but automatic approval or a set of users authorized to approve the requests.
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using System.Text.Json;
    /// using Pulumi;
    /// using Sdm = PiersKarsenbarg.Sdm;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var autoGrantWorkflow = new Sdm.Workflow("autoGrantWorkflow", new()
    ///     {
    ///         AutoGrant = true,
    ///         Enabled = true,
    ///         AccessRules = JsonSerializer.Serialize(new[]
    ///         {
    ///             new Dictionary&lt;string, object?&gt;
    ///             {
    ///                 ["type"] = "redis",
    ///                 ["tags"] = new Dictionary&lt;string, object?&gt;
    ///                 {
    ///                     ["region"] = "us-east",
    ///                 },
    ///             },
    ///         }),
    ///     });
    /// 
    ///     var manualApprovalWorkflow = new Sdm.Workflow("manualApprovalWorkflow", new()
    ///     {
    ///         AutoGrant = false,
    ///         AccessRules = JsonSerializer.Serialize(new[]
    ///         {
    ///             new Dictionary&lt;string, object?&gt;
    ///             {
    ///                 ["type"] = "redis",
    ///                 ["tags"] = new Dictionary&lt;string, object?&gt;
    ///                 {
    ///                     ["region"] = "us-east",
    ///                 },
    ///             },
    ///         }),
    ///     });
    /// 
    /// });
    /// ```
    /// This resource can be imported using the import command.
    /// 
    /// ## Import
    /// 
    /// A Workflow can be imported using the id, e.g.,
    /// 
    /// ```sh
    ///  $ pulumi import sdm:index/workflow:Workflow example aw-12345678
    /// ```
    /// </summary>
    [SdmResourceType("sdm:index/workflow:Workflow")]
    public partial class Workflow : global::Pulumi.CustomResource
    {
        /// <summary>
        /// AccessRules is a list of access rules defining the resources this Workflow provides access to.
        /// </summary>
        [Output("accessRules")]
        public Output<string> AccessRules { get; private set; } = null!;

        /// <summary>
        /// Optional auto grant setting to automatically approve requests or not, defaults to false.
        /// </summary>
        [Output("autoGrant")]
        public Output<bool?> AutoGrant { get; private set; } = null!;

        /// <summary>
        /// Optional description of the Workflow.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Optional enabled state for workflow. This setting may be overridden by the system if the workflow doesn't meet the requirements to be enabled or if other conditions prevent enabling the workflow. The requirements to enable a workflow are that the workflow must be either set up for with auto grant enabled or have one or more WorkflowApprovers created for the workflow.
        /// </summary>
        [Output("enabled")]
        public Output<bool?> Enabled { get; private set; } = null!;

        /// <summary>
        /// Unique human-readable name of the Workflow.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Optional weight for workflow to specify it's priority in matching a request.
        /// </summary>
        [Output("weight")]
        public Output<int?> Weight { get; private set; } = null!;


        /// <summary>
        /// Create a Workflow resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Workflow(string name, WorkflowArgs? args = null, CustomResourceOptions? options = null)
            : base("sdm:index/workflow:Workflow", name, args ?? new WorkflowArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Workflow(string name, Input<string> id, WorkflowState? state = null, CustomResourceOptions? options = null)
            : base("sdm:index/workflow:Workflow", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Workflow resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Workflow Get(string name, Input<string> id, WorkflowState? state = null, CustomResourceOptions? options = null)
        {
            return new Workflow(name, id, state, options);
        }
    }

    public sealed class WorkflowArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// AccessRules is a list of access rules defining the resources this Workflow provides access to.
        /// </summary>
        [Input("accessRules")]
        public Input<string>? AccessRules { get; set; }

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
        /// Unique human-readable name of the Workflow.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Optional weight for workflow to specify it's priority in matching a request.
        /// </summary>
        [Input("weight")]
        public Input<int>? Weight { get; set; }

        public WorkflowArgs()
        {
        }
        public static new WorkflowArgs Empty => new WorkflowArgs();
    }

    public sealed class WorkflowState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// AccessRules is a list of access rules defining the resources this Workflow provides access to.
        /// </summary>
        [Input("accessRules")]
        public Input<string>? AccessRules { get; set; }

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
        /// Unique human-readable name of the Workflow.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Optional weight for workflow to specify it's priority in matching a request.
        /// </summary>
        [Input("weight")]
        public Input<int>? Weight { get; set; }

        public WorkflowState()
        {
        }
        public static new WorkflowState Empty => new WorkflowState();
    }
}