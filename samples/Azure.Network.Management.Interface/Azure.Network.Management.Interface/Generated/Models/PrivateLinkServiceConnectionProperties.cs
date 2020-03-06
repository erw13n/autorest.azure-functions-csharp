// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> Properties of the PrivateLinkServiceConnection. </summary>
    public partial class PrivateLinkServiceConnectionProperties
    {
        /// <summary> The provisioning state of the private link service connection resource. </summary>
        public ProvisioningState? ProvisioningState { get; internal set; }
        /// <summary> The resource id of private link service. </summary>
        public string PrivateLinkServiceId { get; set; }
        /// <summary> The ID(s) of the group(s) obtained from the remote resource that this private endpoint should connect to. </summary>
        public ICollection<string> GroupIds { get; set; }
        /// <summary> A message passed to the owner of the remote resource with this connection request. Restricted to 140 chars. </summary>
        public string RequestMessage { get; set; }
        /// <summary> A collection of read-only information about the state of the connection to the remote resource. </summary>
        public PrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get; set; }
    }
}
