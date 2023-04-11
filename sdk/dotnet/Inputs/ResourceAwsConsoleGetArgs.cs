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
        /// Bind interface
        /// </summary>
        [Input("bindInterface")]
        public Input<string>? BindInterface { get; set; }

        /// <summary>
        /// A filter applied to the routing logic to pin datasource to nodes.
        /// </summary>
        [Input("egressFilter")]
        public Input<string>? EgressFilter { get; set; }

        [Input("enableEnvVariables")]
        public Input<bool>? EnableEnvVariables { get; set; }

        /// <summary>
        /// Unique human-readable name of the Resource.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("portOverride")]
        public Input<int>? PortOverride { get; set; }

        [Input("region", required: true)]
        public Input<string> Region { get; set; } = null!;

        [Input("remoteIdentityGroupId")]
        public Input<string>? RemoteIdentityGroupId { get; set; }

        [Input("remoteIdentityHealthcheckUsername")]
        public Input<string>? RemoteIdentityHealthcheckUsername { get; set; }

        [Input("roleArn")]
        public Input<string>? RoleArn { get; set; }

        [Input("roleExternalId")]
        public Input<string>? RoleExternalId { get; set; }

        /// <summary>
        /// ID of the secret store containing credentials for this resource, if any.
        /// </summary>
        [Input("secretStoreId")]
        public Input<string>? SecretStoreId { get; set; }

        [Input("secretStoreRoleArnKey")]
        public Input<string>? SecretStoreRoleArnKey { get; set; }

        [Input("secretStoreRoleArnPath")]
        public Input<string>? SecretStoreRoleArnPath { get; set; }

        [Input("secretStoreRoleExternalIdKey")]
        public Input<string>? SecretStoreRoleExternalIdKey { get; set; }

        [Input("secretStoreRoleExternalIdPath")]
        public Input<string>? SecretStoreRoleExternalIdPath { get; set; }

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
