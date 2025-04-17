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

    public sealed class GetApprovalWorkflowApprovalStepApproverInputArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The account id of the approver (only an account_id OR a role_id may be present for one approver)
        /// </summary>
        [Input("accountId")]
        public Input<string>? AccountId { get; set; }

        /// <summary>
        /// The role id of the approver (only an account_id OR a role_id may be present for one approver)
        /// </summary>
        [Input("roleId")]
        public Input<string>? RoleId { get; set; }

        public GetApprovalWorkflowApprovalStepApproverInputArgs()
        {
        }
        public static new GetApprovalWorkflowApprovalStepApproverInputArgs Empty => new GetApprovalWorkflowApprovalStepApproverInputArgs();
    }
}
