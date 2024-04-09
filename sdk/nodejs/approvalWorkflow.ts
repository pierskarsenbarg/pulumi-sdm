// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * ApprovalWorkflows are the mechanism by which requests for access can be viewed by authorized
 *  approvers and be approved or denied.
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as sdm from "@pierskarsenbarg/sdm";
 *
 * const manualApprovalWorkflow = new sdm.ApprovalWorkflow("manualApprovalWorkflow", {approvalMode: "manual"});
 * const autoGrantApprovalWorkflow = new sdm.ApprovalWorkflow("autoGrantApprovalWorkflow", {approvalMode: "automatic"});
 * ```
 * <!--End PulumiCodeChooser -->
 * This resource can be imported using the import command.
 *
 * ## Import
 *
 * A ApprovalWorkflow can be imported using the id, e.g.,
 *
 * ```sh
 * $ pulumi import sdm:index/approvalWorkflow:ApprovalWorkflow example af-12345678
 * ```
 */
export class ApprovalWorkflow extends pulumi.CustomResource {
    /**
     * Get an existing ApprovalWorkflow resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ApprovalWorkflowState, opts?: pulumi.CustomResourceOptions): ApprovalWorkflow {
        return new ApprovalWorkflow(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'sdm:index/approvalWorkflow:ApprovalWorkflow';

    /**
     * Returns true if the given object is an instance of ApprovalWorkflow.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ApprovalWorkflow {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ApprovalWorkflow.__pulumiType;
    }

    /**
     * Approval mode of the ApprovalWorkflow
     */
    public readonly approvalMode!: pulumi.Output<string>;
    /**
     * Optional description of the ApprovalWorkflow.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Unique human-readable name of the ApprovalWorkflow.
     */
    public readonly name!: pulumi.Output<string>;

    /**
     * Create a ApprovalWorkflow resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ApprovalWorkflowArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ApprovalWorkflowArgs | ApprovalWorkflowState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ApprovalWorkflowState | undefined;
            resourceInputs["approvalMode"] = state ? state.approvalMode : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
        } else {
            const args = argsOrState as ApprovalWorkflowArgs | undefined;
            if ((!args || args.approvalMode === undefined) && !opts.urn) {
                throw new Error("Missing required property 'approvalMode'");
            }
            resourceInputs["approvalMode"] = args ? args.approvalMode : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ApprovalWorkflow.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ApprovalWorkflow resources.
 */
export interface ApprovalWorkflowState {
    /**
     * Approval mode of the ApprovalWorkflow
     */
    approvalMode?: pulumi.Input<string>;
    /**
     * Optional description of the ApprovalWorkflow.
     */
    description?: pulumi.Input<string>;
    /**
     * Unique human-readable name of the ApprovalWorkflow.
     */
    name?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ApprovalWorkflow resource.
 */
export interface ApprovalWorkflowArgs {
    /**
     * Approval mode of the ApprovalWorkflow
     */
    approvalMode: pulumi.Input<string>;
    /**
     * Optional description of the ApprovalWorkflow.
     */
    description?: pulumi.Input<string>;
    /**
     * Unique human-readable name of the ApprovalWorkflow.
     */
    name?: pulumi.Input<string>;
}
