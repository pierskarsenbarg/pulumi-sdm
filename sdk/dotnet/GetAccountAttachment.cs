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
    public static class GetAccountAttachment
    {
        /// <summary>
        /// AccountAttachments assign an account to a role.
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
        ///     var accountAttachmentQuery = Sdm.GetAccountAttachment.Invoke(new()
        ///     {
        ///         AccountId = "a-00000054",
        ///     });
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetAccountAttachmentResult> InvokeAsync(GetAccountAttachmentArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetAccountAttachmentResult>("sdm:index/getAccountAttachment:getAccountAttachment", args ?? new GetAccountAttachmentArgs(), options.WithDefaults());

        /// <summary>
        /// AccountAttachments assign an account to a role.
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
        ///     var accountAttachmentQuery = Sdm.GetAccountAttachment.Invoke(new()
        ///     {
        ///         AccountId = "a-00000054",
        ///     });
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetAccountAttachmentResult> Invoke(GetAccountAttachmentInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetAccountAttachmentResult>("sdm:index/getAccountAttachment:getAccountAttachment", args ?? new GetAccountAttachmentInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetAccountAttachmentArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The id of the account of this AccountAttachment.
        /// </summary>
        [Input("accountId")]
        public string? AccountId { get; set; }

        /// <summary>
        /// Unique identifier of the AccountAttachment.
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The id of the attached role of this AccountAttachment.
        /// </summary>
        [Input("roleId")]
        public string? RoleId { get; set; }

        public GetAccountAttachmentArgs()
        {
        }
        public static new GetAccountAttachmentArgs Empty => new GetAccountAttachmentArgs();
    }

    public sealed class GetAccountAttachmentInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The id of the account of this AccountAttachment.
        /// </summary>
        [Input("accountId")]
        public Input<string>? AccountId { get; set; }

        /// <summary>
        /// Unique identifier of the AccountAttachment.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// The id of the attached role of this AccountAttachment.
        /// </summary>
        [Input("roleId")]
        public Input<string>? RoleId { get; set; }

        public GetAccountAttachmentInvokeArgs()
        {
        }
        public static new GetAccountAttachmentInvokeArgs Empty => new GetAccountAttachmentInvokeArgs();
    }


    [OutputType]
    public sealed class GetAccountAttachmentResult
    {
        /// <summary>
        /// A list where each element has the following attributes:
        /// </summary>
        public readonly ImmutableArray<Outputs.GetAccountAttachmentAccountAttachmentResult> AccountAttachments;
        /// <summary>
        /// The id of the account of this AccountAttachment.
        /// </summary>
        public readonly string? AccountId;
        /// <summary>
        /// Unique identifier of the AccountAttachment.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// a list of strings of ids of data sources that match the given arguments.
        /// </summary>
        public readonly ImmutableArray<string> Ids;
        /// <summary>
        /// The id of the attached role of this AccountAttachment.
        /// </summary>
        public readonly string? RoleId;

        [OutputConstructor]
        private GetAccountAttachmentResult(
            ImmutableArray<Outputs.GetAccountAttachmentAccountAttachmentResult> accountAttachments,

            string? accountId,

            string? id,

            ImmutableArray<string> ids,

            string? roleId)
        {
            AccountAttachments = accountAttachments;
            AccountId = accountId;
            Id = id;
            Ids = ids;
            RoleId = roleId;
        }
    }
}
