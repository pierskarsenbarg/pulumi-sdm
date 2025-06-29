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
    /// PeeringGroupResource represents the attachment between a PeeringGroup and a Resource.
    /// This resource can be imported using the import command.
    /// 
    /// ## Import
    /// 
    /// A PeeringGroupResource can be imported using the id, e.g.,
    /// 
    /// ```sh
    /// $ pulumi import sdm:index/peeringGroupResource:PeeringGroupResource example gr-12345678
    /// ```
    /// </summary>
    [SdmResourceType("sdm:index/peeringGroupResource:PeeringGroupResource")]
    public partial class PeeringGroupResource : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Peering Group ID to which the resource will be attached to.
        /// </summary>
        [Output("groupId")]
        public Output<string> GroupId { get; private set; } = null!;

        /// <summary>
        /// Resource ID to be attached.
        /// </summary>
        [Output("resourceId")]
        public Output<string> ResourceId { get; private set; } = null!;


        /// <summary>
        /// Create a PeeringGroupResource resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public PeeringGroupResource(string name, PeeringGroupResourceArgs? args = null, CustomResourceOptions? options = null)
            : base("sdm:index/peeringGroupResource:PeeringGroupResource", name, args ?? new PeeringGroupResourceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private PeeringGroupResource(string name, Input<string> id, PeeringGroupResourceState? state = null, CustomResourceOptions? options = null)
            : base("sdm:index/peeringGroupResource:PeeringGroupResource", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing PeeringGroupResource resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static PeeringGroupResource Get(string name, Input<string> id, PeeringGroupResourceState? state = null, CustomResourceOptions? options = null)
        {
            return new PeeringGroupResource(name, id, state, options);
        }
    }

    public sealed class PeeringGroupResourceArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Peering Group ID to which the resource will be attached to.
        /// </summary>
        [Input("groupId")]
        public Input<string>? GroupId { get; set; }

        /// <summary>
        /// Resource ID to be attached.
        /// </summary>
        [Input("resourceId")]
        public Input<string>? ResourceId { get; set; }

        public PeeringGroupResourceArgs()
        {
        }
        public static new PeeringGroupResourceArgs Empty => new PeeringGroupResourceArgs();
    }

    public sealed class PeeringGroupResourceState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Peering Group ID to which the resource will be attached to.
        /// </summary>
        [Input("groupId")]
        public Input<string>? GroupId { get; set; }

        /// <summary>
        /// Resource ID to be attached.
        /// </summary>
        [Input("resourceId")]
        public Input<string>? ResourceId { get; set; }

        public PeeringGroupResourceState()
        {
        }
        public static new PeeringGroupResourceState Empty => new PeeringGroupResourceState();
    }
}
