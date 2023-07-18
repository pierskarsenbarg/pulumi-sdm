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
    public sealed class ResourceBigQuery
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
        /// The neptune endpoint to connect to as in endpoint.region.neptune.amazonaws.com
        /// </summary>
        public readonly string Endpoint;
        /// <summary>
        /// Unique human-readable name of the Resource.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The local port used by clients to connect to this resource.
        /// </summary>
        public readonly int? PortOverride;
        /// <summary>
        /// The private key used to authenticate with the server.
        /// </summary>
        public readonly string? PrivateKey;
        /// <summary>
        /// The project to connect to.
        /// </summary>
        public readonly string Project;
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
        /// The username to authenticate with.
        /// </summary>
        public readonly string? Username;

        [OutputConstructor]
        private ResourceBigQuery(
            string? bindInterface,

            string? egressFilter,

            string endpoint,

            string name,

            int? portOverride,

            string? privateKey,

            string project,

            string? secretStoreId,

            string? subdomain,

            ImmutableDictionary<string, string>? tags,

            string? username)
        {
            BindInterface = bindInterface;
            EgressFilter = egressFilter;
            Endpoint = endpoint;
            Name = name;
            PortOverride = portOverride;
            PrivateKey = privateKey;
            Project = project;
            SecretStoreId = secretStoreId;
            Subdomain = subdomain;
            Tags = tags;
            Username = username;
        }
    }
}
