// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Sdm.Inputs
{

    public sealed class AccountUserGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The User's email address. Must be unique.
        /// </summary>
        [Input("email", required: true)]
        public Input<string> Email { get; set; } = null!;

        /// <summary>
        /// External ID is an alternative unique ID this user is represented by within an external service.
        /// </summary>
        [Input("externalId")]
        public Input<string>? ExternalId { get; set; }

        /// <summary>
        /// The User's first name.
        /// </summary>
        [Input("firstName", required: true)]
        public Input<string> FirstName { get; set; } = null!;

        /// <summary>
        /// The User's last name.
        /// </summary>
        [Input("lastName", required: true)]
        public Input<string> LastName { get; set; } = null!;

        /// <summary>
        /// Managed By is a read only field for what service manages this user, e.g. StrongDM, Okta, Azure.
        /// </summary>
        [Input("managedBy")]
        public Input<string>? ManagedBy { get; set; }

        /// <summary>
        /// Manager ID is the ID of the user's manager. This field is empty when the user has no manager.
        /// </summary>
        [Input("managerId")]
        public Input<string>? ManagerId { get; set; }

        /// <summary>
        /// PermissionLevel is the user's permission level e.g. admin, DBA, user.
        /// </summary>
        [Input("permissionLevel")]
        public Input<string>? PermissionLevel { get; set; }

        /// <summary>
        /// Resolved Manager ID is the ID of the user's manager derived from the manager_id, if present, or from the SCIM metadata. This is a read-only field that's only populated for get and list.
        /// </summary>
        [Input("resolvedManagerId")]
        public Input<string>? ResolvedManagerId { get; set; }

        /// <summary>
        /// SCIM contains the raw SCIM metadata for the user. This is a read-only field.
        /// </summary>
        [Input("scim")]
        public Input<string>? Scim { get; set; }

        /// <summary>
        /// The Service's suspended state.
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

        public AccountUserGetArgs()
        {
        }
        public static new AccountUserGetArgs Empty => new AccountUserGetArgs();
    }
}
