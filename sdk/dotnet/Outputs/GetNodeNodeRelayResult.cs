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
    public sealed class GetNodeNodeRelayResult
    {
        /// <summary>
        /// Device is a read only device name uploaded by the gateway process when  it comes online.
        /// </summary>
        public readonly string Device;
        /// <summary>
        /// GatewayFilter can be used to restrict the peering between relays and gateways.
        /// </summary>
        public readonly string? GatewayFilter;
        /// <summary>
        /// Unique identifier of the Relay.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Location is a read only network location uploaded by the gateway process when it comes online.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Unique human-readable name of the Relay. Node names must include only letters, numbers, and hyphens (no spaces, underscores, or other special characters). Generated if not provided on create.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Tags is a map of key, value pairs.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Version is a read only sdm binary version uploaded by the gateway process when it comes online.
        /// </summary>
        public readonly string Version;

        [OutputConstructor]
        private GetNodeNodeRelayResult(
            string device,

            string? gatewayFilter,

            string? id,

            string location,

            string? name,

            ImmutableDictionary<string, string>? tags,

            string version)
        {
            Device = device;
            GatewayFilter = gatewayFilter;
            Id = id;
            Location = location;
            Name = name;
            Tags = tags;
            Version = version;
        }
    }
}
