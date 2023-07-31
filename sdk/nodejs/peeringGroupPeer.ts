// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * PeeringGroupPeer represents the link between two PeeringGroups
 * This resource can be imported using the import command.
 *
 * ## Import
 *
 * PeeringGroupPeer can be imported using the id, e.g.,
 *
 * ```sh
 *  $ pulumi import sdm:index/peeringGroupPeer:PeeringGroupPeer example gp-12345678
 * ```
 */
export class PeeringGroupPeer extends pulumi.CustomResource {
    /**
     * Get an existing PeeringGroupPeer resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: PeeringGroupPeerState, opts?: pulumi.CustomResourceOptions): PeeringGroupPeer {
        return new PeeringGroupPeer(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'sdm:index/peeringGroupPeer:PeeringGroupPeer';

    /**
     * Returns true if the given object is an instance of PeeringGroupPeer.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is PeeringGroupPeer {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === PeeringGroupPeer.__pulumiType;
    }

    /**
     * Group ID from which the link will originate.
     */
    public readonly groupId!: pulumi.Output<string>;
    /**
     * Peering Group ID to which Group ID will link.
     */
    public readonly peersWithGroupId!: pulumi.Output<string>;

    /**
     * Create a PeeringGroupPeer resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: PeeringGroupPeerArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: PeeringGroupPeerArgs | PeeringGroupPeerState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as PeeringGroupPeerState | undefined;
            resourceInputs["groupId"] = state ? state.groupId : undefined;
            resourceInputs["peersWithGroupId"] = state ? state.peersWithGroupId : undefined;
        } else {
            const args = argsOrState as PeeringGroupPeerArgs | undefined;
            resourceInputs["groupId"] = args ? args.groupId : undefined;
            resourceInputs["peersWithGroupId"] = args ? args.peersWithGroupId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(PeeringGroupPeer.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering PeeringGroupPeer resources.
 */
export interface PeeringGroupPeerState {
    /**
     * Group ID from which the link will originate.
     */
    groupId?: pulumi.Input<string>;
    /**
     * Peering Group ID to which Group ID will link.
     */
    peersWithGroupId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a PeeringGroupPeer resource.
 */
export interface PeeringGroupPeerArgs {
    /**
     * Group ID from which the link will originate.
     */
    groupId?: pulumi.Input<string>;
    /**
     * Peering Group ID to which Group ID will link.
     */
    peersWithGroupId?: pulumi.Input<string>;
}