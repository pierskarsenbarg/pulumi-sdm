// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package sdm

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-sdm/sdk/v2/go/sdm/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Nodes make up the strongDM network, and allow your users to connect securely to your resources.
//
//	There are two types of nodes:
//	1. **Relay:** creates connectivity to your datasources, while maintaining the egress-only nature of your firewall
//	2. **Gateways:** a relay that also listens for connections from strongDM clients
//
// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/pierskarsenbarg/pulumi-sdm/sdk/v2/go/sdm"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := sdm.NewNode(ctx, "gateway", &sdm.NodeArgs{
//				Gateway: &sdm.NodeGatewayArgs{
//					BindAddress:   pulumi.String("0.0.0.0:21222"),
//					ListenAddress: pulumi.String("165.23.40.1:21222"),
//					Name:          pulumi.String("test-gateway"),
//					Tags: pulumi.StringMap{
//						"env":    pulumi.String("dev"),
//						"region": pulumi.String("us-west"),
//					},
//				},
//			})
//			if err != nil {
//				return err
//			}
//			_, err = sdm.NewNode(ctx, "relay", &sdm.NodeArgs{
//				Relay: &sdm.NodeRelayArgs{
//					Name: pulumi.String("test-relay"),
//					Tags: pulumi.StringMap{
//						"env":    pulumi.String("dev"),
//						"region": pulumi.String("us-west"),
//					},
//				},
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
// This resource can be imported using the import command.
//
// ## Import
//
// Node can be imported using the id, e.g.,
//
// ```sh
//
//	$ pulumi import sdm:index/node:Node example n-12345678
//
// ```
type Node struct {
	pulumi.CustomResourceState

	// Gateway represents a StrongDM CLI installation running in gateway mode.
	Gateway NodeGatewayPtrOutput `pulumi:"gateway"`
	// Relay represents a StrongDM CLI installation running in relay mode.
	Relay NodeRelayPtrOutput `pulumi:"relay"`
}

// NewNode registers a new resource with the given unique name, arguments, and options.
func NewNode(ctx *pulumi.Context,
	name string, args *NodeArgs, opts ...pulumi.ResourceOption) (*Node, error) {
	if args == nil {
		args = &NodeArgs{}
	}

	opts = internal.PkgResourceDefaultOpts(opts)
	var resource Node
	err := ctx.RegisterResource("sdm:index/node:Node", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetNode gets an existing Node resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNode(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *NodeState, opts ...pulumi.ResourceOption) (*Node, error) {
	var resource Node
	err := ctx.ReadResource("sdm:index/node:Node", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Node resources.
type nodeState struct {
	// Gateway represents a StrongDM CLI installation running in gateway mode.
	Gateway *NodeGateway `pulumi:"gateway"`
	// Relay represents a StrongDM CLI installation running in relay mode.
	Relay *NodeRelay `pulumi:"relay"`
}

type NodeState struct {
	// Gateway represents a StrongDM CLI installation running in gateway mode.
	Gateway NodeGatewayPtrInput
	// Relay represents a StrongDM CLI installation running in relay mode.
	Relay NodeRelayPtrInput
}

func (NodeState) ElementType() reflect.Type {
	return reflect.TypeOf((*nodeState)(nil)).Elem()
}

type nodeArgs struct {
	// Gateway represents a StrongDM CLI installation running in gateway mode.
	Gateway *NodeGateway `pulumi:"gateway"`
	// Relay represents a StrongDM CLI installation running in relay mode.
	Relay *NodeRelay `pulumi:"relay"`
}

// The set of arguments for constructing a Node resource.
type NodeArgs struct {
	// Gateway represents a StrongDM CLI installation running in gateway mode.
	Gateway NodeGatewayPtrInput
	// Relay represents a StrongDM CLI installation running in relay mode.
	Relay NodeRelayPtrInput
}

func (NodeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*nodeArgs)(nil)).Elem()
}

type NodeInput interface {
	pulumi.Input

	ToNodeOutput() NodeOutput
	ToNodeOutputWithContext(ctx context.Context) NodeOutput
}

func (*Node) ElementType() reflect.Type {
	return reflect.TypeOf((**Node)(nil)).Elem()
}

func (i *Node) ToNodeOutput() NodeOutput {
	return i.ToNodeOutputWithContext(context.Background())
}

func (i *Node) ToNodeOutputWithContext(ctx context.Context) NodeOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NodeOutput)
}

