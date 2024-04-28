// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * ApprovalWorkflows are the mechanism by which requests for access can be viewed by authorized
 *  approvers and be approved or denied.
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as sdm from "@pulumi/sdm";
 *
 * const manualApprovalWorkflowQuery = sdm.getApprovalWorkflow({
 *     approvalMode: "manual",
 *     name: "approval workflow manual",
 * });
 * const autoGrantApprovalWorkflowQuery = sdm.getApprovalWorkflow({
 *     approvalMode: "automatic",
 *     name: "approval workflow auto",
 * });
 * ```
 */
export function getApprovalWorkflow(args?: GetApprovalWorkflowArgs, opts?: pulumi.InvokeOptions): Promise<GetApprovalWorkflowResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("sdm:index/getApprovalWorkflow:getApprovalWorkflow", {
        "approvalMode": args.approvalMode,
        "description": args.description,
        "id": args.id,
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getApprovalWorkflow.
 */
export interface GetApprovalWorkflowArgs {
    /**
     * Approval mode of the ApprovalWorkflow
     */
    approvalMode?: string;
    /**
     * Optional description of the ApprovalWorkflow.
     */
    description?: string;
    /**
     * Unique identifier of the ApprovalWorkflow.
     */
    id?: string;
    /**
     * Unique human-readable name of the ApprovalWorkflow.
     */
    name?: string;
}

/**
 * A collection of values returned by getApprovalWorkflow.
 */
export interface GetApprovalWorkflowResult {
    /**
     * Approval mode of the ApprovalWorkflow
     */
    readonly approvalMode?: string;
    /**
     * A list where each element has the following attributes:
     */
    readonly approvalWorkflows: outputs.GetApprovalWorkflowApprovalWorkflow[];
    /**
     * Optional description of the ApprovalWorkflow.
     */
    readonly description?: string;
    /**
     * Unique identifier of the ApprovalWorkflow.
     */
    readonly id?: string;
    /**
     * a list of strings of ids of data sources that match the given arguments.
     */
    readonly ids: string[];
    /**
     * Unique human-readable name of the ApprovalWorkflow.
     */
    readonly name?: string;
}
/**
 * ApprovalWorkflows are the mechanism by which requests for access can be viewed by authorized
 *  approvers and be approved or denied.
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as sdm from "@pulumi/sdm";
 *
 * const manualApprovalWorkflowQuery = sdm.getApprovalWorkflow({
 *     approvalMode: "manual",
 *     name: "approval workflow manual",
 * });
 * const autoGrantApprovalWorkflowQuery = sdm.getApprovalWorkflow({
 *     approvalMode: "automatic",
 *     name: "approval workflow auto",
 * });
 * ```
 */
export function getApprovalWorkflowOutput(args?: GetApprovalWorkflowOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetApprovalWorkflowResult> {
    return pulumi.output(args).apply((a: any) => getApprovalWorkflow(a, opts))
}

/**
 * A collection of arguments for invoking getApprovalWorkflow.
 */
export interface GetApprovalWorkflowOutputArgs {
    /**
     * Approval mode of the ApprovalWorkflow
     */
    approvalMode?: pulumi.Input<string>;
    /**
     * Optional description of the ApprovalWorkflow.
     */
    description?: pulumi.Input<string>;
    /**
     * Unique identifier of the ApprovalWorkflow.
     */
    id?: pulumi.Input<string>;
    /**
     * Unique human-readable name of the ApprovalWorkflow.
     */
    name?: pulumi.Input<string>;
}
