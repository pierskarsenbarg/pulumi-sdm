// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Accounts are users that have access to strongDM. There are two types of accounts:
 *  1. **Users:** humans who are authenticated through username and password or SSO.
 *  2. **Service Accounts:** machines that are authenticated using a service token.
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as sdm from "@pierskarsenbarg/sdm";
 *
 * const test_user = new sdm.Account("test-user", {user: {
 *     email: "albob@strongdm.com",
 *     firstName: "al",
 *     lastName: "bob",
 *     tags: {
 *         env: "dev",
 *         region: "us-west",
 *     },
 * }});
 * const test_service = new sdm.Account("test-service", {service: {
 *     name: "test-service",
 *     tags: {
 *         env: "dev",
 *         region: "us-west",
 *     },
 * }});
 * ```
 * This resource can be imported using the import command.
 *
 * ## Import
 *
 * Account can be imported using the id, e.g.,
 *
 * ```sh
 *  $ pulumi import sdm:index/account:Account example a-12345678
 * ```
 */
export class Account extends pulumi.CustomResource {
    /**
     * Get an existing Account resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AccountState, opts?: pulumi.CustomResourceOptions): Account {
        return new Account(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'sdm:index/account:Account';

    /**
     * Returns true if the given object is an instance of Account.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Account {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Account.__pulumiType;
    }

    /**
     * A Service is a service account that can connect to resources they are granted directly, or granted via roles. Services
     * are typically automated jobs.
     */
    public readonly service!: pulumi.Output<outputs.AccountService | undefined>;
    /**
     * A User can connect to resources they are granted directly, or granted via roles.
     */
    public readonly user!: pulumi.Output<outputs.AccountUser | undefined>;

    /**
     * Create a Account resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: AccountArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AccountArgs | AccountState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as AccountState | undefined;
            resourceInputs["service"] = state ? state.service : undefined;
            resourceInputs["user"] = state ? state.user : undefined;
        } else {
            const args = argsOrState as AccountArgs | undefined;
            resourceInputs["service"] = args ? args.service : undefined;
            resourceInputs["user"] = args ? args.user : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Account.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Account resources.
 */
export interface AccountState {
    /**
     * A Service is a service account that can connect to resources they are granted directly, or granted via roles. Services
     * are typically automated jobs.
     */
    service?: pulumi.Input<inputs.AccountService>;
    /**
     * A User can connect to resources they are granted directly, or granted via roles.
     */
    user?: pulumi.Input<inputs.AccountUser>;
}

/**
 * The set of arguments for constructing a Account resource.
 */
export interface AccountArgs {
    /**
     * A Service is a service account that can connect to resources they are granted directly, or granted via roles. Services
     * are typically automated jobs.
     */
    service?: pulumi.Input<inputs.AccountService>;
    /**
     * A User can connect to resources they are granted directly, or granted via roles.
     */
    user?: pulumi.Input<inputs.AccountUser>;
}
