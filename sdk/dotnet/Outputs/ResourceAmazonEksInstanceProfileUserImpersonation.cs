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
    public sealed class ResourceAmazonEksInstanceProfileUserImpersonation
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
        /// The name of the cluster to connect to.
        /// </summary>
        public readonly string ClusterName;
        /// <summary>
        /// A filter applied to the routing logic to pin datasource to nodes.
        /// </summary>
        public readonly string? EgressFilter;
        /// <summary>
        /// The neptune endpoint to connect to as in endpoint.region.neptune.amazonaws.com
        /// </summary>
        public readonly string Endpoint;
        /// <summary>
        /// The path used to check the health of your connection.  Defaults to `default`.  This field is required, and is only marked as optional for backwards compatibility.
        /// </summary>
        public readonly string? HealthcheckNamespace;
        /// <summary>
        /// Unique human-readable name of the Resource.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The local port used by clients to connect to this resource.
        /// </summary>
        public readonly int? PortOverride;
        /// <summary>
        /// The AWS region to connect to.
        /// </summary>
        public readonly string Region;
        /// <summary>
        /// The role to assume after logging in.
        /// </summary>
        public readonly string? RoleArn;
        /// <summary>
        /// The external ID to associate with assume role requests. Does nothing if a role ARN is not provided.
        /// </summary>
        public readonly string? RoleExternalId;
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
        private ResourceAmazonEksInstanceProfileUserImpersonation(
            string? bindInterface,

            string? certificateAuthority,

            string clusterName,

            string? egressFilter,

            string endpoint,

            string? healthcheckNamespace,

            string name,

            int? portOverride,

            string region,

            string? roleArn,

            string? roleExternalId,

            string? secretStoreId,

            string? subdomain,

            ImmutableDictionary<string, string>? tags)
        {
            BindInterface = bindInterface;
            CertificateAuthority = certificateAuthority;
            ClusterName = clusterName;
            EgressFilter = egressFilter;
            Endpoint = endpoint;
            HealthcheckNamespace = healthcheckNamespace;
            Name = name;
            PortOverride = portOverride;
            Region = region;
            RoleArn = roleArn;
            RoleExternalId = roleExternalId;
            SecretStoreId = secretStoreId;
            Subdomain = subdomain;
            Tags = tags;
        }
    }
}
