// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * ApprovalWorkflowStep links an approval workflow step to an ApprovalWorkflow
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as sdm from "@pierskarsenbarg/sdm";
 *
 * const approvalWorkflowStepExample = new sdm.ApprovalWorkflowStep("approvalWorkflowStepExample", {approvalFlowId: "af-343865"});
 * ```
 * <!--End PulumiCodeChooser -->
 * This resource can be imported using the import command.
 *
 * ## Import
 *
 * A ApprovalWorkflowStep can be imported using the id, e.g.,
 *
 * ```sh
 * $ pulumi import sdm:index/approvalWorkflowStep:ApprovalWorkflowStep example afs-12345678
 * ```
 */
export class ApprovalWorkflowStep extends pulumi.CustomResource {
    /**
     * Get an existing ApprovalWorkflowStep resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ApprovalWorkflowStepState, opts?: pulumi.CustomResourceOptions): ApprovalWorkflowStep {
        return new ApprovalWorkflowStep(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'sdm:index/approvalWorkflowStep:ApprovalWorkflowStep';

    /**
     * Returns true if the given object is an instance of ApprovalWorkflowStep.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ApprovalWorkflowStep {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ApprovalWorkflowStep.__pulumiType;
    }

    /**
     * The approval flow id specified the approval workfflow that this step belongs to
     */
    public readonly approvalFlowId!: pulumi.Output<string>;

    /**
     * Create a ApprovalWorkflowStep resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ApprovalWorkflowStepArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ApprovalWorkflowStepArgs | ApprovalWorkflowStepState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ApprovalWorkflowStepState | undefined;
            resourceInputs["approvalFlowId"] = state ? state.approvalFlowId : undefined;
        } else {
            const args = argsOrState as ApprovalWorkflowStepArgs | undefined;
            if ((!args || args.approvalFlowId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'approvalFlowId'");
            }
            resourceInputs["approvalFlowId"] = args ? args.approvalFlowId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ApprovalWorkflowStep.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ApprovalWorkflowStep resources.
 */
export interface ApprovalWorkflowStepState {
    /**
     * The approval flow id specified the approval workfflow that this step belongs to
     */
    approvalFlowId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ApprovalWorkflowStep resource.
 */
export interface ApprovalWorkflowStepArgs {
    /**
     * The approval flow id specified the approval workfflow that this step belongs to
     */
    approvalFlowId: pulumi.Input<string>;
}