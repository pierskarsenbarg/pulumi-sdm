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
    public static class GetIdentityAlias
    {
        /// <summary>
        /// IdentityAliases define the username to be used for a specific account
        ///  when connecting to a remote resource using that identity set.
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
        ///     var user = Sdm.GetIdentityAlias.Invoke(new()
        ///     {
        ///         Id = "i-0900909",
        ///         Username = "user",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetIdentityAliasResult> InvokeAsync(GetIdentityAliasArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetIdentityAliasResult>("sdm:index/getIdentityAlias:getIdentityAlias", args ?? new GetIdentityAliasArgs(), options.WithDefaults());

        /// <summary>
        /// IdentityAliases define the username to be used for a specific account
        ///  when connecting to a remote resource using that identity set.
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
        ///     var user = Sdm.GetIdentityAlias.Invoke(new()
        ///     {
        ///         Id = "i-0900909",
        ///         Username = "user",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetIdentityAliasResult> Invoke(GetIdentityAliasInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetIdentityAliasResult>("sdm:index/getIdentityAlias:getIdentityAlias", args ?? new GetIdentityAliasInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetIdentityAliasArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The account for this identity alias.
        /// </summary>
        [Input("accountId")]
        public string? AccountId { get; set; }

        /// <summary>
        /// Unique identifier of the IdentityAlias.
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The identity set.
        /// </summary>
        [Input("identitySetId")]
        public string? IdentitySetId { get; set; }

        /// <summary>
        /// The username to be used as the identity alias for this account.
        /// </summary>
        [Input("username")]
        public string? Username { get; set; }

        public GetIdentityAliasArgs()
        {
        }
        public static new GetIdentityAliasArgs Empty => new GetIdentityAliasArgs();
    }

    public sealed class GetIdentityAliasInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The account for this identity alias.
        /// </summary>
        [Input("accountId")]
        public Input<string>? AccountId { get; set; }

        /// <summary>
        /// Unique identifier of the IdentityAlias.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// The identity set.
        /// </summary>
        [Input("identitySetId")]
        public Input<string>? IdentitySetId { get; set; }

        /// <summary>
        /// The username to be used as the identity alias for this account.
        /// </summary>
        [Input("username")]
        public Input<string>? Username { get; set; }

        public GetIdentityAliasInvokeArgs()
        {
        }
        public static new GetIdentityAliasInvokeArgs Empty => new GetIdentityAliasInvokeArgs();
    }


    [OutputType]
    public sealed class GetIdentityAliasResult
    {
        /// <summary>
        /// The account for this identity alias.
        /// </summary>
        public readonly string? AccountId;
        /// <summary>
        /// Unique identifier of the IdentityAlias.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// A list where each element has the following attributes:
        /// </summary>
        public readonly ImmutableArray<Outputs.GetIdentityAliasIdentityAliasResult> IdentityAliases;
        /// <summary>
        /// The identity set.
        /// </summary>
        public readonly string? IdentitySetId;
        /// <summary>
        /// a list of strings of ids of data sources that match the given arguments.
        /// </summary>
        public readonly ImmutableArray<string> Ids;
        /// <summary>
        /// The username to be used as the identity alias for this account.
        /// </summary>
        public readonly string? Username;

        [OutputConstructor]
        private GetIdentityAliasResult(
            string? accountId,

            string? id,

            ImmutableArray<Outputs.GetIdentityAliasIdentityAliasResult> identityAliases,

            string? identitySetId,

            ImmutableArray<string> ids,

            string? username)
        {
            AccountId = accountId;
            Id = id;
            IdentityAliases = identityAliases;
            IdentitySetId = identitySetId;
            Ids = ids;
            Username = username;
        }
    }
}