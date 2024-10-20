// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package sdm

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-sdm/sdk/go/sdm/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Proxy Cluster Keys are authentication keys for all proxies within a cluster.
//
//	The proxies within a cluster share the same key. One cluster can have
//	multiple keys in order to facilitate key rotation.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/pierskarsenbarg/pulumi-sdm/sdk/go/sdm"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := sdm.LookupProxyClusterKey(ctx, &sdm.LookupProxyClusterKeyArgs{
//				ProxyClusterId: pulumi.StringRef("n-233332245"),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func LookupProxyClusterKey(ctx *pulumi.Context, args *LookupProxyClusterKeyArgs, opts ...pulumi.InvokeOption) (*LookupProxyClusterKeyResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupProxyClusterKeyResult
	err := ctx.Invoke("sdm:index/getProxyClusterKey:getProxyClusterKey", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getProxyClusterKey.
type LookupProxyClusterKeyArgs struct {
	// Unique identifier of the Relay.
	Id *string `pulumi:"id"`
	// The ID of the proxy cluster which this key authenticates to.
	ProxyClusterId *string `pulumi:"proxyClusterId"`
}

// A collection of values returned by getProxyClusterKey.
type LookupProxyClusterKeyResult struct {
	// Unique identifier of the Relay.
	Id *string `pulumi:"id"`
	// a list of strings of ids of data sources that match the given arguments.
	Ids []string `pulumi:"ids"`
	// The ID of the proxy cluster which this key authenticates to.
	ProxyClusterId *string `pulumi:"proxyClusterId"`
	// A list where each element has the following attributes:
	ProxyClusterKeys []GetProxyClusterKeyProxyClusterKey `pulumi:"proxyClusterKeys"`
}

func LookupProxyClusterKeyOutput(ctx *pulumi.Context, args LookupProxyClusterKeyOutputArgs, opts ...pulumi.InvokeOption) LookupProxyClusterKeyResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupProxyClusterKeyResultOutput, error) {
			args := v.(LookupProxyClusterKeyArgs)
			opts = internal.PkgInvokeDefaultOpts(opts)
			var rv LookupProxyClusterKeyResult
			secret, err := ctx.InvokePackageRaw("sdm:index/getProxyClusterKey:getProxyClusterKey", args, &rv, "", opts...)
			if err != nil {
				return LookupProxyClusterKeyResultOutput{}, err
			}

			output := pulumi.ToOutput(rv).(LookupProxyClusterKeyResultOutput)
			if secret {
				return pulumi.ToSecret(output).(LookupProxyClusterKeyResultOutput), nil
			}
			return output, nil
		}).(LookupProxyClusterKeyResultOutput)
}

// A collection of arguments for invoking getProxyClusterKey.
type LookupProxyClusterKeyOutputArgs struct {
	// Unique identifier of the Relay.
	Id pulumi.StringPtrInput `pulumi:"id"`
	// The ID of the proxy cluster which this key authenticates to.
	ProxyClusterId pulumi.StringPtrInput `pulumi:"proxyClusterId"`
}

func (LookupProxyClusterKeyOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupProxyClusterKeyArgs)(nil)).Elem()
}

// A collection of values returned by getProxyClusterKey.
type LookupProxyClusterKeyResultOutput struct{ *pulumi.OutputState }

func (LookupProxyClusterKeyResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupProxyClusterKeyResult)(nil)).Elem()
}

func (o LookupProxyClusterKeyResultOutput) ToLookupProxyClusterKeyResultOutput() LookupProxyClusterKeyResultOutput {
	return o
}

func (o LookupProxyClusterKeyResultOutput) ToLookupProxyClusterKeyResultOutputWithContext(ctx context.Context) LookupProxyClusterKeyResultOutput {
	return o
}

// Unique identifier of the Relay.
func (o LookupProxyClusterKeyResultOutput) Id() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupProxyClusterKeyResult) *string { return v.Id }).(pulumi.StringPtrOutput)
}

// a list of strings of ids of data sources that match the given arguments.
func (o LookupProxyClusterKeyResultOutput) Ids() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupProxyClusterKeyResult) []string { return v.Ids }).(pulumi.StringArrayOutput)
}

// The ID of the proxy cluster which this key authenticates to.
func (o LookupProxyClusterKeyResultOutput) ProxyClusterId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupProxyClusterKeyResult) *string { return v.ProxyClusterId }).(pulumi.StringPtrOutput)
}

// A list where each element has the following attributes:
func (o LookupProxyClusterKeyResultOutput) ProxyClusterKeys() GetProxyClusterKeyProxyClusterKeyArrayOutput {
	return o.ApplyT(func(v LookupProxyClusterKeyResult) []GetProxyClusterKeyProxyClusterKey { return v.ProxyClusterKeys }).(GetProxyClusterKeyProxyClusterKeyArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupProxyClusterKeyResultOutput{})
}