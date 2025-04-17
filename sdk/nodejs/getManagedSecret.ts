// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * ManagedSecret contains details about managed secret
 */
export function getManagedSecret(args?: GetManagedSecretArgs, opts?: pulumi.InvokeOptions): Promise<GetManagedSecretResult> {
    args = args || {};
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("sdm:index/getManagedSecret:getManagedSecret", {
        "id": args.id,
        "name": args.name,
        "secretEngineId": args.secretEngineId,
        "tags": args.tags,
        "value": args.value,
    }, opts);
}

/**
 * A collection of arguments for invoking getManagedSecret.
 */
export interface GetManagedSecretArgs {
    /**
     * Unique identifier of the Managed Secret.
     */
    id?: string;
    /**
     * Unique human-readable name of the Managed Secret.
     */
    name?: string;
    /**
     * An ID of a Secret Engine linked with the Managed Secret.
     */
    secretEngineId?: string;
    /**
     * Tags is a map of key, value pairs.
     */
    tags?: {[key: string]: string};
    /**
     * Sensitive value of the secret.
     */
    value?: string;
}

/**
 * A collection of values returned by getManagedSecret.
 */
export interface GetManagedSecretResult {
    /**
     * public part of the secret value
     */
    readonly config: string;
    /**
     * Timestamp of when secret is going to be rotated
     */
    readonly expiresAt: string;
    /**
     * Unique identifier of the Managed Secret.
     */
    readonly id?: string;
    /**
     * a list of strings of ids of data sources that match the given arguments.
     */
    readonly ids: string[];
    /**
     * Timestamp of when secret was last rotated
     */
    readonly lastRotatedAt: string;
    /**
     * A list where each element has the following attributes:
     */
    readonly managedSecrets: outputs.GetManagedSecretManagedSecret[];
    /**
     * Unique human-readable name of the Managed Secret.
     */
    readonly name?: string;
    /**
     * An ID of a Secret Engine linked with the Managed Secret.
     */
    readonly secretEngineId?: string;
    /**
     * Path in a secret store.
     */
    readonly secretStorePath: string;
    /**
     * Tags is a map of key, value pairs.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Sensitive value of the secret.
     */
    readonly value?: string;
}
/**
 * ManagedSecret contains details about managed secret
 */
export function getManagedSecretOutput(args?: GetManagedSecretOutputArgs, opts?: pulumi.InvokeOutputOptions): pulumi.Output<GetManagedSecretResult> {
    args = args || {};
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invokeOutput("sdm:index/getManagedSecret:getManagedSecret", {
        "id": args.id,
        "name": args.name,
        "secretEngineId": args.secretEngineId,
        "tags": args.tags,
        "value": args.value,
    }, opts);
}

/**
 * A collection of arguments for invoking getManagedSecret.
 */
export interface GetManagedSecretOutputArgs {
    /**
     * Unique identifier of the Managed Secret.
     */
    id?: pulumi.Input<string>;
    /**
     * Unique human-readable name of the Managed Secret.
     */
    name?: pulumi.Input<string>;
    /**
     * An ID of a Secret Engine linked with the Managed Secret.
     */
    secretEngineId?: pulumi.Input<string>;
    /**
     * Tags is a map of key, value pairs.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Sensitive value of the secret.
     */
    value?: pulumi.Input<string>;
}
