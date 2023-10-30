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

    public sealed class ResourceRdsPostgresIamArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The bind interface is the IP address to which the port override of a resource is bound (for example, 127.0.0.1). It is automatically generated if not provided.
        /// </summary>
        [Input("bindInterface")]
        public Input<string>? BindInterface { get; set; }

        /// <summary>
        /// The initial database to connect to. This setting does not by itself prevent switching to another database after connecting.
        /// </summary>
        [Input("database", required: true)]
        public Input<string> Database { get; set; } = null!;

        /// <summary>
        /// A filter applied to the routing logic to pin datasource to nodes.
        /// </summary>
        [Input("egressFilter")]
        public Input<string>? EgressFilter { get; set; }

        /// <summary>
        /// The host to dial to initiate a connection from the egress node to this resource.
        /// </summary>
        [Input("hostname", required: true)]
        public Input<string> Hostname { get; set; } = null!;

        /// <summary>
        /// Unique human-readable name of the Resource.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// If set, the database configured cannot be changed by users. This setting is not recommended for most use cases, as some clients will insist their database has changed when it has not, leading to user confusion.
        /// </summary>
        [Input("overrideDatabase")]
        public Input<bool>? OverrideDatabase { get; set; }

        /// <summary>
        /// The port to dial to initiate a connection from the egress node to this resource.
        /// </summary>
        [Input("port")]
        public Input<int>? Port { get; set; }

        /// <summary>
        /// The local port used by clients to connect to this resource.
        /// </summary>
        [Input("portOverride")]
        public Input<int>? PortOverride { get; set; }

        /// <summary>
        /// The AWS region to connect to.
        /// </summary>
        [Input("region", required: true)]
        public Input<string> Region { get; set; } = null!;

        /// <summary>
        /// If provided, the gateway/relay will try to assume this role instead of the underlying compute's role.
        /// </summary>
        [Input("roleAssumptionArn")]
        public Input<string>? RoleAssumptionArn { get; set; }

        /// <summary>
        /// ID of the secret store containing credentials for this resource, if any.
        /// </summary>
        [Input("secretStoreId")]
        public Input<string>? SecretStoreId { get; set; }

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

        /// <summary>
        /// The username to authenticate with.
        /// </summary>
        [Input("username")]
        public Input<string>? Username { get; set; }

        public ResourceRdsPostgresIamArgs()
        {
        }
        public static new ResourceRdsPostgresIamArgs Empty => new ResourceRdsPostgresIamArgs();
    }
}
