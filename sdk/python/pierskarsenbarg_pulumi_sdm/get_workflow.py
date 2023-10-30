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
    'GetWorkflowResult',
    'AwaitableGetWorkflowResult',
    'get_workflow',
    'get_workflow_output',
]

@pulumi.output_type
class GetWorkflowResult:
    """
    A collection of values returned by getWorkflow.
    """
    def __init__(__self__, auto_grant=None, description=None, enabled=None, id=None, ids=None, name=None, weight=None, workflows=None):
        if auto_grant and not isinstance(auto_grant, bool):
            raise TypeError("Expected argument 'auto_grant' to be a bool")
        pulumi.set(__self__, "auto_grant", auto_grant)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if enabled and not isinstance(enabled, bool):
            raise TypeError("Expected argument 'enabled' to be a bool")
        pulumi.set(__self__, "enabled", enabled)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if ids and not isinstance(ids, list):
            raise TypeError("Expected argument 'ids' to be a list")
        pulumi.set(__self__, "ids", ids)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if weight and not isinstance(weight, int):
            raise TypeError("Expected argument 'weight' to be a int")
        pulumi.set(__self__, "weight", weight)
        if workflows and not isinstance(workflows, list):
            raise TypeError("Expected argument 'workflows' to be a list")
        pulumi.set(__self__, "workflows", workflows)

    @property
    @pulumi.getter(name="autoGrant")
    def auto_grant(self) -> Optional[bool]:
        """
        Optional auto grant setting to automatically approve requests or not, defaults to false.
        """
        return pulumi.get(self, "auto_grant")

    @property
    @pulumi.getter
    def description(self) -> Optional[str]:
        """
        Optional description of the Workflow.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def enabled(self) -> Optional[bool]:
        """
        Optional enabled state for workflow. This setting may be overridden by the system if the workflow doesn't meet the requirements to be enabled or if other conditions prevent enabling the workflow. The requirements to enable a workflow are that the workflow must be either set up for with auto grant enabled or have one or more WorkflowApprovers created for the workflow.
        """
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter
    def id(self) -> Optional[str]:
        """
        Unique identifier of the Workflow.
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
        Unique human-readable name of the Workflow.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def weight(self) -> Optional[int]:
        """
        Optional weight for workflow to specify it's priority in matching a request.
        """
        return pulumi.get(self, "weight")

    @property
    @pulumi.getter
    def workflows(self) -> Sequence['outputs.GetWorkflowWorkflowResult']:
        """
        A list where each element has the following attributes:
        """
        return pulumi.get(self, "workflows")


class AwaitableGetWorkflowResult(GetWorkflowResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetWorkflowResult(
            auto_grant=self.auto_grant,
            description=self.description,
            enabled=self.enabled,
            id=self.id,
            ids=self.ids,
            name=self.name,
            weight=self.weight,
            workflows=self.workflows)


def get_workflow(auto_grant: Optional[bool] = None,
                 description: Optional[str] = None,
                 enabled: Optional[bool] = None,
                 id: Optional[str] = None,
                 name: Optional[str] = None,
                 weight: Optional[int] = None,
                 opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetWorkflowResult:
    """
    Workflows are the collection of rules that define the resources to which access can be requested,
     the users that can request that access, and the mechanism for approving those requests which can either
     but automatic approval or a set of users authorized to approve the requests.
    ## Example Usage

    ```python
    import pulumi
    import pulumi_sdm as sdm

    workflow_query = sdm.get_workflow(auto_grant=True,
        name="workflow example")
    ```


    :param bool auto_grant: Optional auto grant setting to automatically approve requests or not, defaults to false.
    :param str description: Optional description of the Workflow.
    :param bool enabled: Optional enabled state for workflow. This setting may be overridden by the system if the workflow doesn't meet the requirements to be enabled or if other conditions prevent enabling the workflow. The requirements to enable a workflow are that the workflow must be either set up for with auto grant enabled or have one or more WorkflowApprovers created for the workflow.
    :param str id: Unique identifier of the Workflow.
    :param str name: Unique human-readable name of the Workflow.
    :param int weight: Optional weight for workflow to specify it's priority in matching a request.
    """
    __args__ = dict()
    __args__['autoGrant'] = auto_grant
    __args__['description'] = description
    __args__['enabled'] = enabled
    __args__['id'] = id
    __args__['name'] = name
    __args__['weight'] = weight
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('sdm:index/getWorkflow:getWorkflow', __args__, opts=opts, typ=GetWorkflowResult).value

    return AwaitableGetWorkflowResult(
        auto_grant=pulumi.get(__ret__, 'auto_grant'),
        description=pulumi.get(__ret__, 'description'),
        enabled=pulumi.get(__ret__, 'enabled'),
        id=pulumi.get(__ret__, 'id'),
        ids=pulumi.get(__ret__, 'ids'),
        name=pulumi.get(__ret__, 'name'),
        weight=pulumi.get(__ret__, 'weight'),
        workflows=pulumi.get(__ret__, 'workflows'))


@_utilities.lift_output_func(get_workflow)
def get_workflow_output(auto_grant: Optional[pulumi.Input[Optional[bool]]] = None,
                        description: Optional[pulumi.Input[Optional[str]]] = None,
                        enabled: Optional[pulumi.Input[Optional[bool]]] = None,
                        id: Optional[pulumi.Input[Optional[str]]] = None,
                        name: Optional[pulumi.Input[Optional[str]]] = None,
                        weight: Optional[pulumi.Input[Optional[int]]] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetWorkflowResult]:
    """
    Workflows are the collection of rules that define the resources to which access can be requested,
     the users that can request that access, and the mechanism for approving those requests which can either
     but automatic approval or a set of users authorized to approve the requests.
    ## Example Usage

    ```python
    import pulumi
    import pulumi_sdm as sdm

    workflow_query = sdm.get_workflow(auto_grant=True,
        name="workflow example")
    ```


    :param bool auto_grant: Optional auto grant setting to automatically approve requests or not, defaults to false.
    :param str description: Optional description of the Workflow.
    :param bool enabled: Optional enabled state for workflow. This setting may be overridden by the system if the workflow doesn't meet the requirements to be enabled or if other conditions prevent enabling the workflow. The requirements to enable a workflow are that the workflow must be either set up for with auto grant enabled or have one or more WorkflowApprovers created for the workflow.
    :param str id: Unique identifier of the Workflow.
    :param str name: Unique human-readable name of the Workflow.
    :param int weight: Optional weight for workflow to specify it's priority in matching a request.
    """
    ...
