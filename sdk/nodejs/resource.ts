// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * ## Import
 *
 * A Resource can be imported using the id, e.g.,
 *
 * ```sh
 *  $ pulumi import sdm:index/resource:Resource example rs-12345678
 * ```
 */
export class Resource extends pulumi.CustomResource {
    /**
     * Get an existing Resource resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ResourceState, opts?: pulumi.CustomResourceOptions): Resource {
        return new Resource(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'sdm:index/resource:Resource';

    /**
     * Returns true if the given object is an instance of Resource.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Resource {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Resource.__pulumiType;
    }

    public readonly aks!: pulumi.Output<outputs.ResourceAks | undefined>;
    public readonly aksBasicAuth!: pulumi.Output<outputs.ResourceAksBasicAuth | undefined>;
    public readonly aksServiceAccount!: pulumi.Output<outputs.ResourceAksServiceAccount | undefined>;
    public readonly aksServiceAccountUserImpersonation!: pulumi.Output<outputs.ResourceAksServiceAccountUserImpersonation | undefined>;
    public readonly aksUserImpersonation!: pulumi.Output<outputs.ResourceAksUserImpersonation | undefined>;
    public readonly amazonEks!: pulumi.Output<outputs.ResourceAmazonEks | undefined>;
    public readonly amazonEksInstanceProfile!: pulumi.Output<outputs.ResourceAmazonEksInstanceProfile | undefined>;
    public readonly amazonEksInstanceProfileUserImpersonation!: pulumi.Output<outputs.ResourceAmazonEksInstanceProfileUserImpersonation | undefined>;
    public readonly amazonEksUserImpersonation!: pulumi.Output<outputs.ResourceAmazonEksUserImpersonation | undefined>;
    public readonly amazonEs!: pulumi.Output<outputs.ResourceAmazonEs | undefined>;
    public readonly amazonmqAmqp091!: pulumi.Output<outputs.ResourceAmazonmqAmqp091 | undefined>;
    public readonly athena!: pulumi.Output<outputs.ResourceAthena | undefined>;
    public readonly auroraMysql!: pulumi.Output<outputs.ResourceAuroraMysql | undefined>;
    public readonly auroraPostgres!: pulumi.Output<outputs.ResourceAuroraPostgres | undefined>;
    /**
     * AuroraPostgresIAM is currently unstable, and its API may change, or it may be removed, without a major version bump.
     */
    public readonly auroraPostgresIam!: pulumi.Output<outputs.ResourceAuroraPostgresIam | undefined>;
    public readonly aws!: pulumi.Output<outputs.ResourceAws | undefined>;
    public readonly awsConsole!: pulumi.Output<outputs.ResourceAwsConsole | undefined>;
    public readonly awsConsoleStaticKeyPair!: pulumi.Output<outputs.ResourceAwsConsoleStaticKeyPair | undefined>;
    public readonly azure!: pulumi.Output<outputs.ResourceAzure | undefined>;
    public readonly azureCertificate!: pulumi.Output<outputs.ResourceAzureCertificate | undefined>;
    public readonly azureMysql!: pulumi.Output<outputs.ResourceAzureMysql | undefined>;
    public readonly azurePostgres!: pulumi.Output<outputs.ResourceAzurePostgres | undefined>;
    public readonly azurePostgresManagedIdentity!: pulumi.Output<outputs.ResourceAzurePostgresManagedIdentity | undefined>;
    public readonly bigQuery!: pulumi.Output<outputs.ResourceBigQuery | undefined>;
    public readonly cassandra!: pulumi.Output<outputs.ResourceCassandra | undefined>;
    public readonly citus!: pulumi.Output<outputs.ResourceCitus | undefined>;
    public readonly clustrix!: pulumi.Output<outputs.ResourceClustrix | undefined>;
    public readonly cockroach!: pulumi.Output<outputs.ResourceCockroach | undefined>;
    public readonly db2I!: pulumi.Output<outputs.ResourceDb2I | undefined>;
    public readonly db2Luw!: pulumi.Output<outputs.ResourceDb2Luw | undefined>;
    public readonly documentDbHost!: pulumi.Output<outputs.ResourceDocumentDbHost | undefined>;
    public readonly documentDbReplicaSet!: pulumi.Output<outputs.ResourceDocumentDbReplicaSet | undefined>;
    public readonly druid!: pulumi.Output<outputs.ResourceDruid | undefined>;
    public readonly dynamoDb!: pulumi.Output<outputs.ResourceDynamoDb | undefined>;
    public readonly elastic!: pulumi.Output<outputs.ResourceElastic | undefined>;
    public readonly elasticacheRedis!: pulumi.Output<outputs.ResourceElasticacheRedis | undefined>;
    public readonly gcp!: pulumi.Output<outputs.ResourceGcp | undefined>;
    public readonly googleGke!: pulumi.Output<outputs.ResourceGoogleGke | undefined>;
    public readonly googleGkeUserImpersonation!: pulumi.Output<outputs.ResourceGoogleGkeUserImpersonation | undefined>;
    public readonly greenplum!: pulumi.Output<outputs.ResourceGreenplum | undefined>;
    public readonly httpAuth!: pulumi.Output<outputs.ResourceHttpAuth | undefined>;
    public readonly httpBasicAuth!: pulumi.Output<outputs.ResourceHttpBasicAuth | undefined>;
    public readonly httpNoAuth!: pulumi.Output<outputs.ResourceHttpNoAuth | undefined>;
    public readonly kubernetes!: pulumi.Output<outputs.ResourceKubernetes | undefined>;
    public readonly kubernetesBasicAuth!: pulumi.Output<outputs.ResourceKubernetesBasicAuth | undefined>;
    public readonly kubernetesServiceAccount!: pulumi.Output<outputs.ResourceKubernetesServiceAccount | undefined>;
    public readonly kubernetesServiceAccountUserImpersonation!: pulumi.Output<outputs.ResourceKubernetesServiceAccountUserImpersonation | undefined>;
    public readonly kubernetesUserImpersonation!: pulumi.Output<outputs.ResourceKubernetesUserImpersonation | undefined>;
    public readonly maria!: pulumi.Output<outputs.ResourceMaria | undefined>;
    public readonly memcached!: pulumi.Output<outputs.ResourceMemcached | undefined>;
    public readonly memsql!: pulumi.Output<outputs.ResourceMemsql | undefined>;
    /**
     * MongoHost is currently unstable, and its API may change, or it may be removed, without a major version bump.
     */
    public readonly mongoHost!: pulumi.Output<outputs.ResourceMongoHost | undefined>;
    public readonly mongoLegacyHost!: pulumi.Output<outputs.ResourceMongoLegacyHost | undefined>;
    public readonly mongoLegacyReplicaset!: pulumi.Output<outputs.ResourceMongoLegacyReplicaset | undefined>;
    /**
     * MongoReplicaSet is currently unstable, and its API may change, or it may be removed, without a major version bump.
     */
    public readonly mongoReplicaSet!: pulumi.Output<outputs.ResourceMongoReplicaSet | undefined>;
    /**
     * MongoShardedCluster is currently unstable, and its API may change, or it may be removed, without a major version bump.
     */
    public readonly mongoShardedCluster!: pulumi.Output<outputs.ResourceMongoShardedCluster | undefined>;
    /**
     * MTLSMysql is currently unstable, and its API may change, or it may be removed, without a major version bump.
     */
    public readonly mtlsMysql!: pulumi.Output<outputs.ResourceMtlsMysql | undefined>;
    public readonly mtlsPostgres!: pulumi.Output<outputs.ResourceMtlsPostgres | undefined>;
    public readonly mysql!: pulumi.Output<outputs.ResourceMysql | undefined>;
    public readonly neptune!: pulumi.Output<outputs.ResourceNeptune | undefined>;
    public readonly neptuneIam!: pulumi.Output<outputs.ResourceNeptuneIam | undefined>;
    public readonly oracle!: pulumi.Output<outputs.ResourceOracle | undefined>;
    public readonly postgres!: pulumi.Output<outputs.ResourcePostgres | undefined>;
    public readonly presto!: pulumi.Output<outputs.ResourcePresto | undefined>;
    public readonly rabbitmqAmqp091!: pulumi.Output<outputs.ResourceRabbitmqAmqp091 | undefined>;
    public readonly rawTcp!: pulumi.Output<outputs.ResourceRawTcp | undefined>;
    public readonly rdp!: pulumi.Output<outputs.ResourceRdp | undefined>;
    /**
     * RDSPostgresIAM is currently unstable, and its API may change, or it may be removed, without a major version bump.
     */
    public readonly rdsPostgresIam!: pulumi.Output<outputs.ResourceRdsPostgresIam | undefined>;
    public readonly redis!: pulumi.Output<outputs.ResourceRedis | undefined>;
    public readonly redshift!: pulumi.Output<outputs.ResourceRedshift | undefined>;
    public readonly singleStore!: pulumi.Output<outputs.ResourceSingleStore | undefined>;
    public readonly snowflake!: pulumi.Output<outputs.ResourceSnowflake | undefined>;
    public readonly snowsight!: pulumi.Output<outputs.ResourceSnowsight | undefined>;
    public readonly sqlServer!: pulumi.Output<outputs.ResourceSqlServer | undefined>;
    public readonly sqlServerAzureAd!: pulumi.Output<outputs.ResourceSqlServerAzureAd | undefined>;
    public readonly sqlServerKerberosAd!: pulumi.Output<outputs.ResourceSqlServerKerberosAd | undefined>;
    public readonly ssh!: pulumi.Output<outputs.ResourceSsh | undefined>;
    public readonly sshCert!: pulumi.Output<outputs.ResourceSshCert | undefined>;
    public readonly sshCustomerKey!: pulumi.Output<outputs.ResourceSshCustomerKey | undefined>;
    public readonly sybase!: pulumi.Output<outputs.ResourceSybase | undefined>;
    public readonly sybaseIq!: pulumi.Output<outputs.ResourceSybaseIq | undefined>;
    public readonly teradata!: pulumi.Output<outputs.ResourceTeradata | undefined>;
    /**
     * Trino is currently unstable, and its API may change, or it may be removed, without a major version bump.
     */
    public readonly trino!: pulumi.Output<outputs.ResourceTrino | undefined>;

