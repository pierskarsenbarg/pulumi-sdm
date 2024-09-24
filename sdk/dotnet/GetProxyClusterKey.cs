// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Sdm
{
    public static class GetProxyClusterKey
    {
        /// <summary>
        /// Proxy Cluster Keys are authentication keys for all proxies within a cluster.
        ///  The proxies within a cluster share the same key. One cluster can have
        ///  multiple keys in order to facilitate key rotation.
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Sdm = Pulumi.Sdm;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var proxyClusterKeyQuery = Sdm.GetProxyClusterKey.Invoke(new()
        ///     {
        ///         ProxyClusterId = "n-233332245",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetProxyClusterKeyResult> InvokeAsync(GetProxyClusterKeyArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetProxyClusterKeyResult>("sdm:index/getProxyClusterKey:getProxyClusterKey", args ?? new GetProxyClusterKeyArgs(), options.WithDefaults());

        /// <summary>
        /// Proxy Cluster Keys are authentication keys for all proxies within a cluster.
        ///  The proxies within a cluster share the same key. One cluster can have
        ///  multiple keys in order to facilitate key rotation.
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Sdm = Pulumi.Sdm;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var proxyClusterKeyQuery = Sdm.GetProxyClusterKey.Invoke(new()
        ///     {
        ///         ProxyClusterId = "n-233332245",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetProxyClusterKeyResult> Invoke(GetProxyClusterKeyInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetProxyClusterKeyResult>("sdm:index/getProxyClusterKey:getProxyClusterKey", args ?? new GetProxyClusterKeyInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetProxyClusterKeyArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Unique identifier of the Relay.
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The ID of the proxy cluster which this key authenticates to.
        /// </summary>
        [Input("proxyClusterId")]
        public string? ProxyClusterId { get; set; }

        public GetProxyClusterKeyArgs()
        {
        }
        public static new GetProxyClusterKeyArgs Empty => new GetProxyClusterKeyArgs();
    }

    public sealed class GetProxyClusterKeyInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Unique identifier of the Relay.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// The ID of the proxy cluster which this key authenticates to.
        /// </summary>
        [Input("proxyClusterId")]
        public Input<string>? ProxyClusterId { get; set; }

        public GetProxyClusterKeyInvokeArgs()
        {
        }
        public static new GetProxyClusterKeyInvokeArgs Empty => new GetProxyClusterKeyInvokeArgs();
    }


    [OutputType]
    public sealed class GetProxyClusterKeyResult
    {
        /// <summary>
        /// Unique identifier of the Relay.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// a list of strings of ids of data sources that match the given arguments.
        /// </summary>
        public readonly ImmutableArray<string> Ids;
        /// <summary>
        /// The ID of the proxy cluster which this key authenticates to.
        /// </summary>
        public readonly string? ProxyClusterId;
        /// <summary>
        /// A list where each element has the following attributes:
        /// </summary>
        public readonly ImmutableArray<Outputs.GetProxyClusterKeyProxyClusterKeyResult> ProxyClusterKeys;

        [OutputConstructor]
        private GetProxyClusterKeyResult(
            string? id,

            ImmutableArray<string> ids,

            string? proxyClusterId,

            ImmutableArray<Outputs.GetProxyClusterKeyProxyClusterKeyResult> proxyClusterKeys)
        {
            Id = id;
            Ids = ids;
            ProxyClusterId = proxyClusterId;
            ProxyClusterKeys = proxyClusterKeys;
        }
    }
}
