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

    public sealed class SecretStoreCyberarkPamGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The URL of the Cyberark instance
        /// </summary>
        [Input("appUrl", required: true)]
        public Input<string> AppUrl { get; set; } = null!;

        /// <summary>
        /// Unique human-readable name of the SecretStore.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

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

        public SecretStoreCyberarkPamGetArgs()
        {
        }
        public static new SecretStoreCyberarkPamGetArgs Empty => new SecretStoreCyberarkPamGetArgs();
    }
}