// NodeArrayInput is an input type that accepts NodeArray and NodeArrayOutput values.
// You can construct a concrete instance of `NodeArrayInput` via:
//
//	NodeArray{ NodeArgs{...} }
type NodeArrayInput interface {
	pulumi.Input

	ToNodeArrayOutput() NodeArrayOutput
	ToNodeArrayOutputWithContext(context.Context) NodeArrayOutput
}

type NodeArray []NodeInput

func (NodeArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Node)(nil)).Elem()
}

func (i NodeArray) ToNodeArrayOutput() NodeArrayOutput {
	return i.ToNodeArrayOutputWithContext(context.Background())
}

func (i NodeArray) ToNodeArrayOutputWithContext(ctx context.Context) NodeArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NodeArrayOutput)
}

// NodeMapInput is an input type that accepts NodeMap and NodeMapOutput values.
// You can construct a concrete instance of `NodeMapInput` via:
//
//	NodeMap{ "key": NodeArgs{...} }
type NodeMapInput interface {
	pulumi.Input

	ToNodeMapOutput() NodeMapOutput
	ToNodeMapOutputWithContext(context.Context) NodeMapOutput
}

type NodeMap map[string]NodeInput

func (NodeMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Node)(nil)).Elem()
}

func (i NodeMap) ToNodeMapOutput() NodeMapOutput {
	return i.ToNodeMapOutputWithContext(context.Background())
}

func (i NodeMap) ToNodeMapOutputWithContext(ctx context.Context) NodeMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NodeMapOutput)
}

type NodeOutput struct{ *pulumi.OutputState }

func (NodeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Node)(nil)).Elem()
}

func (o NodeOutput) ToNodeOutput() NodeOutput {
	return o
}

func (o NodeOutput) ToNodeOutputWithContext(ctx context.Context) NodeOutput {
	return o
}

// Gateway represents a StrongDM CLI installation running in gateway mode.
func (o NodeOutput) Gateway() NodeGatewayPtrOutput {
	return o.ApplyT(func(v *Node) NodeGatewayPtrOutput { return v.Gateway }).(NodeGatewayPtrOutput)
}

// Relay represents a StrongDM CLI installation running in relay mode.
func (o NodeOutput) Relay() NodeRelayPtrOutput {
	return o.ApplyT(func(v *Node) NodeRelayPtrOutput { return v.Relay }).(NodeRelayPtrOutput)
}

type NodeArrayOutput struct{ *pulumi.OutputState }

func (NodeArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Node)(nil)).Elem()
}

func (o NodeArrayOutput) ToNodeArrayOutput() NodeArrayOutput {
	return o
}

func (o NodeArrayOutput) ToNodeArrayOutputWithContext(ctx context.Context) NodeArrayOutput {
	return o
}

func (o NodeArrayOutput) Index(i pulumi.IntInput) NodeOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Node {
		return vs[0].([]*Node)[vs[1].(int)]
	}).(NodeOutput)
}

type NodeMapOutput struct{ *pulumi.OutputState }

func (NodeMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Node)(nil)).Elem()
}

func (o NodeMapOutput) ToNodeMapOutput() NodeMapOutput {
	return o
}

func (o NodeMapOutput) ToNodeMapOutputWithContext(ctx context.Context) NodeMapOutput {
	return o
}

func (o NodeMapOutput) MapIndex(k pulumi.StringInput) NodeOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Node {
		return vs[0].(map[string]*Node)[vs[1].(string)]
	}).(NodeOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*NodeInput)(nil)).Elem(), &Node{})
	pulumi.RegisterInputType(reflect.TypeOf((*NodeArrayInput)(nil)).Elem(), NodeArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*NodeMapInput)(nil)).Elem(), NodeMap{})
	pulumi.RegisterOutputType(NodeOutput{})
	pulumi.RegisterOutputType(NodeArrayOutput{})
	pulumi.RegisterOutputType(NodeMapOutput{})
}
