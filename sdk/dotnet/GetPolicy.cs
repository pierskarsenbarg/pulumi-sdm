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
    public static class GetPolicy
    {
        /// <summary>
        /// Policy is a collection of one or more statements that enforce fine-grained access control
        ///  for the users of an organization.
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
        ///     var policy = Sdm.GetPolicy.Invoke(new()
        ///     {
        ///         Name = "policy-query",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetPolicyResult> InvokeAsync(GetPolicyArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetPolicyResult>("sdm:index/getPolicy:getPolicy", args ?? new GetPolicyArgs(), options.WithDefaults());

        /// <summary>
        /// Policy is a collection of one or more statements that enforce fine-grained access control
        ///  for the users of an organization.
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
        ///     var policy = Sdm.GetPolicy.Invoke(new()
        ///     {
        ///         Name = "policy-query",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetPolicyResult> Invoke(GetPolicyInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetPolicyResult>("sdm:index/getPolicy:getPolicy", args ?? new GetPolicyInvokeArgs(), options.WithDefaults());

        /// <summary>
        /// Policy is a collection of one or more statements that enforce fine-grained access control
        ///  for the users of an organization.
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
        ///     var policy = Sdm.GetPolicy.Invoke(new()
        ///     {
        ///         Name = "policy-query",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetPolicyResult> Invoke(GetPolicyInvokeArgs args, InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetPolicyResult>("sdm:index/getPolicy:getPolicy", args ?? new GetPolicyInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetPolicyArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Optional description of the Policy.
        /// </summary>
        [Input("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Unique identifier of the Policy.
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Unique human-readable name of the Policy.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The content of the Policy, in Cedar policy language.
        /// </summary>
        [Input("policy")]
        public string? Policy { get; set; }

        public GetPolicyArgs()
        {
        }
        public static new GetPolicyArgs Empty => new GetPolicyArgs();
    }

    public sealed class GetPolicyInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Optional description of the Policy.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Unique identifier of the Policy.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Unique human-readable name of the Policy.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The content of the Policy, in Cedar policy language.
        /// </summary>
        [Input("policy")]
        public Input<string>? Policy { get; set; }

        public GetPolicyInvokeArgs()
        {
        }
        public static new GetPolicyInvokeArgs Empty => new GetPolicyInvokeArgs();
    }


    [OutputType]
    public sealed class GetPolicyResult
    {
        /// <summary>
        /// Optional description of the Policy.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Unique identifier of the Policy.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// a list of strings of ids of data sources that match the given arguments.
        /// </summary>
        public readonly ImmutableArray<string> Ids;
        /// <summary>
        /// Unique human-readable name of the Policy.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// A list where each element has the following attributes:
        /// </summary>
        public readonly ImmutableArray<Outputs.GetPolicyPolicyResult> Policies;
        /// <summary>
        /// The content of the Policy, in Cedar policy language.
        /// </summary>
        public readonly string? Policy;

        [OutputConstructor]
        private GetPolicyResult(
            string? description,

            string? id,

            ImmutableArray<string> ids,

            string? name,

            ImmutableArray<Outputs.GetPolicyPolicyResult> policies,

            string? policy)
        {
            Description = description;
            Id = id;
            Ids = ids;
            Name = name;
            Policies = policies;
            Policy = policy;
        }
    }
}
