// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Sdm
{
    /// <summary>
    /// ## Import
    /// 
    /// A Resource can be imported using the id, e.g.,
    /// 
    /// ```sh
    /// $ pulumi import sdm:index/resource:Resource example rs-12345678
    /// ```
    /// </summary>
    [SdmResourceType("sdm:index/resource:Resource")]
    public partial class Resource : global::Pulumi.CustomResource
    {
        [Output("aks")]
        public Output<Outputs.ResourceAks?> Aks { get; private set; } = null!;

        /// <summary>
        /// AKSBasicAuth is currently unstable, and its API may change, or it may be removed, without a major version bump.
        /// </summary>
        [Output("aksBasicAuth")]
        public Output<Outputs.ResourceAksBasicAuth?> AksBasicAuth { get; private set; } = null!;

        [Output("aksServiceAccount")]
        public Output<Outputs.ResourceAksServiceAccount?> AksServiceAccount { get; private set; } = null!;

        [Output("aksServiceAccountUserImpersonation")]
        public Output<Outputs.ResourceAksServiceAccountUserImpersonation?> AksServiceAccountUserImpersonation { get; private set; } = null!;

        [Output("aksUserImpersonation")]
        public Output<Outputs.ResourceAksUserImpersonation?> AksUserImpersonation { get; private set; } = null!;

        [Output("amazonEks")]
        public Output<Outputs.ResourceAmazonEks?> AmazonEks { get; private set; } = null!;

        [Output("amazonEksInstanceProfile")]
        public Output<Outputs.ResourceAmazonEksInstanceProfile?> AmazonEksInstanceProfile { get; private set; } = null!;

        [Output("amazonEksInstanceProfileUserImpersonation")]
        public Output<Outputs.ResourceAmazonEksInstanceProfileUserImpersonation?> AmazonEksInstanceProfileUserImpersonation { get; private set; } = null!;

        [Output("amazonEksUserImpersonation")]
        public Output<Outputs.ResourceAmazonEksUserImpersonation?> AmazonEksUserImpersonation { get; private set; } = null!;

        [Output("amazonEs")]
        public Output<Outputs.ResourceAmazonEs?> AmazonEs { get; private set; } = null!;

        [Output("amazonmqAmqp091")]
        public Output<Outputs.ResourceAmazonmqAmqp091?> AmazonmqAmqp091 { get; private set; } = null!;

        [Output("athena")]
        public Output<Outputs.ResourceAthena?> Athena { get; private set; } = null!;

        [Output("auroraMysql")]
        public Output<Outputs.ResourceAuroraMysql?> AuroraMysql { get; private set; } = null!;

        [Output("auroraPostgres")]
        public Output<Outputs.ResourceAuroraPostgres?> AuroraPostgres { get; private set; } = null!;

        [Output("auroraPostgresIam")]
        public Output<Outputs.ResourceAuroraPostgresIam?> AuroraPostgresIam { get; private set; } = null!;

        [Output("aws")]
        public Output<Outputs.ResourceAws?> Aws { get; private set; } = null!;

        [Output("awsConsole")]
        public Output<Outputs.ResourceAwsConsole?> AwsConsole { get; private set; } = null!;

        [Output("awsConsoleStaticKeyPair")]
        public Output<Outputs.ResourceAwsConsoleStaticKeyPair?> AwsConsoleStaticKeyPair { get; private set; } = null!;

        [Output("azure")]
        public Output<Outputs.ResourceAzure?> Azure { get; private set; } = null!;

        [Output("azureCertificate")]
        public Output<Outputs.ResourceAzureCertificate?> AzureCertificate { get; private set; } = null!;

        [Output("azureMysql")]
        public Output<Outputs.ResourceAzureMysql?> AzureMysql { get; private set; } = null!;

        [Output("azurePostgres")]
        public Output<Outputs.ResourceAzurePostgres?> AzurePostgres { get; private set; } = null!;

        [Output("azurePostgresManagedIdentity")]
        public Output<Outputs.ResourceAzurePostgresManagedIdentity?> AzurePostgresManagedIdentity { get; private set; } = null!;

        [Output("bigQuery")]
        public Output<Outputs.ResourceBigQuery?> BigQuery { get; private set; } = null!;

        [Output("cassandra")]
        public Output<Outputs.ResourceCassandra?> Cassandra { get; private set; } = null!;

        [Output("citus")]
        public Output<Outputs.ResourceCitus?> Citus { get; private set; } = null!;

        [Output("clustrix")]
        public Output<Outputs.ResourceClustrix?> Clustrix { get; private set; } = null!;

        [Output("cockroach")]
        public Output<Outputs.ResourceCockroach?> Cockroach { get; private set; } = null!;

        [Output("db2I")]
        public Output<Outputs.ResourceDb2I?> Db2I { get; private set; } = null!;

        [Output("db2Luw")]
        public Output<Outputs.ResourceDb2Luw?> Db2Luw { get; private set; } = null!;

        [Output("documentDbHost")]
        public Output<Outputs.ResourceDocumentDbHost?> DocumentDbHost { get; private set; } = null!;

        [Output("documentDbReplicaSet")]
        public Output<Outputs.ResourceDocumentDbReplicaSet?> DocumentDbReplicaSet { get; private set; } = null!;

        [Output("druid")]
        public Output<Outputs.ResourceDruid?> Druid { get; private set; } = null!;

        [Output("dynamoDb")]
        public Output<Outputs.ResourceDynamoDb?> DynamoDb { get; private set; } = null!;

        [Output("elastic")]
        public Output<Outputs.ResourceElastic?> Elastic { get; private set; } = null!;

        [Output("elasticacheRedis")]
        public Output<Outputs.ResourceElasticacheRedis?> ElasticacheRedis { get; private set; } = null!;

        [Output("gcp")]
        public Output<Outputs.ResourceGcp?> Gcp { get; private set; } = null!;

        [Output("googleGke")]
        public Output<Outputs.ResourceGoogleGke?> GoogleGke { get; private set; } = null!;

        [Output("googleGkeUserImpersonation")]
        public Output<Outputs.ResourceGoogleGkeUserImpersonation?> GoogleGkeUserImpersonation { get; private set; } = null!;

        [Output("greenplum")]
        public Output<Outputs.ResourceGreenplum?> Greenplum { get; private set; } = null!;

        [Output("httpAuth")]
        public Output<Outputs.ResourceHttpAuth?> HttpAuth { get; private set; } = null!;

        [Output("httpBasicAuth")]
        public Output<Outputs.ResourceHttpBasicAuth?> HttpBasicAuth { get; private set; } = null!;

        [Output("httpNoAuth")]
        public Output<Outputs.ResourceHttpNoAuth?> HttpNoAuth { get; private set; } = null!;

        [Output("kubernetes")]
        public Output<Outputs.ResourceKubernetes?> Kubernetes { get; private set; } = null!;

        /// <summary>
        /// KubernetesBasicAuth is currently unstable, and its API may change, or it may be removed, without a major version bump.
        /// </summary>
        [Output("kubernetesBasicAuth")]
        public Output<Outputs.ResourceKubernetesBasicAuth?> KubernetesBasicAuth { get; private set; } = null!;

        [Output("kubernetesServiceAccount")]
        public Output<Outputs.ResourceKubernetesServiceAccount?> KubernetesServiceAccount { get; private set; } = null!;

        [Output("kubernetesServiceAccountUserImpersonation")]
        public Output<Outputs.ResourceKubernetesServiceAccountUserImpersonation?> KubernetesServiceAccountUserImpersonation { get; private set; } = null!;

        [Output("kubernetesUserImpersonation")]
        public Output<Outputs.ResourceKubernetesUserImpersonation?> KubernetesUserImpersonation { get; private set; } = null!;

        [Output("maria")]
        public Output<Outputs.ResourceMaria?> Maria { get; private set; } = null!;

        [Output("memcached")]
        public Output<Outputs.ResourceMemcached?> Memcached { get; private set; } = null!;

        [Output("memsql")]
        public Output<Outputs.ResourceMemsql?> Memsql { get; private set; } = null!;

        [Output("mongoHost")]
        public Output<Outputs.ResourceMongoHost?> MongoHost { get; private set; } = null!;

        /// <summary>
        /// MongoLegacyHost is currently unstable, and its API may change, or it may be removed, without a major version bump.
        /// </summary>
        [Output("mongoLegacyHost")]
        public Output<Outputs.ResourceMongoLegacyHost?> MongoLegacyHost { get; private set; } = null!;

        /// <summary>
        /// MongoLegacyReplicaset is currently unstable, and its API may change, or it may be removed, without a major version bump.
        /// </summary>
        [Output("mongoLegacyReplicaset")]
        public Output<Outputs.ResourceMongoLegacyReplicaset?> MongoLegacyReplicaset { get; private set; } = null!;

        [Output("mongoReplicaSet")]
        public Output<Outputs.ResourceMongoReplicaSet?> MongoReplicaSet { get; private set; } = null!;

        [Output("mongoShardedCluster")]
        public Output<Outputs.ResourceMongoShardedCluster?> MongoShardedCluster { get; private set; } = null!;

        /// <summary>
        /// MTLSMysql is currently unstable, and its API may change, or it may be removed, without a major version bump.
        /// </summary>
        [Output("mtlsMysql")]
        public Output<Outputs.ResourceMtlsMysql?> MtlsMysql { get; private set; } = null!;

        [Output("mtlsPostgres")]
        public Output<Outputs.ResourceMtlsPostgres?> MtlsPostgres { get; private set; } = null!;

        [Output("mysql")]
        public Output<Outputs.ResourceMysql?> Mysql { get; private set; } = null!;

        [Output("neptune")]
        public Output<Outputs.ResourceNeptune?> Neptune { get; private set; } = null!;

        [Output("neptuneIam")]
        public Output<Outputs.ResourceNeptuneIam?> NeptuneIam { get; private set; } = null!;

        [Output("oracle")]
        public Output<Outputs.ResourceOracle?> Oracle { get; private set; } = null!;

        [Output("postgres")]
        public Output<Outputs.ResourcePostgres?> Postgres { get; private set; } = null!;

        [Output("presto")]
        public Output<Outputs.ResourcePresto?> Presto { get; private set; } = null!;

        [Output("rabbitmqAmqp091")]
        public Output<Outputs.ResourceRabbitmqAmqp091?> RabbitmqAmqp091 { get; private set; } = null!;

        [Output("rawTcp")]
        public Output<Outputs.ResourceRawTcp?> RawTcp { get; private set; } = null!;

        [Output("rdp")]
        public Output<Outputs.ResourceRdp?> Rdp { get; private set; } = null!;

        [Output("rdpCert")]
        public Output<Outputs.ResourceRdpCert?> RdpCert { get; private set; } = null!;

        [Output("rdsPostgresIam")]
        public Output<Outputs.ResourceRdsPostgresIam?> RdsPostgresIam { get; private set; } = null!;

        [Output("redis")]
        public Output<Outputs.ResourceRedis?> Redis { get; private set; } = null!;

        [Output("redshift")]
        public Output<Outputs.ResourceRedshift?> Redshift { get; private set; } = null!;

        [Output("singleStore")]
        public Output<Outputs.ResourceSingleStore?> SingleStore { get; private set; } = null!;

        [Output("snowflake")]
        public Output<Outputs.ResourceSnowflake?> Snowflake { get; private set; } = null!;

        [Output("snowsight")]
        public Output<Outputs.ResourceSnowsight?> Snowsight { get; private set; } = null!;

        [Output("sqlServer")]
        public Output<Outputs.ResourceSqlServer?> SqlServer { get; private set; } = null!;

        [Output("sqlServerAzureAd")]
        public Output<Outputs.ResourceSqlServerAzureAd?> SqlServerAzureAd { get; private set; } = null!;

        [Output("sqlServerKerberosAd")]
        public Output<Outputs.ResourceSqlServerKerberosAd?> SqlServerKerberosAd { get; private set; } = null!;

        [Output("ssh")]
        public Output<Outputs.ResourceSsh?> Ssh { get; private set; } = null!;

        [Output("sshCert")]
        public Output<Outputs.ResourceSshCert?> SshCert { get; private set; } = null!;

        [Output("sshCustomerKey")]
        public Output<Outputs.ResourceSshCustomerKey?> SshCustomerKey { get; private set; } = null!;

        /// <summary>
        /// SSHPassword is currently unstable, and its API may change, or it may be removed, without a major version bump.
        /// </summary>
        [Output("sshPassword")]
        public Output<Outputs.ResourceSshPassword?> SshPassword { get; private set; } = null!;

        [Output("sybase")]
        public Output<Outputs.ResourceSybase?> Sybase { get; private set; } = null!;

        [Output("sybaseIq")]
        public Output<Outputs.ResourceSybaseIq?> SybaseIq { get; private set; } = null!;

        [Output("teradata")]
        public Output<Outputs.ResourceTeradata?> Teradata { get; private set; } = null!;

        /// <summary>
        /// Trino is currently unstable, and its API may change, or it may be removed, without a major version bump.
        /// </summary>
        [Output("trino")]
        public Output<Outputs.ResourceTrino?> Trino { get; private set; } = null!;


        /// <summary>
        /// Create a Resource resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Resource(string name, ResourceArgs? args = null, CustomResourceOptions? options = null)
            : base("sdm:index/resource:Resource", name, args ?? new ResourceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Resource(string name, Input<string> id, ResourceState? state = null, CustomResourceOptions? options = null)
            : base("sdm:index/resource:Resource", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/pierskarsenbarg/pulumi-sdm",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Resource resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Resource Get(string name, Input<string> id, ResourceState? state = null, CustomResourceOptions? options = null)
        {
            return new Resource(name, id, state, options);
        }
    }

    public sealed class ResourceArgs : global::Pulumi.ResourceArgs
    {
        [Input("aks")]
        public Input<Inputs.ResourceAksArgs>? Aks { get; set; }

        /// <summary>
        /// AKSBasicAuth is currently unstable, and its API may change, or it may be removed, without a major version bump.
        /// </summary>
        [Input("aksBasicAuth")]
        public Input<Inputs.ResourceAksBasicAuthArgs>? AksBasicAuth { get; set; }

        [Input("aksServiceAccount")]
        public Input<Inputs.ResourceAksServiceAccountArgs>? AksServiceAccount { get; set; }

        [Input("aksServiceAccountUserImpersonation")]
        public Input<Inputs.ResourceAksServiceAccountUserImpersonationArgs>? AksServiceAccountUserImpersonation { get; set; }

        [Input("aksUserImpersonation")]
        public Input<Inputs.ResourceAksUserImpersonationArgs>? AksUserImpersonation { get; set; }

        [Input("amazonEks")]
        public Input<Inputs.ResourceAmazonEksArgs>? AmazonEks { get; set; }

        [Input("amazonEksInstanceProfile")]
        public Input<Inputs.ResourceAmazonEksInstanceProfileArgs>? AmazonEksInstanceProfile { get; set; }

        [Input("amazonEksInstanceProfileUserImpersonation")]
        public Input<Inputs.ResourceAmazonEksInstanceProfileUserImpersonationArgs>? AmazonEksInstanceProfileUserImpersonation { get; set; }

        [Input("amazonEksUserImpersonation")]
        public Input<Inputs.ResourceAmazonEksUserImpersonationArgs>? AmazonEksUserImpersonation { get; set; }

        [Input("amazonEs")]
        public Input<Inputs.ResourceAmazonEsArgs>? AmazonEs { get; set; }

        [Input("amazonmqAmqp091")]
        public Input<Inputs.ResourceAmazonmqAmqp091Args>? AmazonmqAmqp091 { get; set; }

        [Input("athena")]
        public Input<Inputs.ResourceAthenaArgs>? Athena { get; set; }

        [Input("auroraMysql")]
        public Input<Inputs.ResourceAuroraMysqlArgs>? AuroraMysql { get; set; }

        [Input("auroraPostgres")]
        public Input<Inputs.ResourceAuroraPostgresArgs>? AuroraPostgres { get; set; }

        [Input("auroraPostgresIam")]
        public Input<Inputs.ResourceAuroraPostgresIamArgs>? AuroraPostgresIam { get; set; }

        [Input("aws")]
        public Input<Inputs.ResourceAwsArgs>? Aws { get; set; }

        [Input("awsConsole")]
        public Input<Inputs.ResourceAwsConsoleArgs>? AwsConsole { get; set; }

        [Input("awsConsoleStaticKeyPair")]
        public Input<Inputs.ResourceAwsConsoleStaticKeyPairArgs>? AwsConsoleStaticKeyPair { get; set; }

        [Input("azure")]
        public Input<Inputs.ResourceAzureArgs>? Azure { get; set; }

        [Input("azureCertificate")]
        public Input<Inputs.ResourceAzureCertificateArgs>? AzureCertificate { get; set; }

        [Input("azureMysql")]
        public Input<Inputs.ResourceAzureMysqlArgs>? AzureMysql { get; set; }

        [Input("azurePostgres")]
        public Input<Inputs.ResourceAzurePostgresArgs>? AzurePostgres { get; set; }

        [Input("azurePostgresManagedIdentity")]
        public Input<Inputs.ResourceAzurePostgresManagedIdentityArgs>? AzurePostgresManagedIdentity { get; set; }

        [Input("bigQuery")]
        public Input<Inputs.ResourceBigQueryArgs>? BigQuery { get; set; }

        [Input("cassandra")]
        public Input<Inputs.ResourceCassandraArgs>? Cassandra { get; set; }

        [Input("citus")]
        public Input<Inputs.ResourceCitusArgs>? Citus { get; set; }

        [Input("clustrix")]
        public Input<Inputs.ResourceClustrixArgs>? Clustrix { get; set; }

        [Input("cockroach")]
        public Input<Inputs.ResourceCockroachArgs>? Cockroach { get; set; }

        [Input("db2I")]
        public Input<Inputs.ResourceDb2IArgs>? Db2I { get; set; }

        [Input("db2Luw")]
        public Input<Inputs.ResourceDb2LuwArgs>? Db2Luw { get; set; }

        [Input("documentDbHost")]
        public Input<Inputs.ResourceDocumentDbHostArgs>? DocumentDbHost { get; set; }

        [Input("documentDbReplicaSet")]
        public Input<Inputs.ResourceDocumentDbReplicaSetArgs>? DocumentDbReplicaSet { get; set; }

        [Input("druid")]
        public Input<Inputs.ResourceDruidArgs>? Druid { get; set; }

        [Input("dynamoDb")]
        public Input<Inputs.ResourceDynamoDbArgs>? DynamoDb { get; set; }

        [Input("elastic")]
        public Input<Inputs.ResourceElasticArgs>? Elastic { get; set; }

        [Input("elasticacheRedis")]
        public Input<Inputs.ResourceElasticacheRedisArgs>? ElasticacheRedis { get; set; }

        [Input("gcp")]
        public Input<Inputs.ResourceGcpArgs>? Gcp { get; set; }

        [Input("googleGke")]
        public Input<Inputs.ResourceGoogleGkeArgs>? GoogleGke { get; set; }

        [Input("googleGkeUserImpersonation")]
        public Input<Inputs.ResourceGoogleGkeUserImpersonationArgs>? GoogleGkeUserImpersonation { get; set; }

        [Input("greenplum")]
        public Input<Inputs.ResourceGreenplumArgs>? Greenplum { get; set; }

        [Input("httpAuth")]
        public Input<Inputs.ResourceHttpAuthArgs>? HttpAuth { get; set; }

        [Input("httpBasicAuth")]
        public Input<Inputs.ResourceHttpBasicAuthArgs>? HttpBasicAuth { get; set; }

        [Input("httpNoAuth")]
        public Input<Inputs.ResourceHttpNoAuthArgs>? HttpNoAuth { get; set; }

        [Input("kubernetes")]
        public Input<Inputs.ResourceKubernetesArgs>? Kubernetes { get; set; }

        /// <summary>
        /// KubernetesBasicAuth is currently unstable, and its API may change, or it may be removed, without a major version bump.
        /// </summary>
        [Input("kubernetesBasicAuth")]
        public Input<Inputs.ResourceKubernetesBasicAuthArgs>? KubernetesBasicAuth { get; set; }

        [Input("kubernetesServiceAccount")]
        public Input<Inputs.ResourceKubernetesServiceAccountArgs>? KubernetesServiceAccount { get; set; }

        [Input("kubernetesServiceAccountUserImpersonation")]
        public Input<Inputs.ResourceKubernetesServiceAccountUserImpersonationArgs>? KubernetesServiceAccountUserImpersonation { get; set; }

        [Input("kubernetesUserImpersonation")]
        public Input<Inputs.ResourceKubernetesUserImpersonationArgs>? KubernetesUserImpersonation { get; set; }

        [Input("maria")]
        public Input<Inputs.ResourceMariaArgs>? Maria { get; set; }

        [Input("memcached")]
        public Input<Inputs.ResourceMemcachedArgs>? Memcached { get; set; }

        [Input("memsql")]
        public Input<Inputs.ResourceMemsqlArgs>? Memsql { get; set; }

        [Input("mongoHost")]
        public Input<Inputs.ResourceMongoHostArgs>? MongoHost { get; set; }

        /// <summary>
        /// MongoLegacyHost is currently unstable, and its API may change, or it may be removed, without a major version bump.
        /// </summary>
        [Input("mongoLegacyHost")]
        public Input<Inputs.ResourceMongoLegacyHostArgs>? MongoLegacyHost { get; set; }

        /// <summary>
        /// MongoLegacyReplicaset is currently unstable, and its API may change, or it may be removed, without a major version bump.
        /// </summary>
        [Input("mongoLegacyReplicaset")]
        public Input<Inputs.ResourceMongoLegacyReplicasetArgs>? MongoLegacyReplicaset { get; set; }

        [Input("mongoReplicaSet")]
        public Input<Inputs.ResourceMongoReplicaSetArgs>? MongoReplicaSet { get; set; }

        [Input("mongoShardedCluster")]
        public Input<Inputs.ResourceMongoShardedClusterArgs>? MongoShardedCluster { get; set; }

        /// <summary>
        /// MTLSMysql is currently unstable, and its API may change, or it may be removed, without a major version bump.
        /// </summary>
        [Input("mtlsMysql")]
        public Input<Inputs.ResourceMtlsMysqlArgs>? MtlsMysql { get; set; }

        [Input("mtlsPostgres")]
        public Input<Inputs.ResourceMtlsPostgresArgs>? MtlsPostgres { get; set; }

        [Input("mysql")]
        public Input<Inputs.ResourceMysqlArgs>? Mysql { get; set; }

        [Input("neptune")]
        public Input<Inputs.ResourceNeptuneArgs>? Neptune { get; set; }

        [Input("neptuneIam")]
        public Input<Inputs.ResourceNeptuneIamArgs>? NeptuneIam { get; set; }

        [Input("oracle")]
        public Input<Inputs.ResourceOracleArgs>? Oracle { get; set; }

        [Input("postgres")]
        public Input<Inputs.ResourcePostgresArgs>? Postgres { get; set; }

        [Input("presto")]
        public Input<Inputs.ResourcePrestoArgs>? Presto { get; set; }

        [Input("rabbitmqAmqp091")]
        public Input<Inputs.ResourceRabbitmqAmqp091Args>? RabbitmqAmqp091 { get; set; }

        [Input("rawTcp")]
        public Input<Inputs.ResourceRawTcpArgs>? RawTcp { get; set; }

        [Input("rdp")]
        public Input<Inputs.ResourceRdpArgs>? Rdp { get; set; }

        [Input("rdpCert")]
        public Input<Inputs.ResourceRdpCertArgs>? RdpCert { get; set; }

        [Input("rdsPostgresIam")]
        public Input<Inputs.ResourceRdsPostgresIamArgs>? RdsPostgresIam { get; set; }

        [Input("redis")]
        public Input<Inputs.ResourceRedisArgs>? Redis { get; set; }

        [Input("redshift")]
        public Input<Inputs.ResourceRedshiftArgs>? Redshift { get; set; }

        [Input("singleStore")]
        public Input<Inputs.ResourceSingleStoreArgs>? SingleStore { get; set; }

        [Input("snowflake")]
        public Input<Inputs.ResourceSnowflakeArgs>? Snowflake { get; set; }

        [Input("snowsight")]
        public Input<Inputs.ResourceSnowsightArgs>? Snowsight { get; set; }

        [Input("sqlServer")]
        public Input<Inputs.ResourceSqlServerArgs>? SqlServer { get; set; }

        [Input("sqlServerAzureAd")]
        public Input<Inputs.ResourceSqlServerAzureAdArgs>? SqlServerAzureAd { get; set; }

        [Input("sqlServerKerberosAd")]
        public Input<Inputs.ResourceSqlServerKerberosAdArgs>? SqlServerKerberosAd { get; set; }

        [Input("ssh")]
        public Input<Inputs.ResourceSshArgs>? Ssh { get; set; }

        [Input("sshCert")]
        public Input<Inputs.ResourceSshCertArgs>? SshCert { get; set; }

        [Input("sshCustomerKey")]
        public Input<Inputs.ResourceSshCustomerKeyArgs>? SshCustomerKey { get; set; }

        /// <summary>
        /// SSHPassword is currently unstable, and its API may change, or it may be removed, without a major version bump.
        /// </summary>
        [Input("sshPassword")]
        public Input<Inputs.ResourceSshPasswordArgs>? SshPassword { get; set; }

        [Input("sybase")]
        public Input<Inputs.ResourceSybaseArgs>? Sybase { get; set; }

        [Input("sybaseIq")]
        public Input<Inputs.ResourceSybaseIqArgs>? SybaseIq { get; set; }

        [Input("teradata")]
        public Input<Inputs.ResourceTeradataArgs>? Teradata { get; set; }

        /// <summary>
        /// Trino is currently unstable, and its API may change, or it may be removed, without a major version bump.
        /// </summary>
        [Input("trino")]
        public Input<Inputs.ResourceTrinoArgs>? Trino { get; set; }

        public ResourceArgs()
        {
        }
        public static new ResourceArgs Empty => new ResourceArgs();
    }

    public sealed class ResourceState : global::Pulumi.ResourceArgs
    {
        [Input("aks")]
        public Input<Inputs.ResourceAksGetArgs>? Aks { get; set; }

        /// <summary>
        /// AKSBasicAuth is currently unstable, and its API may change, or it may be removed, without a major version bump.
        /// </summary>
        [Input("aksBasicAuth")]
        public Input<Inputs.ResourceAksBasicAuthGetArgs>? AksBasicAuth { get; set; }

        [Input("aksServiceAccount")]
        public Input<Inputs.ResourceAksServiceAccountGetArgs>? AksServiceAccount { get; set; }

        [Input("aksServiceAccountUserImpersonation")]
        public Input<Inputs.ResourceAksServiceAccountUserImpersonationGetArgs>? AksServiceAccountUserImpersonation { get; set; }

        [Input("aksUserImpersonation")]
        public Input<Inputs.ResourceAksUserImpersonationGetArgs>? AksUserImpersonation { get; set; }

        [Input("amazonEks")]
        public Input<Inputs.ResourceAmazonEksGetArgs>? AmazonEks { get; set; }

        [Input("amazonEksInstanceProfile")]
        public Input<Inputs.ResourceAmazonEksInstanceProfileGetArgs>? AmazonEksInstanceProfile { get; set; }

        [Input("amazonEksInstanceProfileUserImpersonation")]
        public Input<Inputs.ResourceAmazonEksInstanceProfileUserImpersonationGetArgs>? AmazonEksInstanceProfileUserImpersonation { get; set; }

        [Input("amazonEksUserImpersonation")]
        public Input<Inputs.ResourceAmazonEksUserImpersonationGetArgs>? AmazonEksUserImpersonation { get; set; }

        [Input("amazonEs")]
        public Input<Inputs.ResourceAmazonEsGetArgs>? AmazonEs { get; set; }

        [Input("amazonmqAmqp091")]
        public Input<Inputs.ResourceAmazonmqAmqp091GetArgs>? AmazonmqAmqp091 { get; set; }

        [Input("athena")]
        public Input<Inputs.ResourceAthenaGetArgs>? Athena { get; set; }

        [Input("auroraMysql")]
        public Input<Inputs.ResourceAuroraMysqlGetArgs>? AuroraMysql { get; set; }

        [Input("auroraPostgres")]
        public Input<Inputs.ResourceAuroraPostgresGetArgs>? AuroraPostgres { get; set; }

        [Input("auroraPostgresIam")]
        public Input<Inputs.ResourceAuroraPostgresIamGetArgs>? AuroraPostgresIam { get; set; }

        [Input("aws")]
        public Input<Inputs.ResourceAwsGetArgs>? Aws { get; set; }

        [Input("awsConsole")]
        public Input<Inputs.ResourceAwsConsoleGetArgs>? AwsConsole { get; set; }

        [Input("awsConsoleStaticKeyPair")]
        public Input<Inputs.ResourceAwsConsoleStaticKeyPairGetArgs>? AwsConsoleStaticKeyPair { get; set; }

        [Input("azure")]
        public Input<Inputs.ResourceAzureGetArgs>? Azure { get; set; }

        [Input("azureCertificate")]
        public Input<Inputs.ResourceAzureCertificateGetArgs>? AzureCertificate { get; set; }

        [Input("azureMysql")]
        public Input<Inputs.ResourceAzureMysqlGetArgs>? AzureMysql { get; set; }

        [Input("azurePostgres")]
        public Input<Inputs.ResourceAzurePostgresGetArgs>? AzurePostgres { get; set; }

        [Input("azurePostgresManagedIdentity")]
        public Input<Inputs.ResourceAzurePostgresManagedIdentityGetArgs>? AzurePostgresManagedIdentity { get; set; }

        [Input("bigQuery")]
        public Input<Inputs.ResourceBigQueryGetArgs>? BigQuery { get; set; }

        [Input("cassandra")]
        public Input<Inputs.ResourceCassandraGetArgs>? Cassandra { get; set; }

        [Input("citus")]
        public Input<Inputs.ResourceCitusGetArgs>? Citus { get; set; }

        [Input("clustrix")]
        public Input<Inputs.ResourceClustrixGetArgs>? Clustrix { get; set; }

        [Input("cockroach")]
        public Input<Inputs.ResourceCockroachGetArgs>? Cockroach { get; set; }

        [Input("db2I")]
        public Input<Inputs.ResourceDb2IGetArgs>? Db2I { get; set; }

        [Input("db2Luw")]
        public Input<Inputs.ResourceDb2LuwGetArgs>? Db2Luw { get; set; }

        [Input("documentDbHost")]
        public Input<Inputs.ResourceDocumentDbHostGetArgs>? DocumentDbHost { get; set; }

        [Input("documentDbReplicaSet")]
        public Input<Inputs.ResourceDocumentDbReplicaSetGetArgs>? DocumentDbReplicaSet { get; set; }

        [Input("druid")]
        public Input<Inputs.ResourceDruidGetArgs>? Druid { get; set; }

        [Input("dynamoDb")]
        public Input<Inputs.ResourceDynamoDbGetArgs>? DynamoDb { get; set; }

        [Input("elastic")]
        public Input<Inputs.ResourceElasticGetArgs>? Elastic { get; set; }

        [Input("elasticacheRedis")]
        public Input<Inputs.ResourceElasticacheRedisGetArgs>? ElasticacheRedis { get; set; }

        [Input("gcp")]
        public Input<Inputs.ResourceGcpGetArgs>? Gcp { get; set; }

        [Input("googleGke")]
        public Input<Inputs.ResourceGoogleGkeGetArgs>? GoogleGke { get; set; }

        [Input("googleGkeUserImpersonation")]
        public Input<Inputs.ResourceGoogleGkeUserImpersonationGetArgs>? GoogleGkeUserImpersonation { get; set; }

        [Input("greenplum")]
        public Input<Inputs.ResourceGreenplumGetArgs>? Greenplum { get; set; }

        [Input("httpAuth")]
        public Input<Inputs.ResourceHttpAuthGetArgs>? HttpAuth { get; set; }

        [Input("httpBasicAuth")]
        public Input<Inputs.ResourceHttpBasicAuthGetArgs>? HttpBasicAuth { get; set; }

        [Input("httpNoAuth")]
        public Input<Inputs.ResourceHttpNoAuthGetArgs>? HttpNoAuth { get; set; }

        [Input("kubernetes")]
        public Input<Inputs.ResourceKubernetesGetArgs>? Kubernetes { get; set; }

        /// <summary>
        /// KubernetesBasicAuth is currently unstable, and its API may change, or it may be removed, without a major version bump.
        /// </summary>
        [Input("kubernetesBasicAuth")]
        public Input<Inputs.ResourceKubernetesBasicAuthGetArgs>? KubernetesBasicAuth { get; set; }

        [Input("kubernetesServiceAccount")]
        public Input<Inputs.ResourceKubernetesServiceAccountGetArgs>? KubernetesServiceAccount { get; set; }

        [Input("kubernetesServiceAccountUserImpersonation")]
        public Input<Inputs.ResourceKubernetesServiceAccountUserImpersonationGetArgs>? KubernetesServiceAccountUserImpersonation { get; set; }

        [Input("kubernetesUserImpersonation")]
        public Input<Inputs.ResourceKubernetesUserImpersonationGetArgs>? KubernetesUserImpersonation { get; set; }

        [Input("maria")]
        public Input<Inputs.ResourceMariaGetArgs>? Maria { get; set; }

        [Input("memcached")]
        public Input<Inputs.ResourceMemcachedGetArgs>? Memcached { get; set; }

        [Input("memsql")]
        public Input<Inputs.ResourceMemsqlGetArgs>? Memsql { get; set; }

        [Input("mongoHost")]
        public Input<Inputs.ResourceMongoHostGetArgs>? MongoHost { get; set; }

        /// <summary>
        /// MongoLegacyHost is currently unstable, and its API may change, or it may be removed, without a major version bump.
        /// </summary>
        [Input("mongoLegacyHost")]
        public Input<Inputs.ResourceMongoLegacyHostGetArgs>? MongoLegacyHost { get; set; }

        /// <summary>
        /// MongoLegacyReplicaset is currently unstable, and its API may change, or it may be removed, without a major version bump.
        /// </summary>
        [Input("mongoLegacyReplicaset")]
        public Input<Inputs.ResourceMongoLegacyReplicasetGetArgs>? MongoLegacyReplicaset { get; set; }

        [Input("mongoReplicaSet")]
        public Input<Inputs.ResourceMongoReplicaSetGetArgs>? MongoReplicaSet { get; set; }

        [Input("mongoShardedCluster")]
        public Input<Inputs.ResourceMongoShardedClusterGetArgs>? MongoShardedCluster { get; set; }

        /// <summary>
        /// MTLSMysql is currently unstable, and its API may change, or it may be removed, without a major version bump.
        /// </summary>
        [Input("mtlsMysql")]
        public Input<Inputs.ResourceMtlsMysqlGetArgs>? MtlsMysql { get; set; }

        [Input("mtlsPostgres")]
        public Input<Inputs.ResourceMtlsPostgresGetArgs>? MtlsPostgres { get; set; }

        [Input("mysql")]
        public Input<Inputs.ResourceMysqlGetArgs>? Mysql { get; set; }

        [Input("neptune")]
        public Input<Inputs.ResourceNeptuneGetArgs>? Neptune { get; set; }

        [Input("neptuneIam")]
        public Input<Inputs.ResourceNeptuneIamGetArgs>? NeptuneIam { get; set; }

        [Input("oracle")]
        public Input<Inputs.ResourceOracleGetArgs>? Oracle { get; set; }

        [Input("postgres")]
        public Input<Inputs.ResourcePostgresGetArgs>? Postgres { get; set; }

        [Input("presto")]
        public Input<Inputs.ResourcePrestoGetArgs>? Presto { get; set; }

        [Input("rabbitmqAmqp091")]
        public Input<Inputs.ResourceRabbitmqAmqp091GetArgs>? RabbitmqAmqp091 { get; set; }

        [Input("rawTcp")]
        public Input<Inputs.ResourceRawTcpGetArgs>? RawTcp { get; set; }

        [Input("rdp")]
        public Input<Inputs.ResourceRdpGetArgs>? Rdp { get; set; }

        [Input("rdpCert")]
        public Input<Inputs.ResourceRdpCertGetArgs>? RdpCert { get; set; }

        [Input("rdsPostgresIam")]
        public Input<Inputs.ResourceRdsPostgresIamGetArgs>? RdsPostgresIam { get; set; }

        [Input("redis")]
        public Input<Inputs.ResourceRedisGetArgs>? Redis { get; set; }

        [Input("redshift")]
        public Input<Inputs.ResourceRedshiftGetArgs>? Redshift { get; set; }

        [Input("singleStore")]
        public Input<Inputs.ResourceSingleStoreGetArgs>? SingleStore { get; set; }

        [Input("snowflake")]
        public Input<Inputs.ResourceSnowflakeGetArgs>? Snowflake { get; set; }

        [Input("snowsight")]
        public Input<Inputs.ResourceSnowsightGetArgs>? Snowsight { get; set; }

        [Input("sqlServer")]
        public Input<Inputs.ResourceSqlServerGetArgs>? SqlServer { get; set; }

        [Input("sqlServerAzureAd")]
        public Input<Inputs.ResourceSqlServerAzureAdGetArgs>? SqlServerAzureAd { get; set; }

        [Input("sqlServerKerberosAd")]
        public Input<Inputs.ResourceSqlServerKerberosAdGetArgs>? SqlServerKerberosAd { get; set; }

        [Input("ssh")]
        public Input<Inputs.ResourceSshGetArgs>? Ssh { get; set; }

        [Input("sshCert")]
        public Input<Inputs.ResourceSshCertGetArgs>? SshCert { get; set; }

        [Input("sshCustomerKey")]
        public Input<Inputs.ResourceSshCustomerKeyGetArgs>? SshCustomerKey { get; set; }

        /// <summary>
        /// SSHPassword is currently unstable, and its API may change, or it may be removed, without a major version bump.
        /// </summary>
        [Input("sshPassword")]
        public Input<Inputs.ResourceSshPasswordGetArgs>? SshPassword { get; set; }

        [Input("sybase")]
        public Input<Inputs.ResourceSybaseGetArgs>? Sybase { get; set; }

        [Input("sybaseIq")]
        public Input<Inputs.ResourceSybaseIqGetArgs>? SybaseIq { get; set; }

        [Input("teradata")]
        public Input<Inputs.ResourceTeradataGetArgs>? Teradata { get; set; }

        /// <summary>
        /// Trino is currently unstable, and its API may change, or it may be removed, without a major version bump.
        /// </summary>
        [Input("trino")]
        public Input<Inputs.ResourceTrinoGetArgs>? Trino { get; set; }

        public ResourceState()
        {
        }
        public static new ResourceState Empty => new ResourceState();
    }
}
