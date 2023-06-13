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
    public sealed class ResourceDb2Luw
    {
        /// <summary>
        /// Bind interface
        /// </summary>
        public readonly string? BindInterface;
        public readonly string Database;
        /// <summary>
        /// A filter applied to the routing logic to pin datasource to nodes.
        /// </summary>
        public readonly string? EgressFilter;
        public readonly string Hostname;
        /// <summary>
        /// Unique human-readable name of the Resource.
        /// </summary>
        public readonly string Name;
        public readonly string? Password;
        public readonly int? Port;
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
        public readonly string? Username;

        [OutputConstructor]
        private ResourceDb2Luw(
            string? bindInterface,

            string database,

            string? egressFilter,

            string hostname,

            string name,

            string? password,

            int? port,

            int? portOverride,

            string? secretStoreId,

            string? subdomain,

            ImmutableDictionary<string, string>? tags,

            string? username)
        {
            BindInterface = bindInterface;
            Database = database;
            EgressFilter = egressFilter;
            Hostname = hostname;
            Name = name;
            Password = password;
            Port = port;
            PortOverride = portOverride;
            SecretStoreId = secretStoreId;
            Subdomain = subdomain;
            Tags = tags;
            Username = username;
        }
    }
}
