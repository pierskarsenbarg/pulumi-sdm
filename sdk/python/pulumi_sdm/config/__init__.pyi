# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

apiAccessKey: Optional[str]
"""
A GUID identifying the API key used to authenticate with the StrongDM API.
"""

apiSecretKey: Optional[str]
"""
A base64 encoded secret key used to authenticate with the StrongDM API.
"""

host: Optional[str]
"""
The host and port of the StrongDM API endpoint.
"""

retryRateLimitErrors: Optional[bool]
"""
Whether experienced rate limits should cause the client to sleep instead of erroring out
"""

