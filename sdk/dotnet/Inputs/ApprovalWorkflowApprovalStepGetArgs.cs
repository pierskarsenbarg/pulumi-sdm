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

    public sealed class ApprovalWorkflowApprovalStepGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("approvers", required: true)]
        private InputList<Inputs.ApprovalWorkflowApprovalStepApproverGetArgs>? _approvers;

        /// <summary>
        /// The approvers for this approval step
        /// </summary>
        public InputList<Inputs.ApprovalWorkflowApprovalStepApproverGetArgs> Approvers
        {
            get => _approvers ?? (_approvers = new InputList<Inputs.ApprovalWorkflowApprovalStepApproverGetArgs>());
            set => _approvers = value;
        }

        /// <summary>
        /// Whether any or all approvers are required to approve for this approval step (optional, defaults to any)
        /// </summary>
        [Input("quantifier")]
        public Input<string>? Quantifier { get; set; }

        /// <summary>
        /// Duration after which this approval step will be skipped if no approval is given (optional, if not provided this step must be manually approved)
        /// </summary>
        [Input("skipAfter")]
        public Input<string>? SkipAfter { get; set; }

        public ApprovalWorkflowApprovalStepGetArgs()
        {
        }
        public static new ApprovalWorkflowApprovalStepGetArgs Empty => new ApprovalWorkflowApprovalStepGetArgs();
    }
}
