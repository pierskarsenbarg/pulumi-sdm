// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * A IdentitySet defines a group of identity aliases.
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as sdm from "@pulumi/sdm";
 *
 * const default = sdm.getIdentitySet({
 *     name: "default",
 * });
 * ```
 */
export function getIdentitySet(args?: GetIdentitySetArgs, opts?: pulumi.InvokeOptions): Promise<GetIdentitySetResult> {
    args = args || {};
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("sdm:index/getIdentitySet:getIdentitySet", {
        "id": args.id,
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getIdentitySet.
 */
export interface GetIdentitySetArgs {
    /**
     * Unique identifier of the IdentitySet.
     */
    id?: string;
    /**
     * Unique human-readable name of the IdentitySet.
     */
    name?: string;
}

/**
 * A collection of values returned by getIdentitySet.
 */
export interface GetIdentitySetResult {
    /**
     * Unique identifier of the IdentitySet.
     */
    readonly id?: string;
    /**
     * A list where each element has the following attributes:
     */
    readonly identitySets: outputs.GetIdentitySetIdentitySet[];
    /**
     * a list of strings of ids of data sources that match the given arguments.
     */
    readonly ids: string[];
    /**
     * Unique human-readable name of the IdentitySet.
     */
    readonly name?: string;
}
/**
 * A IdentitySet defines a group of identity aliases.
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as sdm from "@pulumi/sdm";
 *
 * const default = sdm.getIdentitySet({
 *     name: "default",
 * });
 * ```
 */
export function getIdentitySetOutput(args?: GetIdentitySetOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetIdentitySetResult> {
    args = args || {};
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invokeOutput("sdm:index/getIdentitySet:getIdentitySet", {
        "id": args.id,
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getIdentitySet.
 */
export interface GetIdentitySetOutputArgs {
    /**
     * Unique identifier of the IdentitySet.
     */
    id?: pulumi.Input<string>;
    /**
     * Unique human-readable name of the IdentitySet.
     */
    name?: pulumi.Input<string>;
}
