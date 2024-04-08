# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['ApprovalWorkflowArgs', 'ApprovalWorkflow']

@pulumi.input_type
class ApprovalWorkflowArgs:
    def __init__(__self__, *,
                 approval_mode: pulumi.Input[str],
                 description: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a ApprovalWorkflow resource.
        :param pulumi.Input[str] approval_mode: Approval mode of the ApprovalWorkflow
        :param pulumi.Input[str] description: Optional description of the ApprovalWorkflow.
        :param pulumi.Input[str] name: Unique human-readable name of the ApprovalWorkflow.
        """
        pulumi.set(__self__, "approval_mode", approval_mode)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter(name="approvalMode")
    def approval_mode(self) -> pulumi.Input[str]:
        """
        Approval mode of the ApprovalWorkflow
        """
        return pulumi.get(self, "approval_mode")

    @approval_mode.setter
    def approval_mode(self, value: pulumi.Input[str]):
        pulumi.set(self, "approval_mode", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Optional description of the ApprovalWorkflow.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Unique human-readable name of the ApprovalWorkflow.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)


@pulumi.input_type
class _ApprovalWorkflowState:
    def __init__(__self__, *,
                 approval_mode: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering ApprovalWorkflow resources.
        :param pulumi.Input[str] approval_mode: Approval mode of the ApprovalWorkflow
        :param pulumi.Input[str] description: Optional description of the ApprovalWorkflow.
        :param pulumi.Input[str] name: Unique human-readable name of the ApprovalWorkflow.
        """
        if approval_mode is not None:
            pulumi.set(__self__, "approval_mode", approval_mode)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter(name="approvalMode")
    def approval_mode(self) -> Optional[pulumi.Input[str]]:
        """
        Approval mode of the ApprovalWorkflow
        """
        return pulumi.get(self, "approval_mode")

    @approval_mode.setter
    def approval_mode(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "approval_mode", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Optional description of the ApprovalWorkflow.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Unique human-readable name of the ApprovalWorkflow.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)


class ApprovalWorkflow(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 approval_mode: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        ApprovalWorkflows are the mechanism by which requests for access can be viewed by authorized
         approvers and be approved or denied.
        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pierskarsenbarg_pulumi_sdm as sdm

        manual_approval_workflow = sdm.ApprovalWorkflow("manualApprovalWorkflow", approval_mode="manual")
        auto_grant_approval_workflow = sdm.ApprovalWorkflow("autoGrantApprovalWorkflow", approval_mode="automatic")
        ```
        <!--End PulumiCodeChooser -->
        This resource can be imported using the import command.

        ## Import

        A ApprovalWorkflow can be imported using the id, e.g.,

        ```sh
        $ pulumi import sdm:index/approvalWorkflow:ApprovalWorkflow example af-12345678
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] approval_mode: Approval mode of the ApprovalWorkflow
        :param pulumi.Input[str] description: Optional description of the ApprovalWorkflow.
        :param pulumi.Input[str] name: Unique human-readable name of the ApprovalWorkflow.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ApprovalWorkflowArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        ApprovalWorkflows are the mechanism by which requests for access can be viewed by authorized
         approvers and be approved or denied.
        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pierskarsenbarg_pulumi_sdm as sdm

        manual_approval_workflow = sdm.ApprovalWorkflow("manualApprovalWorkflow", approval_mode="manual")
        auto_grant_approval_workflow = sdm.ApprovalWorkflow("autoGrantApprovalWorkflow", approval_mode="automatic")
        ```
        <!--End PulumiCodeChooser -->
        This resource can be imported using the import command.

        ## Import

        A ApprovalWorkflow can be imported using the id, e.g.,

        ```sh
        $ pulumi import sdm:index/approvalWorkflow:ApprovalWorkflow example af-12345678
        ```

        :param str resource_name: The name of the resource.
        :param ApprovalWorkflowArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ApprovalWorkflowArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 approval_mode: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ApprovalWorkflowArgs.__new__(ApprovalWorkflowArgs)

            if approval_mode is None and not opts.urn:
                raise TypeError("Missing required property 'approval_mode'")
            __props__.__dict__["approval_mode"] = approval_mode
            __props__.__dict__["description"] = description
            __props__.__dict__["name"] = name
        super(ApprovalWorkflow, __self__).__init__(
            'sdm:index/approvalWorkflow:ApprovalWorkflow',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            approval_mode: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None) -> 'ApprovalWorkflow':
        """
        Get an existing ApprovalWorkflow resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] approval_mode: Approval mode of the ApprovalWorkflow
        :param pulumi.Input[str] description: Optional description of the ApprovalWorkflow.
        :param pulumi.Input[str] name: Unique human-readable name of the ApprovalWorkflow.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ApprovalWorkflowState.__new__(_ApprovalWorkflowState)

        __props__.__dict__["approval_mode"] = approval_mode
        __props__.__dict__["description"] = description
        __props__.__dict__["name"] = name
        return ApprovalWorkflow(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="approvalMode")
    def approval_mode(self) -> pulumi.Output[str]:
        """
        Approval mode of the ApprovalWorkflow
        """
        return pulumi.get(self, "approval_mode")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        Optional description of the ApprovalWorkflow.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Unique human-readable name of the ApprovalWorkflow.
        """
        return pulumi.get(self, "name")
