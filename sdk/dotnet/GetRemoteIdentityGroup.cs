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
    public static class GetRemoteIdentityGroup
    {
        /// <summary>
        /// A RemoteIdentityGroup defines a group of remote identities.
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using Pulumi;
        /// using Sdm = Pulumi.Sdm;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var @default = Sdm.GetRemoteIdentityGroup.Invoke(new()
        ///     {
        ///         Name = "default",
        ///     });
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetRemoteIdentityGroupResult> InvokeAsync(GetRemoteIdentityGroupArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetRemoteIdentityGroupResult>("sdm:index/getRemoteIdentityGroup:getRemoteIdentityGroup", args ?? new GetRemoteIdentityGroupArgs(), options.WithDefaults());

        /// <summary>
        /// A RemoteIdentityGroup defines a group of remote identities.
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using Pulumi;
        /// using Sdm = Pulumi.Sdm;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var @default = Sdm.GetRemoteIdentityGroup.Invoke(new()
        ///     {
        ///         Name = "default",
        ///     });
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetRemoteIdentityGroupResult> Invoke(GetRemoteIdentityGroupInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetRemoteIdentityGroupResult>("sdm:index/getRemoteIdentityGroup:getRemoteIdentityGroup", args ?? new GetRemoteIdentityGroupInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetRemoteIdentityGroupArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Unique identifier of the RemoteIdentityGroup.
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Unique human-readable name of the RemoteIdentityGroup.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        public GetRemoteIdentityGroupArgs()
        {
        }
        public static new GetRemoteIdentityGroupArgs Empty => new GetRemoteIdentityGroupArgs();
    }

    public sealed class GetRemoteIdentityGroupInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Unique identifier of the RemoteIdentityGroup.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Unique human-readable name of the RemoteIdentityGroup.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public GetRemoteIdentityGroupInvokeArgs()
        {
        }
        public static new GetRemoteIdentityGroupInvokeArgs Empty => new GetRemoteIdentityGroupInvokeArgs();
    }


    [OutputType]
    public sealed class GetRemoteIdentityGroupResult
    {
        /// <summary>
        /// Unique identifier of the RemoteIdentityGroup.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// a list of strings of ids of data sources that match the given arguments.
        /// </summary>
        public readonly ImmutableArray<string> Ids;
        /// <summary>
        /// Unique human-readable name of the RemoteIdentityGroup.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// A list where each element has the following attributes:
        /// </summary>
        public readonly ImmutableArray<Outputs.GetRemoteIdentityGroupRemoteIdentityGroupResult> RemoteIdentityGroups;

        [OutputConstructor]
        private GetRemoteIdentityGroupResult(
            string? id,

            ImmutableArray<string> ids,

            string? name,

            ImmutableArray<Outputs.GetRemoteIdentityGroupRemoteIdentityGroupResult> remoteIdentityGroups)
        {
            Id = id;
            Ids = ids;
            Name = name;
            RemoteIdentityGroups = remoteIdentityGroups;
        }
    }
}
