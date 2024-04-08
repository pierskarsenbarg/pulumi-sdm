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
    'GetApprovalWorkflowStepResult',
    'AwaitableGetApprovalWorkflowStepResult',
    'get_approval_workflow_step',
    'get_approval_workflow_step_output',
]

@pulumi.output_type
class GetApprovalWorkflowStepResult:
    """
    A collection of values returned by getApprovalWorkflowStep.
    """
    def __init__(__self__, approval_flow_id=None, approval_workflow_steps=None, id=None, ids=None):
        if approval_flow_id and not isinstance(approval_flow_id, str):
            raise TypeError("Expected argument 'approval_flow_id' to be a str")
        pulumi.set(__self__, "approval_flow_id", approval_flow_id)
        if approval_workflow_steps and not isinstance(approval_workflow_steps, list):
            raise TypeError("Expected argument 'approval_workflow_steps' to be a list")
        pulumi.set(__self__, "approval_workflow_steps", approval_workflow_steps)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if ids and not isinstance(ids, list):
            raise TypeError("Expected argument 'ids' to be a list")
        pulumi.set(__self__, "ids", ids)

    @property
    @pulumi.getter(name="approvalFlowId")
    def approval_flow_id(self) -> Optional[str]:
        """
        The approval flow id specified the approval workfflow that this step belongs to
        """
        return pulumi.get(self, "approval_flow_id")

    @property
    @pulumi.getter(name="approvalWorkflowSteps")
    def approval_workflow_steps(self) -> Sequence['outputs.GetApprovalWorkflowStepApprovalWorkflowStepResult']:
        """
        A list where each element has the following attributes:
        """
        return pulumi.get(self, "approval_workflow_steps")

    @property
    @pulumi.getter
    def id(self) -> Optional[str]:
        """
        Unique identifier of the ApprovalWorkflowStep.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def ids(self) -> Sequence[str]:
        """
        a list of strings of ids of data sources that match the given arguments.
        """
        return pulumi.get(self, "ids")


class AwaitableGetApprovalWorkflowStepResult(GetApprovalWorkflowStepResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetApprovalWorkflowStepResult(
            approval_flow_id=self.approval_flow_id,
            approval_workflow_steps=self.approval_workflow_steps,
            id=self.id,
            ids=self.ids)


def get_approval_workflow_step(approval_flow_id: Optional[str] = None,
                               id: Optional[str] = None,
                               opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetApprovalWorkflowStepResult:
    """
    ApprovalWorkflowStep links an approval workflow step to an ApprovalWorkflow
    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_sdm as sdm

    approval_workflow_step_query = sdm.get_approval_workflow_step(approval_flow_id="af-7935485")
    ```
    <!--End PulumiCodeChooser -->


    :param str approval_flow_id: The approval flow id specified the approval workfflow that this step belongs to
    :param str id: Unique identifier of the ApprovalWorkflowStep.
    """
    __args__ = dict()
    __args__['approvalFlowId'] = approval_flow_id
    __args__['id'] = id
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('sdm:index/getApprovalWorkflowStep:getApprovalWorkflowStep', __args__, opts=opts, typ=GetApprovalWorkflowStepResult).value

    return AwaitableGetApprovalWorkflowStepResult(
        approval_flow_id=pulumi.get(__ret__, 'approval_flow_id'),
        approval_workflow_steps=pulumi.get(__ret__, 'approval_workflow_steps'),
        id=pulumi.get(__ret__, 'id'),
        ids=pulumi.get(__ret__, 'ids'))


@_utilities.lift_output_func(get_approval_workflow_step)
def get_approval_workflow_step_output(approval_flow_id: Optional[pulumi.Input[Optional[str]]] = None,
                                      id: Optional[pulumi.Input[Optional[str]]] = None,
                                      opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetApprovalWorkflowStepResult]:
    """
    ApprovalWorkflowStep links an approval workflow step to an ApprovalWorkflow
    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_sdm as sdm

    approval_workflow_step_query = sdm.get_approval_workflow_step(approval_flow_id="af-7935485")
    ```
    <!--End PulumiCodeChooser -->


    :param str approval_flow_id: The approval flow id specified the approval workfflow that this step belongs to
    :param str id: Unique identifier of the ApprovalWorkflowStep.
    """
    ...