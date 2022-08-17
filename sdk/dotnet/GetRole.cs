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
    public static class GetRole
    {
        /// <summary>
        /// A Role has a list of access rules which determine which Resources the members
        ///  of the Role have access to. An Account can be a member of multiple Roles via
        ///  AccountAttachments.
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Sdm = Pulumi.Sdm;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var compositeRoleQuery = Output.Create(Sdm.GetRole.InvokeAsync(new Sdm.GetRoleArgs
        ///         {
        ///             Composite = true,
        ///             Tags = 
        ///             {
        ///                 { "env", "dev" },
        ///                 { "region", "us-west" },
        ///             },
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetRoleResult> InvokeAsync(GetRoleArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetRoleResult>("sdm:index/getRole:getRole", args ?? new GetRoleArgs(), options.WithDefaults());

        /// <summary>
        /// A Role has a list of access rules which determine which Resources the members
        ///  of the Role have access to. An Account can be a member of multiple Roles via
        ///  AccountAttachments.
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Sdm = Pulumi.Sdm;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var compositeRoleQuery = Output.Create(Sdm.GetRole.InvokeAsync(new Sdm.GetRoleArgs
        ///         {
        ///             Composite = true,
        ///             Tags = 
        ///             {
        ///                 { "env", "dev" },
        ///                 { "region", "us-west" },
        ///             },
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetRoleResult> Invoke(GetRoleInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetRoleResult>("sdm:index/getRole:getRole", args ?? new GetRoleInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetRoleArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Unique identifier of the Role.
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Unique human-readable name of the Role.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        [Input("tags")]
        private Dictionary<string, string>? _tags;

        /// <summary>
        /// Tags is a map of key, value pairs.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get => _tags ?? (_tags = new Dictionary<string, string>());
            set => _tags = value;
        }

        public GetRoleArgs()
        {
        }
    }

    public sealed class GetRoleInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Unique identifier of the Role.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Unique human-readable name of the Role.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Tags is a map of key, value pairs.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public GetRoleInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetRoleResult
    {
        /// <summary>
        /// Unique identifier of the Role.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// a list of strings of ids of data sources that match the given arguments.
        /// </summary>
        public readonly ImmutableArray<string> Ids;
        /// <summary>
        /// Unique human-readable name of the Role.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// A list where each element has the following attributes:
        /// </summary>
        public readonly ImmutableArray<Outputs.GetRoleRoleResult> Roles;
        /// <summary>
        /// Tags is a map of key, value pairs.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;

        [OutputConstructor]
        private GetRoleResult(
            string? id,

            ImmutableArray<string> ids,

            string? name,

            ImmutableArray<Outputs.GetRoleRoleResult> roles,

            ImmutableDictionary<string, string>? tags)
        {
            Id = id;
            Ids = ids;
            Name = name;
            Roles = roles;
            Tags = tags;
        }
    }
}
