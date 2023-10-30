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
    public sealed class GetResourceResourceResult
    {
        public readonly ImmutableArray<Outputs.GetResourceResourceAkResult> Aks;
        public readonly ImmutableArray<Outputs.GetResourceResourceAksBasicAuthResult> AksBasicAuths;
        public readonly ImmutableArray<Outputs.GetResourceResourceAksServiceAccountUserImpersonationResult> AksServiceAccountUserImpersonations;
        public readonly ImmutableArray<Outputs.GetResourceResourceAksServiceAccountResult> AksServiceAccounts;
        public readonly ImmutableArray<Outputs.GetResourceResourceAksUserImpersonationResult> AksUserImpersonations;
        public readonly ImmutableArray<Outputs.GetResourceResourceAmazonEkResult> AmazonEks;
        public readonly ImmutableArray<Outputs.GetResourceResourceAmazonEksInstanceProfileUserImpersonationResult> AmazonEksInstanceProfileUserImpersonations;
        public readonly ImmutableArray<Outputs.GetResourceResourceAmazonEksInstanceProfileResult> AmazonEksInstanceProfiles;
        public readonly ImmutableArray<Outputs.GetResourceResourceAmazonEksUserImpersonationResult> AmazonEksUserImpersonations;
        public readonly ImmutableArray<Outputs.GetResourceResourceAmazonEResult> AmazonEs;
        public readonly ImmutableArray<Outputs.GetResourceResourceAmazonmqAmqp091Result> AmazonmqAmqp091s;
        public readonly ImmutableArray<Outputs.GetResourceResourceAthenaResult> Athenas;
        public readonly ImmutableArray<Outputs.GetResourceResourceAuroraMysqlResult> AuroraMysqls;
        public readonly ImmutableArray<Outputs.GetResourceResourceAuroraPostgreResult> AuroraPostgres;
        public readonly ImmutableArray<Outputs.GetResourceResourceAuroraPostgresIamResult> AuroraPostgresIams;
        public readonly ImmutableArray<Outputs.GetResourceResourceAwResult> Aws;
        public readonly ImmutableArray<Outputs.GetResourceResourceAwsConsoleStaticKeyPairResult> AwsConsoleStaticKeyPairs;
        public readonly ImmutableArray<Outputs.GetResourceResourceAwsConsoleResult> AwsConsoles;
        public readonly ImmutableArray<Outputs.GetResourceResourceAzureCertificateResult> AzureCertificates;
        public readonly ImmutableArray<Outputs.GetResourceResourceAzureMysqlResult> AzureMysqls;
        public readonly ImmutableArray<Outputs.GetResourceResourceAzurePostgreResult> AzurePostgres;
        public readonly ImmutableArray<Outputs.GetResourceResourceAzurePostgresManagedIdentityResult> AzurePostgresManagedIdentities;
        public readonly ImmutableArray<Outputs.GetResourceResourceAzureResult> Azures;
        public readonly ImmutableArray<Outputs.GetResourceResourceBigQueryResult> BigQueries;
        public readonly ImmutableArray<Outputs.GetResourceResourceCassandraResult> Cassandras;
        public readonly ImmutableArray<Outputs.GetResourceResourceCitusResult> Cituses;
        public readonly ImmutableArray<Outputs.GetResourceResourceClustrixResult> Clustrixes;
        public readonly ImmutableArray<Outputs.GetResourceResourceCockroachResult> Cockroaches;
        public readonly ImmutableArray<Outputs.GetResourceResourceDb2IResult> Db2Is;
        public readonly ImmutableArray<Outputs.GetResourceResourceDb2LuwResult> Db2Luws;
        public readonly ImmutableArray<Outputs.GetResourceResourceDocumentDbHostResult> DocumentDbHosts;
        public readonly ImmutableArray<Outputs.GetResourceResourceDocumentDbReplicaSetResult> DocumentDbReplicaSets;
        public readonly ImmutableArray<Outputs.GetResourceResourceDruidResult> Druids;
        public readonly ImmutableArray<Outputs.GetResourceResourceDynamoDbResult> DynamoDbs;
        public readonly ImmutableArray<Outputs.GetResourceResourceElasticacheRediResult> ElasticacheRedis;
        public readonly ImmutableArray<Outputs.GetResourceResourceElasticResult> Elastics;
        public readonly ImmutableArray<Outputs.GetResourceResourceGcpResult> Gcps;
        public readonly ImmutableArray<Outputs.GetResourceResourceGoogleGkeUserImpersonationResult> GoogleGkeUserImpersonations;
        public readonly ImmutableArray<Outputs.GetResourceResourceGoogleGkeResult> GoogleGkes;
        public readonly ImmutableArray<Outputs.GetResourceResourceGreenplumResult> Greenplums;
        public readonly ImmutableArray<Outputs.GetResourceResourceHttpAuthResult> HttpAuths;
        public readonly ImmutableArray<Outputs.GetResourceResourceHttpBasicAuthResult> HttpBasicAuths;
        public readonly ImmutableArray<Outputs.GetResourceResourceHttpNoAuthResult> HttpNoAuths;
        public readonly ImmutableArray<Outputs.GetResourceResourceKuberneteResult> Kubernetes;
        public readonly ImmutableArray<Outputs.GetResourceResourceKubernetesBasicAuthResult> KubernetesBasicAuths;
        public readonly ImmutableArray<Outputs.GetResourceResourceKubernetesServiceAccountUserImpersonationResult> KubernetesServiceAccountUserImpersonations;
        public readonly ImmutableArray<Outputs.GetResourceResourceKubernetesServiceAccountResult> KubernetesServiceAccounts;
        public readonly ImmutableArray<Outputs.GetResourceResourceKubernetesUserImpersonationResult> KubernetesUserImpersonations;
        public readonly ImmutableArray<Outputs.GetResourceResourceMariaResult> Marias;
        public readonly ImmutableArray<Outputs.GetResourceResourceMemcachedResult> Memcacheds;
        public readonly ImmutableArray<Outputs.GetResourceResourceMemsqlResult> Memsqls;
        public readonly ImmutableArray<Outputs.GetResourceResourceMongoHostResult> MongoHosts;
        public readonly ImmutableArray<Outputs.GetResourceResourceMongoLegacyHostResult> MongoLegacyHosts;
        public readonly ImmutableArray<Outputs.GetResourceResourceMongoLegacyReplicasetResult> MongoLegacyReplicasets;
        public readonly ImmutableArray<Outputs.GetResourceResourceMongoReplicaSetResult> MongoReplicaSets;
        public readonly ImmutableArray<Outputs.GetResourceResourceMongoShardedClusterResult> MongoShardedClusters;
        public readonly ImmutableArray<Outputs.GetResourceResourceMtlsMysqlResult> MtlsMysqls;
        public readonly ImmutableArray<Outputs.GetResourceResourceMtlsPostgreResult> MtlsPostgres;
        public readonly ImmutableArray<Outputs.GetResourceResourceMysqlResult> Mysqls;
        public readonly ImmutableArray<Outputs.GetResourceResourceNeptuneIamResult> NeptuneIams;
        public readonly ImmutableArray<Outputs.GetResourceResourceNeptuneResult> Neptunes;
        public readonly ImmutableArray<Outputs.GetResourceResourceOracleResult> Oracles;
        public readonly ImmutableArray<Outputs.GetResourceResourcePostgreResult> Postgres;
        public readonly ImmutableArray<Outputs.GetResourceResourcePrestoResult> Prestos;
        public readonly ImmutableArray<Outputs.GetResourceResourceRabbitmqAmqp091Result> RabbitmqAmqp091s;
        public readonly ImmutableArray<Outputs.GetResourceResourceRawTcpResult> RawTcps;
        public readonly ImmutableArray<Outputs.GetResourceResourceRdpResult> Rdps;
        public readonly ImmutableArray<Outputs.GetResourceResourceRdsPostgresIamResult> RdsPostgresIams;
        public readonly ImmutableArray<Outputs.GetResourceResourceRediResult> Redis;
        public readonly ImmutableArray<Outputs.GetResourceResourceRedshiftResult> Redshifts;
        public readonly ImmutableArray<Outputs.GetResourceResourceSingleStoreResult> SingleStores;
        public readonly ImmutableArray<Outputs.GetResourceResourceSnowflakeResult> Snowflakes;
        public readonly ImmutableArray<Outputs.GetResourceResourceSnowsightResult> Snowsights;
        public readonly ImmutableArray<Outputs.GetResourceResourceSqlServerAzureAdResult> SqlServerAzureAds;
        public readonly ImmutableArray<Outputs.GetResourceResourceSqlServerKerberosAdResult> SqlServerKerberosAds;
        public readonly ImmutableArray<Outputs.GetResourceResourceSqlServerResult> SqlServers;
        public readonly ImmutableArray<Outputs.GetResourceResourceSshCertResult> SshCerts;
        public readonly ImmutableArray<Outputs.GetResourceResourceSshCustomerKeyResult> SshCustomerKeys;
        public readonly ImmutableArray<Outputs.GetResourceResourceSshResult> Sshes;
        public readonly ImmutableArray<Outputs.GetResourceResourceSybaseIqResult> SybaseIqs;
        public readonly ImmutableArray<Outputs.GetResourceResourceSybaseResult> Sybases;
        public readonly ImmutableArray<Outputs.GetResourceResourceTeradataResult> Teradatas;
        public readonly ImmutableArray<Outputs.GetResourceResourceTrinoResult> Trinos;

        [OutputConstructor]
        private GetResourceResourceResult(
            ImmutableArray<Outputs.GetResourceResourceAkResult> aks,

            ImmutableArray<Outputs.GetResourceResourceAksBasicAuthResult> aksBasicAuths,

            ImmutableArray<Outputs.GetResourceResourceAksServiceAccountUserImpersonationResult> aksServiceAccountUserImpersonations,

            ImmutableArray<Outputs.GetResourceResourceAksServiceAccountResult> aksServiceAccounts,

            ImmutableArray<Outputs.GetResourceResourceAksUserImpersonationResult> aksUserImpersonations,

            ImmutableArray<Outputs.GetResourceResourceAmazonEkResult> amazonEks,

            ImmutableArray<Outputs.GetResourceResourceAmazonEksInstanceProfileUserImpersonationResult> amazonEksInstanceProfileUserImpersonations,

            ImmutableArray<Outputs.GetResourceResourceAmazonEksInstanceProfileResult> amazonEksInstanceProfiles,

            ImmutableArray<Outputs.GetResourceResourceAmazonEksUserImpersonationResult> amazonEksUserImpersonations,

            ImmutableArray<Outputs.GetResourceResourceAmazonEResult> amazonEs,

            ImmutableArray<Outputs.GetResourceResourceAmazonmqAmqp091Result> amazonmqAmqp091s,

            ImmutableArray<Outputs.GetResourceResourceAthenaResult> athenas,

            ImmutableArray<Outputs.GetResourceResourceAuroraMysqlResult> auroraMysqls,

            ImmutableArray<Outputs.GetResourceResourceAuroraPostgreResult> auroraPostgres,

            ImmutableArray<Outputs.GetResourceResourceAuroraPostgresIamResult> auroraPostgresIams,

            ImmutableArray<Outputs.GetResourceResourceAwResult> aws,

            ImmutableArray<Outputs.GetResourceResourceAwsConsoleStaticKeyPairResult> awsConsoleStaticKeyPairs,

            ImmutableArray<Outputs.GetResourceResourceAwsConsoleResult> awsConsoles,

            ImmutableArray<Outputs.GetResourceResourceAzureCertificateResult> azureCertificates,

            ImmutableArray<Outputs.GetResourceResourceAzureMysqlResult> azureMysqls,

            ImmutableArray<Outputs.GetResourceResourceAzurePostgreResult> azurePostgres,

            ImmutableArray<Outputs.GetResourceResourceAzurePostgresManagedIdentityResult> azurePostgresManagedIdentities,

            ImmutableArray<Outputs.GetResourceResourceAzureResult> azures,

            ImmutableArray<Outputs.GetResourceResourceBigQueryResult> bigQueries,

            ImmutableArray<Outputs.GetResourceResourceCassandraResult> cassandras,

            ImmutableArray<Outputs.GetResourceResourceCitusResult> cituses,

            ImmutableArray<Outputs.GetResourceResourceClustrixResult> clustrixes,

            ImmutableArray<Outputs.GetResourceResourceCockroachResult> cockroaches,

            ImmutableArray<Outputs.GetResourceResourceDb2IResult> db2Is,

            ImmutableArray<Outputs.GetResourceResourceDb2LuwResult> db2Luws,

            ImmutableArray<Outputs.GetResourceResourceDocumentDbHostResult> documentDbHosts,

            ImmutableArray<Outputs.GetResourceResourceDocumentDbReplicaSetResult> documentDbReplicaSets,

            ImmutableArray<Outputs.GetResourceResourceDruidResult> druids,

            ImmutableArray<Outputs.GetResourceResourceDynamoDbResult> dynamoDbs,

            ImmutableArray<Outputs.GetResourceResourceElasticacheRediResult> elasticacheRedis,

            ImmutableArray<Outputs.GetResourceResourceElasticResult> elastics,

            ImmutableArray<Outputs.GetResourceResourceGcpResult> gcps,

            ImmutableArray<Outputs.GetResourceResourceGoogleGkeUserImpersonationResult> googleGkeUserImpersonations,

            ImmutableArray<Outputs.GetResourceResourceGoogleGkeResult> googleGkes,

            ImmutableArray<Outputs.GetResourceResourceGreenplumResult> greenplums,

            ImmutableArray<Outputs.GetResourceResourceHttpAuthResult> httpAuths,

            ImmutableArray<Outputs.GetResourceResourceHttpBasicAuthResult> httpBasicAuths,

            ImmutableArray<Outputs.GetResourceResourceHttpNoAuthResult> httpNoAuths,

            ImmutableArray<Outputs.GetResourceResourceKuberneteResult> kubernetes,

            ImmutableArray<Outputs.GetResourceResourceKubernetesBasicAuthResult> kubernetesBasicAuths,

            ImmutableArray<Outputs.GetResourceResourceKubernetesServiceAccountUserImpersonationResult> kubernetesServiceAccountUserImpersonations,

            ImmutableArray<Outputs.GetResourceResourceKubernetesServiceAccountResult> kubernetesServiceAccounts,

            ImmutableArray<Outputs.GetResourceResourceKubernetesUserImpersonationResult> kubernetesUserImpersonations,

            ImmutableArray<Outputs.GetResourceResourceMariaResult> marias,

            ImmutableArray<Outputs.GetResourceResourceMemcachedResult> memcacheds,

            ImmutableArray<Outputs.GetResourceResourceMemsqlResult> memsqls,

            ImmutableArray<Outputs.GetResourceResourceMongoHostResult> mongoHosts,

            ImmutableArray<Outputs.GetResourceResourceMongoLegacyHostResult> mongoLegacyHosts,

            ImmutableArray<Outputs.GetResourceResourceMongoLegacyReplicasetResult> mongoLegacyReplicasets,

            ImmutableArray<Outputs.GetResourceResourceMongoReplicaSetResult> mongoReplicaSets,

            ImmutableArray<Outputs.GetResourceResourceMongoShardedClusterResult> mongoShardedClusters,

            ImmutableArray<Outputs.GetResourceResourceMtlsMysqlResult> mtlsMysqls,

            ImmutableArray<Outputs.GetResourceResourceMtlsPostgreResult> mtlsPostgres,

            ImmutableArray<Outputs.GetResourceResourceMysqlResult> mysqls,

            ImmutableArray<Outputs.GetResourceResourceNeptuneIamResult> neptuneIams,

            ImmutableArray<Outputs.GetResourceResourceNeptuneResult> neptunes,

            ImmutableArray<Outputs.GetResourceResourceOracleResult> oracles,

            ImmutableArray<Outputs.GetResourceResourcePostgreResult> postgres,

            ImmutableArray<Outputs.GetResourceResourcePrestoResult> prestos,

            ImmutableArray<Outputs.GetResourceResourceRabbitmqAmqp091Result> rabbitmqAmqp091s,

            ImmutableArray<Outputs.GetResourceResourceRawTcpResult> rawTcps,

            ImmutableArray<Outputs.GetResourceResourceRdpResult> rdps,

            ImmutableArray<Outputs.GetResourceResourceRdsPostgresIamResult> rdsPostgresIams,

            ImmutableArray<Outputs.GetResourceResourceRediResult> redis,

            ImmutableArray<Outputs.GetResourceResourceRedshiftResult> redshifts,

            ImmutableArray<Outputs.GetResourceResourceSingleStoreResult> singleStores,

            ImmutableArray<Outputs.GetResourceResourceSnowflakeResult> snowflakes,

            ImmutableArray<Outputs.GetResourceResourceSnowsightResult> snowsights,

            ImmutableArray<Outputs.GetResourceResourceSqlServerAzureAdResult> sqlServerAzureAds,

            ImmutableArray<Outputs.GetResourceResourceSqlServerKerberosAdResult> sqlServerKerberosAds,

            ImmutableArray<Outputs.GetResourceResourceSqlServerResult> sqlServers,

            ImmutableArray<Outputs.GetResourceResourceSshCertResult> sshCerts,

            ImmutableArray<Outputs.GetResourceResourceSshCustomerKeyResult> sshCustomerKeys,

            ImmutableArray<Outputs.GetResourceResourceSshResult> sshes,

            ImmutableArray<Outputs.GetResourceResourceSybaseIqResult> sybaseIqs,

            ImmutableArray<Outputs.GetResourceResourceSybaseResult> sybases,

            ImmutableArray<Outputs.GetResourceResourceTeradataResult> teradatas,

            ImmutableArray<Outputs.GetResourceResourceTrinoResult> trinos)
        {
            Aks = aks;
            AksBasicAuths = aksBasicAuths;
            AksServiceAccountUserImpersonations = aksServiceAccountUserImpersonations;
            AksServiceAccounts = aksServiceAccounts;
            AksUserImpersonations = aksUserImpersonations;
            AmazonEks = amazonEks;
            AmazonEksInstanceProfileUserImpersonations = amazonEksInstanceProfileUserImpersonations;
            AmazonEksInstanceProfiles = amazonEksInstanceProfiles;
            AmazonEksUserImpersonations = amazonEksUserImpersonations;
            AmazonEs = amazonEs;
            AmazonmqAmqp091s = amazonmqAmqp091s;
            Athenas = athenas;
            AuroraMysqls = auroraMysqls;
            AuroraPostgres = auroraPostgres;
            AuroraPostgresIams = auroraPostgresIams;
            Aws = aws;
            AwsConsoleStaticKeyPairs = awsConsoleStaticKeyPairs;
            AwsConsoles = awsConsoles;
            AzureCertificates = azureCertificates;
            AzureMysqls = azureMysqls;
            AzurePostgres = azurePostgres;
            AzurePostgresManagedIdentities = azurePostgresManagedIdentities;
            Azures = azures;
            BigQueries = bigQueries;
            Cassandras = cassandras;
            Cituses = cituses;
            Clustrixes = clustrixes;
            Cockroaches = cockroaches;
            Db2Is = db2Is;
            Db2Luws = db2Luws;
            DocumentDbHosts = documentDbHosts;
            DocumentDbReplicaSets = documentDbReplicaSets;
            Druids = druids;
            DynamoDbs = dynamoDbs;
            ElasticacheRedis = elasticacheRedis;
            Elastics = elastics;
            Gcps = gcps;
            GoogleGkeUserImpersonations = googleGkeUserImpersonations;
            GoogleGkes = googleGkes;
            Greenplums = greenplums;
            HttpAuths = httpAuths;
            HttpBasicAuths = httpBasicAuths;
            HttpNoAuths = httpNoAuths;
            Kubernetes = kubernetes;
            KubernetesBasicAuths = kubernetesBasicAuths;
            KubernetesServiceAccountUserImpersonations = kubernetesServiceAccountUserImpersonations;
            KubernetesServiceAccounts = kubernetesServiceAccounts;
            KubernetesUserImpersonations = kubernetesUserImpersonations;
            Marias = marias;
            Memcacheds = memcacheds;
            Memsqls = memsqls;
            MongoHosts = mongoHosts;
            MongoLegacyHosts = mongoLegacyHosts;
            MongoLegacyReplicasets = mongoLegacyReplicasets;
            MongoReplicaSets = mongoReplicaSets;
            MongoShardedClusters = mongoShardedClusters;
            MtlsMysqls = mtlsMysqls;
            MtlsPostgres = mtlsPostgres;
            Mysqls = mysqls;
            NeptuneIams = neptuneIams;
            Neptunes = neptunes;
            Oracles = oracles;
            Postgres = postgres;
            Prestos = prestos;
            RabbitmqAmqp091s = rabbitmqAmqp091s;
            RawTcps = rawTcps;
            Rdps = rdps;
            RdsPostgresIams = rdsPostgresIams;
            Redis = redis;
            Redshifts = redshifts;
            SingleStores = singleStores;
            Snowflakes = snowflakes;
            Snowsights = snowsights;
            SqlServerAzureAds = sqlServerAzureAds;
            SqlServerKerberosAds = sqlServerKerberosAds;
            SqlServers = sqlServers;
            SshCerts = sshCerts;
            SshCustomerKeys = sshCustomerKeys;
            Sshes = sshes;
            SybaseIqs = sybaseIqs;
            Sybases = sybases;
            Teradatas = teradatas;
            Trinos = trinos;
        }
    }
}
