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
from . import outputs
from ._inputs import *

__all__ = ['AccountArgs', 'Account']

@pulumi.input_type
class AccountArgs:
    def __init__(__self__, *,
                 service: Optional[pulumi.Input['AccountServiceArgs']] = None,
                 user: Optional[pulumi.Input['AccountUserArgs']] = None):
        """
        The set of arguments for constructing a Account resource.
        :param pulumi.Input['AccountServiceArgs'] service: A Service is a service account that can connect to resources they are granted directly, or granted via roles. Services
               are typically automated jobs.
        :param pulumi.Input['AccountUserArgs'] user: A User can connect to resources they are granted directly, or granted via roles.
        """
        if service is not None:
            pulumi.set(__self__, "service", service)
        if user is not None:
            pulumi.set(__self__, "user", user)

    @property
    @pulumi.getter
    def service(self) -> Optional[pulumi.Input['AccountServiceArgs']]:
        """
        A Service is a service account that can connect to resources they are granted directly, or granted via roles. Services
        are typically automated jobs.
        """
        return pulumi.get(self, "service")

    @service.setter
    def service(self, value: Optional[pulumi.Input['AccountServiceArgs']]):
        pulumi.set(self, "service", value)

    @property
    @pulumi.getter
    def user(self) -> Optional[pulumi.Input['AccountUserArgs']]:
        """
        A User can connect to resources they are granted directly, or granted via roles.
        """
        return pulumi.get(self, "user")

    @user.setter
    def user(self, value: Optional[pulumi.Input['AccountUserArgs']]):
        pulumi.set(self, "user", value)


@pulumi.input_type
class _AccountState:
    def __init__(__self__, *,
                 service: Optional[pulumi.Input['AccountServiceArgs']] = None,
                 user: Optional[pulumi.Input['AccountUserArgs']] = None):
        """
        Input properties used for looking up and filtering Account resources.
        :param pulumi.Input['AccountServiceArgs'] service: A Service is a service account that can connect to resources they are granted directly, or granted via roles. Services
               are typically automated jobs.
        :param pulumi.Input['AccountUserArgs'] user: A User can connect to resources they are granted directly, or granted via roles.
        """
        if service is not None:
            pulumi.set(__self__, "service", service)
        if user is not None:
            pulumi.set(__self__, "user", user)

    @property
    @pulumi.getter
    def service(self) -> Optional[pulumi.Input['AccountServiceArgs']]:
        """
        A Service is a service account that can connect to resources they are granted directly, or granted via roles. Services
        are typically automated jobs.
        """
        return pulumi.get(self, "service")

    @service.setter
    def service(self, value: Optional[pulumi.Input['AccountServiceArgs']]):
        pulumi.set(self, "service", value)

    @property
    @pulumi.getter
    def user(self) -> Optional[pulumi.Input['AccountUserArgs']]:
        """
        A User can connect to resources they are granted directly, or granted via roles.
        """
        return pulumi.get(self, "user")

    @user.setter
    def user(self, value: Optional[pulumi.Input['AccountUserArgs']]):
        pulumi.set(self, "user", value)


class Account(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 service: Optional[pulumi.Input[Union['AccountServiceArgs', 'AccountServiceArgsDict']]] = None,
                 user: Optional[pulumi.Input[Union['AccountUserArgs', 'AccountUserArgsDict']]] = None,
                 __props__=None):
        """
        Accounts are users that have access to strongDM. The types of accounts are:
         1. **Users:** humans who are authenticated through username and password or SSO.
         2. **Service Accounts:** machines that are authenticated using a service token.
         3. **Tokens** are access keys with permissions that can be used for authentication.
        ## Example Usage

        ```python
        import pulumi
        import pierskarsenbarg_pulumi_sdm as sdm

        test_user = sdm.Account("test-user", user={
            "email": "albob@strongdm.com",
            "first_name": "al",
            "last_name": "bob",
            "tags": {
                "env": "dev",
                "region": "us-west",
            },
        })
        test_service = sdm.Account("test-service", service={
            "name": "test-service",
            "tags": {
                "env": "dev",
                "region": "us-west",
            },
        })
        ```
        This resource can be imported using the import command.

        ## Import

        A Account can be imported using the id, e.g.,

        ```sh
        $ pulumi import sdm:index/account:Account example a-12345678
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Union['AccountServiceArgs', 'AccountServiceArgsDict']] service: A Service is a service account that can connect to resources they are granted directly, or granted via roles. Services
               are typically automated jobs.
        :param pulumi.Input[Union['AccountUserArgs', 'AccountUserArgsDict']] user: A User can connect to resources they are granted directly, or granted via roles.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[AccountArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Accounts are users that have access to strongDM. The types of accounts are:
         1. **Users:** humans who are authenticated through username and password or SSO.
         2. **Service Accounts:** machines that are authenticated using a service token.
         3. **Tokens** are access keys with permissions that can be used for authentication.
        ## Example Usage

        ```python
        import pulumi
        import pierskarsenbarg_pulumi_sdm as sdm

        test_user = sdm.Account("test-user", user={
            "email": "albob@strongdm.com",
            "first_name": "al",
            "last_name": "bob",
            "tags": {
                "env": "dev",
                "region": "us-west",
            },
        })
        test_service = sdm.Account("test-service", service={
            "name": "test-service",
            "tags": {
                "env": "dev",
                "region": "us-west",
            },
        })
        ```
        This resource can be imported using the import command.

        ## Import

        A Account can be imported using the id, e.g.,

        ```sh
        $ pulumi import sdm:index/account:Account example a-12345678
        ```

        :param str resource_name: The name of the resource.
        :param AccountArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(AccountArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 service: Optional[pulumi.Input[Union['AccountServiceArgs', 'AccountServiceArgsDict']]] = None,
                 user: Optional[pulumi.Input[Union['AccountUserArgs', 'AccountUserArgsDict']]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = AccountArgs.__new__(AccountArgs)

            __props__.__dict__["service"] = service
            __props__.__dict__["user"] = user
        super(Account, __self__).__init__(
            'sdm:index/account:Account',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            service: Optional[pulumi.Input[Union['AccountServiceArgs', 'AccountServiceArgsDict']]] = None,
            user: Optional[pulumi.Input[Union['AccountUserArgs', 'AccountUserArgsDict']]] = None) -> 'Account':
        """
        Get an existing Account resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Union['AccountServiceArgs', 'AccountServiceArgsDict']] service: A Service is a service account that can connect to resources they are granted directly, or granted via roles. Services
               are typically automated jobs.
        :param pulumi.Input[Union['AccountUserArgs', 'AccountUserArgsDict']] user: A User can connect to resources they are granted directly, or granted via roles.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _AccountState.__new__(_AccountState)

        __props__.__dict__["service"] = service
        __props__.__dict__["user"] = user
        return Account(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def service(self) -> pulumi.Output[Optional['outputs.AccountService']]:
        """
        A Service is a service account that can connect to resources they are granted directly, or granted via roles. Services
        are typically automated jobs.
        """
        return pulumi.get(self, "service")

    @property
    @pulumi.getter
    def user(self) -> pulumi.Output[Optional['outputs.AccountUser']]:
        """
        A User can connect to resources they are granted directly, or granted via roles.
        """
        return pulumi.get(self, "user")

