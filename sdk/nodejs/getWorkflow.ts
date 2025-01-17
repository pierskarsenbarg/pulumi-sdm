// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Workflows are the collection of rules that define the resources to which access can be requested,
 *  the users that can request that access, and the mechanism for approving those requests which can either
 *  but automatic approval or a set of users authorized to approve the requests.
 */
export function getWorkflow(args?: GetWorkflowArgs, opts?: pulumi.InvokeOptions): Promise<GetWorkflowResult> {
    args = args || {};
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("sdm:index/getWorkflow:getWorkflow", {
        "accessRequestFixedDuration": args.accessRequestFixedDuration,
        "accessRequestMaxDuration": args.accessRequestMaxDuration,
        "approvalFlowId": args.approvalFlowId,
        "autoGrant": args.autoGrant,
        "description": args.description,
        "enabled": args.enabled,
        "id": args.id,
        "name": args.name,
        "weight": args.weight,
    }, opts);
}

/**
 * A collection of arguments for invoking getWorkflow.
 */
export interface GetWorkflowArgs {
    /**
     * Fixed Duration of access requests bound to this workflow. If fixed duration is provided, max duration must be empty. If neither max nor fixed duration are provided, requests that bind to this workflow will use the organization-level settings.
     */
    accessRequestFixedDuration?: string;
    /**
     * Maximum Duration of access requests bound to this workflow. If max duration is provided, fixed duration must be empty. If neither max nor fixed duration are provided, requests that bind to this workflow will use the organization-level settings.
     */
    accessRequestMaxDuration?: string;
    /**
     * Optional approval flow ID identifies an approval flow that linked to the workflow
     */
    approvalFlowId?: string;
    /**
     * Optional auto grant setting to automatically approve requests or not, defaults to false.
     */
    autoGrant?: boolean;
    /**
     * Optional description of the Workflow.
     */
    description?: string;
    /**
     * Optional enabled state for workflow. This setting may be overridden by the system if the workflow doesn't meet the requirements to be enabled or if other conditions prevent enabling the workflow. The requirements to enable a workflow are that the workflow must be either set up for with auto grant enabled or have one or more WorkflowApprovers created for the workflow.
     */
    enabled?: boolean;
    /**
     * Unique identifier of the Workflow.
     */
    id?: string;
    /**
     * Unique human-readable name of the Workflow.
     */
    name?: string;
    /**
     * Optional weight for workflow to specify it's priority in matching a request.
     */
    weight?: number;
}

/**
 * A collection of values returned by getWorkflow.
 */
export interface GetWorkflowResult {
    /**
     * Fixed Duration of access requests bound to this workflow. If fixed duration is provided, max duration must be empty. If neither max nor fixed duration are provided, requests that bind to this workflow will use the organization-level settings.
     */
    readonly accessRequestFixedDuration?: string;
    /**
     * Maximum Duration of access requests bound to this workflow. If max duration is provided, fixed duration must be empty. If neither max nor fixed duration are provided, requests that bind to this workflow will use the organization-level settings.
     */
    readonly accessRequestMaxDuration?: string;
    /**
     * Optional approval flow ID identifies an approval flow that linked to the workflow
     */
    readonly approvalFlowId?: string;
    /**
     * Optional auto grant setting to automatically approve requests or not, defaults to false.
     */
    readonly autoGrant?: boolean;
    /**
     * Optional description of the Workflow.
     */
    readonly description?: string;
    /**
     * Optional enabled state for workflow. This setting may be overridden by the system if the workflow doesn't meet the requirements to be enabled or if other conditions prevent enabling the workflow. The requirements to enable a workflow are that the workflow must be either set up for with auto grant enabled or have one or more WorkflowApprovers created for the workflow.
     */
    readonly enabled?: boolean;
    /**
     * Unique identifier of the Workflow.
     */
    readonly id?: string;
    /**
     * a list of strings of ids of data sources that match the given arguments.
     */
    readonly ids: string[];
    /**
     * Unique human-readable name of the Workflow.
     */
    readonly name?: string;
    /**
     * Optional weight for workflow to specify it's priority in matching a request.
     */
    readonly weight?: number;
    /**
     * A list where each element has the following attributes:
     */
    readonly workflows: outputs.GetWorkflowWorkflow[];
}
/**
 * Workflows are the collection of rules that define the resources to which access can be requested,
 *  the users that can request that access, and the mechanism for approving those requests which can either
 *  but automatic approval or a set of users authorized to approve the requests.
 */
export function getWorkflowOutput(args?: GetWorkflowOutputArgs, opts?: pulumi.InvokeOutputOptions): pulumi.Output<GetWorkflowResult> {
    args = args || {};
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invokeOutput("sdm:index/getWorkflow:getWorkflow", {
        "accessRequestFixedDuration": args.accessRequestFixedDuration,
        "accessRequestMaxDuration": args.accessRequestMaxDuration,
        "approvalFlowId": args.approvalFlowId,
        "autoGrant": args.autoGrant,
        "description": args.description,
        "enabled": args.enabled,
        "id": args.id,
        "name": args.name,
        "weight": args.weight,
    }, opts);
}

/**
 * A collection of arguments for invoking getWorkflow.
 */
export interface GetWorkflowOutputArgs {
    /**
     * Fixed Duration of access requests bound to this workflow. If fixed duration is provided, max duration must be empty. If neither max nor fixed duration are provided, requests that bind to this workflow will use the organization-level settings.
     */
    accessRequestFixedDuration?: pulumi.Input<string>;
    /**
     * Maximum Duration of access requests bound to this workflow. If max duration is provided, fixed duration must be empty. If neither max nor fixed duration are provided, requests that bind to this workflow will use the organization-level settings.
     */
    accessRequestMaxDuration?: pulumi.Input<string>;
    /**
     * Optional approval flow ID identifies an approval flow that linked to the workflow
     */
    approvalFlowId?: pulumi.Input<string>;
    /**
     * Optional auto grant setting to automatically approve requests or not, defaults to false.
     */
    autoGrant?: pulumi.Input<boolean>;
    /**
     * Optional description of the Workflow.
     */
    description?: pulumi.Input<string>;
    /**
     * Optional enabled state for workflow. This setting may be overridden by the system if the workflow doesn't meet the requirements to be enabled or if other conditions prevent enabling the workflow. The requirements to enable a workflow are that the workflow must be either set up for with auto grant enabled or have one or more WorkflowApprovers created for the workflow.
     */
    enabled?: pulumi.Input<boolean>;
    /**
     * Unique identifier of the Workflow.
     */
    id?: pulumi.Input<string>;
    /**
     * Unique human-readable name of the Workflow.
     */
    name?: pulumi.Input<string>;
    /**
     * Optional weight for workflow to specify it's priority in matching a request.
     */
    weight?: pulumi.Input<number>;
}
