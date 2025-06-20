// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * WorkflowApprover is an account or a role with the ability to approve requests bound to a workflow.
 * This data source is deprecated.
 */
export function getWorkflowApprover(args?: GetWorkflowApproverArgs, opts?: pulumi.InvokeOptions): Promise<GetWorkflowApproverResult> {
    args = args || {};
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("sdm:index/getWorkflowApprover:getWorkflowApprover", {
        "accountId": args.accountId,
        "id": args.id,
        "roleId": args.roleId,
        "workflowId": args.workflowId,
    }, opts);
}

/**
 * A collection of arguments for invoking getWorkflowApprover.
 */
export interface GetWorkflowApproverArgs {
    /**
     * The approver account id.
     */
    accountId?: string;
    /**
     * Unique identifier of the WorkflowApprover.
     */
    id?: string;
    /**
     * The approver role id
     */
    roleId?: string;
    /**
     * The workflow id.
     */
    workflowId?: string;
}

/**
 * A collection of values returned by getWorkflowApprover.
 */
export interface GetWorkflowApproverResult {
    /**
     * The approver account id.
     */
    readonly accountId?: string;
    /**
     * Unique identifier of the WorkflowApprover.
     */
    readonly id?: string;
    /**
     * a list of strings of ids of data sources that match the given arguments.
     */
    readonly ids: string[];
    /**
     * The approver role id
     */
    readonly roleId?: string;
    /**
     * A list where each element has the following attributes:
     */
    readonly workflowApprovers: outputs.GetWorkflowApproverWorkflowApprover[];
    /**
     * The workflow id.
     */
    readonly workflowId?: string;
}
/**
 * WorkflowApprover is an account or a role with the ability to approve requests bound to a workflow.
 * This data source is deprecated.
 */
export function getWorkflowApproverOutput(args?: GetWorkflowApproverOutputArgs, opts?: pulumi.InvokeOutputOptions): pulumi.Output<GetWorkflowApproverResult> {
    args = args || {};
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invokeOutput("sdm:index/getWorkflowApprover:getWorkflowApprover", {
        "accountId": args.accountId,
        "id": args.id,
        "roleId": args.roleId,
        "workflowId": args.workflowId,
    }, opts);
}

/**
 * A collection of arguments for invoking getWorkflowApprover.
 */
export interface GetWorkflowApproverOutputArgs {
    /**
     * The approver account id.
     */
    accountId?: pulumi.Input<string>;
    /**
     * Unique identifier of the WorkflowApprover.
     */
    id?: pulumi.Input<string>;
    /**
     * The approver role id
     */
    roleId?: pulumi.Input<string>;
    /**
     * The workflow id.
     */
    workflowId?: pulumi.Input<string>;
}
