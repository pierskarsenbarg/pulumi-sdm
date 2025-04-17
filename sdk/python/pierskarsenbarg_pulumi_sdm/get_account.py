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

__all__ = [
    'GetAccountResult',
    'AwaitableGetAccountResult',
    'get_account',
    'get_account_output',
]

@pulumi.output_type
class GetAccountResult:
    """
    A collection of values returned by getAccount.
    """
    def __init__(__self__, account_type=None, accounts=None, email=None, external_id=None, first_name=None, id=None, ids=None, last_name=None, name=None, permission_level=None, permissions=None, suspended=None, tags=None, type=None):
        if account_type and not isinstance(account_type, str):
            raise TypeError("Expected argument 'account_type' to be a str")
        pulumi.set(__self__, "account_type", account_type)
        if accounts and not isinstance(accounts, list):
            raise TypeError("Expected argument 'accounts' to be a list")
        pulumi.set(__self__, "accounts", accounts)
        if email and not isinstance(email, str):
            raise TypeError("Expected argument 'email' to be a str")
        pulumi.set(__self__, "email", email)
        if external_id and not isinstance(external_id, str):
            raise TypeError("Expected argument 'external_id' to be a str")
        pulumi.set(__self__, "external_id", external_id)
        if first_name and not isinstance(first_name, str):
            raise TypeError("Expected argument 'first_name' to be a str")
        pulumi.set(__self__, "first_name", first_name)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if ids and not isinstance(ids, list):
            raise TypeError("Expected argument 'ids' to be a list")
        pulumi.set(__self__, "ids", ids)
        if last_name and not isinstance(last_name, str):
            raise TypeError("Expected argument 'last_name' to be a str")
        pulumi.set(__self__, "last_name", last_name)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if permission_level and not isinstance(permission_level, str):
            raise TypeError("Expected argument 'permission_level' to be a str")
        pulumi.set(__self__, "permission_level", permission_level)
        if permissions and not isinstance(permissions, str):
            raise TypeError("Expected argument 'permissions' to be a str")
        pulumi.set(__self__, "permissions", permissions)
        if suspended and not isinstance(suspended, bool):
            raise TypeError("Expected argument 'suspended' to be a bool")
        pulumi.set(__self__, "suspended", suspended)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="accountType")
    def account_type(self) -> Optional[builtins.str]:
        """
        Corresponds to the type of token, e.g. api or admin-token.
        """
        return pulumi.get(self, "account_type")

    @property
    @pulumi.getter
    def accounts(self) -> Sequence['outputs.GetAccountAccountResult']:
        """
        A single element list containing a map, where each key lists one of the following objects:
        * service:
        """
        return pulumi.get(self, "accounts")

    @property
    @pulumi.getter
    def email(self) -> Optional[builtins.str]:
        """
        The User's email address. Must be unique.
        """
        return pulumi.get(self, "email")

    @property
    @pulumi.getter(name="externalId")
    def external_id(self) -> Optional[builtins.str]:
        """
        External ID is an alternative unique ID this user is represented by within an external service.
        """
        return pulumi.get(self, "external_id")

    @property
    @pulumi.getter(name="firstName")
    def first_name(self) -> Optional[builtins.str]:
        """
        The User's first name.
        """
        return pulumi.get(self, "first_name")

    @property
    @pulumi.getter
    def id(self) -> Optional[builtins.str]:
        """
        Unique identifier of the User.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def ids(self) -> Sequence[builtins.str]:
        """
        a list of strings of ids of data sources that match the given arguments.
        """
        return pulumi.get(self, "ids")

    @property
    @pulumi.getter(name="lastName")
    def last_name(self) -> Optional[builtins.str]:
        """
        The User's last name.
        """
        return pulumi.get(self, "last_name")

    @property
    @pulumi.getter
    def name(self) -> Optional[builtins.str]:
        """
        Unique human-readable name of the Token.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="permissionLevel")
    def permission_level(self) -> Optional[builtins.str]:
        """
        PermissionLevel is the user's permission level e.g. admin, DBA, user.
        """
        return pulumi.get(self, "permission_level")

    @property
    @pulumi.getter
    def permissions(self) -> Optional[builtins.str]:
        """
        Permissions assigned to the token, e.g. role:create.
        """
        return pulumi.get(self, "permissions")

    @property
    @pulumi.getter
    def suspended(self) -> Optional[builtins.bool]:
        """
        Suspended is a read only field for the User's suspended state.
        """
        return pulumi.get(self, "suspended")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, builtins.str]]:
        """
        Tags is a map of key, value pairs.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> Optional[builtins.str]:
        return pulumi.get(self, "type")


class AwaitableGetAccountResult(GetAccountResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetAccountResult(
            account_type=self.account_type,
            accounts=self.accounts,
            email=self.email,
            external_id=self.external_id,
            first_name=self.first_name,
            id=self.id,
            ids=self.ids,
            last_name=self.last_name,
            name=self.name,
            permission_level=self.permission_level,
            permissions=self.permissions,
            suspended=self.suspended,
            tags=self.tags,
            type=self.type)


def get_account(account_type: Optional[builtins.str] = None,
                email: Optional[builtins.str] = None,
                external_id: Optional[builtins.str] = None,
                first_name: Optional[builtins.str] = None,
                id: Optional[builtins.str] = None,
                last_name: Optional[builtins.str] = None,
                name: Optional[builtins.str] = None,
                permission_level: Optional[builtins.str] = None,
                permissions: Optional[builtins.str] = None,
                suspended: Optional[builtins.bool] = None,
                tags: Optional[Mapping[str, builtins.str]] = None,
                type: Optional[builtins.str] = None,
                opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetAccountResult:
    """
    Accounts are users that have access to strongDM. The types of accounts are:
     1. **Users:** humans who are authenticated through username and password or SSO.
     2. **Service Accounts:** machines that are authenticated using a service token.
     3. **Tokens** are access keys with permissions that can be used for authentication.
    ## Example Usage

    ```python
    import pulumi
    import pulumi_sdm as sdm

    user_queries = sdm.get_account(email="*@strongdm.com",
        tags={
            "env": "dev",
            "region": "us-west",
        },
        type="user")
    api_key_queries = sdm.get_account(name="*-dev",
        type="api")
    admin_token_queries = sdm.get_account(name="*-prod",
        type="admin-token")
    ```


    :param builtins.str account_type: Corresponds to the type of token, e.g. api or admin-token.
    :param builtins.str email: The User's email address. Must be unique.
    :param builtins.str external_id: External ID is an alternative unique ID this user is represented by within an external service.
    :param builtins.str first_name: The User's first name.
    :param builtins.str id: Unique identifier of the User.
    :param builtins.str last_name: The User's last name.
    :param builtins.str name: Unique human-readable name of the Token.
    :param builtins.str permission_level: PermissionLevel is the user's permission level e.g. admin, DBA, user.
    :param builtins.str permissions: Permissions assigned to the token, e.g. role:create.
    :param builtins.bool suspended: Reserved for future use.  Always false for tokens.
    :param Mapping[str, builtins.str] tags: Tags is a map of key, value pairs.
    :param builtins.str type: a filter to select all items of a certain subtype. See the [filter documentation](https://www.strongdm.com/docs/automation/getting-started/filters) for more information.
    """
    __args__ = dict()
    __args__['accountType'] = account_type
    __args__['email'] = email
    __args__['externalId'] = external_id
    __args__['firstName'] = first_name
    __args__['id'] = id
    __args__['lastName'] = last_name
    __args__['name'] = name
    __args__['permissionLevel'] = permission_level
    __args__['permissions'] = permissions
    __args__['suspended'] = suspended
    __args__['tags'] = tags
    __args__['type'] = type
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('sdm:index/getAccount:getAccount', __args__, opts=opts, typ=GetAccountResult).value

    return AwaitableGetAccountResult(
        account_type=pulumi.get(__ret__, 'account_type'),
        accounts=pulumi.get(__ret__, 'accounts'),
        email=pulumi.get(__ret__, 'email'),
        external_id=pulumi.get(__ret__, 'external_id'),
        first_name=pulumi.get(__ret__, 'first_name'),
        id=pulumi.get(__ret__, 'id'),
        ids=pulumi.get(__ret__, 'ids'),
        last_name=pulumi.get(__ret__, 'last_name'),
        name=pulumi.get(__ret__, 'name'),
        permission_level=pulumi.get(__ret__, 'permission_level'),
        permissions=pulumi.get(__ret__, 'permissions'),
        suspended=pulumi.get(__ret__, 'suspended'),
        tags=pulumi.get(__ret__, 'tags'),
        type=pulumi.get(__ret__, 'type'))
def get_account_output(account_type: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                       email: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                       external_id: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                       first_name: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                       id: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                       last_name: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                       name: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                       permission_level: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                       permissions: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                       suspended: Optional[pulumi.Input[Optional[builtins.bool]]] = None,
                       tags: Optional[pulumi.Input[Optional[Mapping[str, builtins.str]]]] = None,
                       type: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                       opts: Optional[Union[pulumi.InvokeOptions, pulumi.InvokeOutputOptions]] = None) -> pulumi.Output[GetAccountResult]:
    """
    Accounts are users that have access to strongDM. The types of accounts are:
     1. **Users:** humans who are authenticated through username and password or SSO.
     2. **Service Accounts:** machines that are authenticated using a service token.
     3. **Tokens** are access keys with permissions that can be used for authentication.
    ## Example Usage

    ```python
    import pulumi
    import pulumi_sdm as sdm

    user_queries = sdm.get_account(email="*@strongdm.com",
        tags={
            "env": "dev",
            "region": "us-west",
        },
        type="user")
    api_key_queries = sdm.get_account(name="*-dev",
        type="api")
    admin_token_queries = sdm.get_account(name="*-prod",
        type="admin-token")
    ```


    :param builtins.str account_type: Corresponds to the type of token, e.g. api or admin-token.
    :param builtins.str email: The User's email address. Must be unique.
    :param builtins.str external_id: External ID is an alternative unique ID this user is represented by within an external service.
    :param builtins.str first_name: The User's first name.
    :param builtins.str id: Unique identifier of the User.
    :param builtins.str last_name: The User's last name.
    :param builtins.str name: Unique human-readable name of the Token.
    :param builtins.str permission_level: PermissionLevel is the user's permission level e.g. admin, DBA, user.
    :param builtins.str permissions: Permissions assigned to the token, e.g. role:create.
    :param builtins.bool suspended: Reserved for future use.  Always false for tokens.
    :param Mapping[str, builtins.str] tags: Tags is a map of key, value pairs.
    :param builtins.str type: a filter to select all items of a certain subtype. See the [filter documentation](https://www.strongdm.com/docs/automation/getting-started/filters) for more information.
    """
    __args__ = dict()
    __args__['accountType'] = account_type
    __args__['email'] = email
    __args__['externalId'] = external_id
    __args__['firstName'] = first_name
    __args__['id'] = id
    __args__['lastName'] = last_name
    __args__['name'] = name
    __args__['permissionLevel'] = permission_level
    __args__['permissions'] = permissions
    __args__['suspended'] = suspended
    __args__['tags'] = tags
    __args__['type'] = type
    opts = pulumi.InvokeOutputOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke_output('sdm:index/getAccount:getAccount', __args__, opts=opts, typ=GetAccountResult)
    return __ret__.apply(lambda __response__: GetAccountResult(
        account_type=pulumi.get(__response__, 'account_type'),
        accounts=pulumi.get(__response__, 'accounts'),
        email=pulumi.get(__response__, 'email'),
        external_id=pulumi.get(__response__, 'external_id'),
        first_name=pulumi.get(__response__, 'first_name'),
        id=pulumi.get(__response__, 'id'),
        ids=pulumi.get(__response__, 'ids'),
        last_name=pulumi.get(__response__, 'last_name'),
        name=pulumi.get(__response__, 'name'),
        permission_level=pulumi.get(__response__, 'permission_level'),
        permissions=pulumi.get(__response__, 'permissions'),
        suspended=pulumi.get(__response__, 'suspended'),
        tags=pulumi.get(__response__, 'tags'),
        type=pulumi.get(__response__, 'type')))
