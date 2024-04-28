// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Nodes make up the strongDM network, and allow your users to connect securely to your resources.
 *  There are two types of nodes:
 *  1. **Relay:** creates connectivity to your datasources, while maintaining the egress-only nature of your firewall
 *  2. **Gateways:** a relay that also listens for connections from strongDM clients
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as sdm from "@pierskarsenbarg/sdm";
 *
 * const gateway = new sdm.Node("gateway", {gateway: {
 *     bindAddress: "0.0.0.0:21222",
 *     listenAddress: "165.23.40.1:21222",
 *     name: "test-gateway",
 *     tags: {
 *         env: "dev",
 *         region: "us-west",
 *     },
 * }});
 * const relay = new sdm.Node("relay", {relay: {
 *     name: "test-relay",
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
 * A Node can be imported using the id, e.g.,
 *
 * ```sh
 * $ pulumi import sdm:index/node:Node example n-12345678
 * ```
 */
export class Node extends pulumi.CustomResource {
    /**
     * Get an existing Node resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: NodeState, opts?: pulumi.CustomResourceOptions): Node {
        return new Node(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'sdm:index/node:Node';

    /**
     * Returns true if the given object is an instance of Node.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Node {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Node.__pulumiType;
    }

    /**
     * Gateway represents a StrongDM CLI installation running in gateway mode.
     */
    public readonly gateway!: pulumi.Output<outputs.NodeGateway | undefined>;
    /**
     * Relay represents a StrongDM CLI installation running in relay mode.
     */
    public readonly relay!: pulumi.Output<outputs.NodeRelay | undefined>;

    /**
     * Create a Node resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: NodeArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: NodeArgs | NodeState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as NodeState | undefined;
            resourceInputs["gateway"] = state ? state.gateway : undefined;
            resourceInputs["relay"] = state ? state.relay : undefined;
        } else {
            const args = argsOrState as NodeArgs | undefined;
            resourceInputs["gateway"] = args ? args.gateway : undefined;
            resourceInputs["relay"] = args ? args.relay : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Node.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Node resources.
 */
export interface NodeState {
    /**
     * Gateway represents a StrongDM CLI installation running in gateway mode.
     */
    gateway?: pulumi.Input<inputs.NodeGateway>;
    /**
     * Relay represents a StrongDM CLI installation running in relay mode.
     */
    relay?: pulumi.Input<inputs.NodeRelay>;
}

/**
 * The set of arguments for constructing a Node resource.
 */
export interface NodeArgs {
    /**
     * Gateway represents a StrongDM CLI installation running in gateway mode.
     */
    gateway?: pulumi.Input<inputs.NodeGateway>;
    /**
     * Relay represents a StrongDM CLI installation running in relay mode.
     */
    relay?: pulumi.Input<inputs.NodeRelay>;
}
