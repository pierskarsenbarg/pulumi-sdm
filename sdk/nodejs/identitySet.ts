// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * A IdentitySet defines a group of identity aliases.
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as sdm from "@pierskarsenbarg/sdm";
 *
 * const _default = new sdm.IdentitySet("default", {});
 * ```
 * This resource can be imported using the import command.
 *
 * ## Import
 *
 * A IdentitySet can be imported using the id, e.g.,
 *
 * ```sh
 * $ pulumi import sdm:index/identitySet:IdentitySet example ig-12345678
 * ```
 */
export class IdentitySet extends pulumi.CustomResource {
    /**
     * Get an existing IdentitySet resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: IdentitySetState, opts?: pulumi.CustomResourceOptions): IdentitySet {
        return new IdentitySet(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'sdm:index/identitySet:IdentitySet';

    /**
     * Returns true if the given object is an instance of IdentitySet.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is IdentitySet {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === IdentitySet.__pulumiType;
    }

    /**
     * Unique human-readable name of the IdentitySet.
     */
    public readonly name!: pulumi.Output<string>;

    /**
     * Create a IdentitySet resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: IdentitySetArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: IdentitySetArgs | IdentitySetState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as IdentitySetState | undefined;
            resourceInputs["name"] = state ? state.name : undefined;
        } else {
            const args = argsOrState as IdentitySetArgs | undefined;
            resourceInputs["name"] = args ? args.name : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(IdentitySet.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering IdentitySet resources.
 */
export interface IdentitySetState {
    /**
     * Unique human-readable name of the IdentitySet.
     */
    name?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a IdentitySet resource.
 */
export interface IdentitySetArgs {
    /**
     * Unique human-readable name of the IdentitySet.
     */
    name?: pulumi.Input<string>;
}
