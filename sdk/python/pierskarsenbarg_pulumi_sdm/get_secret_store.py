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
    'GetSecretStoreResult',
    'AwaitableGetSecretStoreResult',
    'get_secret_store',
    'get_secret_store_output',
]

@pulumi.output_type
class GetSecretStoreResult:
    """
    A collection of values returned by getSecretStore.
    """
    def __init__(__self__, id=None, ids=None, name=None, secret_stores=None, tags=None, type=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if ids and not isinstance(ids, list):
            raise TypeError("Expected argument 'ids' to be a list")
        pulumi.set(__self__, "ids", ids)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if secret_stores and not isinstance(secret_stores, list):
            raise TypeError("Expected argument 'secret_stores' to be a list")
        pulumi.set(__self__, "secret_stores", secret_stores)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def id(self) -> Optional[str]:
        """
        Unique identifier of the SecretStore.
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
        Unique human-readable name of the SecretStore.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="secretStores")
    def secret_stores(self) -> Sequence['outputs.GetSecretStoreSecretStoreResult']:
        """
        A single element list containing a map, where each key lists one of the following objects:
        * aws:
        """
        return pulumi.get(self, "secret_stores")

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


class AwaitableGetSecretStoreResult(GetSecretStoreResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetSecretStoreResult(
            id=self.id,
            ids=self.ids,
            name=self.name,
            secret_stores=self.secret_stores,
            tags=self.tags,
            type=self.type)


def get_secret_store(id: Optional[str] = None,
                     name: Optional[str] = None,
                     tags: Optional[Mapping[str, Any]] = None,
                     type: Optional[str] = None,
                     opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetSecretStoreResult:
    """
    A SecretStore is a server where resource secrets (passwords, keys) are stored.
     Coming soon support for HashiCorp Vault and AWS Secret Store.


    :param str id: Unique identifier of the SecretStore.
    :param str name: Unique human-readable name of the SecretStore.
    :param Mapping[str, Any] tags: Tags is a map of key, value pairs.
    :param str type: a filter to select all items of a certain subtype. See the [filter documentation](https://www.strongdm.com/docs/automation/getting-started/filters for more information.
    """
    __args__ = dict()
    __args__['id'] = id
    __args__['name'] = name
    __args__['tags'] = tags
    __args__['type'] = type
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('sdm:index/getSecretStore:getSecretStore', __args__, opts=opts, typ=GetSecretStoreResult).value

    return AwaitableGetSecretStoreResult(
        id=pulumi.get(__ret__, 'id'),
        ids=pulumi.get(__ret__, 'ids'),
        name=pulumi.get(__ret__, 'name'),
        secret_stores=pulumi.get(__ret__, 'secret_stores'),
        tags=pulumi.get(__ret__, 'tags'),
        type=pulumi.get(__ret__, 'type'))


@_utilities.lift_output_func(get_secret_store)
def get_secret_store_output(id: Optional[pulumi.Input[Optional[str]]] = None,
                            name: Optional[pulumi.Input[Optional[str]]] = None,
                            tags: Optional[pulumi.Input[Optional[Mapping[str, Any]]]] = None,
                            type: Optional[pulumi.Input[Optional[str]]] = None,
                            opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetSecretStoreResult]:
    """
    A SecretStore is a server where resource secrets (passwords, keys) are stored.
     Coming soon support for HashiCorp Vault and AWS Secret Store.


    :param str id: Unique identifier of the SecretStore.
    :param str name: Unique human-readable name of the SecretStore.
    :param Mapping[str, Any] tags: Tags is a map of key, value pairs.
    :param str type: a filter to select all items of a certain subtype. See the [filter documentation](https://www.strongdm.com/docs/automation/getting-started/filters for more information.
    """
    ...
