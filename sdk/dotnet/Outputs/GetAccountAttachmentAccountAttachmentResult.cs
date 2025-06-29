// *** WARNING: this file was generated by pulumi-language-dotnet. ***
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
    public sealed class GetAccountAttachmentAccountAttachmentResult
    {
        /// <summary>
        /// The id of the account of this AccountAttachment.
        /// </summary>
        public readonly string? AccountId;
        /// <summary>
        /// Unique identifier of the AccountAttachment.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The id of the attached role of this AccountAttachment.
        /// </summary>
        public readonly string? RoleId;

        [OutputConstructor]
        private GetAccountAttachmentAccountAttachmentResult(
            string? accountId,

            string? id,

            string? roleId)
        {
            AccountId = accountId;
            Id = id;
            RoleId = roleId;
        }
    }
}
