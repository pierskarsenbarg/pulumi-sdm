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
    public sealed class GetResourceResourceSqlServerAzureAdResult
    {
        /// <summary>
        /// The bind interface is the IP address to which the port override of a resource is bound (for example, 127.0.0.1). It is automatically generated if not provided.
        /// </summary>
        public readonly string? BindInterface;
        /// <summary>
        /// The Azure AD application (client) ID with which to authenticate.
        /// </summary>
        public readonly string? ClientId;
        /// <summary>
        /// The initial database to connect to. This setting does not by itself prevent switching to another database after connecting.
        /// </summary>
        public readonly string? Database;
        /// <summary>
        /// A filter applied to the routing logic to pin datasource to nodes.
        /// </summary>
        public readonly string? EgressFilter;
        /// <summary>
        /// The host to dial to initiate a connection from the egress node to this resource.
        /// </summary>
        public readonly string? Hostname;
        /// <summary>
        /// Unique identifier of the Resource.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Unique human-readable name of the Resource.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// If set, the database configured cannot be changed by users. This setting is not recommended for most use cases, as some clients will insist their database has changed when it has not, leading to user confusion.
        /// </summary>
        public readonly bool? OverrideDatabase;
        /// <summary>
        /// The port to dial to initiate a connection from the egress node to this resource.
        /// </summary>
        public readonly int? Port;
        /// <summary>
        /// The local port used by clients to connect to this resource.
        /// </summary>
        public readonly int? PortOverride;
        /// <summary>
        /// The Schema to use to direct initial requests.
        /// </summary>
        public readonly string? Schema;
        /// <summary>
        /// The Azure AD client secret (application password) with which to authenticate.
        /// </summary>
        public readonly string? Secret;
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
        private GetResourceResourceSqlServerAzureAdResult(
            string? bindInterface,

            string? clientId,

            string? database,

            string? egressFilter,

            string? hostname,

            string? id,

            string? name,

            bool? overrideDatabase,

            int? port,

            int? portOverride,

            string? schema,

            string? secret,

            string? secretStoreId,

            string? subdomain,

            ImmutableDictionary<string, string>? tags,

            string? tenantId)
        {
            BindInterface = bindInterface;
            ClientId = clientId;
            Database = database;
            EgressFilter = egressFilter;
            Hostname = hostname;
            Id = id;
            Name = name;
            OverrideDatabase = overrideDatabase;
            Port = port;
            PortOverride = portOverride;
            Schema = schema;
            Secret = secret;
            SecretStoreId = secretStoreId;
            Subdomain = subdomain;
            Tags = tags;
            TenantId = tenantId;
        }
    }
}
