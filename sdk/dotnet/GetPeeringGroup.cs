// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Sdm
{
    public static class GetPeeringGroup
    {
        /// <summary>
        /// PeeringGroups are the building blocks used for explicit network topology making.
        ///  They may be linked to other peering groups. Sets of PeeringGroupResource and PeeringGroupNode can be attached to a peering group.
        /// </summary>
        public static Task<GetPeeringGroupResult> InvokeAsync(GetPeeringGroupArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetPeeringGroupResult>("sdm:index/getPeeringGroup:getPeeringGroup", args ?? new GetPeeringGroupArgs(), options.WithDefaults());

        /// <summary>
        /// PeeringGroups are the building blocks used for explicit network topology making.
        ///  They may be linked to other peering groups. Sets of PeeringGroupResource and PeeringGroupNode can be attached to a peering group.
        /// </summary>
        public static Output<GetPeeringGroupResult> Invoke(GetPeeringGroupInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetPeeringGroupResult>("sdm:index/getPeeringGroup:getPeeringGroup", args ?? new GetPeeringGroupInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetPeeringGroupArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Unique identifier of the PeeringGroup.
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Unique human-readable name of the PeeringGroup.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        public GetPeeringGroupArgs()
        {
        }
        public static new GetPeeringGroupArgs Empty => new GetPeeringGroupArgs();
    }

    public sealed class GetPeeringGroupInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Unique identifier of the PeeringGroup.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Unique human-readable name of the PeeringGroup.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public GetPeeringGroupInvokeArgs()
        {
        }
        public static new GetPeeringGroupInvokeArgs Empty => new GetPeeringGroupInvokeArgs();
    }


    [OutputType]
    public sealed class GetPeeringGroupResult
    {
        /// <summary>
        /// Unique identifier of the PeeringGroup.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// a list of strings of ids of data sources that match the given arguments.
        /// </summary>
        public readonly ImmutableArray<string> Ids;
        /// <summary>
        /// Unique human-readable name of the PeeringGroup.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// A list where each element has the following attributes:
        /// </summary>
        public readonly ImmutableArray<Outputs.GetPeeringGroupPeeringGroupResult> PeeringGroups;

        [OutputConstructor]
        private GetPeeringGroupResult(
            string? id,

            ImmutableArray<string> ids,

            string? name,

            ImmutableArray<Outputs.GetPeeringGroupPeeringGroupResult> peeringGroups)
        {
            Id = id;
            Ids = ids;
            Name = name;
            PeeringGroups = peeringGroups;
        }
    }
}
