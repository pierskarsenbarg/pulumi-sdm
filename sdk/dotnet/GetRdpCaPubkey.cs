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
    public static class GetRdpCaPubkey
    {
        /// <summary>
        /// The RDP CA Pubkey is a public key used for setting up a trusted CA on Active Directiory Domain Controllers.
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
        ///     var rdpPubkeyQuery = Sdm.GetRdpCaPubkey.Invoke();
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["rdpca"] = rdpPubkeyQuery.Apply(getRdpCaPubkeyResult =&gt; getRdpCaPubkeyResult.PublicKey),
        ///     };
        /// });
        /// ```
        /// </summary>
        public static Task<GetRdpCaPubkeyResult> InvokeAsync(GetRdpCaPubkeyArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetRdpCaPubkeyResult>("sdm:index/getRdpCaPubkey:getRdpCaPubkey", args ?? new GetRdpCaPubkeyArgs(), options.WithDefaults());

        /// <summary>
        /// The RDP CA Pubkey is a public key used for setting up a trusted CA on Active Directiory Domain Controllers.
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
        ///     var rdpPubkeyQuery = Sdm.GetRdpCaPubkey.Invoke();
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["rdpca"] = rdpPubkeyQuery.Apply(getRdpCaPubkeyResult =&gt; getRdpCaPubkeyResult.PublicKey),
        ///     };
        /// });
        /// ```
        /// </summary>
        public static Output<GetRdpCaPubkeyResult> Invoke(GetRdpCaPubkeyInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetRdpCaPubkeyResult>("sdm:index/getRdpCaPubkey:getRdpCaPubkey", args ?? new GetRdpCaPubkeyInvokeArgs(), options.WithDefaults());

        /// <summary>
        /// The RDP CA Pubkey is a public key used for setting up a trusted CA on Active Directiory Domain Controllers.
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
        ///     var rdpPubkeyQuery = Sdm.GetRdpCaPubkey.Invoke();
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["rdpca"] = rdpPubkeyQuery.Apply(getRdpCaPubkeyResult =&gt; getRdpCaPubkeyResult.PublicKey),
        ///     };
        /// });
        /// ```
        /// </summary>
        public static Output<GetRdpCaPubkeyResult> Invoke(GetRdpCaPubkeyInvokeArgs args, InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetRdpCaPubkeyResult>("sdm:index/getRdpCaPubkey:getRdpCaPubkey", args ?? new GetRdpCaPubkeyInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetRdpCaPubkeyArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// a generated id representing this request.
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

        /// <summary>
        /// the RDP Certificate Authority public key.
        /// </summary>
        [Input("publicKey")]
        public string? PublicKey { get; set; }

        public GetRdpCaPubkeyArgs()
        {
        }
        public static new GetRdpCaPubkeyArgs Empty => new GetRdpCaPubkeyArgs();
    }

    public sealed class GetRdpCaPubkeyInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// a generated id representing this request.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// the RDP Certificate Authority public key.
        /// </summary>
        [Input("publicKey")]
        public Input<string>? PublicKey { get; set; }

        public GetRdpCaPubkeyInvokeArgs()
        {
        }
        public static new GetRdpCaPubkeyInvokeArgs Empty => new GetRdpCaPubkeyInvokeArgs();
    }


    [OutputType]
    public sealed class GetRdpCaPubkeyResult
    {
        /// <summary>
        /// a generated id representing this request.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// the RDP Certificate Authority public key.
        /// </summary>
        public readonly string? PublicKey;

        [OutputConstructor]
        private GetRdpCaPubkeyResult(
            string? id,

            string? publicKey)
        {
            Id = id;
            PublicKey = publicKey;
        }
    }
}
