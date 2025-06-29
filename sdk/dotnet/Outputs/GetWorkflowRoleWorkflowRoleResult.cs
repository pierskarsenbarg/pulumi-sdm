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
    public sealed class GetWorkflowRoleWorkflowRoleResult
    {
        /// <summary>
        /// Unique identifier of the WorkflowRole.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The role id.
        /// </summary>
        public readonly string? RoleId;
        /// <summary>
        /// The workflow id.
        /// </summary>
        public readonly string? WorkflowId;

        [OutputConstructor]
        private GetWorkflowRoleWorkflowRoleResult(
            string? id,

            string? roleId,

            string? workflowId)
        {
            Id = id;
            RoleId = roleId;
            WorkflowId = workflowId;
        }
    }
}
