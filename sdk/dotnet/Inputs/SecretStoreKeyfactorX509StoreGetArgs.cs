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

    public sealed class SecretStoreKeyfactorX509StoreGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Path to the root CA that signed the certificate passed to the client for HTTPS connection. This is not required if the CA is trusted by the host operating system. This should be a PEM formatted certificate, and doesn't necessarily have to be the CA that signed CertificateFile.
        /// </summary>
        [Input("caFilePath")]
        public Input<string>? CaFilePath { get; set; }

        /// <summary>
        /// Path to client certificate in PEM format. This certificate must contain a client certificate that is recognized by the EJBCA instance represented by Hostname. This PEM file may also contain the private key associated with the certificate, but KeyFile can also be set to configure the private key.
        /// </summary>
        [Input("certificateFilePath", required: true)]
        public Input<string> CertificateFilePath { get; set; } = null!;

        /// <summary>
        /// Name of EJBCA certificate authority that will enroll CSR.
        /// </summary>
        [Input("defaultCertificateAuthorityName", required: true)]
        public Input<string> DefaultCertificateAuthorityName { get; set; } = null!;

        /// <summary>
        /// Certificate profile name that EJBCA will enroll the CSR with.
        /// </summary>
        [Input("defaultCertificateProfileName", required: true)]
        public Input<string> DefaultCertificateProfileName { get; set; } = null!;

        /// <summary>
        /// End entity profile that EJBCA will enroll the CSR with.
        /// </summary>
        [Input("defaultEndEntityProfileName", required: true)]
        public Input<string> DefaultEndEntityProfileName { get; set; } = null!;

        /// <summary>
        /// code used by EJBCA during enrollment. May be left blank if no code is required.
        /// </summary>
        [Input("enrollmentCodeEnvVar")]
        public Input<string>? EnrollmentCodeEnvVar { get; set; }

        /// <summary>
        /// username that used by the EJBCA during enrollment. This can be left out.  If so, the username must be auto-generated on the Keyfactor side.
        /// </summary>
        [Input("enrollmentUsernameEnvVar")]
        public Input<string>? EnrollmentUsernameEnvVar { get; set; }

        /// <summary>
        /// Path to private key in PEM format. This file should contain the private key associated with the client certificate configured in CertificateFile.
        /// </summary>
        [Input("keyFilePath")]
        public Input<string>? KeyFilePath { get; set; }

        /// <summary>
        /// optional environment variable housing the password that is used to decrypt the key file.
        /// </summary>
        [Input("keyPasswordEnvVar")]
        public Input<string>? KeyPasswordEnvVar { get; set; }

        /// <summary>
        /// Unique human-readable name of the SecretStore.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The URL of the Vault to target
        /// </summary>
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

        public SecretStoreKeyfactorX509StoreGetArgs()
        {
        }
        public static new SecretStoreKeyfactorX509StoreGetArgs Empty => new SecretStoreKeyfactorX509StoreGetArgs();
    }
}
