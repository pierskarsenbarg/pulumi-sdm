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

    public sealed class NodeRelayArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// ConnectsTo can be used to restrict the peering between relays and gateways.
        /// </summary>
        [Input("connectsTo")]
        public Input<string>? ConnectsTo { get; set; }

        /// <summary>
        /// Device is a read only device name uploaded by the gateway process when it comes online.
        /// </summary>
        [Input("device")]
        public Input<string>? Device { get; set; }

        /// <summary>
        /// GatewayFilter can be used to restrict the peering between relays and gateways. Deprecated.
        /// </summary>
        [Input("gatewayFilter")]
        public Input<string>? GatewayFilter { get; set; }

        /// <summary>
        /// Location is a read only network location uploaded by the gateway process when it comes online.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        [Input("maintenanceWindows")]
        private InputList<Inputs.NodeRelayMaintenanceWindowArgs>? _maintenanceWindows;

        /// <summary>
        /// Maintenance Windows define when this node is allowed to restart. If a node is requested to restart, it will check each window to determine if any of them permit it to restart, and if any do, it will. This check is repeated per window until the restart is successfully completed.  If not set here, may be set on the command line or via an environment variable on the process itself; any server setting will take precedence over local settings. This setting is ineffective for nodes below version 38.44.0.  If this setting is not applied via this remote configuration or via local configuration, the default setting is used: always allow restarts if serving no connections, and allow a restart even if serving connections between 7-8 UTC, any day.
        /// </summary>
        public InputList<Inputs.NodeRelayMaintenanceWindowArgs> MaintenanceWindows
        {
            get => _maintenanceWindows ?? (_maintenanceWindows = new InputList<Inputs.NodeRelayMaintenanceWindowArgs>());
            set => _maintenanceWindows = value;
        }

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
        private Input<string>? _token;
        public Input<string>? Token
        {
            get => _token;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _token = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// Version is a read only sdm binary version uploaded by the gateway process when it comes online.
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        public NodeRelayArgs()
        {
        }
        public static new NodeRelayArgs Empty => new NodeRelayArgs();
    }
}
