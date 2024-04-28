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
    /// <summary>
    /// Nodes make up the strongDM network, and allow your users to connect securely to your resources.
    ///  There are two types of nodes:
    ///  1. **Relay:** creates connectivity to your datasources, while maintaining the egress-only nature of your firewall
    ///  2. **Gateways:** a relay that also listens for connections from strongDM clients
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Sdm = PiersKarsenbarg.Sdm;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var gateway = new Sdm.Node("gateway", new()
    ///     {
    ///         Gateway = new Sdm.Inputs.NodeGatewayArgs
    ///         {
    ///             BindAddress = "0.0.0.0:21222",
    ///             ListenAddress = "165.23.40.1:21222",
    ///             Name = "test-gateway",
    ///             Tags = 
    ///             {
    ///                 { "env", "dev" },
    ///                 { "region", "us-west" },
    ///             },
    ///         },
    ///     });
    /// 
    ///     var relay = new Sdm.Node("relay", new()
    ///     {
    ///         Relay = new Sdm.Inputs.NodeRelayArgs
    ///         {
    ///             Name = "test-relay",
    ///             Tags = 
    ///             {
    ///                 { "env", "dev" },
    ///                 { "region", "us-west" },
    ///             },
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// This resource can be imported using the import command.
    /// 
    /// ## Import
    /// 
    /// A Node can be imported using the id, e.g.,
    /// 
    /// ```sh
    /// $ pulumi import sdm:index/node:Node example n-12345678
    /// ```
    /// </summary>
    [SdmResourceType("sdm:index/node:Node")]
    public partial class Node : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Gateway represents a StrongDM CLI installation running in gateway mode.
        /// </summary>
        [Output("gateway")]
        public Output<Outputs.NodeGateway?> Gateway { get; private set; } = null!;

        /// <summary>
        /// Relay represents a StrongDM CLI installation running in relay mode.
        /// </summary>
        [Output("relay")]
        public Output<Outputs.NodeRelay?> Relay { get; private set; } = null!;


        /// <summary>
        /// Create a Node resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Node(string name, NodeArgs? args = null, CustomResourceOptions? options = null)
            : base("sdm:index/node:Node", name, args ?? new NodeArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Node(string name, Input<string> id, NodeState? state = null, CustomResourceOptions? options = null)
            : base("sdm:index/node:Node", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/pierskarsenbarg/pulumi-sdm",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Node resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Node Get(string name, Input<string> id, NodeState? state = null, CustomResourceOptions? options = null)
        {
            return new Node(name, id, state, options);
        }
    }

    public sealed class NodeArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Gateway represents a StrongDM CLI installation running in gateway mode.
        /// </summary>
        [Input("gateway")]
        public Input<Inputs.NodeGatewayArgs>? Gateway { get; set; }

        /// <summary>
        /// Relay represents a StrongDM CLI installation running in relay mode.
        /// </summary>
        [Input("relay")]
        public Input<Inputs.NodeRelayArgs>? Relay { get; set; }

        public NodeArgs()
        {
        }
        public static new NodeArgs Empty => new NodeArgs();
    }

    public sealed class NodeState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Gateway represents a StrongDM CLI installation running in gateway mode.
        /// </summary>
        [Input("gateway")]
        public Input<Inputs.NodeGatewayGetArgs>? Gateway { get; set; }

        /// <summary>
        /// Relay represents a StrongDM CLI installation running in relay mode.
        /// </summary>
        [Input("relay")]
        public Input<Inputs.NodeRelayGetArgs>? Relay { get; set; }

        public NodeState()
        {
        }
        public static new NodeState Empty => new NodeState();
    }
}
