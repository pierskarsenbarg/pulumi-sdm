// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Sdm.Inputs
{

    public sealed class NodeGatewayArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The hostname/port tuple which the gateway daemon will bind to. If not provided on create, set to "0.0.0.0:listen_address_port".
        /// </summary>
        [Input("bindAddress")]
        public Input<string>? BindAddress { get; set; }

        /// <summary>
        /// GatewayFilter can be used to restrict the peering between relays and gateways.
        /// </summary>
        [Input("gatewayFilter")]
        public Input<string>? GatewayFilter { get; set; }

        /// <summary>
        /// The public hostname/port tuple at which the gateway will be accessible to clients.
        /// </summary>
        [Input("listenAddress", required: true)]
        public Input<string> ListenAddress { get; set; } = null!;

        /// <summary>
        /// Unique human-readable name of the Relay. Node names must include only letters, numbers, and hyphens (no spaces, underscores, or other special characters). Generated if not provided on create.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Tags is a map of key, value pairs.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        [Input("token")]
        public Input<string>? Token { get; set; }

        public NodeGatewayArgs()
        {
        }
        public static new NodeGatewayArgs Empty => new NodeGatewayArgs();
    }
}