    /**
     * Create a Resource resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: ResourceArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ResourceArgs | ResourceState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ResourceState | undefined;
            resourceInputs["aks"] = state ? state.aks : undefined;
            resourceInputs["aksBasicAuth"] = state ? state.aksBasicAuth : undefined;
            resourceInputs["aksServiceAccount"] = state ? state.aksServiceAccount : undefined;
            resourceInputs["aksServiceAccountUserImpersonation"] = state ? state.aksServiceAccountUserImpersonation : undefined;
            resourceInputs["aksUserImpersonation"] = state ? state.aksUserImpersonation : undefined;
            resourceInputs["amazonEks"] = state ? state.amazonEks : undefined;
            resourceInputs["amazonEksInstanceProfile"] = state ? state.amazonEksInstanceProfile : undefined;
            resourceInputs["amazonEksInstanceProfileUserImpersonation"] = state ? state.amazonEksInstanceProfileUserImpersonation : undefined;
            resourceInputs["amazonEksUserImpersonation"] = state ? state.amazonEksUserImpersonation : undefined;
            resourceInputs["amazonEs"] = state ? state.amazonEs : undefined;
            resourceInputs["amazonmqAmqp091"] = state ? state.amazonmqAmqp091 : undefined;
            resourceInputs["athena"] = state ? state.athena : undefined;
            resourceInputs["auroraMysql"] = state ? state.auroraMysql : undefined;
            resourceInputs["auroraPostgres"] = state ? state.auroraPostgres : undefined;
            resourceInputs["auroraPostgresIam"] = state ? state.auroraPostgresIam : undefined;
            resourceInputs["aws"] = state ? state.aws : undefined;
            resourceInputs["awsConsole"] = state ? state.awsConsole : undefined;
            resourceInputs["awsConsoleStaticKeyPair"] = state ? state.awsConsoleStaticKeyPair : undefined;
            resourceInputs["azure"] = state ? state.azure : undefined;
            resourceInputs["azureCertificate"] = state ? state.azureCertificate : undefined;
            resourceInputs["azureMysql"] = state ? state.azureMysql : undefined;
            resourceInputs["azurePostgres"] = state ? state.azurePostgres : undefined;
            resourceInputs["azurePostgresManagedIdentity"] = state ? state.azurePostgresManagedIdentity : undefined;
            resourceInputs["bigQuery"] = state ? state.bigQuery : undefined;
            resourceInputs["cassandra"] = state ? state.cassandra : undefined;
            resourceInputs["citus"] = state ? state.citus : undefined;
            resourceInputs["clustrix"] = state ? state.clustrix : undefined;
            resourceInputs["cockroach"] = state ? state.cockroach : undefined;
            resourceInputs["db2I"] = state ? state.db2I : undefined;
            resourceInputs["db2Luw"] = state ? state.db2Luw : undefined;
            resourceInputs["documentDbHost"] = state ? state.documentDbHost : undefined;
            resourceInputs["documentDbReplicaSet"] = state ? state.documentDbReplicaSet : undefined;
            resourceInputs["druid"] = state ? state.druid : undefined;
            resourceInputs["dynamoDb"] = state ? state.dynamoDb : undefined;
            resourceInputs["elastic"] = state ? state.elastic : undefined;
            resourceInputs["elasticacheRedis"] = state ? state.elasticacheRedis : undefined;
            resourceInputs["gcp"] = state ? state.gcp : undefined;
            resourceInputs["googleGke"] = state ? state.googleGke : undefined;
            resourceInputs["googleGkeUserImpersonation"] = state ? state.googleGkeUserImpersonation : undefined;
            resourceInputs["greenplum"] = state ? state.greenplum : undefined;
            resourceInputs["httpAuth"] = state ? state.httpAuth : undefined;
            resourceInputs["httpBasicAuth"] = state ? state.httpBasicAuth : undefined;
            resourceInputs["httpNoAuth"] = state ? state.httpNoAuth : undefined;
            resourceInputs["kubernetes"] = state ? state.kubernetes : undefined;
            resourceInputs["kubernetesBasicAuth"] = state ? state.kubernetesBasicAuth : undefined;
            resourceInputs["kubernetesServiceAccount"] = state ? state.kubernetesServiceAccount : undefined;
            resourceInputs["kubernetesServiceAccountUserImpersonation"] = state ? state.kubernetesServiceAccountUserImpersonation : undefined;
            resourceInputs["kubernetesUserImpersonation"] = state ? state.kubernetesUserImpersonation : undefined;
            resourceInputs["maria"] = state ? state.maria : undefined;
            resourceInputs["memcached"] = state ? state.memcached : undefined;
            resourceInputs["memsql"] = state ? state.memsql : undefined;
            resourceInputs["mongoHost"] = state ? state.mongoHost : undefined;
            resourceInputs["mongoLegacyHost"] = state ? state.mongoLegacyHost : undefined;
            resourceInputs["mongoLegacyReplicaset"] = state ? state.mongoLegacyReplicaset : undefined;
            resourceInputs["mongoReplicaSet"] = state ? state.mongoReplicaSet : undefined;
            resourceInputs["mongoShardedCluster"] = state ? state.mongoShardedCluster : undefined;
            resourceInputs["mtlsMysql"] = state ? state.mtlsMysql : undefined;
            resourceInputs["mtlsPostgres"] = state ? state.mtlsPostgres : undefined;
            resourceInputs["mysql"] = state ? state.mysql : undefined;
            resourceInputs["neptune"] = state ? state.neptune : undefined;
            resourceInputs["neptuneIam"] = state ? state.neptuneIam : undefined;
            resourceInputs["oracle"] = state ? state.oracle : undefined;
            resourceInputs["postgres"] = state ? state.postgres : undefined;
            resourceInputs["presto"] = state ? state.presto : undefined;
            resourceInputs["rabbitmqAmqp091"] = state ? state.rabbitmqAmqp091 : undefined;
            resourceInputs["rawTcp"] = state ? state.rawTcp : undefined;
            resourceInputs["rdp"] = state ? state.rdp : undefined;
            resourceInputs["rdsPostgresIam"] = state ? state.rdsPostgresIam : undefined;
            resourceInputs["redis"] = state ? state.redis : undefined;
            resourceInputs["redshift"] = state ? state.redshift : undefined;
            resourceInputs["singleStore"] = state ? state.singleStore : undefined;
            resourceInputs["snowflake"] = state ? state.snowflake : undefined;
            resourceInputs["snowsight"] = state ? state.snowsight : undefined;
            resourceInputs["sqlServer"] = state ? state.sqlServer : undefined;
            resourceInputs["sqlServerAzureAd"] = state ? state.sqlServerAzureAd : undefined;
            resourceInputs["sqlServerKerberosAd"] = state ? state.sqlServerKerberosAd : undefined;
            resourceInputs["ssh"] = state ? state.ssh : undefined;
            resourceInputs["sshCert"] = state ? state.sshCert : undefined;
            resourceInputs["sshCustomerKey"] = state ? state.sshCustomerKey : undefined;
            resourceInputs["sybase"] = state ? state.sybase : undefined;
            resourceInputs["sybaseIq"] = state ? state.sybaseIq : undefined;
            resourceInputs["teradata"] = state ? state.teradata : undefined;
            resourceInputs["trino"] = state ? state.trino : undefined;
        } else {
            const args = argsOrState as ResourceArgs | undefined;
            resourceInputs["aks"] = args ? args.aks : undefined;
            resourceInputs["aksBasicAuth"] = args ? args.aksBasicAuth : undefined;
            resourceInputs["aksServiceAccount"] = args ? args.aksServiceAccount : undefined;
            resourceInputs["aksServiceAccountUserImpersonation"] = args ? args.aksServiceAccountUserImpersonation : undefined;
            resourceInputs["aksUserImpersonation"] = args ? args.aksUserImpersonation : undefined;
            resourceInputs["amazonEks"] = args ? args.amazonEks : undefined;
            resourceInputs["amazonEksInstanceProfile"] = args ? args.amazonEksInstanceProfile : undefined;
            resourceInputs["amazonEksInstanceProfileUserImpersonation"] = args ? args.amazonEksInstanceProfileUserImpersonation : undefined;
            resourceInputs["amazonEksUserImpersonation"] = args ? args.amazonEksUserImpersonation : undefined;
            resourceInputs["amazonEs"] = args ? args.amazonEs : undefined;
            resourceInputs["amazonmqAmqp091"] = args ? args.amazonmqAmqp091 : undefined;
            resourceInputs["athena"] = args ? args.athena : undefined;
            resourceInputs["auroraMysql"] = args ? args.auroraMysql : undefined;
            resourceInputs["auroraPostgres"] = args ? args.auroraPostgres : undefined;
            resourceInputs["auroraPostgresIam"] = args ? args.auroraPostgresIam : undefined;
            resourceInputs["aws"] = args ? args.aws : undefined;
            resourceInputs["awsConsole"] = args ? args.awsConsole : undefined;
            resourceInputs["awsConsoleStaticKeyPair"] = args ? args.awsConsoleStaticKeyPair : undefined;
            resourceInputs["azure"] = args ? args.azure : undefined;
            resourceInputs["azureCertificate"] = args ? args.azureCertificate : undefined;
            resourceInputs["azureMysql"] = args ? args.azureMysql : undefined;
            resourceInputs["azurePostgres"] = args ? args.azurePostgres : undefined;
            resourceInputs["azurePostgresManagedIdentity"] = args ? args.azurePostgresManagedIdentity : undefined;
            resourceInputs["bigQuery"] = args ? args.bigQuery : undefined;
            resourceInputs["cassandra"] = args ? args.cassandra : undefined;
            resourceInputs["citus"] = args ? args.citus : undefined;
            resourceInputs["clustrix"] = args ? args.clustrix : undefined;
            resourceInputs["cockroach"] = args ? args.cockroach : undefined;
            resourceInputs["db2I"] = args ? args.db2I : undefined;
            resourceInputs["db2Luw"] = args ? args.db2Luw : undefined;
            resourceInputs["documentDbHost"] = args ? args.documentDbHost : undefined;
            resourceInputs["documentDbReplicaSet"] = args ? args.documentDbReplicaSet : undefined;
            resourceInputs["druid"] = args ? args.druid : undefined;
            resourceInputs["dynamoDb"] = args ? args.dynamoDb : undefined;
            resourceInputs["elastic"] = args ? args.elastic : undefined;
            resourceInputs["elasticacheRedis"] = args ? args.elasticacheRedis : undefined;
            resourceInputs["gcp"] = args ? args.gcp : undefined;
            resourceInputs["googleGke"] = args ? args.googleGke : undefined;
            resourceInputs["googleGkeUserImpersonation"] = args ? args.googleGkeUserImpersonation : undefined;
            resourceInputs["greenplum"] = args ? args.greenplum : undefined;
            resourceInputs["httpAuth"] = args ? args.httpAuth : undefined;
            resourceInputs["httpBasicAuth"] = args ? args.httpBasicAuth : undefined;
            resourceInputs["httpNoAuth"] = args ? args.httpNoAuth : undefined;
            resourceInputs["kubernetes"] = args ? args.kubernetes : undefined;
            resourceInputs["kubernetesBasicAuth"] = args ? args.kubernetesBasicAuth : undefined;
            resourceInputs["kubernetesServiceAccount"] = args ? args.kubernetesServiceAccount : undefined;
            resourceInputs["kubernetesServiceAccountUserImpersonation"] = args ? args.kubernetesServiceAccountUserImpersonation : undefined;
            resourceInputs["kubernetesUserImpersonation"] = args ? args.kubernetesUserImpersonation : undefined;
            resourceInputs["maria"] = args ? args.maria : undefined;
            resourceInputs["memcached"] = args ? args.memcached : undefined;
            resourceInputs["memsql"] = args ? args.memsql : undefined;
            resourceInputs["mongoHost"] = args ? args.mongoHost : undefined;
            resourceInputs["mongoLegacyHost"] = args ? args.mongoLegacyHost : undefined;
            resourceInputs["mongoLegacyReplicaset"] = args ? args.mongoLegacyReplicaset : undefined;
            resourceInputs["mongoReplicaSet"] = args ? args.mongoReplicaSet : undefined;
            resourceInputs["mongoShardedCluster"] = args ? args.mongoShardedCluster : undefined;
            resourceInputs["mtlsMysql"] = args ? args.mtlsMysql : undefined;
            resourceInputs["mtlsPostgres"] = args ? args.mtlsPostgres : undefined;
            resourceInputs["mysql"] = args ? args.mysql : undefined;
            resourceInputs["neptune"] = args ? args.neptune : undefined;
            resourceInputs["neptuneIam"] = args ? args.neptuneIam : undefined;
            resourceInputs["oracle"] = args ? args.oracle : undefined;
            resourceInputs["postgres"] = args ? args.postgres : undefined;
            resourceInputs["presto"] = args ? args.presto : undefined;
            resourceInputs["rabbitmqAmqp091"] = args ? args.rabbitmqAmqp091 : undefined;
            resourceInputs["rawTcp"] = args ? args.rawTcp : undefined;
            resourceInputs["rdp"] = args ? args.rdp : undefined;
            resourceInputs["rdsPostgresIam"] = args ? args.rdsPostgresIam : undefined;
            resourceInputs["redis"] = args ? args.redis : undefined;
            resourceInputs["redshift"] = args ? args.redshift : undefined;
            resourceInputs["singleStore"] = args ? args.singleStore : undefined;
            resourceInputs["snowflake"] = args ? args.snowflake : undefined;
            resourceInputs["snowsight"] = args ? args.snowsight : undefined;
            resourceInputs["sqlServer"] = args ? args.sqlServer : undefined;
            resourceInputs["sqlServerAzureAd"] = args ? args.sqlServerAzureAd : undefined;
            resourceInputs["sqlServerKerberosAd"] = args ? args.sqlServerKerberosAd : undefined;
            resourceInputs["ssh"] = args ? args.ssh : undefined;
            resourceInputs["sshCert"] = args ? args.sshCert : undefined;
            resourceInputs["sshCustomerKey"] = args ? args.sshCustomerKey : undefined;
            resourceInputs["sybase"] = args ? args.sybase : undefined;
            resourceInputs["sybaseIq"] = args ? args.sybaseIq : undefined;
            resourceInputs["teradata"] = args ? args.teradata : undefined;
            resourceInputs["trino"] = args ? args.trino : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Resource.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Resource resources.
 */
export interface ResourceState {
    aks?: pulumi.Input<inputs.ResourceAks>;
    aksBasicAuth?: pulumi.Input<inputs.ResourceAksBasicAuth>;
    aksServiceAccount?: pulumi.Input<inputs.ResourceAksServiceAccount>;
    aksServiceAccountUserImpersonation?: pulumi.Input<inputs.ResourceAksServiceAccountUserImpersonation>;
    aksUserImpersonation?: pulumi.Input<inputs.ResourceAksUserImpersonation>;
    amazonEks?: pulumi.Input<inputs.ResourceAmazonEks>;
    amazonEksInstanceProfile?: pulumi.Input<inputs.ResourceAmazonEksInstanceProfile>;
    amazonEksInstanceProfileUserImpersonation?: pulumi.Input<inputs.ResourceAmazonEksInstanceProfileUserImpersonation>;
    amazonEksUserImpersonation?: pulumi.Input<inputs.ResourceAmazonEksUserImpersonation>;
    amazonEs?: pulumi.Input<inputs.ResourceAmazonEs>;
    amazonmqAmqp091?: pulumi.Input<inputs.ResourceAmazonmqAmqp091>;
    athena?: pulumi.Input<inputs.ResourceAthena>;
    auroraMysql?: pulumi.Input<inputs.ResourceAuroraMysql>;
    auroraPostgres?: pulumi.Input<inputs.ResourceAuroraPostgres>;
    /**
     * AuroraPostgresIAM is currently unstable, and its API may change, or it may be removed, without a major version bump.
     */
    auroraPostgresIam?: pulumi.Input<inputs.ResourceAuroraPostgresIam>;
    aws?: pulumi.Input<inputs.ResourceAws>;
    awsConsole?: pulumi.Input<inputs.ResourceAwsConsole>;
    awsConsoleStaticKeyPair?: pulumi.Input<inputs.ResourceAwsConsoleStaticKeyPair>;
    azure?: pulumi.Input<inputs.ResourceAzure>;
    azureCertificate?: pulumi.Input<inputs.ResourceAzureCertificate>;
    azureMysql?: pulumi.Input<inputs.ResourceAzureMysql>;
    azurePostgres?: pulumi.Input<inputs.ResourceAzurePostgres>;
    azurePostgresManagedIdentity?: pulumi.Input<inputs.ResourceAzurePostgresManagedIdentity>;
    bigQuery?: pulumi.Input<inputs.ResourceBigQuery>;
    cassandra?: pulumi.Input<inputs.ResourceCassandra>;
    citus?: pulumi.Input<inputs.ResourceCitus>;
    clustrix?: pulumi.Input<inputs.ResourceClustrix>;
    cockroach?: pulumi.Input<inputs.ResourceCockroach>;
    db2I?: pulumi.Input<inputs.ResourceDb2I>;
    db2Luw?: pulumi.Input<inputs.ResourceDb2Luw>;
    documentDbHost?: pulumi.Input<inputs.ResourceDocumentDbHost>;
    documentDbReplicaSet?: pulumi.Input<inputs.ResourceDocumentDbReplicaSet>;
    druid?: pulumi.Input<inputs.ResourceDruid>;
    dynamoDb?: pulumi.Input<inputs.ResourceDynamoDb>;
    elastic?: pulumi.Input<inputs.ResourceElastic>;
    elasticacheRedis?: pulumi.Input<inputs.ResourceElasticacheRedis>;
    gcp?: pulumi.Input<inputs.ResourceGcp>;
    googleGke?: pulumi.Input<inputs.ResourceGoogleGke>;
    googleGkeUserImpersonation?: pulumi.Input<inputs.ResourceGoogleGkeUserImpersonation>;
    greenplum?: pulumi.Input<inputs.ResourceGreenplum>;
    httpAuth?: pulumi.Input<inputs.ResourceHttpAuth>;
    httpBasicAuth?: pulumi.Input<inputs.ResourceHttpBasicAuth>;
    httpNoAuth?: pulumi.Input<inputs.ResourceHttpNoAuth>;
    kubernetes?: pulumi.Input<inputs.ResourceKubernetes>;
    kubernetesBasicAuth?: pulumi.Input<inputs.ResourceKubernetesBasicAuth>;
    kubernetesServiceAccount?: pulumi.Input<inputs.ResourceKubernetesServiceAccount>;
    kubernetesServiceAccountUserImpersonation?: pulumi.Input<inputs.ResourceKubernetesServiceAccountUserImpersonation>;
    kubernetesUserImpersonation?: pulumi.Input<inputs.ResourceKubernetesUserImpersonation>;
    maria?: pulumi.Input<inputs.ResourceMaria>;
    memcached?: pulumi.Input<inputs.ResourceMemcached>;
    memsql?: pulumi.Input<inputs.ResourceMemsql>;
    /**
     * MongoHost is currently unstable, and its API may change, or it may be removed, without a major version bump.
     */
    mongoHost?: pulumi.Input<inputs.ResourceMongoHost>;
    mongoLegacyHost?: pulumi.Input<inputs.ResourceMongoLegacyHost>;
    mongoLegacyReplicaset?: pulumi.Input<inputs.ResourceMongoLegacyReplicaset>;
    /**
     * MongoReplicaSet is currently unstable, and its API may change, or it may be removed, without a major version bump.
     */
    mongoReplicaSet?: pulumi.Input<inputs.ResourceMongoReplicaSet>;
    /**
     * MongoShardedCluster is currently unstable, and its API may change, or it may be removed, without a major version bump.
     */
    mongoShardedCluster?: pulumi.Input<inputs.ResourceMongoShardedCluster>;
    /**
     * MTLSMysql is currently unstable, and its API may change, or it may be removed, without a major version bump.
     */
    mtlsMysql?: pulumi.Input<inputs.ResourceMtlsMysql>;
    mtlsPostgres?: pulumi.Input<inputs.ResourceMtlsPostgres>;
    mysql?: pulumi.Input<inputs.ResourceMysql>;
    neptune?: pulumi.Input<inputs.ResourceNeptune>;
    neptuneIam?: pulumi.Input<inputs.ResourceNeptuneIam>;
    oracle?: pulumi.Input<inputs.ResourceOracle>;
    postgres?: pulumi.Input<inputs.ResourcePostgres>;
    presto?: pulumi.Input<inputs.ResourcePresto>;
    rabbitmqAmqp091?: pulumi.Input<inputs.ResourceRabbitmqAmqp091>;
    rawTcp?: pulumi.Input<inputs.ResourceRawTcp>;
    rdp?: pulumi.Input<inputs.ResourceRdp>;
    /**
     * RDSPostgresIAM is currently unstable, and its API may change, or it may be removed, without a major version bump.
     */
    rdsPostgresIam?: pulumi.Input<inputs.ResourceRdsPostgresIam>;
    redis?: pulumi.Input<inputs.ResourceRedis>;
    redshift?: pulumi.Input<inputs.ResourceRedshift>;
    singleStore?: pulumi.Input<inputs.ResourceSingleStore>;
    snowflake?: pulumi.Input<inputs.ResourceSnowflake>;
    snowsight?: pulumi.Input<inputs.ResourceSnowsight>;
    sqlServer?: pulumi.Input<inputs.ResourceSqlServer>;
    sqlServerAzureAd?: pulumi.Input<inputs.ResourceSqlServerAzureAd>;
    sqlServerKerberosAd?: pulumi.Input<inputs.ResourceSqlServerKerberosAd>;
    ssh?: pulumi.Input<inputs.ResourceSsh>;
    sshCert?: pulumi.Input<inputs.ResourceSshCert>;
    sshCustomerKey?: pulumi.Input<inputs.ResourceSshCustomerKey>;
    sybase?: pulumi.Input<inputs.ResourceSybase>;
    sybaseIq?: pulumi.Input<inputs.ResourceSybaseIq>;
    teradata?: pulumi.Input<inputs.ResourceTeradata>;
    /**
     * Trino is currently unstable, and its API may change, or it may be removed, without a major version bump.
     */
    trino?: pulumi.Input<inputs.ResourceTrino>;
}

/**
 * The set of arguments for constructing a Resource resource.
 */
export interface ResourceArgs {
    aks?: pulumi.Input<inputs.ResourceAks>;
    aksBasicAuth?: pulumi.Input<inputs.ResourceAksBasicAuth>;
    aksServiceAccount?: pulumi.Input<inputs.ResourceAksServiceAccount>;
    aksServiceAccountUserImpersonation?: pulumi.Input<inputs.ResourceAksServiceAccountUserImpersonation>;
    aksUserImpersonation?: pulumi.Input<inputs.ResourceAksUserImpersonation>;
    amazonEks?: pulumi.Input<inputs.ResourceAmazonEks>;
    amazonEksInstanceProfile?: pulumi.Input<inputs.ResourceAmazonEksInstanceProfile>;
    amazonEksInstanceProfileUserImpersonation?: pulumi.Input<inputs.ResourceAmazonEksInstanceProfileUserImpersonation>;
    amazonEksUserImpersonation?: pulumi.Input<inputs.ResourceAmazonEksUserImpersonation>;
    amazonEs?: pulumi.Input<inputs.ResourceAmazonEs>;
    amazonmqAmqp091?: pulumi.Input<inputs.ResourceAmazonmqAmqp091>;
    athena?: pulumi.Input<inputs.ResourceAthena>;
    auroraMysql?: pulumi.Input<inputs.ResourceAuroraMysql>;
    auroraPostgres?: pulumi.Input<inputs.ResourceAuroraPostgres>;
    /**
     * AuroraPostgresIAM is currently unstable, and its API may change, or it may be removed, without a major version bump.
     */
    auroraPostgresIam?: pulumi.Input<inputs.ResourceAuroraPostgresIam>;
    aws?: pulumi.Input<inputs.ResourceAws>;
    awsConsole?: pulumi.Input<inputs.ResourceAwsConsole>;
    awsConsoleStaticKeyPair?: pulumi.Input<inputs.ResourceAwsConsoleStaticKeyPair>;
    azure?: pulumi.Input<inputs.ResourceAzure>;
    azureCertificate?: pulumi.Input<inputs.ResourceAzureCertificate>;
    azureMysql?: pulumi.Input<inputs.ResourceAzureMysql>;
    azurePostgres?: pulumi.Input<inputs.ResourceAzurePostgres>;
    azurePostgresManagedIdentity?: pulumi.Input<inputs.ResourceAzurePostgresManagedIdentity>;
    bigQuery?: pulumi.Input<inputs.ResourceBigQuery>;
    cassandra?: pulumi.Input<inputs.ResourceCassandra>;
    citus?: pulumi.Input<inputs.ResourceCitus>;
    clustrix?: pulumi.Input<inputs.ResourceClustrix>;
    cockroach?: pulumi.Input<inputs.ResourceCockroach>;
    db2I?: pulumi.Input<inputs.ResourceDb2I>;
    db2Luw?: pulumi.Input<inputs.ResourceDb2Luw>;
    documentDbHost?: pulumi.Input<inputs.ResourceDocumentDbHost>;
    documentDbReplicaSet?: pulumi.Input<inputs.ResourceDocumentDbReplicaSet>;
    druid?: pulumi.Input<inputs.ResourceDruid>;
    dynamoDb?: pulumi.Input<inputs.ResourceDynamoDb>;
    elastic?: pulumi.Input<inputs.ResourceElastic>;
    elasticacheRedis?: pulumi.Input<inputs.ResourceElasticacheRedis>;
    gcp?: pulumi.Input<inputs.ResourceGcp>;
    googleGke?: pulumi.Input<inputs.ResourceGoogleGke>;
    googleGkeUserImpersonation?: pulumi.Input<inputs.ResourceGoogleGkeUserImpersonation>;
    greenplum?: pulumi.Input<inputs.ResourceGreenplum>;
    httpAuth?: pulumi.Input<inputs.ResourceHttpAuth>;
    httpBasicAuth?: pulumi.Input<inputs.ResourceHttpBasicAuth>;
    httpNoAuth?: pulumi.Input<inputs.ResourceHttpNoAuth>;
    kubernetes?: pulumi.Input<inputs.ResourceKubernetes>;
    kubernetesBasicAuth?: pulumi.Input<inputs.ResourceKubernetesBasicAuth>;
    kubernetesServiceAccount?: pulumi.Input<inputs.ResourceKubernetesServiceAccount>;
    kubernetesServiceAccountUserImpersonation?: pulumi.Input<inputs.ResourceKubernetesServiceAccountUserImpersonation>;
    kubernetesUserImpersonation?: pulumi.Input<inputs.ResourceKubernetesUserImpersonation>;
    maria?: pulumi.Input<inputs.ResourceMaria>;
    memcached?: pulumi.Input<inputs.ResourceMemcached>;
    memsql?: pulumi.Input<inputs.ResourceMemsql>;
    /**
     * MongoHost is currently unstable, and its API may change, or it may be removed, without a major version bump.
     */
    mongoHost?: pulumi.Input<inputs.ResourceMongoHost>;
    mongoLegacyHost?: pulumi.Input<inputs.ResourceMongoLegacyHost>;
    mongoLegacyReplicaset?: pulumi.Input<inputs.ResourceMongoLegacyReplicaset>;
    /**
     * MongoReplicaSet is currently unstable, and its API may change, or it may be removed, without a major version bump.
     */
    mongoReplicaSet?: pulumi.Input<inputs.ResourceMongoReplicaSet>;
    /**
     * MongoShardedCluster is currently unstable, and its API may change, or it may be removed, without a major version bump.
     */
    mongoShardedCluster?: pulumi.Input<inputs.ResourceMongoShardedCluster>;
    /**
     * MTLSMysql is currently unstable, and its API may change, or it may be removed, without a major version bump.
     */
    mtlsMysql?: pulumi.Input<inputs.ResourceMtlsMysql>;
    mtlsPostgres?: pulumi.Input<inputs.ResourceMtlsPostgres>;
    mysql?: pulumi.Input<inputs.ResourceMysql>;
    neptune?: pulumi.Input<inputs.ResourceNeptune>;
    neptuneIam?: pulumi.Input<inputs.ResourceNeptuneIam>;
    oracle?: pulumi.Input<inputs.ResourceOracle>;
    postgres?: pulumi.Input<inputs.ResourcePostgres>;
    presto?: pulumi.Input<inputs.ResourcePresto>;
    rabbitmqAmqp091?: pulumi.Input<inputs.ResourceRabbitmqAmqp091>;
    rawTcp?: pulumi.Input<inputs.ResourceRawTcp>;
    rdp?: pulumi.Input<inputs.ResourceRdp>;
    /**
     * RDSPostgresIAM is currently unstable, and its API may change, or it may be removed, without a major version bump.
     */
    rdsPostgresIam?: pulumi.Input<inputs.ResourceRdsPostgresIam>;
    redis?: pulumi.Input<inputs.ResourceRedis>;
    redshift?: pulumi.Input<inputs.ResourceRedshift>;
    singleStore?: pulumi.Input<inputs.ResourceSingleStore>;
    snowflake?: pulumi.Input<inputs.ResourceSnowflake>;
    snowsight?: pulumi.Input<inputs.ResourceSnowsight>;
    sqlServer?: pulumi.Input<inputs.ResourceSqlServer>;
    sqlServerAzureAd?: pulumi.Input<inputs.ResourceSqlServerAzureAd>;
    sqlServerKerberosAd?: pulumi.Input<inputs.ResourceSqlServerKerberosAd>;
    ssh?: pulumi.Input<inputs.ResourceSsh>;
    sshCert?: pulumi.Input<inputs.ResourceSshCert>;
    sshCustomerKey?: pulumi.Input<inputs.ResourceSshCustomerKey>;
    sybase?: pulumi.Input<inputs.ResourceSybase>;
    sybaseIq?: pulumi.Input<inputs.ResourceSybaseIq>;
    teradata?: pulumi.Input<inputs.ResourceTeradata>;
    /**
     * Trino is currently unstable, and its API may change, or it may be removed, without a major version bump.
     */
    trino?: pulumi.Input<inputs.ResourceTrino>;
}
