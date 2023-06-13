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
    public sealed class GetResourceResourceSqlServerKerberosAdResult
    {
        /// <summary>
        /// Bind interface
        /// </summary>
        public readonly string? BindInterface;
        public readonly string? Database;
        /// <summary>
        /// A filter applied to the routing logic to pin datasource to nodes.
        /// </summary>
        public readonly string? EgressFilter;
        public readonly string? Hostname;
        /// <summary>
        /// Unique identifier of the Resource.
        /// </summary>
        public readonly string? Id;
        public readonly string? Keytab;
        public readonly string? KrbConfig;
        /// <summary>
        /// Unique human-readable name of the Resource.
        /// </summary>
        public readonly string? Name;
        public readonly bool? OverrideDatabase;
        public readonly int? Port;
        public readonly int? PortOverride;
        public readonly string? Realm;
        public readonly string? Schema;
        /// <summary>
        /// ID of the secret store containing credentials for this resource, if any.
        /// </summary>
        public readonly string? SecretStoreId;
        public readonly string? ServerSpn;
        /// <summary>
        /// Subdomain is the local DNS address.  (e.g. app-prod1 turns into app-prod1.your-org-name.sdm.network)
        /// </summary>
        public readonly string? Subdomain;
        /// <summary>
        /// Tags is a map of key, value pairs.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        public readonly string? Username;

        [OutputConstructor]
        private GetResourceResourceSqlServerKerberosAdResult(
            string? bindInterface,

            string? database,

            string? egressFilter,

            string? hostname,

            string? id,

            string? keytab,

            string? krbConfig,

            string? name,

            bool? overrideDatabase,

            int? port,

            int? portOverride,

            string? realm,

            string? schema,

            string? secretStoreId,

            string? serverSpn,

            string? subdomain,

            ImmutableDictionary<string, string>? tags,

            string? username)
        {
            BindInterface = bindInterface;
            Database = database;
            EgressFilter = egressFilter;
            Hostname = hostname;
            Id = id;
            Keytab = keytab;
            KrbConfig = krbConfig;
            Name = name;
            OverrideDatabase = overrideDatabase;
            Port = port;
            PortOverride = portOverride;
            Realm = realm;
            Schema = schema;
            SecretStoreId = secretStoreId;
            ServerSpn = serverSpn;
            Subdomain = subdomain;
            Tags = tags;
            Username = username;
        }
    }
}
