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
    public sealed class ResourceKubernetes
    {
        /// <summary>
        /// Bind interface
        /// </summary>
        public readonly string? BindInterface;
        public readonly string? CertificateAuthority;
        public readonly string? ClientCertificate;
        public readonly string? ClientKey;
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
        public readonly string? RemoteIdentityGroupId;
        public readonly string? RemoteIdentityHealthcheckUsername;
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

        [OutputConstructor]
        private ResourceKubernetes(
            string? bindInterface,

            string? certificateAuthority,

            string? clientCertificate,

            string? clientKey,

            string? egressFilter,

            string? healthcheckNamespace,

            string hostname,

            string name,

            int port,

            int? portOverride,

            string? remoteIdentityGroupId,

            string? remoteIdentityHealthcheckUsername,

            string? secretStoreId,

            string? subdomain,

            ImmutableDictionary<string, string>? tags)
        {
            BindInterface = bindInterface;
            CertificateAuthority = certificateAuthority;
            ClientCertificate = clientCertificate;
            ClientKey = clientKey;
            EgressFilter = egressFilter;
            HealthcheckNamespace = healthcheckNamespace;
            Hostname = hostname;
            Name = name;
            Port = port;
            PortOverride = portOverride;
            RemoteIdentityGroupId = remoteIdentityGroupId;
            RemoteIdentityHealthcheckUsername = remoteIdentityHealthcheckUsername;
            SecretStoreId = secretStoreId;
            Subdomain = subdomain;
            Tags = tags;
        }
    }
}
