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
    'GetPeeringGroupPeerResult',
    'AwaitableGetPeeringGroupPeerResult',
    'get_peering_group_peer',
    'get_peering_group_peer_output',
]

@pulumi.output_type
class GetPeeringGroupPeerResult:
    """
    A collection of values returned by getPeeringGroupPeer.
    """
    def __init__(__self__, group_id=None, id=None, ids=None, peering_group_peers=None, peers_with_group_id=None):
        if group_id and not isinstance(group_id, str):
            raise TypeError("Expected argument 'group_id' to be a str")
        pulumi.set(__self__, "group_id", group_id)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if ids and not isinstance(ids, list):
            raise TypeError("Expected argument 'ids' to be a list")
        pulumi.set(__self__, "ids", ids)
        if peering_group_peers and not isinstance(peering_group_peers, list):
            raise TypeError("Expected argument 'peering_group_peers' to be a list")
        pulumi.set(__self__, "peering_group_peers", peering_group_peers)
        if peers_with_group_id and not isinstance(peers_with_group_id, str):
            raise TypeError("Expected argument 'peers_with_group_id' to be a str")
        pulumi.set(__self__, "peers_with_group_id", peers_with_group_id)

    @property
    @pulumi.getter(name="groupId")
    def group_id(self) -> Optional[str]:
        """
        Group ID from which the link will originate.
        """
        return pulumi.get(self, "group_id")

    @property
    @pulumi.getter
    def id(self) -> Optional[str]:
        """
        Unique identifier of the Attachment.
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
    @pulumi.getter(name="peeringGroupPeers")
    def peering_group_peers(self) -> Sequence['outputs.GetPeeringGroupPeerPeeringGroupPeerResult']:
        """
        A list where each element has the following attributes:
        """
        return pulumi.get(self, "peering_group_peers")

    @property
    @pulumi.getter(name="peersWithGroupId")
    def peers_with_group_id(self) -> Optional[str]:
        """
        Peering Group ID to which Group ID will link.
        """
        return pulumi.get(self, "peers_with_group_id")


class AwaitableGetPeeringGroupPeerResult(GetPeeringGroupPeerResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetPeeringGroupPeerResult(
            group_id=self.group_id,
            id=self.id,
            ids=self.ids,
            peering_group_peers=self.peering_group_peers,
            peers_with_group_id=self.peers_with_group_id)


def get_peering_group_peer(group_id: Optional[str] = None,
                           id: Optional[str] = None,
                           peers_with_group_id: Optional[str] = None,
                           opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetPeeringGroupPeerResult:
    """
    PeeringGroupPeer represents the link between two PeeringGroups


    :param str group_id: Group ID from which the link will originate.
    :param str id: Unique identifier of the Attachment.
    :param str peers_with_group_id: Peering Group ID to which Group ID will link.
    """
    __args__ = dict()
    __args__['groupId'] = group_id
    __args__['id'] = id
    __args__['peersWithGroupId'] = peers_with_group_id
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('sdm:index/getPeeringGroupPeer:getPeeringGroupPeer', __args__, opts=opts, typ=GetPeeringGroupPeerResult).value

    return AwaitableGetPeeringGroupPeerResult(
        group_id=pulumi.get(__ret__, 'group_id'),
        id=pulumi.get(__ret__, 'id'),
        ids=pulumi.get(__ret__, 'ids'),
        peering_group_peers=pulumi.get(__ret__, 'peering_group_peers'),
        peers_with_group_id=pulumi.get(__ret__, 'peers_with_group_id'))
def get_peering_group_peer_output(group_id: Optional[pulumi.Input[Optional[str]]] = None,
                                  id: Optional[pulumi.Input[Optional[str]]] = None,
                                  peers_with_group_id: Optional[pulumi.Input[Optional[str]]] = None,
                                  opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetPeeringGroupPeerResult]:
    """
    PeeringGroupPeer represents the link between two PeeringGroups


    :param str group_id: Group ID from which the link will originate.
    :param str id: Unique identifier of the Attachment.
    :param str peers_with_group_id: Peering Group ID to which Group ID will link.
    """
    __args__ = dict()
    __args__['groupId'] = group_id
    __args__['id'] = id
    __args__['peersWithGroupId'] = peers_with_group_id
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke_output('sdm:index/getPeeringGroupPeer:getPeeringGroupPeer', __args__, opts=opts, typ=GetPeeringGroupPeerResult)
    return __ret__.apply(lambda __response__: GetPeeringGroupPeerResult(
        group_id=pulumi.get(__response__, 'group_id'),
        id=pulumi.get(__response__, 'id'),
        ids=pulumi.get(__response__, 'ids'),
        peering_group_peers=pulumi.get(__response__, 'peering_group_peers'),
        peers_with_group_id=pulumi.get(__response__, 'peers_with_group_id')))
