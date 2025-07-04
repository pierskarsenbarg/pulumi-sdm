// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Accounts are users that have access to strongDM. The types of accounts are:
 *  1. **Users:** humans who are authenticated through username and password or SSO.
 *  2. **Service Accounts:** machines that are authenticated using a service token.
 *  3. **Tokens** are access keys with permissions that can be used for authentication.
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as sdm from "@pierskarsenbarg/sdm";
 *
 * const user_queries = sdm.getAccount({
 *     email: "*@strongdm.com",
 *     tags: {
 *         env: "dev",
 *         region: "us-west",
 *     },
 *     type: "user",
 * });
 * const api_key_queries = sdm.getAccount({
 *     name: "*-dev",
 *     type: "api",
 * });
 * const admin_token_queries = sdm.getAccount({
 *     name: "*-prod",
 *     type: "admin-token",
 * });
 * ```
 */
export function getAccount(args?: GetAccountArgs, opts?: pulumi.InvokeOptions): Promise<GetAccountResult> {
    args = args || {};
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("sdm:index/getAccount:getAccount", {
        "accountType": args.accountType,
        "email": args.email,
        "externalId": args.externalId,
        "firstName": args.firstName,
        "id": args.id,
        "lastName": args.lastName,
        "managerId": args.managerId,
        "name": args.name,
        "permissionLevel": args.permissionLevel,
        "permissions": args.permissions,
        "suspended": args.suspended,
        "tags": args.tags,
        "type": args.type,
    }, opts);
}

/**
 * A collection of arguments for invoking getAccount.
 */
export interface GetAccountArgs {
    /**
     * Corresponds to the type of token, e.g. api or admin-token.
     */
    accountType?: string;
    /**
     * The User's email address. Must be unique.
     */
    email?: string;
    /**
     * External ID is an alternative unique ID this user is represented by within an external service.
     */
    externalId?: string;
    /**
     * The User's first name.
     */
    firstName?: string;
    /**
     * Unique identifier of the User.
     */
    id?: string;
    /**
     * The User's last name.
     */
    lastName?: string;
    /**
     * Manager ID is the ID of the user's manager. This field is empty when the user has no manager.
     */
    managerId?: string;
    /**
     * Unique human-readable name of the Token.
     */
    name?: string;
    /**
     * PermissionLevel is the user's permission level e.g. admin, DBA, user.
     */
    permissionLevel?: string;
    /**
     * Permissions assigned to the token, e.g. role:create.
     */
    permissions?: string;
    /**
     * Reserved for future use.  Always false for tokens.
     */
    suspended?: boolean;
    /**
     * Tags is a map of key, value pairs.
     */
    tags?: {[key: string]: string};
    /**
     * a filter to select all items of a certain subtype. See the [filter documentation](https://www.strongdm.com/docs/cli/filters/) for more information.
     */
    type?: string;
}

/**
 * A collection of values returned by getAccount.
 */
export interface GetAccountResult {
    /**
     * Corresponds to the type of token, e.g. api or admin-token.
     */
    readonly accountType?: string;
    /**
     * A single element list containing a map, where each key lists one of the following objects:
     * * service:
     */
    readonly accounts: outputs.GetAccountAccount[];
    /**
     * The User's email address. Must be unique.
     */
    readonly email?: string;
    /**
     * External ID is an alternative unique ID this user is represented by within an external service.
     */
    readonly externalId?: string;
    /**
     * The User's first name.
     */
    readonly firstName?: string;
    /**
     * Unique identifier of the User.
     */
    readonly id?: string;
    /**
     * a list of strings of ids of data sources that match the given arguments.
     */
    readonly ids: string[];
    /**
     * The User's last name.
     */
    readonly lastName?: string;
    /**
     * Manager ID is the ID of the user's manager. This field is empty when the user has no manager.
     */
    readonly managerId?: string;
    /**
     * Unique human-readable name of the Token.
     */
    readonly name?: string;
    /**
     * PermissionLevel is the user's permission level e.g. admin, DBA, user.
     */
    readonly permissionLevel?: string;
    /**
     * Permissions assigned to the token, e.g. role:create.
     */
    readonly permissions?: string;
    /**
     * Suspended is a read only field for the User's suspended state.
     */
    readonly suspended?: boolean;
    /**
     * Tags is a map of key, value pairs.
     */
    readonly tags?: {[key: string]: string};
    readonly type?: string;
}
/**
 * Accounts are users that have access to strongDM. The types of accounts are:
 *  1. **Users:** humans who are authenticated through username and password or SSO.
 *  2. **Service Accounts:** machines that are authenticated using a service token.
 *  3. **Tokens** are access keys with permissions that can be used for authentication.
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as sdm from "@pierskarsenbarg/sdm";
 *
 * const user_queries = sdm.getAccount({
 *     email: "*@strongdm.com",
 *     tags: {
 *         env: "dev",
 *         region: "us-west",
 *     },
 *     type: "user",
 * });
 * const api_key_queries = sdm.getAccount({
 *     name: "*-dev",
 *     type: "api",
 * });
 * const admin_token_queries = sdm.getAccount({
 *     name: "*-prod",
 *     type: "admin-token",
 * });
 * ```
 */
export function getAccountOutput(args?: GetAccountOutputArgs, opts?: pulumi.InvokeOutputOptions): pulumi.Output<GetAccountResult> {
    args = args || {};
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invokeOutput("sdm:index/getAccount:getAccount", {
        "accountType": args.accountType,
        "email": args.email,
        "externalId": args.externalId,
        "firstName": args.firstName,
        "id": args.id,
        "lastName": args.lastName,
        "managerId": args.managerId,
        "name": args.name,
        "permissionLevel": args.permissionLevel,
        "permissions": args.permissions,
        "suspended": args.suspended,
        "tags": args.tags,
        "type": args.type,
    }, opts);
}

/**
 * A collection of arguments for invoking getAccount.
 */
export interface GetAccountOutputArgs {
    /**
     * Corresponds to the type of token, e.g. api or admin-token.
     */
    accountType?: pulumi.Input<string>;
    /**
     * The User's email address. Must be unique.
     */
    email?: pulumi.Input<string>;
    /**
     * External ID is an alternative unique ID this user is represented by within an external service.
     */
    externalId?: pulumi.Input<string>;
    /**
     * The User's first name.
     */
    firstName?: pulumi.Input<string>;
    /**
     * Unique identifier of the User.
     */
    id?: pulumi.Input<string>;
    /**
     * The User's last name.
     */
    lastName?: pulumi.Input<string>;
    /**
     * Manager ID is the ID of the user's manager. This field is empty when the user has no manager.
     */
    managerId?: pulumi.Input<string>;
    /**
     * Unique human-readable name of the Token.
     */
    name?: pulumi.Input<string>;
    /**
     * PermissionLevel is the user's permission level e.g. admin, DBA, user.
     */
    permissionLevel?: pulumi.Input<string>;
    /**
     * Permissions assigned to the token, e.g. role:create.
     */
    permissions?: pulumi.Input<string>;
    /**
     * Reserved for future use.  Always false for tokens.
     */
    suspended?: pulumi.Input<boolean>;
    /**
     * Tags is a map of key, value pairs.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * a filter to select all items of a certain subtype. See the [filter documentation](https://www.strongdm.com/docs/cli/filters/) for more information.
     */
    type?: pulumi.Input<string>;
}
