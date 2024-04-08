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

    public sealed class SecretStoreVaultApproleCertX509GetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The lifetime of certificates issued by this CA represented in minutes.
        /// </summary>
        [Input("issuedCertTtlMinutes", required: true)]
        public Input<int> IssuedCertTtlMinutes { get; set; } = null!;

        /// <summary>
        /// Unique human-readable name of the SecretStore.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The namespace to make requests within
        /// </summary>
        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        /// <summary>
        /// The mount point of the PKI engine configured with the desired CA
        /// </summary>
        [Input("pkiMountPoint", required: true)]
        public Input<string> PkiMountPoint { get; set; } = null!;

        /// <summary>
        /// The URL of the Vault to target
        /// </summary>
        [Input("serverAddress", required: true)]
        public Input<string> ServerAddress { get; set; } = null!;

        /// <summary>
        /// The signing role to be used for signing certificates
        /// </summary>
        [Input("signingRole", required: true)]
        public Input<string> SigningRole { get; set; } = null!;

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

        public SecretStoreVaultApproleCertX509GetArgs()
        {
        }
        public static new SecretStoreVaultApproleCertX509GetArgs Empty => new SecretStoreVaultApproleCertX509GetArgs();
    }
}
