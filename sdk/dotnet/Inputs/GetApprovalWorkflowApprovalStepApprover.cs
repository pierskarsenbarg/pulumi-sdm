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

    public sealed class GetApprovalWorkflowApprovalStepApproverArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The account id of the approver (only one of account_id, role_id, or reference may be present for one approver)
        /// </summary>
        [Input("accountId")]
        public string? AccountId { get; set; }

        /// <summary>
        /// A reference to an approver: 'manager-of-requester' or 'manager-of-manager-of-requester' (only one of account_id, role_id, or reference may be present for one approver)
        /// </summary>
        [Input("reference")]
        public string? Reference { get; set; }

        /// <summary>
        /// The role id of the approver (only one of account_id, role_id, or reference may be present for one approver)
        /// </summary>
        [Input("roleId")]
        public string? RoleId { get; set; }

        public GetApprovalWorkflowApprovalStepApproverArgs()
        {
        }
        public static new GetApprovalWorkflowApprovalStepApproverArgs Empty => new GetApprovalWorkflowApprovalStepApproverArgs();
    }
}
