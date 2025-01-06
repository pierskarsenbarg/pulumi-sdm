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
    public sealed class ResourceGcpwif
    {
        /// <summary>
        /// The bind interface is the IP address to which the port override of a resource is bound (for example, 127.0.0.1). It is automatically generated if not provided.
        /// </summary>
        public readonly string? BindInterface;
        /// <summary>
        /// A filter applied to the routing logic to pin datasource to nodes.
        /// </summary>
        public readonly string? EgressFilter;
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
        public readonly string Name;
        /// <summary>
        /// The local port used by clients to connect to this resource.
        /// </summary>
        public readonly int? PortOverride;
        /// <summary>
        /// When specified, all project scoped requests will use this Project ID, overriding the project ID specified by clients
        /// </summary>
        public readonly string? ProjectId;
        /// <summary>
        /// ID of the proxy cluster for this resource, if any.
        /// </summary>
        public readonly string? ProxyClusterId;
        /// <summary>
        /// Space separated scopes that this login should assume into when authenticating.
        /// </summary>
        public readonly string Scopes;
        /// <summary>
        /// ID of the secret store containing credentials for this resource, if any.
        /// </summary>
        public readonly string? SecretStoreId;
        /// <summary>
        /// The length of time in seconds console sessions will live before needing to reauthenticate.
        /// </summary>
        public readonly int? SessionExpiry;
        /// <summary>
        /// Subdomain is the local DNS address.  (e.g. app-prod1 turns into app-prod1.your-org-name.sdm.network)
        /// </summary>
        public readonly string? Subdomain;
        /// <summary>
        /// Tags is a map of key, value pairs.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The ID of the Workforce Identity Pool in GCP to use for federated authentication.
        /// </summary>
        public readonly string WorkforcePoolId;
        /// <summary>
        /// The ID of the Workforce Identity Provider in GCP to use for federated authentication.
        /// * google_gke:
        /// </summary>
        public readonly string WorkforceProviderId;

        [OutputConstructor]
        private ResourceGcpwif(
            string? bindInterface,

            string? egressFilter,

            string? identityAliasHealthcheckUsername,

            string? identitySetId,

            string name,

            int? portOverride,

            string? projectId,

            string? proxyClusterId,

            string scopes,

            string? secretStoreId,

            int? sessionExpiry,

            string? subdomain,

            ImmutableDictionary<string, string>? tags,

            string workforcePoolId,

            string workforceProviderId)
        {
            BindInterface = bindInterface;
            EgressFilter = egressFilter;
            IdentityAliasHealthcheckUsername = identityAliasHealthcheckUsername;
            IdentitySetId = identitySetId;
            Name = name;
            PortOverride = portOverride;
            ProjectId = projectId;
            ProxyClusterId = proxyClusterId;
            Scopes = scopes;
            SecretStoreId = secretStoreId;
            SessionExpiry = sessionExpiry;
            Subdomain = subdomain;
            Tags = tags;
            WorkforcePoolId = workforcePoolId;
            WorkforceProviderId = workforceProviderId;
        }
    }
}
