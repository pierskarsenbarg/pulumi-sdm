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

    public sealed class AccountServiceArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Unique human-readable name of the Service.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The User's suspended state.
        /// </summary>
        [Input("suspended")]
        public Input<bool>? Suspended { get; set; }

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
        public Input<string>? Token { get; set; }

        public AccountServiceArgs()
        {
        }
        public static new AccountServiceArgs Empty => new AccountServiceArgs();
    }
}
