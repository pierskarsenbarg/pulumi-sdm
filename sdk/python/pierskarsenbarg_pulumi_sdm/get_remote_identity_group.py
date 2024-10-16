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
    'GetRemoteIdentityGroupResult',
    'AwaitableGetRemoteIdentityGroupResult',
    'get_remote_identity_group',
    'get_remote_identity_group_output',
]

@pulumi.output_type
class GetRemoteIdentityGroupResult:
    """
    A collection of values returned by getRemoteIdentityGroup.
    """
    def __init__(__self__, id=None, ids=None, name=None, remote_identity_groups=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if ids and not isinstance(ids, list):
            raise TypeError("Expected argument 'ids' to be a list")
        pulumi.set(__self__, "ids", ids)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if remote_identity_groups and not isinstance(remote_identity_groups, list):
            raise TypeError("Expected argument 'remote_identity_groups' to be a list")
        pulumi.set(__self__, "remote_identity_groups", remote_identity_groups)

    @property
    @pulumi.getter
    def id(self) -> Optional[str]:
        """
        Unique identifier of the RemoteIdentityGroup.
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
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        Unique human-readable name of the RemoteIdentityGroup.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="remoteIdentityGroups")
    def remote_identity_groups(self) -> Sequence['outputs.GetRemoteIdentityGroupRemoteIdentityGroupResult']:
        """
        A list where each element has the following attributes:
        """
        return pulumi.get(self, "remote_identity_groups")


class AwaitableGetRemoteIdentityGroupResult(GetRemoteIdentityGroupResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetRemoteIdentityGroupResult(
            id=self.id,
            ids=self.ids,
            name=self.name,
            remote_identity_groups=self.remote_identity_groups)


def get_remote_identity_group(id: Optional[str] = None,
                              name: Optional[str] = None,
                              opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetRemoteIdentityGroupResult:
    """
    A RemoteIdentityGroup defines a group of remote identities.
    ## Example Usage

    ```python
    import pulumi
    import pulumi_sdm as sdm

    default = sdm.get_remote_identity_group(name="default")
    ```


    :param str id: Unique identifier of the RemoteIdentityGroup.
    :param str name: Unique human-readable name of the RemoteIdentityGroup.
    """
    __args__ = dict()
    __args__['id'] = id
    __args__['name'] = name
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('sdm:index/getRemoteIdentityGroup:getRemoteIdentityGroup', __args__, opts=opts, typ=GetRemoteIdentityGroupResult).value

    return AwaitableGetRemoteIdentityGroupResult(
        id=pulumi.get(__ret__, 'id'),
        ids=pulumi.get(__ret__, 'ids'),
        name=pulumi.get(__ret__, 'name'),
        remote_identity_groups=pulumi.get(__ret__, 'remote_identity_groups'))
def get_remote_identity_group_output(id: Optional[pulumi.Input[Optional[str]]] = None,
                                     name: Optional[pulumi.Input[Optional[str]]] = None,
                                     opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetRemoteIdentityGroupResult]:
    """
    A RemoteIdentityGroup defines a group of remote identities.
    ## Example Usage

    ```python
    import pulumi
    import pulumi_sdm as sdm

    default = sdm.get_remote_identity_group(name="default")
    ```


    :param str id: Unique identifier of the RemoteIdentityGroup.
    :param str name: Unique human-readable name of the RemoteIdentityGroup.
    """
    __args__ = dict()
    __args__['id'] = id
    __args__['name'] = name
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke_output('sdm:index/getRemoteIdentityGroup:getRemoteIdentityGroup', __args__, opts=opts, typ=GetRemoteIdentityGroupResult)
    return __ret__.apply(lambda __response__: GetRemoteIdentityGroupResult(
        id=pulumi.get(__response__, 'id'),
        ids=pulumi.get(__response__, 'ids'),
        name=pulumi.get(__response__, 'name'),
        remote_identity_groups=pulumi.get(__response__, 'remote_identity_groups')))
