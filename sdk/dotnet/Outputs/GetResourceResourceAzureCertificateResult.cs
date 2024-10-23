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
    public sealed class GetResourceResourceAzureCertificateResult
    {
        /// <summary>
        /// The application ID to authenticate with.
        /// </summary>
        public readonly string? AppId;
        /// <summary>
        /// The bind interface is the IP address to which the port override of a resource is bound (for example, 127.0.0.1). It is automatically generated if not provided.
        /// </summary>
        public readonly string? BindInterface;
        /// <summary>
        /// The certificate to authenticate TLS connections with.
        /// </summary>
        public readonly string? ClientCertificate;
        /// <summary>
        /// A filter applied to the routing logic to pin datasource to nodes.
        /// </summary>
        public readonly string? EgressFilter;
        /// <summary>
        /// Unique identifier of the Resource.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Unique human-readable name of the Resource.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The local port used by clients to connect to this resource.
        /// </summary>
        public readonly int? PortOverride;
        /// <summary>
        /// ID of the proxy cluster for this resource, if any.
        /// </summary>
        public readonly string? ProxyClusterId;
        /// <summary>
        /// ID of the secret store containing credentials for this resource, if any.
        /// </summary>
        public readonly string? SecretStoreId;
        /// <summary>
        /// Subdomain is the local DNS address.  (e.g. app-prod1 turns into app-prod1.your-org-name.sdm.network)
        /// </summary>
        public readonly string? Subdomain;
        /// <summary>
        /// Tags is a map of key, value pairs.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The Azure AD directory (tenant) ID with which to authenticate.
        /// * sql_server_kerberos_ad:
        /// </summary>
        public readonly string? TenantId;

        [OutputConstructor]
        private GetResourceResourceAzureCertificateResult(
            string? appId,

            string? bindInterface,

            string? clientCertificate,

            string? egressFilter,

            string? id,

            string? name,

            int? portOverride,

            string? proxyClusterId,

            string? secretStoreId,

            string? subdomain,

            ImmutableDictionary<string, string>? tags,

            string? tenantId)
        {
            AppId = appId;
            BindInterface = bindInterface;
            ClientCertificate = clientCertificate;
            EgressFilter = egressFilter;
            Id = id;
            Name = name;
            PortOverride = portOverride;
            ProxyClusterId = proxyClusterId;
            SecretStoreId = secretStoreId;
            Subdomain = subdomain;
            Tags = tags;
            TenantId = tenantId;
        }
    }
}
