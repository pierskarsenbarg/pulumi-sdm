# coding=utf-8
# *** WARNING: this file was generated by pulumi-language-python. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import builtins
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
    'GetWorkflowRoleResult',
    'AwaitableGetWorkflowRoleResult',
    'get_workflow_role',
    'get_workflow_role_output',
]

@pulumi.output_type
class GetWorkflowRoleResult:
    """
    A collection of values returned by getWorkflowRole.
    """
    def __init__(__self__, id=None, ids=None, role_id=None, workflow_id=None, workflow_roles=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if ids and not isinstance(ids, list):
            raise TypeError("Expected argument 'ids' to be a list")
        pulumi.set(__self__, "ids", ids)
        if role_id and not isinstance(role_id, str):
            raise TypeError("Expected argument 'role_id' to be a str")
        pulumi.set(__self__, "role_id", role_id)
        if workflow_id and not isinstance(workflow_id, str):
            raise TypeError("Expected argument 'workflow_id' to be a str")
        pulumi.set(__self__, "workflow_id", workflow_id)
        if workflow_roles and not isinstance(workflow_roles, list):
            raise TypeError("Expected argument 'workflow_roles' to be a list")
        pulumi.set(__self__, "workflow_roles", workflow_roles)

    @property
    @pulumi.getter
    def id(self) -> Optional[builtins.str]:
        """
        Unique identifier of the WorkflowRole.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def ids(self) -> Sequence[builtins.str]:
        """
        a list of strings of ids of data sources that match the given arguments.
        """
        return pulumi.get(self, "ids")

    @property
    @pulumi.getter(name="roleId")
    def role_id(self) -> Optional[builtins.str]:
        """
        The role id.
        """
        return pulumi.get(self, "role_id")

    @property
    @pulumi.getter(name="workflowId")
    def workflow_id(self) -> Optional[builtins.str]:
        """
        The workflow id.
        """
        return pulumi.get(self, "workflow_id")

    @property
    @pulumi.getter(name="workflowRoles")
    def workflow_roles(self) -> Sequence['outputs.GetWorkflowRoleWorkflowRoleResult']:
        """
        A list where each element has the following attributes:
        """
        return pulumi.get(self, "workflow_roles")


class AwaitableGetWorkflowRoleResult(GetWorkflowRoleResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetWorkflowRoleResult(
            id=self.id,
            ids=self.ids,
            role_id=self.role_id,
            workflow_id=self.workflow_id,
            workflow_roles=self.workflow_roles)


def get_workflow_role(id: Optional[builtins.str] = None,
                      role_id: Optional[builtins.str] = None,
                      workflow_id: Optional[builtins.str] = None,
                      opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetWorkflowRoleResult:
    """
    WorkflowRole links a role to a workflow. The linked roles indicate which roles a user must be a part of
     to request access to a resource via the workflow.
    ## Example Usage

    ```python
    import pulumi
    import pulumi_sdm as sdm

    workflow_role_query = sdm.get_workflow_role(role_id="r-9862923",
        workflow_id="aw-7935485")
    ```


    :param builtins.str id: Unique identifier of the WorkflowRole.
    :param builtins.str role_id: The role id.
    :param builtins.str workflow_id: The workflow id.
    """
    __args__ = dict()
    __args__['id'] = id
    __args__['roleId'] = role_id
    __args__['workflowId'] = workflow_id
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('sdm:index/getWorkflowRole:getWorkflowRole', __args__, opts=opts, typ=GetWorkflowRoleResult).value

    return AwaitableGetWorkflowRoleResult(
        id=pulumi.get(__ret__, 'id'),
        ids=pulumi.get(__ret__, 'ids'),
        role_id=pulumi.get(__ret__, 'role_id'),
        workflow_id=pulumi.get(__ret__, 'workflow_id'),
        workflow_roles=pulumi.get(__ret__, 'workflow_roles'))
def get_workflow_role_output(id: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                             role_id: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                             workflow_id: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                             opts: Optional[Union[pulumi.InvokeOptions, pulumi.InvokeOutputOptions]] = None) -> pulumi.Output[GetWorkflowRoleResult]:
    """
    WorkflowRole links a role to a workflow. The linked roles indicate which roles a user must be a part of
     to request access to a resource via the workflow.
    ## Example Usage

    ```python
    import pulumi
    import pulumi_sdm as sdm

    workflow_role_query = sdm.get_workflow_role(role_id="r-9862923",
        workflow_id="aw-7935485")
    ```


    :param builtins.str id: Unique identifier of the WorkflowRole.
    :param builtins.str role_id: The role id.
    :param builtins.str workflow_id: The workflow id.
    """
    __args__ = dict()
    __args__['id'] = id
    __args__['roleId'] = role_id
    __args__['workflowId'] = workflow_id
    opts = pulumi.InvokeOutputOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke_output('sdm:index/getWorkflowRole:getWorkflowRole', __args__, opts=opts, typ=GetWorkflowRoleResult)
    return __ret__.apply(lambda __response__: GetWorkflowRoleResult(
        id=pulumi.get(__response__, 'id'),
        ids=pulumi.get(__response__, 'ids'),
        role_id=pulumi.get(__response__, 'role_id'),
        workflow_id=pulumi.get(__response__, 'workflow_id'),
        workflow_roles=pulumi.get(__response__, 'workflow_roles')))
