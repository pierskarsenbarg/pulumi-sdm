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
    public sealed class GetSecretStoreSecretStoreResult
    {
        public readonly ImmutableArray<Outputs.GetSecretStoreSecretStoreActiveDirectoryStoreResult> ActiveDirectoryStores;
        public readonly ImmutableArray<Outputs.GetSecretStoreSecretStoreAwResult> Aws;
        public readonly ImmutableArray<Outputs.GetSecretStoreSecretStoreAwsCertX509Result> AwsCertX509s;
        public readonly ImmutableArray<Outputs.GetSecretStoreSecretStoreAzureStoreResult> AzureStores;
        public readonly ImmutableArray<Outputs.GetSecretStoreSecretStoreCyberarkConjurResult> CyberarkConjurs;
        public readonly ImmutableArray<Outputs.GetSecretStoreSecretStoreCyberarkPamExperimentalResult> CyberarkPamExperimentals;
        public readonly ImmutableArray<Outputs.GetSecretStoreSecretStoreCyberarkPamResult> CyberarkPams;
        public readonly ImmutableArray<Outputs.GetSecretStoreSecretStoreDelineaStoreResult> DelineaStores;
        public readonly ImmutableArray<Outputs.GetSecretStoreSecretStoreGcpCertX509StoreResult> GcpCertX509Stores;
        public readonly ImmutableArray<Outputs.GetSecretStoreSecretStoreGcpStoreResult> GcpStores;
        public readonly ImmutableArray<Outputs.GetSecretStoreSecretStoreKeyfactorX509StoreResult> KeyfactorX509Stores;
        public readonly ImmutableArray<Outputs.GetSecretStoreSecretStoreVaultApproleCertSshResult> VaultApproleCertSshes;
        public readonly ImmutableArray<Outputs.GetSecretStoreSecretStoreVaultApproleCertX509Result> VaultApproleCertX509s;
        public readonly ImmutableArray<Outputs.GetSecretStoreSecretStoreVaultApproleResult> VaultApproles;
        public readonly ImmutableArray<Outputs.GetSecretStoreSecretStoreVaultTlResult> VaultTls;
        public readonly ImmutableArray<Outputs.GetSecretStoreSecretStoreVaultTlsCertSshResult> VaultTlsCertSshes;
        public readonly ImmutableArray<Outputs.GetSecretStoreSecretStoreVaultTlsCertX509Result> VaultTlsCertX509s;
        public readonly ImmutableArray<Outputs.GetSecretStoreSecretStoreVaultTokenCertSshResult> VaultTokenCertSshes;
        public readonly ImmutableArray<Outputs.GetSecretStoreSecretStoreVaultTokenCertX509Result> VaultTokenCertX509s;
        public readonly ImmutableArray<Outputs.GetSecretStoreSecretStoreVaultTokenResult> VaultTokens;

        [OutputConstructor]
        private GetSecretStoreSecretStoreResult(
            ImmutableArray<Outputs.GetSecretStoreSecretStoreActiveDirectoryStoreResult> activeDirectoryStores,

            ImmutableArray<Outputs.GetSecretStoreSecretStoreAwResult> aws,

            ImmutableArray<Outputs.GetSecretStoreSecretStoreAwsCertX509Result> awsCertX509s,

            ImmutableArray<Outputs.GetSecretStoreSecretStoreAzureStoreResult> azureStores,

            ImmutableArray<Outputs.GetSecretStoreSecretStoreCyberarkConjurResult> cyberarkConjurs,

            ImmutableArray<Outputs.GetSecretStoreSecretStoreCyberarkPamExperimentalResult> cyberarkPamExperimentals,

            ImmutableArray<Outputs.GetSecretStoreSecretStoreCyberarkPamResult> cyberarkPams,

            ImmutableArray<Outputs.GetSecretStoreSecretStoreDelineaStoreResult> delineaStores,

            ImmutableArray<Outputs.GetSecretStoreSecretStoreGcpCertX509StoreResult> gcpCertX509Stores,

            ImmutableArray<Outputs.GetSecretStoreSecretStoreGcpStoreResult> gcpStores,

            ImmutableArray<Outputs.GetSecretStoreSecretStoreKeyfactorX509StoreResult> keyfactorX509Stores,

            ImmutableArray<Outputs.GetSecretStoreSecretStoreVaultApproleCertSshResult> vaultApproleCertSshes,

            ImmutableArray<Outputs.GetSecretStoreSecretStoreVaultApproleCertX509Result> vaultApproleCertX509s,

            ImmutableArray<Outputs.GetSecretStoreSecretStoreVaultApproleResult> vaultApproles,

            ImmutableArray<Outputs.GetSecretStoreSecretStoreVaultTlResult> vaultTls,

            ImmutableArray<Outputs.GetSecretStoreSecretStoreVaultTlsCertSshResult> vaultTlsCertSshes,

            ImmutableArray<Outputs.GetSecretStoreSecretStoreVaultTlsCertX509Result> vaultTlsCertX509s,

            ImmutableArray<Outputs.GetSecretStoreSecretStoreVaultTokenCertSshResult> vaultTokenCertSshes,

            ImmutableArray<Outputs.GetSecretStoreSecretStoreVaultTokenCertX509Result> vaultTokenCertX509s,

            ImmutableArray<Outputs.GetSecretStoreSecretStoreVaultTokenResult> vaultTokens)
        {
            ActiveDirectoryStores = activeDirectoryStores;
            Aws = aws;
            AwsCertX509s = awsCertX509s;
            AzureStores = azureStores;
            CyberarkConjurs = cyberarkConjurs;
            CyberarkPamExperimentals = cyberarkPamExperimentals;
            CyberarkPams = cyberarkPams;
            DelineaStores = delineaStores;
            GcpCertX509Stores = gcpCertX509Stores;
            GcpStores = gcpStores;
            KeyfactorX509Stores = keyfactorX509Stores;
            VaultApproleCertSshes = vaultApproleCertSshes;
            VaultApproleCertX509s = vaultApproleCertX509s;
            VaultApproles = vaultApproles;
            VaultTls = vaultTls;
            VaultTlsCertSshes = vaultTlsCertSshes;
            VaultTlsCertX509s = vaultTlsCertX509s;
            VaultTokenCertSshes = vaultTokenCertSshes;
            VaultTokenCertX509s = vaultTokenCertX509s;
            VaultTokens = vaultTokens;
        }
    }
}
