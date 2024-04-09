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
    'GetApprovalWorkflowResult',
    'AwaitableGetApprovalWorkflowResult',
    'get_approval_workflow',
    'get_approval_workflow_output',
]

@pulumi.output_type
class GetApprovalWorkflowResult:
    """
    A collection of values returned by getApprovalWorkflow.
    """
    def __init__(__self__, approval_mode=None, approval_workflows=None, description=None, id=None, ids=None, name=None):
        if approval_mode and not isinstance(approval_mode, str):
            raise TypeError("Expected argument 'approval_mode' to be a str")
        pulumi.set(__self__, "approval_mode", approval_mode)
        if approval_workflows and not isinstance(approval_workflows, list):
            raise TypeError("Expected argument 'approval_workflows' to be a list")
        pulumi.set(__self__, "approval_workflows", approval_workflows)
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

    @property
    @pulumi.getter(name="approvalMode")
    def approval_mode(self) -> Optional[str]:
        """
        Approval mode of the ApprovalWorkflow
        """
        return pulumi.get(self, "approval_mode")

    @property
    @pulumi.getter(name="approvalWorkflows")
    def approval_workflows(self) -> Sequence['outputs.GetApprovalWorkflowApprovalWorkflowResult']:
        """
        A list where each element has the following attributes:
        """
        return pulumi.get(self, "approval_workflows")

    @property
    @pulumi.getter
    def description(self) -> Optional[str]:
        """
        Optional description of the ApprovalWorkflow.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def id(self) -> Optional[str]:
        """
        Unique identifier of the ApprovalWorkflow.
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
        Unique human-readable name of the ApprovalWorkflow.
        """
        return pulumi.get(self, "name")


class AwaitableGetApprovalWorkflowResult(GetApprovalWorkflowResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetApprovalWorkflowResult(
            approval_mode=self.approval_mode,
            approval_workflows=self.approval_workflows,
            description=self.description,
            id=self.id,
            ids=self.ids,
            name=self.name)


def get_approval_workflow(approval_mode: Optional[str] = None,
                          description: Optional[str] = None,
                          id: Optional[str] = None,
                          name: Optional[str] = None,
                          opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetApprovalWorkflowResult:
    """
    ApprovalWorkflows are the mechanism by which requests for access can be viewed by authorized
     approvers and be approved or denied.
    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_sdm as sdm

    manual_approval_workflow_query = sdm.get_approval_workflow(approval_mode="manual",
        name="approval workflow manual")
    auto_grant_approval_workflow_query = sdm.get_approval_workflow(approval_mode="automatic",
        name="approval workflow auto")
    ```
    <!--End PulumiCodeChooser -->


    :param str approval_mode: Approval mode of the ApprovalWorkflow
    :param str description: Optional description of the ApprovalWorkflow.
    :param str id: Unique identifier of the ApprovalWorkflow.
    :param str name: Unique human-readable name of the ApprovalWorkflow.
    """
    __args__ = dict()
    __args__['approvalMode'] = approval_mode
    __args__['description'] = description
    __args__['id'] = id
    __args__['name'] = name
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('sdm:index/getApprovalWorkflow:getApprovalWorkflow', __args__, opts=opts, typ=GetApprovalWorkflowResult).value

    return AwaitableGetApprovalWorkflowResult(
        approval_mode=pulumi.get(__ret__, 'approval_mode'),
        approval_workflows=pulumi.get(__ret__, 'approval_workflows'),
        description=pulumi.get(__ret__, 'description'),
        id=pulumi.get(__ret__, 'id'),
        ids=pulumi.get(__ret__, 'ids'),
        name=pulumi.get(__ret__, 'name'))


@_utilities.lift_output_func(get_approval_workflow)
def get_approval_workflow_output(approval_mode: Optional[pulumi.Input[Optional[str]]] = None,
                                 description: Optional[pulumi.Input[Optional[str]]] = None,
                                 id: Optional[pulumi.Input[Optional[str]]] = None,
                                 name: Optional[pulumi.Input[Optional[str]]] = None,
                                 opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetApprovalWorkflowResult]:
    """
    ApprovalWorkflows are the mechanism by which requests for access can be viewed by authorized
     approvers and be approved or denied.
    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_sdm as sdm

    manual_approval_workflow_query = sdm.get_approval_workflow(approval_mode="manual",
        name="approval workflow manual")
    auto_grant_approval_workflow_query = sdm.get_approval_workflow(approval_mode="automatic",
        name="approval workflow auto")
    ```
    <!--End PulumiCodeChooser -->


    :param str approval_mode: Approval mode of the ApprovalWorkflow
    :param str description: Optional description of the ApprovalWorkflow.
    :param str id: Unique identifier of the ApprovalWorkflow.
    :param str name: Unique human-readable name of the ApprovalWorkflow.
    """
    ...
