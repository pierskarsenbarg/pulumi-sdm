// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * ApprovalWorkflowStep links an approval workflow step to an ApprovalWorkflow
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as sdm from "@pulumi/sdm";
 *
 * const approvalWorkflowStepQuery = sdm.getApprovalWorkflowStep({
 *     approvalFlowId: "af-7935485",
 * });
 * ```
 */
export function getApprovalWorkflowStep(args?: GetApprovalWorkflowStepArgs, opts?: pulumi.InvokeOptions): Promise<GetApprovalWorkflowStepResult> {
    args = args || {};
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("sdm:index/getApprovalWorkflowStep:getApprovalWorkflowStep", {
        "approvalFlowId": args.approvalFlowId,
        "id": args.id,
    }, opts);
}

/**
 * A collection of arguments for invoking getApprovalWorkflowStep.
 */
export interface GetApprovalWorkflowStepArgs {
    /**
     * The approval flow id specified the approval workfflow that this step belongs to
     */
    approvalFlowId?: string;
    /**
     * Unique identifier of the ApprovalWorkflowStep.
     */
    id?: string;
}

/**
 * A collection of values returned by getApprovalWorkflowStep.
 */
export interface GetApprovalWorkflowStepResult {
    /**
     * The approval flow id specified the approval workfflow that this step belongs to
     */
    readonly approvalFlowId?: string;
    /**
     * A list where each element has the following attributes:
     */
    readonly approvalWorkflowSteps: outputs.GetApprovalWorkflowStepApprovalWorkflowStep[];
    /**
     * Unique identifier of the ApprovalWorkflowStep.
     */
    readonly id?: string;
    /**
     * a list of strings of ids of data sources that match the given arguments.
     */
    readonly ids: string[];
}
/**
 * ApprovalWorkflowStep links an approval workflow step to an ApprovalWorkflow
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as sdm from "@pulumi/sdm";
 *
 * const approvalWorkflowStepQuery = sdm.getApprovalWorkflowStep({
 *     approvalFlowId: "af-7935485",
 * });
 * ```
 */
export function getApprovalWorkflowStepOutput(args?: GetApprovalWorkflowStepOutputArgs, opts?: pulumi.InvokeOutputOptions): pulumi.Output<GetApprovalWorkflowStepResult> {
    args = args || {};
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invokeOutput("sdm:index/getApprovalWorkflowStep:getApprovalWorkflowStep", {
        "approvalFlowId": args.approvalFlowId,
        "id": args.id,
    }, opts);
}

/**
 * A collection of arguments for invoking getApprovalWorkflowStep.
 */
export interface GetApprovalWorkflowStepOutputArgs {
    /**
     * The approval flow id specified the approval workfflow that this step belongs to
     */
    approvalFlowId?: pulumi.Input<string>;
    /**
     * Unique identifier of the ApprovalWorkflowStep.
     */
    id?: pulumi.Input<string>;
}
