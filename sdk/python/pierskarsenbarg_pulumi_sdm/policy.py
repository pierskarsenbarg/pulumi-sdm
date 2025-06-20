# coding=utf-8
# *** WARNING: this file was generated by pulumi-language-python. ***
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

__all__ = ['PolicyArgs', 'Policy']

@pulumi.input_type
class PolicyArgs:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 policy_content: Optional[pulumi.Input[builtins.str]] = None):
        """
        The set of arguments for constructing a Policy resource.
        :param pulumi.Input[builtins.str] description: Optional description of the Policy.
        :param pulumi.Input[builtins.str] name: Unique human-readable name of the Policy.
        :param pulumi.Input[builtins.str] policy_content: The content of the Policy, in Cedar policy language.
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if policy_content is not None:
            pulumi.set(__self__, "policy_content", policy_content)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Optional description of the Policy.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Unique human-readable name of the Policy.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="policyContent")
    def policy_content(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The content of the Policy, in Cedar policy language.
        """
        return pulumi.get(self, "policy_content")

    @policy_content.setter
    def policy_content(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "policy_content", value)


@pulumi.input_type
class _PolicyState:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 policy_content: Optional[pulumi.Input[builtins.str]] = None):
        """
        Input properties used for looking up and filtering Policy resources.
        :param pulumi.Input[builtins.str] description: Optional description of the Policy.
        :param pulumi.Input[builtins.str] name: Unique human-readable name of the Policy.
        :param pulumi.Input[builtins.str] policy_content: The content of the Policy, in Cedar policy language.
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if policy_content is not None:
            pulumi.set(__self__, "policy_content", policy_content)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Optional description of the Policy.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Unique human-readable name of the Policy.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="policyContent")
    def policy_content(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The content of the Policy, in Cedar policy language.
        """
        return pulumi.get(self, "policy_content")

    @policy_content.setter
    def policy_content(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "policy_content", value)


@pulumi.type_token("sdm:index/policy:Policy")
class Policy(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 policy_content: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        """
        Policy is a collection of one or more statements that enforce fine-grained access control
         for the users of an organization.
        ## Example Usage

        ```python
        import pulumi
        import pierskarsenbarg_pulumi_sdm as sdm

        permit_everything = sdm.Policy("permitEverything",
            description="this policy permits everything",
            policy_content=\"\"\"permit(principal, action, resource);

        \"\"\")
        ```
        This resource can be imported using the import command.

        ## Import

        A Policy can be imported using the id, e.g.,

        ```sh
        $ pulumi import sdm:index/policy:Policy example po-12345678
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] description: Optional description of the Policy.
        :param pulumi.Input[builtins.str] name: Unique human-readable name of the Policy.
        :param pulumi.Input[builtins.str] policy_content: The content of the Policy, in Cedar policy language.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[PolicyArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Policy is a collection of one or more statements that enforce fine-grained access control
         for the users of an organization.
        ## Example Usage

        ```python
        import pulumi
        import pierskarsenbarg_pulumi_sdm as sdm

        permit_everything = sdm.Policy("permitEverything",
            description="this policy permits everything",
            policy_content=\"\"\"permit(principal, action, resource);

        \"\"\")
        ```
        This resource can be imported using the import command.

        ## Import

        A Policy can be imported using the id, e.g.,

        ```sh
        $ pulumi import sdm:index/policy:Policy example po-12345678
        ```

        :param str resource_name: The name of the resource.
        :param PolicyArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(PolicyArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 policy_content: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = PolicyArgs.__new__(PolicyArgs)

            __props__.__dict__["description"] = description
            __props__.__dict__["name"] = name
            __props__.__dict__["policy_content"] = policy_content
        super(Policy, __self__).__init__(
            'sdm:index/policy:Policy',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            description: Optional[pulumi.Input[builtins.str]] = None,
            name: Optional[pulumi.Input[builtins.str]] = None,
            policy_content: Optional[pulumi.Input[builtins.str]] = None) -> 'Policy':
        """
        Get an existing Policy resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] description: Optional description of the Policy.
        :param pulumi.Input[builtins.str] name: Unique human-readable name of the Policy.
        :param pulumi.Input[builtins.str] policy_content: The content of the Policy, in Cedar policy language.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _PolicyState.__new__(_PolicyState)

        __props__.__dict__["description"] = description
        __props__.__dict__["name"] = name
        __props__.__dict__["policy_content"] = policy_content
        return Policy(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[builtins.str]]:
        """
        Optional description of the Policy.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[builtins.str]:
        """
        Unique human-readable name of the Policy.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="policyContent")
    def policy_content(self) -> pulumi.Output[Optional[builtins.str]]:
        """
        The content of the Policy, in Cedar policy language.
        """
        return pulumi.get(self, "policy_content")

