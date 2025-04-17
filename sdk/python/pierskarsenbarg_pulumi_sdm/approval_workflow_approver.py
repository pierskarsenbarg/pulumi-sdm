# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
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

__all__ = ['ApprovalWorkflowApproverArgs', 'ApprovalWorkflowApprover']

@pulumi.input_type
class ApprovalWorkflowApproverArgs:
    def __init__(__self__, *,
                 approval_flow_id: pulumi.Input[builtins.str],
                 approval_step_id: pulumi.Input[builtins.str],
                 account_id: Optional[pulumi.Input[builtins.str]] = None,
                 role_id: Optional[pulumi.Input[builtins.str]] = None):
        """
        The set of arguments for constructing a ApprovalWorkflowApprover resource.
        :param pulumi.Input[builtins.str] approval_flow_id: The approval flow id specified the approval workflow that this approver belongs to
        :param pulumi.Input[builtins.str] approval_step_id: The approval step id specified the approval flow step that this approver belongs to
        :param pulumi.Input[builtins.str] account_id: The approver account id.
        :param pulumi.Input[builtins.str] role_id: The approver role id
        """
        pulumi.set(__self__, "approval_flow_id", approval_flow_id)
        pulumi.set(__self__, "approval_step_id", approval_step_id)
        if account_id is not None:
            pulumi.set(__self__, "account_id", account_id)
        if role_id is not None:
            pulumi.set(__self__, "role_id", role_id)

    @property
    @pulumi.getter(name="approvalFlowId")
    def approval_flow_id(self) -> pulumi.Input[builtins.str]:
        """
        The approval flow id specified the approval workflow that this approver belongs to
        """
        return pulumi.get(self, "approval_flow_id")

    @approval_flow_id.setter
    def approval_flow_id(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "approval_flow_id", value)

    @property
    @pulumi.getter(name="approvalStepId")
    def approval_step_id(self) -> pulumi.Input[builtins.str]:
        """
        The approval step id specified the approval flow step that this approver belongs to
        """
        return pulumi.get(self, "approval_step_id")

    @approval_step_id.setter
    def approval_step_id(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "approval_step_id", value)

    @property
    @pulumi.getter(name="accountId")
    def account_id(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The approver account id.
        """
        return pulumi.get(self, "account_id")

    @account_id.setter
    def account_id(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "account_id", value)

    @property
    @pulumi.getter(name="roleId")
    def role_id(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The approver role id
        """
        return pulumi.get(self, "role_id")

    @role_id.setter
    def role_id(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "role_id", value)


@pulumi.input_type
class _ApprovalWorkflowApproverState:
    def __init__(__self__, *,
                 account_id: Optional[pulumi.Input[builtins.str]] = None,
                 approval_flow_id: Optional[pulumi.Input[builtins.str]] = None,
                 approval_step_id: Optional[pulumi.Input[builtins.str]] = None,
                 role_id: Optional[pulumi.Input[builtins.str]] = None):
        """
        Input properties used for looking up and filtering ApprovalWorkflowApprover resources.
        :param pulumi.Input[builtins.str] account_id: The approver account id.
        :param pulumi.Input[builtins.str] approval_flow_id: The approval flow id specified the approval workflow that this approver belongs to
        :param pulumi.Input[builtins.str] approval_step_id: The approval step id specified the approval flow step that this approver belongs to
        :param pulumi.Input[builtins.str] role_id: The approver role id
        """
        if account_id is not None:
            pulumi.set(__self__, "account_id", account_id)
        if approval_flow_id is not None:
            pulumi.set(__self__, "approval_flow_id", approval_flow_id)
        if approval_step_id is not None:
            pulumi.set(__self__, "approval_step_id", approval_step_id)
        if role_id is not None:
            pulumi.set(__self__, "role_id", role_id)

    @property
    @pulumi.getter(name="accountId")
    def account_id(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The approver account id.
        """
        return pulumi.get(self, "account_id")

    @account_id.setter
    def account_id(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "account_id", value)

    @property
    @pulumi.getter(name="approvalFlowId")
    def approval_flow_id(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The approval flow id specified the approval workflow that this approver belongs to
        """
        return pulumi.get(self, "approval_flow_id")

    @approval_flow_id.setter
    def approval_flow_id(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "approval_flow_id", value)

    @property
    @pulumi.getter(name="approvalStepId")
    def approval_step_id(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The approval step id specified the approval flow step that this approver belongs to
        """
        return pulumi.get(self, "approval_step_id")

    @approval_step_id.setter
    def approval_step_id(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "approval_step_id", value)

    @property
    @pulumi.getter(name="roleId")
    def role_id(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The approver role id
        """
        return pulumi.get(self, "role_id")

    @role_id.setter
    def role_id(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "role_id", value)


class ApprovalWorkflowApprover(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 account_id: Optional[pulumi.Input[builtins.str]] = None,
                 approval_flow_id: Optional[pulumi.Input[builtins.str]] = None,
                 approval_step_id: Optional[pulumi.Input[builtins.str]] = None,
                 role_id: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        """
        ApprovalWorkflowApprover links an approval workflow approver to an ApprovalWorkflowStep
        ## Example Usage

        ```python
        import pulumi
        import pierskarsenbarg_pulumi_sdm as sdm

        approval_workflow_approver_account_example = sdm.ApprovalWorkflowApprover("approvalWorkflowApproverAccountExample",
            account_id="a-234605",
            approval_flow_id="af-6799234",
            approval_step_id="afs-2956266")
        approval_workflow_approver_role_example = sdm.ApprovalWorkflowApprover("approvalWorkflowApproverRoleExample",
            approval_flow_id="af-1935694",
            approval_step_id="afs-9245942",
            role_id="r-542982")
        ```
        This resource can be imported using the import command.

        ## Import

        A ApprovalWorkflowApprover can be imported using the id, e.g.,

        ```sh
        $ pulumi import sdm:index/approvalWorkflowApprover:ApprovalWorkflowApprover example afa-12345678
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] account_id: The approver account id.
        :param pulumi.Input[builtins.str] approval_flow_id: The approval flow id specified the approval workflow that this approver belongs to
        :param pulumi.Input[builtins.str] approval_step_id: The approval step id specified the approval flow step that this approver belongs to
        :param pulumi.Input[builtins.str] role_id: The approver role id
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ApprovalWorkflowApproverArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        ApprovalWorkflowApprover links an approval workflow approver to an ApprovalWorkflowStep
        ## Example Usage

        ```python
        import pulumi
        import pierskarsenbarg_pulumi_sdm as sdm

        approval_workflow_approver_account_example = sdm.ApprovalWorkflowApprover("approvalWorkflowApproverAccountExample",
            account_id="a-234605",
            approval_flow_id="af-6799234",
            approval_step_id="afs-2956266")
        approval_workflow_approver_role_example = sdm.ApprovalWorkflowApprover("approvalWorkflowApproverRoleExample",
            approval_flow_id="af-1935694",
            approval_step_id="afs-9245942",
            role_id="r-542982")
        ```
        This resource can be imported using the import command.

        ## Import

        A ApprovalWorkflowApprover can be imported using the id, e.g.,

        ```sh
        $ pulumi import sdm:index/approvalWorkflowApprover:ApprovalWorkflowApprover example afa-12345678
        ```

        :param str resource_name: The name of the resource.
        :param ApprovalWorkflowApproverArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ApprovalWorkflowApproverArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 account_id: Optional[pulumi.Input[builtins.str]] = None,
                 approval_flow_id: Optional[pulumi.Input[builtins.str]] = None,
                 approval_step_id: Optional[pulumi.Input[builtins.str]] = None,
                 role_id: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ApprovalWorkflowApproverArgs.__new__(ApprovalWorkflowApproverArgs)

            __props__.__dict__["account_id"] = account_id
            if approval_flow_id is None and not opts.urn:
                raise TypeError("Missing required property 'approval_flow_id'")
            __props__.__dict__["approval_flow_id"] = approval_flow_id
            if approval_step_id is None and not opts.urn:
                raise TypeError("Missing required property 'approval_step_id'")
            __props__.__dict__["approval_step_id"] = approval_step_id
            __props__.__dict__["role_id"] = role_id
        super(ApprovalWorkflowApprover, __self__).__init__(
            'sdm:index/approvalWorkflowApprover:ApprovalWorkflowApprover',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            account_id: Optional[pulumi.Input[builtins.str]] = None,
            approval_flow_id: Optional[pulumi.Input[builtins.str]] = None,
            approval_step_id: Optional[pulumi.Input[builtins.str]] = None,
            role_id: Optional[pulumi.Input[builtins.str]] = None) -> 'ApprovalWorkflowApprover':
        """
        Get an existing ApprovalWorkflowApprover resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] account_id: The approver account id.
        :param pulumi.Input[builtins.str] approval_flow_id: The approval flow id specified the approval workflow that this approver belongs to
        :param pulumi.Input[builtins.str] approval_step_id: The approval step id specified the approval flow step that this approver belongs to
        :param pulumi.Input[builtins.str] role_id: The approver role id
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ApprovalWorkflowApproverState.__new__(_ApprovalWorkflowApproverState)

        __props__.__dict__["account_id"] = account_id
        __props__.__dict__["approval_flow_id"] = approval_flow_id
        __props__.__dict__["approval_step_id"] = approval_step_id
        __props__.__dict__["role_id"] = role_id
        return ApprovalWorkflowApprover(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="accountId")
    def account_id(self) -> pulumi.Output[Optional[builtins.str]]:
        """
        The approver account id.
        """
        return pulumi.get(self, "account_id")

    @property
    @pulumi.getter(name="approvalFlowId")
    def approval_flow_id(self) -> pulumi.Output[builtins.str]:
        """
        The approval flow id specified the approval workflow that this approver belongs to
        """
        return pulumi.get(self, "approval_flow_id")

    @property
    @pulumi.getter(name="approvalStepId")
    def approval_step_id(self) -> pulumi.Output[builtins.str]:
        """
        The approval step id specified the approval flow step that this approver belongs to
        """
        return pulumi.get(self, "approval_step_id")

    @property
    @pulumi.getter(name="roleId")
    def role_id(self) -> pulumi.Output[Optional[builtins.str]]:
        """
        The approver role id
        """
        return pulumi.get(self, "role_id")

