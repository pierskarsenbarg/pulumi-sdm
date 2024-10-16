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
    'GetRemoteIdentityResult',
    'AwaitableGetRemoteIdentityResult',
    'get_remote_identity',
    'get_remote_identity_output',
]

@pulumi.output_type
class GetRemoteIdentityResult:
    """
    A collection of values returned by getRemoteIdentity.
    """
    def __init__(__self__, account_id=None, id=None, ids=None, remote_identities=None, remote_identity_group_id=None, username=None):
        if account_id and not isinstance(account_id, str):
            raise TypeError("Expected argument 'account_id' to be a str")
        pulumi.set(__self__, "account_id", account_id)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if ids and not isinstance(ids, list):
            raise TypeError("Expected argument 'ids' to be a list")
        pulumi.set(__self__, "ids", ids)
        if remote_identities and not isinstance(remote_identities, list):
            raise TypeError("Expected argument 'remote_identities' to be a list")
        pulumi.set(__self__, "remote_identities", remote_identities)
        if remote_identity_group_id and not isinstance(remote_identity_group_id, str):
            raise TypeError("Expected argument 'remote_identity_group_id' to be a str")
        pulumi.set(__self__, "remote_identity_group_id", remote_identity_group_id)
        if username and not isinstance(username, str):
            raise TypeError("Expected argument 'username' to be a str")
        pulumi.set(__self__, "username", username)

    @property
    @pulumi.getter(name="accountId")
    def account_id(self) -> Optional[str]:
        """
        The account for this remote identity.
        """
        return pulumi.get(self, "account_id")

    @property
    @pulumi.getter
    def id(self) -> Optional[str]:
        """
        Unique identifier of the RemoteIdentity.
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
    @pulumi.getter(name="remoteIdentities")
    def remote_identities(self) -> Sequence['outputs.GetRemoteIdentityRemoteIdentityResult']:
        """
        A list where each element has the following attributes:
        """
        return pulumi.get(self, "remote_identities")

    @property
    @pulumi.getter(name="remoteIdentityGroupId")
    def remote_identity_group_id(self) -> Optional[str]:
        """
        The remote identity group.
        """
        return pulumi.get(self, "remote_identity_group_id")

    @property
    @pulumi.getter
    def username(self) -> Optional[str]:
        """
        The username to be used as the remote identity for this account.
        """
        return pulumi.get(self, "username")


class AwaitableGetRemoteIdentityResult(GetRemoteIdentityResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetRemoteIdentityResult(
            account_id=self.account_id,
            id=self.id,
            ids=self.ids,
            remote_identities=self.remote_identities,
            remote_identity_group_id=self.remote_identity_group_id,
            username=self.username)


def get_remote_identity(account_id: Optional[str] = None,
                        id: Optional[str] = None,
                        remote_identity_group_id: Optional[str] = None,
                        username: Optional[str] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetRemoteIdentityResult:
    """
    RemoteIdentities define the username to be used for a specific account
     when connecting to a remote resource using that group.
    ## Example Usage

    ```python
    import pulumi
    import pulumi_sdm as sdm

    user = sdm.get_remote_identity(id="i-0900909",
        username="user")
    ```


    :param str account_id: The account for this remote identity.
    :param str id: Unique identifier of the RemoteIdentity.
    :param str remote_identity_group_id: The remote identity group.
    :param str username: The username to be used as the remote identity for this account.
    """
    __args__ = dict()
    __args__['accountId'] = account_id
    __args__['id'] = id
    __args__['remoteIdentityGroupId'] = remote_identity_group_id
    __args__['username'] = username
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('sdm:index/getRemoteIdentity:getRemoteIdentity', __args__, opts=opts, typ=GetRemoteIdentityResult).value

    return AwaitableGetRemoteIdentityResult(
        account_id=pulumi.get(__ret__, 'account_id'),
        id=pulumi.get(__ret__, 'id'),
        ids=pulumi.get(__ret__, 'ids'),
        remote_identities=pulumi.get(__ret__, 'remote_identities'),
        remote_identity_group_id=pulumi.get(__ret__, 'remote_identity_group_id'),
        username=pulumi.get(__ret__, 'username'))
def get_remote_identity_output(account_id: Optional[pulumi.Input[Optional[str]]] = None,
                               id: Optional[pulumi.Input[Optional[str]]] = None,
                               remote_identity_group_id: Optional[pulumi.Input[Optional[str]]] = None,
                               username: Optional[pulumi.Input[Optional[str]]] = None,
                               opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetRemoteIdentityResult]:
    """
    RemoteIdentities define the username to be used for a specific account
     when connecting to a remote resource using that group.
    ## Example Usage

    ```python
    import pulumi
    import pulumi_sdm as sdm

    user = sdm.get_remote_identity(id="i-0900909",
        username="user")
    ```


    :param str account_id: The account for this remote identity.
    :param str id: Unique identifier of the RemoteIdentity.
    :param str remote_identity_group_id: The remote identity group.
    :param str username: The username to be used as the remote identity for this account.
    """
    __args__ = dict()
    __args__['accountId'] = account_id
    __args__['id'] = id
    __args__['remoteIdentityGroupId'] = remote_identity_group_id
    __args__['username'] = username
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke_output('sdm:index/getRemoteIdentity:getRemoteIdentity', __args__, opts=opts, typ=GetRemoteIdentityResult)
    return __ret__.apply(lambda __response__: GetRemoteIdentityResult(
        account_id=pulumi.get(__response__, 'account_id'),
        id=pulumi.get(__response__, 'id'),
        ids=pulumi.get(__response__, 'ids'),
        remote_identities=pulumi.get(__response__, 'remote_identities'),
        remote_identity_group_id=pulumi.get(__response__, 'remote_identity_group_id'),
        username=pulumi.get(__response__, 'username')))
