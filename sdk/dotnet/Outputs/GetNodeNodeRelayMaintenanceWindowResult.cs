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
    public sealed class GetNodeNodeRelayMaintenanceWindowResult
    {
        public readonly string CronSchedule;
        public readonly bool RequireIdleness;

        [OutputConstructor]
        private GetNodeNodeRelayMaintenanceWindowResult(
            string cronSchedule,

            bool requireIdleness)
        {
            CronSchedule = cronSchedule;
            RequireIdleness = requireIdleness;
        }
    }
}
