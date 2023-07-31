# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['PeeringGroupArgs', 'PeeringGroup']

@pulumi.input_type
class PeeringGroupArgs:
    def __init__(__self__, *,
                 name: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a PeeringGroup resource.
        :param pulumi.Input[str] name: Unique human-readable name of the PeeringGroup.
        """
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Unique human-readable name of the PeeringGroup.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)


@pulumi.input_type
class _PeeringGroupState:
    def __init__(__self__, *,
                 name: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering PeeringGroup resources.
        :param pulumi.Input[str] name: Unique human-readable name of the PeeringGroup.
        """
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Unique human-readable name of the PeeringGroup.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)


class PeeringGroup(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        PeeringGroups are the building blocks used for explicit network topology making.
         They may be linked to other peering groups. Sets of PeeringGroupResource and PeeringGroupNode can be attached to a peering group.
        This resource can be imported using the import command.

        ## Import

        PeeringGroup can be imported using the id, e.g.,

        ```sh
         $ pulumi import sdm:index/peeringGroup:PeeringGroup example g-12345678
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] name: Unique human-readable name of the PeeringGroup.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[PeeringGroupArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        PeeringGroups are the building blocks used for explicit network topology making.
         They may be linked to other peering groups. Sets of PeeringGroupResource and PeeringGroupNode can be attached to a peering group.
        This resource can be imported using the import command.

        ## Import

        PeeringGroup can be imported using the id, e.g.,

        ```sh
         $ pulumi import sdm:index/peeringGroup:PeeringGroup example g-12345678
        ```

        :param str resource_name: The name of the resource.
        :param PeeringGroupArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(PeeringGroupArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = PeeringGroupArgs.__new__(PeeringGroupArgs)

            __props__.__dict__["name"] = name
        super(PeeringGroup, __self__).__init__(
            'sdm:index/peeringGroup:PeeringGroup',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            name: Optional[pulumi.Input[str]] = None) -> 'PeeringGroup':
        """
        Get an existing PeeringGroup resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] name: Unique human-readable name of the PeeringGroup.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _PeeringGroupState.__new__(_PeeringGroupState)

        __props__.__dict__["name"] = name
        return PeeringGroup(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Unique human-readable name of the PeeringGroup.
        """
        return pulumi.get(self, "name")

