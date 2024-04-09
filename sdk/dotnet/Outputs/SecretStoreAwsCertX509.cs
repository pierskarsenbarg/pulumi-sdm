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
    public sealed class SecretStoreAwsCertX509
    {
        /// <summary>
        /// The ARN of the CA in AWS Private CA
        /// </summary>
        public readonly string CaArn;
        /// <summary>
        /// The ARN of the AWS certificate template for requested certificates. Must allow SAN, key usage, and ext key usage passthrough from CSR
        /// </summary>
        public readonly string CertificateTemplateArn;
        /// <summary>
        /// The lifetime of certificates issued by this CA represented in minutes.
        /// </summary>
        public readonly int IssuedCertTtlMinutes;
        /// <summary>
        /// Unique human-readable name of the SecretStore.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The AWS region to target e.g. us-east-1
        /// </summary>
        public readonly string Region;
        /// <summary>
        /// The specified signing algorithm family (RSA or ECDSA) must match the algorithm family of the CA's secret key. e.g. SHA256WITHRSA
        /// </summary>
        public readonly string SigningAlgo;
        /// <summary>
        /// Tags is a map of key, value pairs.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;

        [OutputConstructor]
        private SecretStoreAwsCertX509(
            string caArn,

            string certificateTemplateArn,

            int issuedCertTtlMinutes,

            string name,

            string region,

            string signingAlgo,

            ImmutableDictionary<string, string>? tags)
        {
            CaArn = caArn;
            CertificateTemplateArn = certificateTemplateArn;
            IssuedCertTtlMinutes = issuedCertTtlMinutes;
            Name = name;
            Region = region;
            SigningAlgo = signingAlgo;
            Tags = tags;
        }
    }
}
