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

    public sealed class SecretStoreVaultTlsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("caCertPath")]
        public Input<string>? CaCertPath { get; set; }

        [Input("clientCertPath", required: true)]
        public Input<string> ClientCertPath { get; set; } = null!;

        [Input("clientKeyPath", required: true)]
        public Input<string> ClientKeyPath { get; set; } = null!;

        /// <summary>
        /// Unique human-readable name of the SecretStore.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        [Input("serverAddress", required: true)]
        public Input<string> ServerAddress { get; set; } = null!;

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

        public SecretStoreVaultTlsGetArgs()
        {
        }
        public static new SecretStoreVaultTlsGetArgs Empty => new SecretStoreVaultTlsGetArgs();
    }
}
