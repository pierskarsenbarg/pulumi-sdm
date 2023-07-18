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

    public sealed class ResourceAwsConsoleGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The bind interface is the IP address to which the port override of a resource is bound (for example, 127.0.0.1). It is automatically generated if not provided.
        /// </summary>
        [Input("bindInterface")]
        public Input<string>? BindInterface { get; set; }

        /// <summary>
        /// A filter applied to the routing logic to pin datasource to nodes.
        /// </summary>
        [Input("egressFilter")]
        public Input<string>? EgressFilter { get; set; }

        /// <summary>
        /// If true, prefer environment variables to authenticate connection even if EC2 roles are configured.
        /// </summary>
        [Input("enableEnvVariables")]
        public Input<bool>? EnableEnvVariables { get; set; }

        /// <summary>
        /// Unique human-readable name of the Resource.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

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
        /// The ID of the remote identity group to use for remote identity connections.
        /// </summary>
        [Input("remoteIdentityGroupId")]
        public Input<string>? RemoteIdentityGroupId { get; set; }

        /// <summary>
        /// The username to use for healthchecks, when clients otherwise connect with their own remote identity username.
        /// </summary>
        [Input("remoteIdentityHealthcheckUsername")]
        public Input<string>? RemoteIdentityHealthcheckUsername { get; set; }

        /// <summary>
        /// The role to assume after logging in.
        /// </summary>
        [Input("roleArn")]
        public Input<string>? RoleArn { get; set; }

        /// <summary>
        /// The external ID to associate with assume role requests. Does nothing if a role ARN is not provided.
        /// </summary>
        [Input("roleExternalId")]
        public Input<string>? RoleExternalId { get; set; }

        /// <summary>
        /// ID of the secret store containing credentials for this resource, if any.
        /// </summary>
        [Input("secretStoreId")]
        public Input<string>? SecretStoreId { get; set; }

        /// <summary>
        /// The length of time in seconds AWS console sessions will live before needing to reauthenticate.
        /// </summary>
        [Input("sessionExpiry")]
        public Input<int>? SessionExpiry { get; set; }

        /// <summary>
        /// Subdomain is the local DNS address.  (e.g. app-prod1 turns into app-prod1.your-org-name.sdm.network)
        /// </summary>
        [Input("subdomain", required: true)]
        public Input<string> Subdomain { get; set; } = null!;

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

        public ResourceAwsConsoleGetArgs()
        {
        }
        public static new ResourceAwsConsoleGetArgs Empty => new ResourceAwsConsoleGetArgs();
    }
}
