# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

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
    'GetRoleResult',
    'AwaitableGetRoleResult',
    'get_role',
    'get_role_output',
]

@pulumi.output_type
class GetRoleResult:
    """
    A collection of values returned by getRole.
    """
    def __init__(__self__, id=None, ids=None, managed_by=None, name=None, roles=None, tags=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if ids and not isinstance(ids, list):
            raise TypeError("Expected argument 'ids' to be a list")
        pulumi.set(__self__, "ids", ids)
        if managed_by and not isinstance(managed_by, str):
            raise TypeError("Expected argument 'managed_by' to be a str")
        pulumi.set(__self__, "managed_by", managed_by)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if roles and not isinstance(roles, list):
            raise TypeError("Expected argument 'roles' to be a list")
        pulumi.set(__self__, "roles", roles)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter
    def id(self) -> Optional[str]:
        """
        Unique identifier of the Role.
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
    @pulumi.getter(name="managedBy")
    def managed_by(self) -> str:
        """
        Managed By is a read only field for what service manages this role, e.g. StrongDM, Okta, Azure.
        """
        return pulumi.get(self, "managed_by")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        Unique human-readable name of the Role.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def roles(self) -> Sequence['outputs.GetRoleRoleResult']:
        """
        A list where each element has the following attributes:
        """
        return pulumi.get(self, "roles")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, str]]:
        """
        Tags is a map of key, value pairs.
        """
        return pulumi.get(self, "tags")


class AwaitableGetRoleResult(GetRoleResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetRoleResult(
            id=self.id,
            ids=self.ids,
            managed_by=self.managed_by,
            name=self.name,
            roles=self.roles,
            tags=self.tags)


def get_role(id: Optional[str] = None,
             name: Optional[str] = None,
             tags: Optional[Mapping[str, str]] = None,
             opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetRoleResult:
    """
    A Role has a list of access rules which determine which Resources the members
     of the Role have access to. An Account can be a member of multiple Roles via
     AccountAttachments.


    :param str id: Unique identifier of the Role.
    :param str name: Unique human-readable name of the Role.
    :param Mapping[str, str] tags: Tags is a map of key, value pairs.
    """
    __args__ = dict()
    __args__['id'] = id
    __args__['name'] = name
    __args__['tags'] = tags
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('sdm:index/getRole:getRole', __args__, opts=opts, typ=GetRoleResult).value

    return AwaitableGetRoleResult(
        id=pulumi.get(__ret__, 'id'),
        ids=pulumi.get(__ret__, 'ids'),
        managed_by=pulumi.get(__ret__, 'managed_by'),
        name=pulumi.get(__ret__, 'name'),
        roles=pulumi.get(__ret__, 'roles'),
        tags=pulumi.get(__ret__, 'tags'))
def get_role_output(id: Optional[pulumi.Input[Optional[str]]] = None,
                    name: Optional[pulumi.Input[Optional[str]]] = None,
                    tags: Optional[pulumi.Input[Optional[Mapping[str, str]]]] = None,
                    opts: Optional[Union[pulumi.InvokeOptions, pulumi.InvokeOutputOptions]] = None) -> pulumi.Output[GetRoleResult]:
    """
    A Role has a list of access rules which determine which Resources the members
     of the Role have access to. An Account can be a member of multiple Roles via
     AccountAttachments.


    :param str id: Unique identifier of the Role.
    :param str name: Unique human-readable name of the Role.
    :param Mapping[str, str] tags: Tags is a map of key, value pairs.
    """
    __args__ = dict()
    __args__['id'] = id
    __args__['name'] = name
    __args__['tags'] = tags
    opts = pulumi.InvokeOutputOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke_output('sdm:index/getRole:getRole', __args__, opts=opts, typ=GetRoleResult)
    return __ret__.apply(lambda __response__: GetRoleResult(
        id=pulumi.get(__response__, 'id'),
        ids=pulumi.get(__response__, 'ids'),
        managed_by=pulumi.get(__response__, 'managed_by'),
        name=pulumi.get(__response__, 'name'),
        roles=pulumi.get(__response__, 'roles'),
        tags=pulumi.get(__response__, 'tags')))
