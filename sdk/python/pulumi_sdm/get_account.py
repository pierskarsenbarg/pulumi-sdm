# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
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
    def __init__(__self__, accounts=None, email=None, external_id=None, first_name=None, id=None, ids=None, last_name=None, name=None, suspended=None, tags=None, type=None):
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
    @pulumi.getter
    def accounts(self) -> Sequence['outputs.GetAccountAccountResult']:
        """
        A single element list containing a map, where each key lists one of the following objects:
        * service:
        """
        return pulumi.get(self, "accounts")

    @property
    @pulumi.getter
    def email(self) -> Optional[str]:
        """
        The User's email address. Must be unique.
        """
        return pulumi.get(self, "email")

    @property
    @pulumi.getter(name="externalId")
    def external_id(self) -> Optional[str]:
        """
        External ID is an alternative unique ID this user is represented by within an external service.
        """
        return pulumi.get(self, "external_id")

    @property
    @pulumi.getter(name="firstName")
    def first_name(self) -> Optional[str]:
        """
        The User's first name.
        """
        return pulumi.get(self, "first_name")

    @property
    @pulumi.getter
    def id(self) -> Optional[str]:
        """
        Unique identifier of the User.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def ids(self) -> Sequence[str]:
        """
        a list of strings of ids of data sources that match the given arguments.
        """
        return pulumi.get(self, "ids")

    @property
    @pulumi.getter(name="lastName")
    def last_name(self) -> Optional[str]:
        """
        The User's last name.
        """
        return pulumi.get(self, "last_name")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        Unique human-readable name of the Service.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def suspended(self) -> Optional[bool]:
        """
        The User's suspended state.
        """
        return pulumi.get(self, "suspended")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, Any]]:
        """
        Tags is a map of key, value pairs.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> Optional[str]:
        return pulumi.get(self, "type")


class AwaitableGetAccountResult(GetAccountResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetAccountResult(
            accounts=self.accounts,
            email=self.email,
            external_id=self.external_id,
            first_name=self.first_name,
            id=self.id,
            ids=self.ids,
            last_name=self.last_name,
            name=self.name,
            suspended=self.suspended,
            tags=self.tags,
            type=self.type)


def get_account(email: Optional[str] = None,
                external_id: Optional[str] = None,
                first_name: Optional[str] = None,
                id: Optional[str] = None,
                last_name: Optional[str] = None,
                name: Optional[str] = None,
                suspended: Optional[bool] = None,
                tags: Optional[Mapping[str, Any]] = None,
                type: Optional[str] = None,
                opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetAccountResult:
    """
    Accounts are users that have access to strongDM. There are two types of accounts:
     1. **Users:** humans who are authenticated through username and password or SSO.
     2. **Service Accounts:** machines that are authenticated using a service token.
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
    ```


    :param str email: The User's email address. Must be unique.
    :param str external_id: External ID is an alternative unique ID this user is represented by within an external service.
    :param str first_name: The User's first name.
    :param str id: Unique identifier of the User.
    :param str last_name: The User's last name.
    :param str name: Unique human-readable name of the Service.
    :param bool suspended: The User's suspended state.
    :param Mapping[str, Any] tags: Tags is a map of key, value pairs.
    :param str type: a filter to select all items of a certain subtype. See the [filter documentation](https://www.strongdm.com/docs/automation/getting-started/filters for more information.
    """
    __args__ = dict()
    __args__['email'] = email
    __args__['externalId'] = external_id
    __args__['firstName'] = first_name
    __args__['id'] = id
    __args__['lastName'] = last_name
    __args__['name'] = name
    __args__['suspended'] = suspended
    __args__['tags'] = tags
    __args__['type'] = type
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('sdm:index/getAccount:getAccount', __args__, opts=opts, typ=GetAccountResult).value

    return AwaitableGetAccountResult(
        accounts=__ret__.accounts,
        email=__ret__.email,
        external_id=__ret__.external_id,
        first_name=__ret__.first_name,
        id=__ret__.id,
        ids=__ret__.ids,
        last_name=__ret__.last_name,
        name=__ret__.name,
        suspended=__ret__.suspended,
        tags=__ret__.tags,
        type=__ret__.type)


@_utilities.lift_output_func(get_account)
def get_account_output(email: Optional[pulumi.Input[Optional[str]]] = None,
                       external_id: Optional[pulumi.Input[Optional[str]]] = None,
                       first_name: Optional[pulumi.Input[Optional[str]]] = None,
                       id: Optional[pulumi.Input[Optional[str]]] = None,
                       last_name: Optional[pulumi.Input[Optional[str]]] = None,
                       name: Optional[pulumi.Input[Optional[str]]] = None,
                       suspended: Optional[pulumi.Input[Optional[bool]]] = None,
                       tags: Optional[pulumi.Input[Optional[Mapping[str, Any]]]] = None,
                       type: Optional[pulumi.Input[Optional[str]]] = None,
                       opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetAccountResult]:
    """
    Accounts are users that have access to strongDM. There are two types of accounts:
     1. **Users:** humans who are authenticated through username and password or SSO.
     2. **Service Accounts:** machines that are authenticated using a service token.
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
    ```


    :param str email: The User's email address. Must be unique.
    :param str external_id: External ID is an alternative unique ID this user is represented by within an external service.
    :param str first_name: The User's first name.
    :param str id: Unique identifier of the User.
    :param str last_name: The User's last name.
    :param str name: Unique human-readable name of the Service.
    :param bool suspended: The User's suspended state.
    :param Mapping[str, Any] tags: Tags is a map of key, value pairs.
    :param str type: a filter to select all items of a certain subtype. See the [filter documentation](https://www.strongdm.com/docs/automation/getting-started/filters for more information.
    """
    ...
