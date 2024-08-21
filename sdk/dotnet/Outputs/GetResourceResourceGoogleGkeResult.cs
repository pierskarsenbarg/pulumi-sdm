// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Sdm.Outputs
{

    [OutputType]
    public sealed class GetResourceResourceGoogleGkeResult
    {
        /// <summary>
        /// If true, allows users to fallback to the existing authentication mode (Leased Credential or Identity Set) when a resource role is not provided.
        /// </summary>
        public readonly bool? AllowResourceRoleBypass;
        /// <summary>
        /// The bind interface is the IP address to which the port override of a resource is bound (for example, 127.0.0.1). It is automatically generated if not provided.
        /// </summary>
        public readonly string? BindInterface;
        /// <summary>
        /// The CA to authenticate TLS connections with.
        /// </summary>
        public readonly string? CertificateAuthority;
        /// <summary>
        /// If true, configures discovery of a cluster to be run from a node.
        /// </summary>
        public readonly bool? DiscoveryEnabled;
        /// <summary>
        /// If a cluster is configured for user impersonation, this is the user to impersonate when running discovery.
        /// </summary>
        public readonly string? DiscoveryUsername;
        /// <summary>
        /// A filter applied to the routing logic to pin datasource to nodes.
        /// </summary>
        public readonly string? EgressFilter;
        /// <summary>
        /// The neptune endpoint to connect to as in endpoint.region.neptune.amazonaws.com
        /// </summary>
        public readonly string? Endpoint;
        /// <summary>
        /// The path used to check the health of your connection.  Defaults to `default`.  This field is required, and is only marked as optional for backwards compatibility.
        /// </summary>
        public readonly string? HealthcheckNamespace;
        /// <summary>
        /// Unique identifier of the Resource.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The username to use for healthchecks, when clients otherwise connect with their own identity alias username.
        /// </summary>
        public readonly string? IdentityAliasHealthcheckUsername;
        /// <summary>
        /// The ID of the identity set to use for identity connections.
        /// </summary>
        public readonly string? IdentitySetId;
        /// <summary>
        /// Unique human-readable name of the Resource.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The local port used by clients to connect to this resource.
        /// </summary>
        public readonly int? PortOverride;
        /// <summary>
        /// ID of the secret store containing credentials for this resource, if any.
        /// </summary>
        public readonly string? SecretStoreId;
        /// <summary>
        /// The service account key to authenticate with.
        /// </summary>
        public readonly string? ServiceAccountKey;
        /// <summary>
        /// Subdomain is the local DNS address.  (e.g. app-prod1 turns into app-prod1.your-org-name.sdm.network)
        /// </summary>
        public readonly string? Subdomain;
        /// <summary>
        /// Tags is a map of key, value pairs.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;

        [OutputConstructor]
        private GetResourceResourceGoogleGkeResult(
            bool? allowResourceRoleBypass,

            string? bindInterface,

            string? certificateAuthority,

            bool? discoveryEnabled,

            string? discoveryUsername,

            string? egressFilter,

            string? endpoint,

            string? healthcheckNamespace,

            string? id,

            string? identityAliasHealthcheckUsername,

            string? identitySetId,

            string? name,

            int? portOverride,

            string? secretStoreId,

            string? serviceAccountKey,

            string? subdomain,

            ImmutableDictionary<string, string>? tags)
        {
            AllowResourceRoleBypass = allowResourceRoleBypass;
            BindInterface = bindInterface;
            CertificateAuthority = certificateAuthority;
            DiscoveryEnabled = discoveryEnabled;
            DiscoveryUsername = discoveryUsername;
            EgressFilter = egressFilter;
            Endpoint = endpoint;
            HealthcheckNamespace = healthcheckNamespace;
            Id = id;
            IdentityAliasHealthcheckUsername = identityAliasHealthcheckUsername;
            IdentitySetId = identitySetId;
            Name = name;
            PortOverride = portOverride;
            SecretStoreId = secretStoreId;
            ServiceAccountKey = serviceAccountKey;
            Subdomain = subdomain;
            Tags = tags;
        }
    }
}
