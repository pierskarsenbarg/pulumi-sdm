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

    public sealed class ResourceSshGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("allowDeprecatedKeyExchanges")]
        public Input<bool>? AllowDeprecatedKeyExchanges { get; set; }

        /// <summary>
        /// Bind interface
        /// </summary>
        [Input("bindInterface")]
        public Input<string>? BindInterface { get; set; }

        /// <summary>
        /// A filter applied to the routing logic to pin datasource to nodes.
        /// </summary>
        [Input("egressFilter")]
        public Input<string>? EgressFilter { get; set; }

        [Input("hostname", required: true)]
        public Input<string> Hostname { get; set; } = null!;

        [Input("keyType")]
        public Input<string>? KeyType { get; set; }

        /// <summary>
        /// Unique human-readable name of the Resource.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("port", required: true)]
        public Input<int> Port { get; set; } = null!;

        [Input("portForwarding")]
        public Input<bool>? PortForwarding { get; set; }

        [Input("portOverride")]
        public Input<int>? PortOverride { get; set; }

        [Input("publicKey")]
        public Input<string>? PublicKey { get; set; }

        /// <summary>
        /// ID of the secret store containing credentials for this resource, if any.
        /// </summary>
        [Input("secretStoreId")]
        public Input<string>? SecretStoreId { get; set; }

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

        public ResourceSshGetArgs()
        {
        }
        public static new ResourceSshGetArgs Empty => new ResourceSshGetArgs();
    }
}
