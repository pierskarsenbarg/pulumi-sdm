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

    public sealed class ResourceKubernetesPodIdentityArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// If true, allows users to fallback to the existing authentication mode (Leased Credential or Identity Set) when a resource role is not provided.
        /// </summary>
        [Input("allowResourceRoleBypass")]
        public Input<bool>? AllowResourceRoleBypass { get; set; }

        /// <summary>
        /// The bind interface is the IP address to which the port override of a resource is bound (for example, 127.0.0.1). It is automatically generated if not provided.
        /// </summary>
        [Input("bindInterface")]
        public Input<string>? BindInterface { get; set; }

        [Input("certificateAuthority")]
        private Input<string>? _certificateAuthority;

        /// <summary>
        /// The CA to authenticate TLS connections with.
        /// </summary>
        public Input<string>? CertificateAuthority
        {
            get => _certificateAuthority;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _certificateAuthority = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// A filter applied to the routing logic to pin datasource to nodes.
        /// </summary>
        [Input("egressFilter")]
        public Input<string>? EgressFilter { get; set; }

        /// <summary>
        /// The path used to check the health of your connection.  Defaults to `default`.  This field is required, and is only marked as optional for backwards compatibility.
        /// </summary>
        [Input("healthcheckNamespace")]
        public Input<string>? HealthcheckNamespace { get; set; }

        /// <summary>
        /// The username to use for healthchecks, when clients otherwise connect with their own identity alias username.
        /// </summary>
        [Input("identityAliasHealthcheckUsername")]
        public Input<string>? IdentityAliasHealthcheckUsername { get; set; }

        /// <summary>
        /// The ID of the identity set to use for identity connections.
        /// </summary>
        [Input("identitySetId")]
        public Input<string>? IdentitySetId { get; set; }

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
        /// ID of the proxy cluster for this resource, if any.
        /// </summary>
        [Input("proxyClusterId")]
        public Input<string>? ProxyClusterId { get; set; }

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

        public ResourceKubernetesPodIdentityArgs()
        {
        }
        public static new ResourceKubernetesPodIdentityArgs Empty => new ResourceKubernetesPodIdentityArgs();
    }
}
