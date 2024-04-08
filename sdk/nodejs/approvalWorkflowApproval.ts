// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * ApprovalWorkflowApprover links an approval workflow approver to an ApprovalWorkflowStep
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as sdm from "@pierskarsenbarg/sdm";
 *
 * const approvalWorkflowApproverAccountExample = new sdm.ApprovalWorkflowApproval("approvalWorkflowApproverAccountExample", {
 *     accountId: "a-234605",
 *     approvalFlowId: "af-6799234",
 *     approvalStepId: "afs-2956266",
 * });
 * const approvalWorkflowApproverRoleExample = new sdm.ApprovalWorkflowApproval("approvalWorkflowApproverRoleExample", {
 *     approvalFlowId: "af-1935694",
 *     approvalStepId: "afs-9245942",
 *     roleId: "r-542982",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 * This resource can be imported using the import command.
 *
 * ## Import
 *
 * A ApprovalWorkflowApprover can be imported using the id, e.g.,
 *
 * ```sh
 * $ pulumi import sdm:index/approvalWorkflowApproval:ApprovalWorkflowApproval example afa-12345678
 * ```
 */
export class ApprovalWorkflowApproval extends pulumi.CustomResource {
    /**
     * Get an existing ApprovalWorkflowApproval resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ApprovalWorkflowApprovalState, opts?: pulumi.CustomResourceOptions): ApprovalWorkflowApproval {
        return new ApprovalWorkflowApproval(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'sdm:index/approvalWorkflowApproval:ApprovalWorkflowApproval';

    /**
     * Returns true if the given object is an instance of ApprovalWorkflowApproval.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ApprovalWorkflowApproval {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ApprovalWorkflowApproval.__pulumiType;
    }

    /**
     * The approver account id.
     */
    public readonly accountId!: pulumi.Output<string | undefined>;
    /**
     * The approval flow id specified the approval workflow that this approver belongs to
     */
    public readonly approvalFlowId!: pulumi.Output<string>;
    /**
     * The approval step id specified the approval flow step that this approver belongs to
     */
    public readonly approvalStepId!: pulumi.Output<string>;
    /**
     * The approver role id
     */
    public readonly roleId!: pulumi.Output<string | undefined>;

    /**
     * Create a ApprovalWorkflowApproval resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ApprovalWorkflowApprovalArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ApprovalWorkflowApprovalArgs | ApprovalWorkflowApprovalState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ApprovalWorkflowApprovalState | undefined;
            resourceInputs["accountId"] = state ? state.accountId : undefined;
            resourceInputs["approvalFlowId"] = state ? state.approvalFlowId : undefined;
            resourceInputs["approvalStepId"] = state ? state.approvalStepId : undefined;
            resourceInputs["roleId"] = state ? state.roleId : undefined;
        } else {
            const args = argsOrState as ApprovalWorkflowApprovalArgs | undefined;
            if ((!args || args.approvalFlowId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'approvalFlowId'");
            }
            if ((!args || args.approvalStepId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'approvalStepId'");
            }
            resourceInputs["accountId"] = args ? args.accountId : undefined;
            resourceInputs["approvalFlowId"] = args ? args.approvalFlowId : undefined;
            resourceInputs["approvalStepId"] = args ? args.approvalStepId : undefined;
            resourceInputs["roleId"] = args ? args.roleId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ApprovalWorkflowApproval.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ApprovalWorkflowApproval resources.
 */
export interface ApprovalWorkflowApprovalState {
    /**
     * The approver account id.
     */
    accountId?: pulumi.Input<string>;
    /**
     * The approval flow id specified the approval workflow that this approver belongs to
     */
    approvalFlowId?: pulumi.Input<string>;
    /**
     * The approval step id specified the approval flow step that this approver belongs to
     */
    approvalStepId?: pulumi.Input<string>;
    /**
     * The approver role id
     */
    roleId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ApprovalWorkflowApproval resource.
 */
export interface ApprovalWorkflowApprovalArgs {
    /**
     * The approver account id.
     */
    accountId?: pulumi.Input<string>;
    /**
     * The approval flow id specified the approval workflow that this approver belongs to
     */
    approvalFlowId: pulumi.Input<string>;
    /**
     * The approval step id specified the approval flow step that this approver belongs to
     */
    approvalStepId: pulumi.Input<string>;
    /**
     * The approver role id
     */
    roleId?: pulumi.Input<string>;
}