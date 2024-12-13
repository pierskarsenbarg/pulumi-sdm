// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * PeeringGroupResource represents the attachment between a PeeringGroup and a Resource.
 */
export function getPeeringGroupResource(args?: GetPeeringGroupResourceArgs, opts?: pulumi.InvokeOptions): Promise<GetPeeringGroupResourceResult> {
    args = args || {};
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("sdm:index/getPeeringGroupResource:getPeeringGroupResource", {
        "groupId": args.groupId,
        "id": args.id,
        "resourceId": args.resourceId,
    }, opts);
}

/**
 * A collection of arguments for invoking getPeeringGroupResource.
 */
export interface GetPeeringGroupResourceArgs {
    /**
     * Peering Group ID to which the resource will be attached to.
     */
    groupId?: string;
    /**
     * Unique identifier of the Attachment.
     */
    id?: string;
    /**
     * Resource ID to be attached.
     */
    resourceId?: string;
}

/**
 * A collection of values returned by getPeeringGroupResource.
 */
export interface GetPeeringGroupResourceResult {
    /**
     * Peering Group ID to which the resource will be attached to.
     */
    readonly groupId?: string;
    /**
     * Unique identifier of the Attachment.
     */
    readonly id?: string;
    /**
     * a list of strings of ids of data sources that match the given arguments.
     */
    readonly ids: string[];
    /**
     * A list where each element has the following attributes:
     */
    readonly peeringGroupResources: outputs.GetPeeringGroupResourcePeeringGroupResource[];
    /**
     * Resource ID to be attached.
     */
    readonly resourceId?: string;
}
/**
 * PeeringGroupResource represents the attachment between a PeeringGroup and a Resource.
 */
export function getPeeringGroupResourceOutput(args?: GetPeeringGroupResourceOutputArgs, opts?: pulumi.InvokeOutputOptions): pulumi.Output<GetPeeringGroupResourceResult> {
    args = args || {};
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invokeOutput("sdm:index/getPeeringGroupResource:getPeeringGroupResource", {
        "groupId": args.groupId,
        "id": args.id,
        "resourceId": args.resourceId,
    }, opts);
}

/**
 * A collection of arguments for invoking getPeeringGroupResource.
 */
export interface GetPeeringGroupResourceOutputArgs {
    /**
     * Peering Group ID to which the resource will be attached to.
     */
    groupId?: pulumi.Input<string>;
    /**
     * Unique identifier of the Attachment.
     */
    id?: pulumi.Input<string>;
    /**
     * Resource ID to be attached.
     */
    resourceId?: pulumi.Input<string>;
}
