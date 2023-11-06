# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['WorkflowArgs', 'Workflow']

@pulumi.input_type
class WorkflowArgs:
    def __init__(__self__, *,
                 access_rules: Optional[pulumi.Input[str]] = None,
                 auto_grant: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 weight: Optional[pulumi.Input[int]] = None):
        """
        The set of arguments for constructing a Workflow resource.
        :param pulumi.Input[str] access_rules: AccessRules is a list of access rules defining the resources this Workflow provides access to.
        :param pulumi.Input[bool] auto_grant: Optional auto grant setting to automatically approve requests or not, defaults to false.
        :param pulumi.Input[str] description: Optional description of the Workflow.
        :param pulumi.Input[bool] enabled: Optional enabled state for workflow. This setting may be overridden by the system if the workflow doesn't meet the requirements to be enabled or if other conditions prevent enabling the workflow. The requirements to enable a workflow are that the workflow must be either set up for with auto grant enabled or have one or more WorkflowApprovers created for the workflow.
        :param pulumi.Input[str] name: Unique human-readable name of the Workflow.
        :param pulumi.Input[int] weight: Optional weight for workflow to specify it's priority in matching a request.
        """
        if access_rules is not None:
            pulumi.set(__self__, "access_rules", access_rules)
        if auto_grant is not None:
            pulumi.set(__self__, "auto_grant", auto_grant)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if weight is not None:
            pulumi.set(__self__, "weight", weight)

    @property
    @pulumi.getter(name="accessRules")
    def access_rules(self) -> Optional[pulumi.Input[str]]:
        """
        AccessRules is a list of access rules defining the resources this Workflow provides access to.
        """
        return pulumi.get(self, "access_rules")

    @access_rules.setter
    def access_rules(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "access_rules", value)

    @property
    @pulumi.getter(name="autoGrant")
    def auto_grant(self) -> Optional[pulumi.Input[bool]]:
        """
        Optional auto grant setting to automatically approve requests or not, defaults to false.
        """
        return pulumi.get(self, "auto_grant")

    @auto_grant.setter
    def auto_grant(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "auto_grant", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Optional description of the Workflow.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def enabled(self) -> Optional[pulumi.Input[bool]]:
        """
        Optional enabled state for workflow. This setting may be overridden by the system if the workflow doesn't meet the requirements to be enabled or if other conditions prevent enabling the workflow. The requirements to enable a workflow are that the workflow must be either set up for with auto grant enabled or have one or more WorkflowApprovers created for the workflow.
        """
        return pulumi.get(self, "enabled")

    @enabled.setter
    def enabled(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enabled", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Unique human-readable name of the Workflow.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def weight(self) -> Optional[pulumi.Input[int]]:
        """
        Optional weight for workflow to specify it's priority in matching a request.
        """
        return pulumi.get(self, "weight")

    @weight.setter
    def weight(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "weight", value)


@pulumi.input_type
class _WorkflowState:
    def __init__(__self__, *,
                 access_rules: Optional[pulumi.Input[str]] = None,
                 auto_grant: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 weight: Optional[pulumi.Input[int]] = None):
        """
        Input properties used for looking up and filtering Workflow resources.
        :param pulumi.Input[str] access_rules: AccessRules is a list of access rules defining the resources this Workflow provides access to.
        :param pulumi.Input[bool] auto_grant: Optional auto grant setting to automatically approve requests or not, defaults to false.
        :param pulumi.Input[str] description: Optional description of the Workflow.
        :param pulumi.Input[bool] enabled: Optional enabled state for workflow. This setting may be overridden by the system if the workflow doesn't meet the requirements to be enabled or if other conditions prevent enabling the workflow. The requirements to enable a workflow are that the workflow must be either set up for with auto grant enabled or have one or more WorkflowApprovers created for the workflow.
        :param pulumi.Input[str] name: Unique human-readable name of the Workflow.
        :param pulumi.Input[int] weight: Optional weight for workflow to specify it's priority in matching a request.
        """
        if access_rules is not None:
            pulumi.set(__self__, "access_rules", access_rules)
        if auto_grant is not None:
            pulumi.set(__self__, "auto_grant", auto_grant)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if weight is not None:
            pulumi.set(__self__, "weight", weight)

    @property
    @pulumi.getter(name="accessRules")
    def access_rules(self) -> Optional[pulumi.Input[str]]:
        """
        AccessRules is a list of access rules defining the resources this Workflow provides access to.
        """
        return pulumi.get(self, "access_rules")

    @access_rules.setter
    def access_rules(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "access_rules", value)

    @property
    @pulumi.getter(name="autoGrant")
    def auto_grant(self) -> Optional[pulumi.Input[bool]]:
        """
        Optional auto grant setting to automatically approve requests or not, defaults to false.
        """
        return pulumi.get(self, "auto_grant")

    @auto_grant.setter
    def auto_grant(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "auto_grant", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Optional description of the Workflow.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def enabled(self) -> Optional[pulumi.Input[bool]]:
        """
        Optional enabled state for workflow. This setting may be overridden by the system if the workflow doesn't meet the requirements to be enabled or if other conditions prevent enabling the workflow. The requirements to enable a workflow are that the workflow must be either set up for with auto grant enabled or have one or more WorkflowApprovers created for the workflow.
        """
        return pulumi.get(self, "enabled")

    @enabled.setter
    def enabled(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enabled", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Unique human-readable name of the Workflow.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def weight(self) -> Optional[pulumi.Input[int]]:
        """
        Optional weight for workflow to specify it's priority in matching a request.
        """
        return pulumi.get(self, "weight")

    @weight.setter
    def weight(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "weight", value)


class Workflow(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 access_rules: Optional[pulumi.Input[str]] = None,
                 auto_grant: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 weight: Optional[pulumi.Input[int]] = None,
                 __props__=None):
        """
        Workflows are the collection of rules that define the resources to which access can be requested,
         the users that can request that access, and the mechanism for approving those requests which can either
         but automatic approval or a set of users authorized to approve the requests.
        ## Example Usage

        ```python
        import pulumi
        import json
        import pierskarsenbarg_pulumi_sdm as sdm

        auto_grant_workflow = sdm.Workflow("autoGrantWorkflow",
            auto_grant=True,
            enabled=True,
            access_rules=json.dumps([{
                "type": "redis",
                "tags": {
                    "region": "us-east",
                },
            }]))
        manual_approval_workflow = sdm.Workflow("manualApprovalWorkflow",
            auto_grant=False,
            access_rules=json.dumps([{
                "type": "redis",
                "tags": {
                    "region": "us-east",
                },
            }]))
        ```
        This resource can be imported using the import command.

        ## Import

        A Workflow can be imported using the id, e.g.,

        ```sh
         $ pulumi import sdm:index/workflow:Workflow example aw-12345678
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] access_rules: AccessRules is a list of access rules defining the resources this Workflow provides access to.
        :param pulumi.Input[bool] auto_grant: Optional auto grant setting to automatically approve requests or not, defaults to false.
        :param pulumi.Input[str] description: Optional description of the Workflow.
        :param pulumi.Input[bool] enabled: Optional enabled state for workflow. This setting may be overridden by the system if the workflow doesn't meet the requirements to be enabled or if other conditions prevent enabling the workflow. The requirements to enable a workflow are that the workflow must be either set up for with auto grant enabled or have one or more WorkflowApprovers created for the workflow.
        :param pulumi.Input[str] name: Unique human-readable name of the Workflow.
        :param pulumi.Input[int] weight: Optional weight for workflow to specify it's priority in matching a request.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[WorkflowArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Workflows are the collection of rules that define the resources to which access can be requested,
         the users that can request that access, and the mechanism for approving those requests which can either
         but automatic approval or a set of users authorized to approve the requests.
        ## Example Usage

        ```python
        import pulumi
        import json
        import pierskarsenbarg_pulumi_sdm as sdm

        auto_grant_workflow = sdm.Workflow("autoGrantWorkflow",
            auto_grant=True,
            enabled=True,
            access_rules=json.dumps([{
                "type": "redis",
                "tags": {
                    "region": "us-east",
                },
            }]))
        manual_approval_workflow = sdm.Workflow("manualApprovalWorkflow",
            auto_grant=False,
            access_rules=json.dumps([{
                "type": "redis",
                "tags": {
                    "region": "us-east",
                },
            }]))
        ```
        This resource can be imported using the import command.

        ## Import

        A Workflow can be imported using the id, e.g.,

        ```sh
         $ pulumi import sdm:index/workflow:Workflow example aw-12345678
        ```

        :param str resource_name: The name of the resource.
        :param WorkflowArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(WorkflowArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 access_rules: Optional[pulumi.Input[str]] = None,
                 auto_grant: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 weight: Optional[pulumi.Input[int]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = WorkflowArgs.__new__(WorkflowArgs)

            __props__.__dict__["access_rules"] = access_rules
            __props__.__dict__["auto_grant"] = auto_grant
            __props__.__dict__["description"] = description
            __props__.__dict__["enabled"] = enabled
            __props__.__dict__["name"] = name
            __props__.__dict__["weight"] = weight
        super(Workflow, __self__).__init__(
            'sdm:index/workflow:Workflow',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            access_rules: Optional[pulumi.Input[str]] = None,
            auto_grant: Optional[pulumi.Input[bool]] = None,
            description: Optional[pulumi.Input[str]] = None,
            enabled: Optional[pulumi.Input[bool]] = None,
            name: Optional[pulumi.Input[str]] = None,
            weight: Optional[pulumi.Input[int]] = None) -> 'Workflow':
        """
        Get an existing Workflow resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] access_rules: AccessRules is a list of access rules defining the resources this Workflow provides access to.
        :param pulumi.Input[bool] auto_grant: Optional auto grant setting to automatically approve requests or not, defaults to false.
        :param pulumi.Input[str] description: Optional description of the Workflow.
        :param pulumi.Input[bool] enabled: Optional enabled state for workflow. This setting may be overridden by the system if the workflow doesn't meet the requirements to be enabled or if other conditions prevent enabling the workflow. The requirements to enable a workflow are that the workflow must be either set up for with auto grant enabled or have one or more WorkflowApprovers created for the workflow.
        :param pulumi.Input[str] name: Unique human-readable name of the Workflow.
        :param pulumi.Input[int] weight: Optional weight for workflow to specify it's priority in matching a request.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _WorkflowState.__new__(_WorkflowState)

        __props__.__dict__["access_rules"] = access_rules
        __props__.__dict__["auto_grant"] = auto_grant
        __props__.__dict__["description"] = description
        __props__.__dict__["enabled"] = enabled
        __props__.__dict__["name"] = name
        __props__.__dict__["weight"] = weight
        return Workflow(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="accessRules")
    def access_rules(self) -> pulumi.Output[str]:
        """
        AccessRules is a list of access rules defining the resources this Workflow provides access to.
        """
        return pulumi.get(self, "access_rules")

    @property
    @pulumi.getter(name="autoGrant")
    def auto_grant(self) -> pulumi.Output[Optional[bool]]:
        """
        Optional auto grant setting to automatically approve requests or not, defaults to false.
        """
        return pulumi.get(self, "auto_grant")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        Optional description of the Workflow.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def enabled(self) -> pulumi.Output[Optional[bool]]:
        """
        Optional enabled state for workflow. This setting may be overridden by the system if the workflow doesn't meet the requirements to be enabled or if other conditions prevent enabling the workflow. The requirements to enable a workflow are that the workflow must be either set up for with auto grant enabled or have one or more WorkflowApprovers created for the workflow.
        """
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Unique human-readable name of the Workflow.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def weight(self) -> pulumi.Output[int]:
        """
        Optional weight for workflow to specify it's priority in matching a request.
        """
        return pulumi.get(self, "weight")

