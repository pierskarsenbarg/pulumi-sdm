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
    public sealed class ResourceKubernetesServiceAccountUserImpersonation
    {
        /// <summary>
        /// Bind interface
        /// </summary>
        public readonly string? BindInterface;
        /// <summary>
        /// A filter applied to the routing logic to pin datasource to nodes.
        /// </summary>
        public readonly string? EgressFilter;
        /// <summary>
        /// The path used to check the health of your connection.  Defaults to `default`.  This field is required, and is only marked as optional for backwards compatibility.
        /// </summary>
        public readonly string? HealthcheckNamespace;
        public readonly string Hostname;
        /// <summary>
        /// Unique human-readable name of the Resource.
        /// </summary>
        public readonly string Name;
        public readonly int Port;
        public readonly int? PortOverride;
        /// <summary>
        /// ID of the secret store containing credentials for this resource, if any.
        /// </summary>
        public readonly string? SecretStoreId;
        /// <summary>
        /// * kubernetes_user_impersonation:
        /// </summary>
        public readonly string? SecretStoreTokenKey;
        public readonly string? SecretStoreTokenPath;
        /// <summary>
        /// Subdomain is the local DNS address.  (e.g. app-prod1 turns into app-prod1.your-org-name.sdm.network)
        /// </summary>
        public readonly string? Subdomain;
        /// <summary>
        /// Tags is a map of key, value pairs.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        public readonly string? Token;

        [OutputConstructor]
        private ResourceKubernetesServiceAccountUserImpersonation(
            string? bindInterface,

            string? egressFilter,

            string? healthcheckNamespace,

            string hostname,

            string name,

            int port,

            int? portOverride,

            string? secretStoreId,

            string? secretStoreTokenKey,

            string? secretStoreTokenPath,

            string? subdomain,

            ImmutableDictionary<string, string>? tags,

            string? token)
        {
            BindInterface = bindInterface;
            EgressFilter = egressFilter;
            HealthcheckNamespace = healthcheckNamespace;
            Hostname = hostname;
            Name = name;
            Port = port;
            PortOverride = portOverride;
            SecretStoreId = secretStoreId;
            SecretStoreTokenKey = secretStoreTokenKey;
            SecretStoreTokenPath = secretStoreTokenPath;
            Subdomain = subdomain;
            Tags = tags;
            Token = token;
        }
    }
}
