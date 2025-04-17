// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Sdm.Inputs
{

    public sealed class SecretEngineKeyValueGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// An interval of public/private key rotation for secret engine in days
        /// </summary>
        [Input("keyRotationIntervalDays")]
        public Input<int>? KeyRotationIntervalDays { get; set; }

        /// <summary>
        /// Unique human-readable name of the Secret Engine.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Public key linked with a secret engine
        /// </summary>
        [Input("publicKey")]
        public Input<string>? PublicKey { get; set; }

        /// <summary>
        /// Backing secret store identifier
        /// </summary>
        [Input("secretStoreId", required: true)]
        public Input<string> SecretStoreId { get; set; } = null!;

        /// <summary>
        /// Backing Secret Store root path where managed secrets are going to be stored
        /// </summary>
        [Input("secretStoreRootPath", required: true)]
        public Input<string> SecretStoreRootPath { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Tags is a map of key, value pairs.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public SecretEngineKeyValueGetArgs()
        {
        }
        public static new SecretEngineKeyValueGetArgs Empty => new SecretEngineKeyValueGetArgs();
    }
}
