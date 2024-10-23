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
    public sealed class GetResourceResourceSshCustomerKeyResult
    {
        /// <summary>
        /// Whether deprecated, insecure key exchanges are allowed for use to connect to the target ssh server.
        /// </summary>
        public readonly bool? AllowDeprecatedKeyExchanges;
        /// <summary>
        /// The bind interface is the IP address to which the port override of a resource is bound (for example, 127.0.0.1). It is automatically generated if not provided.
        /// </summary>
        public readonly string? BindInterface;
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
        /// The port to dial to initiate a connection from the egress node to this resource.
        /// </summary>
        public readonly int? Port;
        /// <summary>
        /// Whether port forwarding is allowed through this server.
        /// </summary>
        public readonly bool? PortForwarding;
        /// <summary>
        /// The local port used by clients to connect to this resource.
        /// </summary>
        public readonly int? PortOverride;
        /// <summary>
        /// The private key used to authenticate with the server.
        /// </summary>
        public readonly string? PrivateKey;
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
        /// The username to authenticate with.
        /// </summary>
        public readonly string? Username;

        [OutputConstructor]
        private GetResourceResourceSshCustomerKeyResult(
            bool? allowDeprecatedKeyExchanges,

            string? bindInterface,

            string? egressFilter,

            string? hostname,

            string? id,

            string? name,

            int? port,

            bool? portForwarding,

            int? portOverride,

            string? privateKey,

            string? proxyClusterId,

            string? secretStoreId,

            string? subdomain,

            ImmutableDictionary<string, string>? tags,

            string? username)
        {
            AllowDeprecatedKeyExchanges = allowDeprecatedKeyExchanges;
            BindInterface = bindInterface;
            EgressFilter = egressFilter;
            Hostname = hostname;
            Id = id;
            Name = name;
            Port = port;
            PortForwarding = portForwarding;
            PortOverride = portOverride;
            PrivateKey = privateKey;
            ProxyClusterId = proxyClusterId;
            SecretStoreId = secretStoreId;
            Subdomain = subdomain;
            Tags = tags;
            Username = username;
        }
    }
}
