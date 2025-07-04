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

__all__ = ['IdentityAliasArgs', 'IdentityAlias']

@pulumi.input_type
class IdentityAliasArgs:
    def __init__(__self__, *,
                 account_id: pulumi.Input[builtins.str],
                 identity_set_id: pulumi.Input[builtins.str],
                 username: pulumi.Input[builtins.str]):
        """
        The set of arguments for constructing a IdentityAlias resource.
        :param pulumi.Input[builtins.str] account_id: The account for this identity alias.
        :param pulumi.Input[builtins.str] identity_set_id: The identity set.
        :param pulumi.Input[builtins.str] username: The username to be used as the identity alias for this account.
        """
        pulumi.set(__self__, "account_id", account_id)
        pulumi.set(__self__, "identity_set_id", identity_set_id)
        pulumi.set(__self__, "username", username)

    @property
    @pulumi.getter(name="accountId")
    def account_id(self) -> pulumi.Input[builtins.str]:
        """
        The account for this identity alias.
        """
        return pulumi.get(self, "account_id")

    @account_id.setter
    def account_id(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "account_id", value)

    @property
    @pulumi.getter(name="identitySetId")
    def identity_set_id(self) -> pulumi.Input[builtins.str]:
        """
        The identity set.
        """
        return pulumi.get(self, "identity_set_id")

    @identity_set_id.setter
    def identity_set_id(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "identity_set_id", value)

    @property
    @pulumi.getter
    def username(self) -> pulumi.Input[builtins.str]:
        """
        The username to be used as the identity alias for this account.
        """
        return pulumi.get(self, "username")

    @username.setter
    def username(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "username", value)


@pulumi.input_type
class _IdentityAliasState:
    def __init__(__self__, *,
                 account_id: Optional[pulumi.Input[builtins.str]] = None,
                 identity_set_id: Optional[pulumi.Input[builtins.str]] = None,
                 username: Optional[pulumi.Input[builtins.str]] = None):
        """
        Input properties used for looking up and filtering IdentityAlias resources.
        :param pulumi.Input[builtins.str] account_id: The account for this identity alias.
        :param pulumi.Input[builtins.str] identity_set_id: The identity set.
        :param pulumi.Input[builtins.str] username: The username to be used as the identity alias for this account.
        """
        if account_id is not None:
            pulumi.set(__self__, "account_id", account_id)
        if identity_set_id is not None:
            pulumi.set(__self__, "identity_set_id", identity_set_id)
        if username is not None:
            pulumi.set(__self__, "username", username)

    @property
    @pulumi.getter(name="accountId")
    def account_id(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The account for this identity alias.
        """
        return pulumi.get(self, "account_id")

    @account_id.setter
    def account_id(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "account_id", value)

    @property
    @pulumi.getter(name="identitySetId")
    def identity_set_id(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The identity set.
        """
        return pulumi.get(self, "identity_set_id")

    @identity_set_id.setter
    def identity_set_id(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "identity_set_id", value)

    @property
    @pulumi.getter
    def username(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The username to be used as the identity alias for this account.
        """
        return pulumi.get(self, "username")

    @username.setter
    def username(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "username", value)


@pulumi.type_token("sdm:index/identityAlias:IdentityAlias")
class IdentityAlias(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 account_id: Optional[pulumi.Input[builtins.str]] = None,
                 identity_set_id: Optional[pulumi.Input[builtins.str]] = None,
                 username: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        """
        IdentityAliases define the username to be used for a specific account
         when connecting to a remote resource using that identity set.
        ## Import

        A IdentityAlias can be imported using the id, e.g.,

        ```sh
        $ pulumi import sdm:index/identityAlias:IdentityAlias example i-12345678
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] account_id: The account for this identity alias.
        :param pulumi.Input[builtins.str] identity_set_id: The identity set.
        :param pulumi.Input[builtins.str] username: The username to be used as the identity alias for this account.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: IdentityAliasArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        IdentityAliases define the username to be used for a specific account
         when connecting to a remote resource using that identity set.
        ## Import

        A IdentityAlias can be imported using the id, e.g.,

        ```sh
        $ pulumi import sdm:index/identityAlias:IdentityAlias example i-12345678
        ```

        :param str resource_name: The name of the resource.
        :param IdentityAliasArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(IdentityAliasArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 account_id: Optional[pulumi.Input[builtins.str]] = None,
                 identity_set_id: Optional[pulumi.Input[builtins.str]] = None,
                 username: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = IdentityAliasArgs.__new__(IdentityAliasArgs)

            if account_id is None and not opts.urn:
                raise TypeError("Missing required property 'account_id'")
            __props__.__dict__["account_id"] = account_id
            if identity_set_id is None and not opts.urn:
                raise TypeError("Missing required property 'identity_set_id'")
            __props__.__dict__["identity_set_id"] = identity_set_id
            if username is None and not opts.urn:
                raise TypeError("Missing required property 'username'")
            __props__.__dict__["username"] = username
        super(IdentityAlias, __self__).__init__(
            'sdm:index/identityAlias:IdentityAlias',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            account_id: Optional[pulumi.Input[builtins.str]] = None,
            identity_set_id: Optional[pulumi.Input[builtins.str]] = None,
            username: Optional[pulumi.Input[builtins.str]] = None) -> 'IdentityAlias':
        """
        Get an existing IdentityAlias resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] account_id: The account for this identity alias.
        :param pulumi.Input[builtins.str] identity_set_id: The identity set.
        :param pulumi.Input[builtins.str] username: The username to be used as the identity alias for this account.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _IdentityAliasState.__new__(_IdentityAliasState)

        __props__.__dict__["account_id"] = account_id
        __props__.__dict__["identity_set_id"] = identity_set_id
        __props__.__dict__["username"] = username
        return IdentityAlias(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="accountId")
    def account_id(self) -> pulumi.Output[builtins.str]:
        """
        The account for this identity alias.
        """
        return pulumi.get(self, "account_id")

    @property
    @pulumi.getter(name="identitySetId")
    def identity_set_id(self) -> pulumi.Output[builtins.str]:
        """
        The identity set.
        """
        return pulumi.get(self, "identity_set_id")

    @property
    @pulumi.getter
    def username(self) -> pulumi.Output[builtins.str]:
        """
        The username to be used as the identity alias for this account.
        """
        return pulumi.get(self, "username")

