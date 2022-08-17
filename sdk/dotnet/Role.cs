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
    /// ## Import
    /// 
    /// Role can be imported using the id, e.g.,
    /// 
    /// ```sh
    ///  $ pulumi import sdm:index/role:Role example r-12345678
    /// ```
    /// </summary>
    [SdmResourceType("sdm:index/role:Role")]
    public partial class Role : global::Pulumi.CustomResource
    {
        /// <summary>
        /// AccessRules is a list of access rules defining the resources this Role has access to.
        /// </summary>
        [Output("accessRules")]
        public Output<string> AccessRules { get; private set; } = null!;

        /// <summary>
        /// Unique human-readable name of the Role.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Tags is a map of key, value pairs.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a Role resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Role(string name, RoleArgs? args = null, CustomResourceOptions? options = null)
            : base("sdm:index/role:Role", name, args ?? new RoleArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Role(string name, Input<string> id, RoleState? state = null, CustomResourceOptions? options = null)
            : base("sdm:index/role:Role", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/pierskarsenbarg/pulumi-sdm/releases/download/${VERSION}",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Role resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Role Get(string name, Input<string> id, RoleState? state = null, CustomResourceOptions? options = null)
        {
            return new Role(name, id, state, options);
        }
    }

    public sealed class RoleArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// AccessRules is a list of access rules defining the resources this Role has access to.
        /// </summary>
        [Input("accessRules")]
        public Input<string>? AccessRules { get; set; }

        /// <summary>
        /// Unique human-readable name of the Role.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Tags is a map of key, value pairs.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public RoleArgs()
        {
        }
        public static new RoleArgs Empty => new RoleArgs();
    }

    public sealed class RoleState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// AccessRules is a list of access rules defining the resources this Role has access to.
        /// </summary>
        [Input("accessRules")]
        public Input<string>? AccessRules { get; set; }

        /// <summary>
        /// Unique human-readable name of the Role.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Tags is a map of key, value pairs.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public RoleState()
        {
        }
        public static new RoleState Empty => new RoleState();
    }
}
