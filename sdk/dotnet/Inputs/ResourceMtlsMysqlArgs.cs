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

    public sealed class ResourceMtlsMysqlArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The bind interface is the IP address to which the port override of a resource is bound (for example, 127.0.0.1). It is automatically generated if not provided.
        /// </summary>
        [Input("bindInterface")]
        public Input<string>? BindInterface { get; set; }

        [Input("certificateAuthority")]
        private Input<string>? _certificateAuthority;

        /// <summary>
        /// The CA to authenticate TLS connections with.
        /// </summary>
        public Input<string>? CertificateAuthority
        {
            get => _certificateAuthority;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _certificateAuthority = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("clientCertificate")]
        private Input<string>? _clientCertificate;

        /// <summary>
        /// The certificate to authenticate TLS connections with.
        /// </summary>
        public Input<string>? ClientCertificate
        {
            get => _clientCertificate;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _clientCertificate = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("clientKey")]
        private Input<string>? _clientKey;

        /// <summary>
        /// The key to authenticate TLS connections with.
        /// </summary>
        public Input<string>? ClientKey
        {
            get => _clientKey;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _clientKey = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// The initial database to connect to. This setting does not by itself prevent switching to another database after connecting.
        /// </summary>
        [Input("database")]
        public Input<string>? Database { get; set; }

        /// <summary>
        /// A filter applied to the routing logic to pin datasource to nodes.
        /// </summary>
        [Input("egressFilter")]
        public Input<string>? EgressFilter { get; set; }

        /// <summary>
        /// The host to dial to initiate a connection from the egress node to this resource.
        /// </summary>
        [Input("hostname", required: true)]
        public Input<string> Hostname { get; set; } = null!;

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
        /// The port to dial to initiate a connection from the egress node to this resource.
        /// </summary>
        [Input("port")]
        public Input<int>? Port { get; set; }

        /// <summary>
        /// The local port used by clients to connect to this resource.
        /// </summary>
        [Input("portOverride")]
        public Input<int>? PortOverride { get; set; }

        /// <summary>
        /// Whether native auth (mysql_native_password) is used for all connections (for backwards compatibility)
        /// </summary>
        [Input("requireNativeAuth")]
        public Input<bool>? RequireNativeAuth { get; set; }

        /// <summary>
        /// ID of the secret store containing credentials for this resource, if any.
        /// </summary>
        [Input("secretStoreId")]
        public Input<string>? SecretStoreId { get; set; }

        /// <summary>
        /// Server name for TLS verification (unverified by StrongDM if empty)
        /// </summary>
        [Input("serverName")]
        public Input<string>? ServerName { get; set; }

        /// <summary>
        /// Subdomain is the local DNS address.  (e.g. app-prod1 turns into app-prod1.your-org-name.sdm.network)
        /// </summary>
        [Input("subdomain")]
        public Input<string>? Subdomain { get; set; }

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
        /// If true, appends the hostname to the username when hitting a database.azure.com address
        /// </summary>
        [Input("useAzureSingleServerUsernames")]
        public Input<bool>? UseAzureSingleServerUsernames { get; set; }

        /// <summary>
        /// The username to authenticate with.
        /// </summary>
        [Input("username")]
        public Input<string>? Username { get; set; }

        public ResourceMtlsMysqlArgs()
        {
        }
        public static new ResourceMtlsMysqlArgs Empty => new ResourceMtlsMysqlArgs();
    }
}
