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

    public sealed class ResourceHttpBasicAuthArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The bind interface is the IP address to which the port override of a resource is bound (for example, 127.0.0.1). It is automatically generated if not provided.
        /// </summary>
        [Input("bindInterface")]
        public Input<string>? BindInterface { get; set; }

        /// <summary>
        /// Automatically redirect to this path upon connecting.
        /// </summary>
        [Input("defaultPath")]
        public Input<string>? DefaultPath { get; set; }

        /// <summary>
        /// A filter applied to the routing logic to pin datasource to nodes.
        /// </summary>
        [Input("egressFilter")]
        public Input<string>? EgressFilter { get; set; }

        /// <summary>
        /// Header names (e.g. Authorization), to omit from logs.
        /// </summary>
        [Input("headersBlacklist")]
        public Input<string>? HeadersBlacklist { get; set; }

        /// <summary>
        /// This path will be used to check the health of your site.
        /// </summary>
        [Input("healthcheckPath", required: true)]
        public Input<string> HealthcheckPath { get; set; } = null!;

        /// <summary>
        /// The host header will be overwritten with this field if provided.
        /// </summary>
        [Input("hostOverride")]
        public Input<string>? HostOverride { get; set; }

        /// <summary>
        /// Unique human-readable name of the Resource.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("password")]
        private Input<string>? _password;

        /// <summary>
        /// The password to authenticate with.
        /// </summary>
        public Input<string>? Password
        {
            get => _password;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _password = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// ID of the secret store containing credentials for this resource, if any.
        /// </summary>
        [Input("secretStoreId")]
        public Input<string>? SecretStoreId { get; set; }

        /// <summary>
        /// Subdomain is the local DNS address.  (e.g. app-prod1 turns into app-prod1.your-org-name.sdm.network)
        /// </summary>
        [Input("subdomain", required: true)]
        public Input<string> Subdomain { get; set; } = null!;

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

        /// <summary>
        /// The base address of your website without the path.
        /// * kubernetes:
        /// </summary>
        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        /// <summary>
        /// The username to authenticate with.
        /// </summary>
        [Input("username")]
        public Input<string>? Username { get; set; }

        public ResourceHttpBasicAuthArgs()
        {
        }
        public static new ResourceHttpBasicAuthArgs Empty => new ResourceHttpBasicAuthArgs();
    }
}
