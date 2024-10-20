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
    public sealed class GetNodeNodeProxyClusterResult
    {
        /// <summary>
        /// The public hostname/port tuple at which the proxy cluster will be accessible to clients.
        /// </summary>
        public readonly string? Address;
        /// <summary>
        /// Unique identifier of the Relay.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Maintenance Windows define when this node is allowed to restart. If a node is requested to restart, it will check each window to determine if any of them permit it to restart, and if any do, it will. This check is repeated per window until the restart is successfully completed.  If not set here, may be set on the command line or via an environment variable on the process itself; any server setting will take precedence over local settings. This setting is ineffective for nodes below version 38.44.0.  If this setting is not applied via this remote configuration or via local configuration, the default setting is used: always allow restarts if serving no connections, and allow a restart even if serving connections between 7-8 UTC, any day.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetNodeNodeProxyClusterMaintenanceWindowResult> MaintenanceWindows;
        /// <summary>
        /// Unique human-readable name of the Relay. Node names must include only letters, numbers, and hyphens (no spaces, underscores, or other special characters). Generated if not provided on create.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Tags is a map of key, value pairs.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;

        [OutputConstructor]
        private GetNodeNodeProxyClusterResult(
            string? address,

            string? id,

            ImmutableArray<Outputs.GetNodeNodeProxyClusterMaintenanceWindowResult> maintenanceWindows,

            string? name,

            ImmutableDictionary<string, string>? tags)
        {
            Address = address;
            Id = id;
            MaintenanceWindows = maintenanceWindows;
            Name = name;
            Tags = tags;
        }
    }
}