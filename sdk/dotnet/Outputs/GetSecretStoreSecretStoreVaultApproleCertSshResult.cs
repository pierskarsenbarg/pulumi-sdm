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
    public sealed class GetSecretStoreSecretStoreVaultApproleCertSshResult
    {
        /// <summary>
        /// Unique identifier of the SecretStore.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The lifetime of certificates issued by this CA represented in minutes.
        /// </summary>
        public readonly int? IssuedCertTtlMinutes;
        /// <summary>
        /// Unique human-readable name of the SecretStore.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The namespace to make requests within
        /// </summary>
        public readonly string? Namespace;
        /// <summary>
        /// The URL of the Vault to target
        /// </summary>
        public readonly string? ServerAddress;
        /// <summary>
        /// The signing role to be used for signing certificates
        /// </summary>
        public readonly string? SigningRole;
        /// <summary>
        /// The mount point of the SSH engine configured with the desired CA
        /// </summary>
        public readonly string? SshMountPoint;
        /// <summary>
        /// Tags is a map of key, value pairs.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;

        [OutputConstructor]
        private GetSecretStoreSecretStoreVaultApproleCertSshResult(
            string? id,

            int? issuedCertTtlMinutes,

            string? name,

            string? @namespace,

            string? serverAddress,

            string? signingRole,

            string? sshMountPoint,

            ImmutableDictionary<string, string>? tags)
        {
            Id = id;
            IssuedCertTtlMinutes = issuedCertTtlMinutes;
            Name = name;
            Namespace = @namespace;
            ServerAddress = serverAddress;
            SigningRole = signingRole;
            SshMountPoint = sshMountPoint;
            Tags = tags;
        }
    }
}