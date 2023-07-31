# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from . import _utilities
import typing
# Export this package's modules as members:
from .account import *
from .account_attachment import *
from .get_account import *
from .get_account_attachment import *
from .get_node import *
from .get_peering_group import *
from .get_peering_group_node import *
from .get_peering_group_peer import *
from .get_peering_group_resource import *
from .get_remote_identity import *
from .get_remote_identity_group import *
from .get_resource import *
from .get_role import *
from .get_secret_store import *
from .get_ssh_ca_pubkey import *
from .node import *
from .peering_group import *
from .peering_group_node import *
from .peering_group_peer import *
from .peering_group_resource import *
from .provider import *
from .remote_identity import *
from .resource import *
from .role import *
from .secret_store import *
from ._inputs import *
from . import outputs

# Make subpackages available:
if typing.TYPE_CHECKING:
    import pierskarsenbarg_pulumi_sdm.config as __config
    config = __config
else:
    config = _utilities.lazy_import('pierskarsenbarg_pulumi_sdm.config')

_utilities.register(
    resource_modules="""
[
 {
  "pkg": "sdm",
  "mod": "index/account",
  "fqn": "pierskarsenbarg_pulumi_sdm",
  "classes": {
   "sdm:index/account:Account": "Account"
  }
 },
 {
  "pkg": "sdm",
  "mod": "index/accountAttachment",
  "fqn": "pierskarsenbarg_pulumi_sdm",
  "classes": {
   "sdm:index/accountAttachment:AccountAttachment": "AccountAttachment"
  }
 },
 {
  "pkg": "sdm",
  "mod": "index/node",
  "fqn": "pierskarsenbarg_pulumi_sdm",
  "classes": {
   "sdm:index/node:Node": "Node"
  }
 },
 {
  "pkg": "sdm",
  "mod": "index/peeringGroup",
  "fqn": "pierskarsenbarg_pulumi_sdm",
  "classes": {
   "sdm:index/peeringGroup:PeeringGroup": "PeeringGroup"
  }
 },
 {
  "pkg": "sdm",
  "mod": "index/peeringGroupNode",
  "fqn": "pierskarsenbarg_pulumi_sdm",
  "classes": {
   "sdm:index/peeringGroupNode:PeeringGroupNode": "PeeringGroupNode"
  }
 },
 {
  "pkg": "sdm",
  "mod": "index/peeringGroupPeer",
  "fqn": "pierskarsenbarg_pulumi_sdm",
  "classes": {
   "sdm:index/peeringGroupPeer:PeeringGroupPeer": "PeeringGroupPeer"
  }
 },
 {
  "pkg": "sdm",
  "mod": "index/peeringGroupResource",
  "fqn": "pierskarsenbarg_pulumi_sdm",
  "classes": {
   "sdm:index/peeringGroupResource:PeeringGroupResource": "PeeringGroupResource"
  }
 },
 {
  "pkg": "sdm",
  "mod": "index/remoteIdentity",
  "fqn": "pierskarsenbarg_pulumi_sdm",
  "classes": {
   "sdm:index/remoteIdentity:RemoteIdentity": "RemoteIdentity"
  }
 },
 {
  "pkg": "sdm",
  "mod": "index/resource",
  "fqn": "pierskarsenbarg_pulumi_sdm",
  "classes": {
   "sdm:index/resource:Resource": "Resource"
  }
 },
 {
  "pkg": "sdm",
  "mod": "index/role",
  "fqn": "pierskarsenbarg_pulumi_sdm",
  "classes": {
   "sdm:index/role:Role": "Role"
  }
 },
 {
  "pkg": "sdm",
  "mod": "index/secretStore",
  "fqn": "pierskarsenbarg_pulumi_sdm",
  "classes": {
   "sdm:index/secretStore:SecretStore": "SecretStore"
  }
 }
]
""",
    resource_packages="""
[
 {
  "pkg": "sdm",
  "token": "pulumi:providers:sdm",
  "fqn": "pierskarsenbarg_pulumi_sdm",
  "class": "Provider"
 }
]
"""
)
