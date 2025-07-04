// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Sdm.Outputs
{

    [OutputType]
    public sealed class GetSecretEngineSecretEngineResult
    {
        public readonly ImmutableArray<Outputs.GetSecretEngineSecretEngineActiveDirectoryResult> ActiveDirectories;
        public readonly ImmutableArray<Outputs.GetSecretEngineSecretEngineKeyValueResult> KeyValues;

        [OutputConstructor]
        private GetSecretEngineSecretEngineResult(
            ImmutableArray<Outputs.GetSecretEngineSecretEngineActiveDirectoryResult> activeDirectories,

            ImmutableArray<Outputs.GetSecretEngineSecretEngineKeyValueResult> keyValues)
        {
            ActiveDirectories = activeDirectories;
            KeyValues = keyValues;
        }
    }
}
