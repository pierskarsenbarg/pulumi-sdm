// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Sdm.Inputs
{

    public sealed class ResourceCitusGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Bind interface
        /// </summary>
        [Input("bindInterface")]
        public Input<string>? BindInterface { get; set; }

        [Input("database", required: true)]
        public Input<string> Database { get; set; } = null!;

        /// <summary>
        /// A filter applied to the routing logic to pin datasource to nodes.
        /// </summary>
        [Input("egressFilter")]
        public Input<string>? EgressFilter { get; set; }

        [Input("hostname", required: true)]
        public Input<string> Hostname { get; set; } = null!;

        /// <summary>
        /// Unique human-readable name of the Resource.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("overrideDatabase")]
        public Input<bool>? OverrideDatabase { get; set; }

        [Input("password")]
        public Input<string>? Password { get; set; }

        [Input("port")]
        public Input<int>? Port { get; set; }

        [Input("portOverride")]
        public Input<int>? PortOverride { get; set; }

        /// <summary>
        /// ID of the secret store containing credentials for this resource, if any.
        /// </summary>
        [Input("secretStoreId")]
        public Input<string>? SecretStoreId { get; set; }

        [Input("secretStorePasswordKey")]
        public Input<string>? SecretStorePasswordKey { get; set; }

        [Input("secretStorePasswordPath")]
        public Input<string>? SecretStorePasswordPath { get; set; }

        [Input("secretStoreUsernameKey")]
        public Input<string>? SecretStoreUsernameKey { get; set; }

        [Input("secretStoreUsernamePath")]
        public Input<string>? SecretStoreUsernamePath { get; set; }

        /// <summary>
        /// Subdomain is the local DNS address.  (e.g. app-prod1 turns into app-prod1.your-org-name.sdm.network)
        /// </summary>
        [Input("subdomain")]
        public Input<string>? Subdomain { get; set; }

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

        [Input("username")]
        public Input<string>? Username { get; set; }

        public ResourceCitusGetArgs()
        {
        }
        public static new ResourceCitusGetArgs Empty => new ResourceCitusGetArgs();
    }
}
