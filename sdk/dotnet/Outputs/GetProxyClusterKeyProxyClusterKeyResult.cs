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
    public sealed class GetProxyClusterKeyProxyClusterKeyResult
    {
        /// <summary>
        /// Unique identifier of the Relay.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The ID of the proxy cluster which this key authenticates to.
        /// </summary>
        public readonly string? ProxyClusterId;

        [OutputConstructor]
        private GetProxyClusterKeyProxyClusterKeyResult(
            string? id,

            string? proxyClusterId)
        {
            Id = id;
            ProxyClusterId = proxyClusterId;
        }
    }
}
