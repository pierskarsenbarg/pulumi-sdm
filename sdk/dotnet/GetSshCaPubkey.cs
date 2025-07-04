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
    public static class GetSshCaPubkey
    {
        /// <summary>
        /// The SSH CA Pubkey is a public key used for setting up SSH resources.
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
        ///     var sshPubkeyQuery = Sdm.GetSshCaPubkey.Invoke();
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["sshca"] = sshPubkeyQuery.Apply(getSshCaPubkeyResult =&gt; getSshCaPubkeyResult.PublicKey),
        ///     };
        /// });
        /// ```
        /// </summary>
        public static Task<GetSshCaPubkeyResult> InvokeAsync(GetSshCaPubkeyArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetSshCaPubkeyResult>("sdm:index/getSshCaPubkey:getSshCaPubkey", args ?? new GetSshCaPubkeyArgs(), options.WithDefaults());

        /// <summary>
        /// The SSH CA Pubkey is a public key used for setting up SSH resources.
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
        ///     var sshPubkeyQuery = Sdm.GetSshCaPubkey.Invoke();
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["sshca"] = sshPubkeyQuery.Apply(getSshCaPubkeyResult =&gt; getSshCaPubkeyResult.PublicKey),
        ///     };
        /// });
        /// ```
        /// </summary>
        public static Output<GetSshCaPubkeyResult> Invoke(GetSshCaPubkeyInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetSshCaPubkeyResult>("sdm:index/getSshCaPubkey:getSshCaPubkey", args ?? new GetSshCaPubkeyInvokeArgs(), options.WithDefaults());

        /// <summary>
        /// The SSH CA Pubkey is a public key used for setting up SSH resources.
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
        ///     var sshPubkeyQuery = Sdm.GetSshCaPubkey.Invoke();
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["sshca"] = sshPubkeyQuery.Apply(getSshCaPubkeyResult =&gt; getSshCaPubkeyResult.PublicKey),
        ///     };
        /// });
        /// ```
        /// </summary>
        public static Output<GetSshCaPubkeyResult> Invoke(GetSshCaPubkeyInvokeArgs args, InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetSshCaPubkeyResult>("sdm:index/getSshCaPubkey:getSshCaPubkey", args ?? new GetSshCaPubkeyInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSshCaPubkeyArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// a generated id representing this request.
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

        /// <summary>
        /// the SSH Certificate Authority public key.
        /// </summary>
        [Input("publicKey")]
        public string? PublicKey { get; set; }

        public GetSshCaPubkeyArgs()
        {
        }
        public static new GetSshCaPubkeyArgs Empty => new GetSshCaPubkeyArgs();
    }

    public sealed class GetSshCaPubkeyInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// a generated id representing this request.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// the SSH Certificate Authority public key.
        /// </summary>
        [Input("publicKey")]
        public Input<string>? PublicKey { get; set; }

        public GetSshCaPubkeyInvokeArgs()
        {
        }
        public static new GetSshCaPubkeyInvokeArgs Empty => new GetSshCaPubkeyInvokeArgs();
    }


    [OutputType]
    public sealed class GetSshCaPubkeyResult
    {
        /// <summary>
        /// a generated id representing this request.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// the SSH Certificate Authority public key.
        /// </summary>
        public readonly string? PublicKey;

        [OutputConstructor]
        private GetSshCaPubkeyResult(
            string? id,

            string? publicKey)
        {
            Id = id;
            PublicKey = publicKey;
        }
    }
}
