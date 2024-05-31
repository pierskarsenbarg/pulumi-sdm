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
    public sealed class GetSecretStoreSecretStoreVaultAwsEc2Result
    {
        /// <summary>
        /// Unique identifier of the SecretStore.
        /// </summary>
        public readonly string? Id;
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
        /// Tags is a map of key, value pairs.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;

        [OutputConstructor]
        private GetSecretStoreSecretStoreVaultAwsEc2Result(
            string? id,

            string? name,

            string? @namespace,

            string? serverAddress,

            ImmutableDictionary<string, string>? tags)
        {
            Id = id;
            Name = name;
            Namespace = @namespace;
            ServerAddress = serverAddress;
            Tags = tags;
        }
    }
}
