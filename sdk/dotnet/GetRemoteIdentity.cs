// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Sdm
{
    public static class GetRemoteIdentity
    {
        /// <summary>
        /// RemoteIdentities define the username to be used for a specific account
        ///  when connecting to a remote resource using that group.
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
        ///     var user = Sdm.GetRemoteIdentity.Invoke(new()
        ///     {
        ///         Id = "i-0900909",
        ///         Username = "user",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetRemoteIdentityResult> InvokeAsync(GetRemoteIdentityArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetRemoteIdentityResult>("sdm:index/getRemoteIdentity:getRemoteIdentity", args ?? new GetRemoteIdentityArgs(), options.WithDefaults());

        /// <summary>
        /// RemoteIdentities define the username to be used for a specific account
        ///  when connecting to a remote resource using that group.
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
        ///     var user = Sdm.GetRemoteIdentity.Invoke(new()
        ///     {
        ///         Id = "i-0900909",
        ///         Username = "user",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetRemoteIdentityResult> Invoke(GetRemoteIdentityInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetRemoteIdentityResult>("sdm:index/getRemoteIdentity:getRemoteIdentity", args ?? new GetRemoteIdentityInvokeArgs(), options.WithDefaults());

        /// <summary>
        /// RemoteIdentities define the username to be used for a specific account
        ///  when connecting to a remote resource using that group.
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
        ///     var user = Sdm.GetRemoteIdentity.Invoke(new()
        ///     {
        ///         Id = "i-0900909",
        ///         Username = "user",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetRemoteIdentityResult> Invoke(GetRemoteIdentityInvokeArgs args, InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetRemoteIdentityResult>("sdm:index/getRemoteIdentity:getRemoteIdentity", args ?? new GetRemoteIdentityInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetRemoteIdentityArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The account for this remote identity.
        /// </summary>
        [Input("accountId")]
        public string? AccountId { get; set; }

        /// <summary>
        /// Unique identifier of the RemoteIdentity.
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The remote identity group.
        /// </summary>
        [Input("remoteIdentityGroupId")]
        public string? RemoteIdentityGroupId { get; set; }

        /// <summary>
        /// The username to be used as the remote identity for this account.
        /// </summary>
        [Input("username")]
        public string? Username { get; set; }

        public GetRemoteIdentityArgs()
        {
        }
        public static new GetRemoteIdentityArgs Empty => new GetRemoteIdentityArgs();
    }

    public sealed class GetRemoteIdentityInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The account for this remote identity.
        /// </summary>
        [Input("accountId")]
        public Input<string>? AccountId { get; set; }

        /// <summary>
        /// Unique identifier of the RemoteIdentity.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// The remote identity group.
        /// </summary>
        [Input("remoteIdentityGroupId")]
        public Input<string>? RemoteIdentityGroupId { get; set; }

        /// <summary>
        /// The username to be used as the remote identity for this account.
        /// </summary>
        [Input("username")]
        public Input<string>? Username { get; set; }

        public GetRemoteIdentityInvokeArgs()
        {
        }
        public static new GetRemoteIdentityInvokeArgs Empty => new GetRemoteIdentityInvokeArgs();
    }


    [OutputType]
    public sealed class GetRemoteIdentityResult
    {
        /// <summary>
        /// The account for this remote identity.
        /// </summary>
        public readonly string? AccountId;
        /// <summary>
        /// Unique identifier of the RemoteIdentity.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// a list of strings of ids of data sources that match the given arguments.
        /// </summary>
        public readonly ImmutableArray<string> Ids;
        /// <summary>
        /// A list where each element has the following attributes:
        /// </summary>
        public readonly ImmutableArray<Outputs.GetRemoteIdentityRemoteIdentityResult> RemoteIdentities;
        /// <summary>
        /// The remote identity group.
        /// </summary>
        public readonly string? RemoteIdentityGroupId;
        /// <summary>
        /// The username to be used as the remote identity for this account.
        /// </summary>
        public readonly string? Username;

        [OutputConstructor]
        private GetRemoteIdentityResult(
            string? accountId,

            string? id,

            ImmutableArray<string> ids,

            ImmutableArray<Outputs.GetRemoteIdentityRemoteIdentityResult> remoteIdentities,

            string? remoteIdentityGroupId,

            string? username)
        {
            AccountId = accountId;
            Id = id;
            Ids = ids;
            RemoteIdentities = remoteIdentities;
            RemoteIdentityGroupId = remoteIdentityGroupId;
            Username = username;
        }
    }
}
