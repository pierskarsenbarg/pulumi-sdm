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
    public sealed class GetApprovalWorkflowStepApprovalWorkflowStepResult
    {
        /// <summary>
        /// The approval flow id specified the approval workfflow that this step belongs to
        /// </summary>
        public readonly string? ApprovalFlowId;
        /// <summary>
        /// Unique identifier of the ApprovalWorkflowStep.
        /// </summary>
        public readonly string? Id;

        [OutputConstructor]
        private GetApprovalWorkflowStepApprovalWorkflowStepResult(
            string? approvalFlowId,

            string? id)
        {
            ApprovalFlowId = approvalFlowId;
            Id = id;
        }
    }
}
