# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import builtins
import copy
import warnings
import sys
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
if sys.version_info >= (3, 11):
    from typing import NotRequired, TypedDict, TypeAlias
else:
    from typing_extensions import NotRequired, TypedDict, TypeAlias
from . import _utilities

__all__ = ['PeeringGroupPeerArgs', 'PeeringGroupPeer']

@pulumi.input_type
class PeeringGroupPeerArgs:
    def __init__(__self__, *,
                 group_id: Optional[pulumi.Input[builtins.str]] = None,
                 peers_with_group_id: Optional[pulumi.Input[builtins.str]] = None):
        """
        The set of arguments for constructing a PeeringGroupPeer resource.
        :param pulumi.Input[builtins.str] group_id: Group ID from which the link will originate.
        :param pulumi.Input[builtins.str] peers_with_group_id: Peering Group ID to which Group ID will link.
        """
        if group_id is not None:
            pulumi.set(__self__, "group_id", group_id)
        if peers_with_group_id is not None:
            pulumi.set(__self__, "peers_with_group_id", peers_with_group_id)

    @property
    @pulumi.getter(name="groupId")
    def group_id(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Group ID from which the link will originate.
        """
        return pulumi.get(self, "group_id")

    @group_id.setter
    def group_id(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "group_id", value)

    @property
    @pulumi.getter(name="peersWithGroupId")
    def peers_with_group_id(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Peering Group ID to which Group ID will link.
        """
        return pulumi.get(self, "peers_with_group_id")

    @peers_with_group_id.setter
    def peers_with_group_id(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "peers_with_group_id", value)


@pulumi.input_type
class _PeeringGroupPeerState:
    def __init__(__self__, *,
                 group_id: Optional[pulumi.Input[builtins.str]] = None,
                 peers_with_group_id: Optional[pulumi.Input[builtins.str]] = None):
        """
        Input properties used for looking up and filtering PeeringGroupPeer resources.
        :param pulumi.Input[builtins.str] group_id: Group ID from which the link will originate.
        :param pulumi.Input[builtins.str] peers_with_group_id: Peering Group ID to which Group ID will link.
        """
        if group_id is not None:
            pulumi.set(__self__, "group_id", group_id)
        if peers_with_group_id is not None:
            pulumi.set(__self__, "peers_with_group_id", peers_with_group_id)

    @property
    @pulumi.getter(name="groupId")
    def group_id(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Group ID from which the link will originate.
        """
        return pulumi.get(self, "group_id")

    @group_id.setter
    def group_id(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "group_id", value)

    @property
    @pulumi.getter(name="peersWithGroupId")
    def peers_with_group_id(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Peering Group ID to which Group ID will link.
        """
        return pulumi.get(self, "peers_with_group_id")

    @peers_with_group_id.setter
    def peers_with_group_id(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "peers_with_group_id", value)


class PeeringGroupPeer(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 group_id: Optional[pulumi.Input[builtins.str]] = None,
                 peers_with_group_id: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        """
        PeeringGroupPeer represents the link between two PeeringGroups
        This resource can be imported using the import command.

        ## Import

        A PeeringGroupPeer can be imported using the id, e.g.,

        ```sh
        $ pulumi import sdm:index/peeringGroupPeer:PeeringGroupPeer example gp-12345678
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] group_id: Group ID from which the link will originate.
        :param pulumi.Input[builtins.str] peers_with_group_id: Peering Group ID to which Group ID will link.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[PeeringGroupPeerArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        PeeringGroupPeer represents the link between two PeeringGroups
        This resource can be imported using the import command.

        ## Import

        A PeeringGroupPeer can be imported using the id, e.g.,

        ```sh
        $ pulumi import sdm:index/peeringGroupPeer:PeeringGroupPeer example gp-12345678
        ```

        :param str resource_name: The name of the resource.
        :param PeeringGroupPeerArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(PeeringGroupPeerArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 group_id: Optional[pulumi.Input[builtins.str]] = None,
                 peers_with_group_id: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = PeeringGroupPeerArgs.__new__(PeeringGroupPeerArgs)

            __props__.__dict__["group_id"] = group_id
            __props__.__dict__["peers_with_group_id"] = peers_with_group_id
        super(PeeringGroupPeer, __self__).__init__(
            'sdm:index/peeringGroupPeer:PeeringGroupPeer',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            group_id: Optional[pulumi.Input[builtins.str]] = None,
            peers_with_group_id: Optional[pulumi.Input[builtins.str]] = None) -> 'PeeringGroupPeer':
        """
        Get an existing PeeringGroupPeer resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] group_id: Group ID from which the link will originate.
        :param pulumi.Input[builtins.str] peers_with_group_id: Peering Group ID to which Group ID will link.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _PeeringGroupPeerState.__new__(_PeeringGroupPeerState)

        __props__.__dict__["group_id"] = group_id
        __props__.__dict__["peers_with_group_id"] = peers_with_group_id
        return PeeringGroupPeer(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="groupId")
    def group_id(self) -> pulumi.Output[builtins.str]:
        """
        Group ID from which the link will originate.
        """
        return pulumi.get(self, "group_id")

    @property
    @pulumi.getter(name="peersWithGroupId")
    def peers_with_group_id(self) -> pulumi.Output[builtins.str]:
        """
        Peering Group ID to which Group ID will link.
        """
        return pulumi.get(self, "peers_with_group_id")

