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
    /// <summary>
    /// AccountAttachments assign an account to a role.
    /// ## Example Usage
    /// 
    /// &lt;!--Start PulumiCodeChooser --&gt;
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Sdm = PiersKarsenbarg.Sdm;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var testAccountAttachment = new Sdm.AccountAttachment("testAccountAttachment", new()
    ///     {
    ///         AccountId = "a-00000054",
    ///         RoleId = "r-12355562",
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// This resource can be imported using the import command.
    /// 
    /// ## Import
    /// 
    /// A AccountAttachment can be imported using the id, e.g.,
    /// 
    /// ```sh
    /// $ pulumi import sdm:index/accountAttachment:AccountAttachment example aa-12345678
    /// ```
    /// </summary>
    [SdmResourceType("sdm:index/accountAttachment:AccountAttachment")]
    public partial class AccountAttachment : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The id of the account of this AccountAttachment.
        /// </summary>
        [Output("accountId")]
        public Output<string> AccountId { get; private set; } = null!;

        /// <summary>
        /// The id of the attached role of this AccountAttachment.
        /// </summary>
        [Output("roleId")]
        public Output<string> RoleId { get; private set; } = null!;


        /// <summary>
        /// Create a AccountAttachment resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AccountAttachment(string name, AccountAttachmentArgs args, CustomResourceOptions? options = null)
            : base("sdm:index/accountAttachment:AccountAttachment", name, args ?? new AccountAttachmentArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AccountAttachment(string name, Input<string> id, AccountAttachmentState? state = null, CustomResourceOptions? options = null)
            : base("sdm:index/accountAttachment:AccountAttachment", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/pierskarsenbarg/pulumi-sdm",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing AccountAttachment resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AccountAttachment Get(string name, Input<string> id, AccountAttachmentState? state = null, CustomResourceOptions? options = null)
        {
            return new AccountAttachment(name, id, state, options);
        }
    }

    public sealed class AccountAttachmentArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The id of the account of this AccountAttachment.
        /// </summary>
        [Input("accountId", required: true)]
        public Input<string> AccountId { get; set; } = null!;

        /// <summary>
        /// The id of the attached role of this AccountAttachment.
        /// </summary>
        [Input("roleId", required: true)]
        public Input<string> RoleId { get; set; } = null!;

        public AccountAttachmentArgs()
        {
        }
        public static new AccountAttachmentArgs Empty => new AccountAttachmentArgs();
    }

    public sealed class AccountAttachmentState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The id of the account of this AccountAttachment.
        /// </summary>
        [Input("accountId")]
        public Input<string>? AccountId { get; set; }

        /// <summary>
        /// The id of the attached role of this AccountAttachment.
        /// </summary>
        [Input("roleId")]
        public Input<string>? RoleId { get; set; }

        public AccountAttachmentState()
        {
        }
        public static new AccountAttachmentState Empty => new AccountAttachmentState();
    }
}
