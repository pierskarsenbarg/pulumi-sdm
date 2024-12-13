// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * A SecretStore is a server where resource secrets (passwords, keys) are stored.
 *  Coming soon support for HashiCorp Vault and AWS Secret Store.
 */
export function getSecretStore(args?: GetSecretStoreArgs, opts?: pulumi.InvokeOptions): Promise<GetSecretStoreResult> {
    args = args || {};
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("sdm:index/getSecretStore:getSecretStore", {
        "id": args.id,
        "name": args.name,
        "tags": args.tags,
        "type": args.type,
    }, opts);
}

/**
 * A collection of arguments for invoking getSecretStore.
 */
export interface GetSecretStoreArgs {
    /**
     * Unique identifier of the SecretStore.
     */
    id?: string;
    /**
     * Unique human-readable name of the SecretStore.
     */
    name?: string;
    /**
     * Tags is a map of key, value pairs.
     */
    tags?: {[key: string]: string};
    /**
     * a filter to select all items of a certain subtype. See the [filter documentation](https://www.strongdm.com/docs/automation/getting-started/filters) for more information.
     */
    type?: string;
}

/**
 * A collection of values returned by getSecretStore.
 */
export interface GetSecretStoreResult {
    /**
     * Unique identifier of the SecretStore.
     */
    readonly id?: string;
    /**
     * a list of strings of ids of data sources that match the given arguments.
     */
    readonly ids: string[];
    /**
     * Unique human-readable name of the SecretStore.
     */
    readonly name?: string;
    /**
     * A single element list containing a map, where each key lists one of the following objects:
     * * active_directory_store:
     */
    readonly secretStores: outputs.GetSecretStoreSecretStore[];
    /**
     * Tags is a map of key, value pairs.
     */
    readonly tags?: {[key: string]: string};
    readonly type?: string;
}
/**
 * A SecretStore is a server where resource secrets (passwords, keys) are stored.
 *  Coming soon support for HashiCorp Vault and AWS Secret Store.
 */
export function getSecretStoreOutput(args?: GetSecretStoreOutputArgs, opts?: pulumi.InvokeOutputOptions): pulumi.Output<GetSecretStoreResult> {
    args = args || {};
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invokeOutput("sdm:index/getSecretStore:getSecretStore", {
        "id": args.id,
        "name": args.name,
        "tags": args.tags,
        "type": args.type,
    }, opts);
}

/**
 * A collection of arguments for invoking getSecretStore.
 */
export interface GetSecretStoreOutputArgs {
    /**
     * Unique identifier of the SecretStore.
     */
    id?: pulumi.Input<string>;
    /**
     * Unique human-readable name of the SecretStore.
     */
    name?: pulumi.Input<string>;
    /**
     * Tags is a map of key, value pairs.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * a filter to select all items of a certain subtype. See the [filter documentation](https://www.strongdm.com/docs/automation/getting-started/filters) for more information.
     */
    type?: pulumi.Input<string>;
}
