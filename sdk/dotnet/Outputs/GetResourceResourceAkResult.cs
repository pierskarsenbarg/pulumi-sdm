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
    public sealed class GetResourceResourceAkResult
    {
        /// <summary>
        /// The bind interface is the IP address to which the port override of a resource is bound (for example, 127.0.0.1). It is automatically generated if not provided.
        /// </summary>
        public readonly string? BindInterface;
        /// <summary>
        /// The CA to authenticate TLS connections with.
        /// </summary>
        public readonly string? CertificateAuthority;
        /// <summary>
        /// The certificate to authenticate TLS connections with.
        /// </summary>
        public readonly string? ClientCertificate;
        /// <summary>
        /// The key to authenticate TLS connections with.
        /// </summary>
        public readonly string? ClientKey;
        /// <summary>
        /// A filter applied to the routing logic to pin datasource to nodes.
        /// </summary>
        public readonly string? EgressFilter;
        /// <summary>
        /// The path used to check the health of your connection.  Defaults to `default`.  This field is required, and is only marked as optional for backwards compatibility.
        /// </summary>
        public readonly string? HealthcheckNamespace;
        /// <summary>
        /// The host to dial to initiate a connection from the egress node to this resource.
        /// </summary>
        public readonly string? Hostname;
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
        /// The port to dial to initiate a connection from the egress node to this resource.
        /// </summary>
        public readonly int? Port;
        /// <summary>
        /// The local port used by clients to connect to this resource.
        /// </summary>
        public readonly int? PortOverride;
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
        private GetResourceResourceAkResult(
            string? bindInterface,

            string? certificateAuthority,

            string? clientCertificate,

            string? clientKey,

            string? egressFilter,

            string? healthcheckNamespace,

            string? hostname,

            string? id,

            string? identityAliasHealthcheckUsername,

            string? identitySetId,

            string? name,

            int? port,

            int? portOverride,

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
            Id = id;
            IdentityAliasHealthcheckUsername = identityAliasHealthcheckUsername;
            IdentitySetId = identitySetId;
            Name = name;
            Port = port;
            PortOverride = portOverride;
            SecretStoreId = secretStoreId;
            Subdomain = subdomain;
            Tags = tags;
        }
    }
}
