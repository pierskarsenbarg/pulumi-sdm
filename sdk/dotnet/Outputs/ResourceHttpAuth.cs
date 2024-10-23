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
    public sealed class ResourceHttpAuth
    {
        /// <summary>
        /// The content to set as the authorization header.
        /// </summary>
        public readonly string? AuthHeader;
        /// <summary>
        /// The bind interface is the IP address to which the port override of a resource is bound (for example, 127.0.0.1). It is automatically generated if not provided.
        /// </summary>
        public readonly string? BindInterface;
        /// <summary>
        /// Automatically redirect to this path upon connecting.
        /// </summary>
        public readonly string? DefaultPath;
        /// <summary>
        /// A filter applied to the routing logic to pin datasource to nodes.
        /// </summary>
        public readonly string? EgressFilter;
        /// <summary>
        /// Header names (e.g. Authorization), to omit from logs.
        /// </summary>
        public readonly string? HeadersBlacklist;
        /// <summary>
        /// This path will be used to check the health of your site.
        /// </summary>
        public readonly string HealthcheckPath;
        /// <summary>
        /// The host header will be overwritten with this field if provided.
        /// </summary>
        public readonly string? HostOverride;
        /// <summary>
        /// Unique human-readable name of the Resource.
        /// </summary>
        public readonly string Name;
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
        public readonly string Subdomain;
        /// <summary>
        /// Tags is a map of key, value pairs.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The base address of your website without the path.
        /// * kubernetes:
        /// </summary>
        public readonly string Url;

        [OutputConstructor]
        private ResourceHttpAuth(
            string? authHeader,

            string? bindInterface,

            string? defaultPath,

            string? egressFilter,

            string? headersBlacklist,

            string healthcheckPath,

            string? hostOverride,

            string name,

            string? proxyClusterId,

            string? secretStoreId,

            string subdomain,

            ImmutableDictionary<string, string>? tags,

            string url)
        {
            AuthHeader = authHeader;
            BindInterface = bindInterface;
            DefaultPath = defaultPath;
            EgressFilter = egressFilter;
            HeadersBlacklist = headersBlacklist;
            HealthcheckPath = healthcheckPath;
            HostOverride = hostOverride;
            Name = name;
            ProxyClusterId = proxyClusterId;
            SecretStoreId = secretStoreId;
            Subdomain = subdomain;
            Tags = tags;
            Url = url;
        }
    }
}
