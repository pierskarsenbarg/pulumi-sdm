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
    public sealed class GetAccountAccountUserResult
    {
        /// <summary>
        /// The User's email address. Must be unique.
        /// </summary>
        public readonly string? Email;
        /// <summary>
        /// External ID is an alternative unique ID this user is represented by within an external service.
        /// </summary>
        public readonly string? ExternalId;
        /// <summary>
        /// The User's first name.
        /// </summary>
        public readonly string? FirstName;
        /// <summary>
        /// Unique identifier of the User.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The User's last name.
        /// </summary>
        public readonly string? LastName;
        /// <summary>
        /// Managed By is a read only field for what service manages this user, e.g. StrongDM, Okta, Azure.
        /// </summary>
        public readonly string ManagedBy;
        /// <summary>
        /// PermissionLevel is a read only field for the user's permission level e.g. admin, DBA, user.
        /// </summary>
        public readonly string PermissionLevel;
        /// <summary>
        /// The User's suspended state.
        /// </summary>
        public readonly bool? Suspended;
        /// <summary>
        /// Tags is a map of key, value pairs.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;

        [OutputConstructor]
        private GetAccountAccountUserResult(
            string? email,

            string? externalId,

            string? firstName,

            string? id,

            string? lastName,

            string managedBy,

            string permissionLevel,

            bool? suspended,

            ImmutableDictionary<string, string>? tags)
        {
            Email = email;
            ExternalId = externalId;
            FirstName = firstName;
            Id = id;
            LastName = lastName;
            ManagedBy = managedBy;
            PermissionLevel = permissionLevel;
            Suspended = suspended;
            Tags = tags;
        }
    }
}
