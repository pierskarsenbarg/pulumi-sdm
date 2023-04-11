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
    public sealed class ResourceAmazonEks
    {
        public readonly string? AccessKey;
        /// <summary>
        /// Bind interface
        /// </summary>
        public readonly string? BindInterface;
        public readonly string? CertificateAuthority;
        public readonly string ClusterName;
        /// <summary>
        /// A filter applied to the routing logic to pin datasource to nodes.
        /// </summary>
        public readonly string? EgressFilter;
        public readonly string Endpoint;
        /// <summary>
        /// The path used to check the health of your connection.  Defaults to `default`.  This field is required, and is only marked as optional for backwards compatibility.
        /// </summary>
        public readonly string? HealthcheckNamespace;
        /// <summary>
        /// Unique human-readable name of the Resource.
        /// </summary>
        public readonly string Name;
        public readonly string Region;
        public readonly string? RemoteIdentityGroupId;
        public readonly string? RemoteIdentityHealthcheckUsername;
        public readonly string? RoleArn;
        public readonly string? RoleExternalId;
        public readonly string? SecretAccessKey;
        public readonly string? SecretStoreAccessKeyKey;
        public readonly string? SecretStoreAccessKeyPath;
        public readonly string? SecretStoreCertificateAuthorityKey;
        public readonly string? SecretStoreCertificateAuthorityPath;
        /// <summary>
        /// ID of the secret store containing credentials for this resource, if any.
        /// </summary>
        public readonly string? SecretStoreId;
        public readonly string? SecretStoreRoleArnKey;
        public readonly string? SecretStoreRoleArnPath;
        public readonly string? SecretStoreRoleExternalIdKey;
        public readonly string? SecretStoreRoleExternalIdPath;
        public readonly string? SecretStoreSecretAccessKeyKey;
        public readonly string? SecretStoreSecretAccessKeyPath;
        /// <summary>
        /// Subdomain is the local DNS address.  (e.g. app-prod1 turns into app-prod1.your-org-name.sdm.network)
        /// </summary>
        public readonly string? Subdomain;
        /// <summary>
        /// Tags is a map of key, value pairs.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;

        [OutputConstructor]
        private ResourceAmazonEks(
            string? accessKey,

            string? bindInterface,

            string? certificateAuthority,

            string clusterName,

            string? egressFilter,

            string endpoint,

            string? healthcheckNamespace,

            string name,

            string region,

            string? remoteIdentityGroupId,

            string? remoteIdentityHealthcheckUsername,

            string? roleArn,

            string? roleExternalId,

            string? secretAccessKey,

            string? secretStoreAccessKeyKey,

            string? secretStoreAccessKeyPath,

            string? secretStoreCertificateAuthorityKey,

            string? secretStoreCertificateAuthorityPath,

            string? secretStoreId,

            string? secretStoreRoleArnKey,

            string? secretStoreRoleArnPath,

            string? secretStoreRoleExternalIdKey,

            string? secretStoreRoleExternalIdPath,

            string? secretStoreSecretAccessKeyKey,

            string? secretStoreSecretAccessKeyPath,

            string? subdomain,

            ImmutableDictionary<string, string>? tags)
        {
            AccessKey = accessKey;
            BindInterface = bindInterface;
            CertificateAuthority = certificateAuthority;
            ClusterName = clusterName;
            EgressFilter = egressFilter;
            Endpoint = endpoint;
            HealthcheckNamespace = healthcheckNamespace;
            Name = name;
            Region = region;
            RemoteIdentityGroupId = remoteIdentityGroupId;
            RemoteIdentityHealthcheckUsername = remoteIdentityHealthcheckUsername;
            RoleArn = roleArn;
            RoleExternalId = roleExternalId;
            SecretAccessKey = secretAccessKey;
            SecretStoreAccessKeyKey = secretStoreAccessKeyKey;
            SecretStoreAccessKeyPath = secretStoreAccessKeyPath;
            SecretStoreCertificateAuthorityKey = secretStoreCertificateAuthorityKey;
            SecretStoreCertificateAuthorityPath = secretStoreCertificateAuthorityPath;
            SecretStoreId = secretStoreId;
            SecretStoreRoleArnKey = secretStoreRoleArnKey;
            SecretStoreRoleArnPath = secretStoreRoleArnPath;
            SecretStoreRoleExternalIdKey = secretStoreRoleExternalIdKey;
            SecretStoreRoleExternalIdPath = secretStoreRoleExternalIdPath;
            SecretStoreSecretAccessKeyKey = secretStoreSecretAccessKeyKey;
            SecretStoreSecretAccessKeyPath = secretStoreSecretAccessKeyPath;
            Subdomain = subdomain;
            Tags = tags;
        }
    }
}
