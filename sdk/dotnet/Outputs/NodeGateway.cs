// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Sdm.Outputs
{

    [OutputType]
    public sealed class NodeGateway
    {
        /// <summary>
        /// The hostname/port tuple which the gateway daemon will bind to. If not provided on create, set to "0.0.0.0:listen_address_port".
        /// </summary>
        public readonly string? BindAddress;
        /// <summary>
        /// Device is a read only device name uploaded by the gateway process when it comes online.
        /// </summary>
        public readonly string? Device;
        /// <summary>
        /// GatewayFilter can be used to restrict the peering between relays and gateways. Deprecated.
        /// </summary>
        public readonly string? GatewayFilter;
        /// <summary>
        /// The public hostname/port tuple at which the gateway will be accessible to clients.
        /// </summary>
        public readonly string ListenAddress;
        /// <summary>
        /// Location is a read only network location uploaded by the gateway process when it comes online.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Maintenance Windows define when this node is allowed to restart. If a node is requested to restart, it will check each window to determine if any of them permit it to restart, and if any do, it will. This check is repeated per window until the restart is successfully completed.  If not set here, may be set on the command line or via an environment variable on the process itself; any server setting will take precedence over local settings. This setting is ineffective for nodes below version 38.44.0.  If this setting is not applied via this remote configuration or via local configuration, the default setting is used: always allow restarts if serving no connections, and allow a restart even if serving connections between 7-8 UTC, any day.
        /// </summary>
        public readonly ImmutableArray<Outputs.NodeGatewayMaintenanceWindow> MaintenanceWindows;
        /// <summary>
        /// Unique human-readable name of the Relay. Node names must include only letters, numbers, and hyphens (no spaces, underscores, or other special characters). Generated if not provided on create.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Tags is a map of key, value pairs.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        public readonly string? Token;
        /// <summary>
        /// Version is a read only sdm binary version uploaded by the gateway process when it comes online.
        /// </summary>
        public readonly string? Version;

        [OutputConstructor]
        private NodeGateway(
            string? bindAddress,

            string? device,

            string? gatewayFilter,

            string listenAddress,

            string? location,

            ImmutableArray<Outputs.NodeGatewayMaintenanceWindow> maintenanceWindows,

            string? name,

            ImmutableDictionary<string, string>? tags,

            string? token,

            string? version)
        {
            BindAddress = bindAddress;
            Device = device;
            GatewayFilter = gatewayFilter;
            ListenAddress = listenAddress;
            Location = location;
            MaintenanceWindows = maintenanceWindows;
            Name = name;
            Tags = tags;
            Token = token;
            Version = version;
        }
    }
}
