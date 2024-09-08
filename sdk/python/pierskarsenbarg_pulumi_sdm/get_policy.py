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
    'GetPolicyResult',
    'AwaitableGetPolicyResult',
    'get_policy',
    'get_policy_output',
]

@pulumi.output_type
class GetPolicyResult:
    """
    A collection of values returned by getPolicy.
    """
    def __init__(__self__, description=None, id=None, ids=None, name=None, policies=None, policy=None):
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if ids and not isinstance(ids, list):
            raise TypeError("Expected argument 'ids' to be a list")
        pulumi.set(__self__, "ids", ids)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if policies and not isinstance(policies, list):
            raise TypeError("Expected argument 'policies' to be a list")
        pulumi.set(__self__, "policies", policies)
        if policy and not isinstance(policy, str):
            raise TypeError("Expected argument 'policy' to be a str")
        pulumi.set(__self__, "policy", policy)

    @property
    @pulumi.getter
    def description(self) -> Optional[str]:
        """
        Optional description of the Policy.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def id(self) -> Optional[str]:
        """
        Unique identifier of the Policy.
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
        Unique human-readable name of the Policy.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def policies(self) -> Sequence['outputs.GetPolicyPolicyResult']:
        """
        A list where each element has the following attributes:
        """
        return pulumi.get(self, "policies")

    @property
    @pulumi.getter
    def policy(self) -> Optional[str]:
        """
        The content of the Policy, in Cedar policy language.
        """
        return pulumi.get(self, "policy")


class AwaitableGetPolicyResult(GetPolicyResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetPolicyResult(
            description=self.description,
            id=self.id,
            ids=self.ids,
            name=self.name,
            policies=self.policies,
            policy=self.policy)


def get_policy(description: Optional[str] = None,
               id: Optional[str] = None,
               name: Optional[str] = None,
               policy: Optional[str] = None,
               opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetPolicyResult:
    """
    Policy is a collection of one or more statements that enforce fine-grained access control
     for the users of an organization.
    ## Example Usage

    ```python
    import pulumi
    import pulumi_sdm as sdm

    policy = sdm.get_policy(name="policy-query")
    ```


    :param str description: Optional description of the Policy.
    :param str id: Unique identifier of the Policy.
    :param str name: Unique human-readable name of the Policy.
    :param str policy: The content of the Policy, in Cedar policy language.
    """
    __args__ = dict()
    __args__['description'] = description
    __args__['id'] = id
    __args__['name'] = name
    __args__['policy'] = policy
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('sdm:index/getPolicy:getPolicy', __args__, opts=opts, typ=GetPolicyResult).value

    return AwaitableGetPolicyResult(
        description=pulumi.get(__ret__, 'description'),
        id=pulumi.get(__ret__, 'id'),
        ids=pulumi.get(__ret__, 'ids'),
        name=pulumi.get(__ret__, 'name'),
        policies=pulumi.get(__ret__, 'policies'),
        policy=pulumi.get(__ret__, 'policy'))


@_utilities.lift_output_func(get_policy)
def get_policy_output(description: Optional[pulumi.Input[Optional[str]]] = None,
                      id: Optional[pulumi.Input[Optional[str]]] = None,
                      name: Optional[pulumi.Input[Optional[str]]] = None,
                      policy: Optional[pulumi.Input[Optional[str]]] = None,
                      opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetPolicyResult]:
    """
    Policy is a collection of one or more statements that enforce fine-grained access control
     for the users of an organization.
    ## Example Usage

    ```python
    import pulumi
    import pulumi_sdm as sdm

    policy = sdm.get_policy(name="policy-query")
    ```


    :param str description: Optional description of the Policy.
    :param str id: Unique identifier of the Policy.
    :param str name: Unique human-readable name of the Policy.
    :param str policy: The content of the Policy, in Cedar policy language.
    """
    ...