// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * A Role has a list of access rules which determine which Resources the members
 *  of the Role have access to. An Account can be a member of multiple Roles via
 *  AccountAttachments.
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as sdm from "@pierskarsenbarg/sdm";
 *
 * const engineers = new sdm.Role("engineers", {tags: {
 *     foo: "bar",
 * }});
 * const example_role = new sdm.Role("example-role", {accessRules: JSON.stringify([
 *     {
 *         tags: {
 *             env: "staging",
 *         },
 *     },
 *     {
 *         type: "postgres",
 *         tags: {
 *             region: "us-west",
 *             env: "dev",
 *         },
 *     },
 *     {
 *         ids: ["rs-093e6f3061eb4dad"],
 *     },
 * ])});
 * ```
 * <!--End PulumiCodeChooser -->
 * This resource can be imported using the import command.
 *
 * ## Import
 *
 * A Role can be imported using the id, e.g.,
 *
 * ```sh
 * $ pulumi import sdm:index/role:Role example r-12345678
 * ```
 */
export class Role extends pulumi.CustomResource {
    /**
     * Get an existing Role resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: RoleState, opts?: pulumi.CustomResourceOptions): Role {
        return new Role(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'sdm:index/role:Role';

    /**
     * Returns true if the given object is an instance of Role.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Role {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Role.__pulumiType;
    }

    /**
     * AccessRules is a list of access rules defining the resources this Role has access to.
     */
    public readonly accessRules!: pulumi.Output<string>;
    /**
     * Managed By is a read only field for what service manages this role, e.g. StrongDM, Okta, Azure.
     */
    public /*out*/ readonly managedBy!: pulumi.Output<string>;
    /**
     * Unique human-readable name of the Role.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Tags is a map of key, value pairs.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;

    /**
     * Create a Role resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: RoleArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: RoleArgs | RoleState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as RoleState | undefined;
            resourceInputs["accessRules"] = state ? state.accessRules : undefined;
            resourceInputs["managedBy"] = state ? state.managedBy : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as RoleArgs | undefined;
            resourceInputs["accessRules"] = args ? args.accessRules : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["managedBy"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Role.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Role resources.
 */
export interface RoleState {
    /**
     * AccessRules is a list of access rules defining the resources this Role has access to.
     */
    accessRules?: pulumi.Input<string>;
    /**
     * Managed By is a read only field for what service manages this role, e.g. StrongDM, Okta, Azure.
     */
    managedBy?: pulumi.Input<string>;
    /**
     * Unique human-readable name of the Role.
     */
    name?: pulumi.Input<string>;
    /**
     * Tags is a map of key, value pairs.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}

/**
 * The set of arguments for constructing a Role resource.
 */
export interface RoleArgs {
    /**
     * AccessRules is a list of access rules defining the resources this Role has access to.
     */
    accessRules?: pulumi.Input<string>;
    /**
     * Unique human-readable name of the Role.
     */
    name?: pulumi.Input<string>;
    /**
     * Tags is a map of key, value pairs.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
