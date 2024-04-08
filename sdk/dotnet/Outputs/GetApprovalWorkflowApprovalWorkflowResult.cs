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
    public sealed class GetApprovalWorkflowApprovalWorkflowResult
    {
        /// <summary>
        /// Approval mode of the ApprovalWorkflow
        /// </summary>
        public readonly string? ApprovalMode;
        /// <summary>
        /// Optional description of the ApprovalWorkflow.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Unique identifier of the ApprovalWorkflow.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Unique human-readable name of the ApprovalWorkflow.
        /// </summary>
        public readonly string? Name;

        [OutputConstructor]
        private GetApprovalWorkflowApprovalWorkflowResult(
            string? approvalMode,

            string? description,

            string? id,

            string? name)
        {
            ApprovalMode = approvalMode;
            Description = description;
            Id = id;
            Name = name;
        }
    }
}