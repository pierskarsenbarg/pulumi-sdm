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

__all__ = ['AccountAttachmentArgs', 'AccountAttachment']

@pulumi.input_type
class AccountAttachmentArgs:
    def __init__(__self__, *,
                 account_id: pulumi.Input[builtins.str],
                 role_id: pulumi.Input[builtins.str]):
        """
        The set of arguments for constructing a AccountAttachment resource.
        :param pulumi.Input[builtins.str] account_id: The id of the account of this AccountAttachment.
        :param pulumi.Input[builtins.str] role_id: The id of the attached role of this AccountAttachment.
        """
        pulumi.set(__self__, "account_id", account_id)
        pulumi.set(__self__, "role_id", role_id)

    @property
    @pulumi.getter(name="accountId")
    def account_id(self) -> pulumi.Input[builtins.str]:
        """
        The id of the account of this AccountAttachment.
        """
        return pulumi.get(self, "account_id")

    @account_id.setter
    def account_id(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "account_id", value)

    @property
    @pulumi.getter(name="roleId")
    def role_id(self) -> pulumi.Input[builtins.str]:
        """
        The id of the attached role of this AccountAttachment.
        """
        return pulumi.get(self, "role_id")

    @role_id.setter
    def role_id(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "role_id", value)


@pulumi.input_type
class _AccountAttachmentState:
    def __init__(__self__, *,
                 account_id: Optional[pulumi.Input[builtins.str]] = None,
                 role_id: Optional[pulumi.Input[builtins.str]] = None):
        """
        Input properties used for looking up and filtering AccountAttachment resources.
        :param pulumi.Input[builtins.str] account_id: The id of the account of this AccountAttachment.
        :param pulumi.Input[builtins.str] role_id: The id of the attached role of this AccountAttachment.
        """
        if account_id is not None:
            pulumi.set(__self__, "account_id", account_id)
        if role_id is not None:
            pulumi.set(__self__, "role_id", role_id)

    @property
    @pulumi.getter(name="accountId")
    def account_id(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The id of the account of this AccountAttachment.
        """
        return pulumi.get(self, "account_id")

    @account_id.setter
    def account_id(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "account_id", value)

    @property
    @pulumi.getter(name="roleId")
    def role_id(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The id of the attached role of this AccountAttachment.
        """
        return pulumi.get(self, "role_id")

    @role_id.setter
    def role_id(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "role_id", value)


@pulumi.type_token("sdm:index/accountAttachment:AccountAttachment")
class AccountAttachment(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 account_id: Optional[pulumi.Input[builtins.str]] = None,
                 role_id: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        """
        AccountAttachments assign an account to a role.
        ## Example Usage

        ```python
        import pulumi
        import pierskarsenbarg_pulumi_sdm as sdm

        test_account_attachment = sdm.AccountAttachment("testAccountAttachment",
            account_id="a-00000054",
            role_id="r-12355562")
        ```
        This resource can be imported using the import command.

        ## Import

        A AccountAttachment can be imported using the id, e.g.,

        ```sh
        $ pulumi import sdm:index/accountAttachment:AccountAttachment example aa-12345678
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] account_id: The id of the account of this AccountAttachment.
        :param pulumi.Input[builtins.str] role_id: The id of the attached role of this AccountAttachment.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: AccountAttachmentArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        AccountAttachments assign an account to a role.
        ## Example Usage

        ```python
        import pulumi
        import pierskarsenbarg_pulumi_sdm as sdm

        test_account_attachment = sdm.AccountAttachment("testAccountAttachment",
            account_id="a-00000054",
            role_id="r-12355562")
        ```
        This resource can be imported using the import command.

        ## Import

        A AccountAttachment can be imported using the id, e.g.,

        ```sh
        $ pulumi import sdm:index/accountAttachment:AccountAttachment example aa-12345678
        ```

        :param str resource_name: The name of the resource.
        :param AccountAttachmentArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(AccountAttachmentArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 account_id: Optional[pulumi.Input[builtins.str]] = None,
                 role_id: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = AccountAttachmentArgs.__new__(AccountAttachmentArgs)

            if account_id is None and not opts.urn:
                raise TypeError("Missing required property 'account_id'")
            __props__.__dict__["account_id"] = account_id
            if role_id is None and not opts.urn:
                raise TypeError("Missing required property 'role_id'")
            __props__.__dict__["role_id"] = role_id
        super(AccountAttachment, __self__).__init__(
            'sdm:index/accountAttachment:AccountAttachment',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            account_id: Optional[pulumi.Input[builtins.str]] = None,
            role_id: Optional[pulumi.Input[builtins.str]] = None) -> 'AccountAttachment':
        """
        Get an existing AccountAttachment resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] account_id: The id of the account of this AccountAttachment.
        :param pulumi.Input[builtins.str] role_id: The id of the attached role of this AccountAttachment.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _AccountAttachmentState.__new__(_AccountAttachmentState)

        __props__.__dict__["account_id"] = account_id
        __props__.__dict__["role_id"] = role_id
        return AccountAttachment(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="accountId")
    def account_id(self) -> pulumi.Output[builtins.str]:
        """
        The id of the account of this AccountAttachment.
        """
        return pulumi.get(self, "account_id")

    @property
    @pulumi.getter(name="roleId")
    def role_id(self) -> pulumi.Output[builtins.str]:
        """
        The id of the attached role of this AccountAttachment.
        """
        return pulumi.get(self, "role_id")

