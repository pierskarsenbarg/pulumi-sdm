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
    public static class GetIdentitySet
    {
        /// <summary>
        /// A IdentitySet defines a group of identity aliases.
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Sdm = Pulumi.Sdm;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var @default = Sdm.GetIdentitySet.Invoke(new()
        ///     {
        ///         Name = "default",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetIdentitySetResult> InvokeAsync(GetIdentitySetArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetIdentitySetResult>("sdm:index/getIdentitySet:getIdentitySet", args ?? new GetIdentitySetArgs(), options.WithDefaults());

        /// <summary>
        /// A IdentitySet defines a group of identity aliases.
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Sdm = Pulumi.Sdm;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var @default = Sdm.GetIdentitySet.Invoke(new()
        ///     {
        ///         Name = "default",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetIdentitySetResult> Invoke(GetIdentitySetInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetIdentitySetResult>("sdm:index/getIdentitySet:getIdentitySet", args ?? new GetIdentitySetInvokeArgs(), options.WithDefaults());

        /// <summary>
        /// A IdentitySet defines a group of identity aliases.
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Sdm = Pulumi.Sdm;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var @default = Sdm.GetIdentitySet.Invoke(new()
        ///     {
        ///         Name = "default",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetIdentitySetResult> Invoke(GetIdentitySetInvokeArgs args, InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetIdentitySetResult>("sdm:index/getIdentitySet:getIdentitySet", args ?? new GetIdentitySetInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetIdentitySetArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Unique identifier of the IdentitySet.
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Unique human-readable name of the IdentitySet.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        public GetIdentitySetArgs()
        {
        }
        public static new GetIdentitySetArgs Empty => new GetIdentitySetArgs();
    }

    public sealed class GetIdentitySetInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Unique identifier of the IdentitySet.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Unique human-readable name of the IdentitySet.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public GetIdentitySetInvokeArgs()
        {
        }
        public static new GetIdentitySetInvokeArgs Empty => new GetIdentitySetInvokeArgs();
    }


    [OutputType]
    public sealed class GetIdentitySetResult
    {
        /// <summary>
        /// Unique identifier of the IdentitySet.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// A list where each element has the following attributes:
        /// </summary>
        public readonly ImmutableArray<Outputs.GetIdentitySetIdentitySetResult> IdentitySets;
        /// <summary>
        /// a list of strings of ids of data sources that match the given arguments.
        /// </summary>
        public readonly ImmutableArray<string> Ids;
        /// <summary>
        /// Unique human-readable name of the IdentitySet.
        /// </summary>
        public readonly string? Name;

        [OutputConstructor]
        private GetIdentitySetResult(
            string? id,

            ImmutableArray<Outputs.GetIdentitySetIdentitySetResult> identitySets,

            ImmutableArray<string> ids,

            string? name)
        {
            Id = id;
            IdentitySets = identitySets;
            Ids = ids;
            Name = name;
        }
    }
}
