// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> Response for list ip configurations API service call. </summary>
    public partial class NetworkInterfaceIPConfigurationListResult
    {
        /// <summary> A list of ip configurations. </summary>
        public IList<NetworkInterfaceIPConfiguration> Value { get; set; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; internal set; }
    }
}
