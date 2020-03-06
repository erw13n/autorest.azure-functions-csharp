// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> Application security group properties. </summary>
    public partial class ApplicationSecurityGroupPropertiesFormat
    {
        /// <summary> The resource GUID property of the application security group resource. It uniquely identifies a resource, even if the user changes its name or migrate the resource across subscriptions or resource groups. </summary>
        public string ResourceGuid { get; internal set; }
        /// <summary> The provisioning state of the application security group resource. </summary>
        public ProvisioningState? ProvisioningState { get; internal set; }
    }
}
