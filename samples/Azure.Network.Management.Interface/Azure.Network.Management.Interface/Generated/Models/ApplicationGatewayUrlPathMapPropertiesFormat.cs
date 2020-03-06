// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> Properties of UrlPathMap of the application gateway. </summary>
    public partial class ApplicationGatewayUrlPathMapPropertiesFormat
    {
        /// <summary> Default backend address pool resource of URL path map. </summary>
        public SubResource DefaultBackendAddressPool { get; set; }
        /// <summary> Default backend http settings resource of URL path map. </summary>
        public SubResource DefaultBackendHttpSettings { get; set; }
        /// <summary> Default Rewrite rule set resource of URL path map. </summary>
        public SubResource DefaultRewriteRuleSet { get; set; }
        /// <summary> Default redirect configuration resource of URL path map. </summary>
        public SubResource DefaultRedirectConfiguration { get; set; }
        /// <summary> Path rule of URL path map resource. </summary>
        public ICollection<ApplicationGatewayPathRule> PathRules { get; set; }
        /// <summary> The provisioning state of the URL path map resource. </summary>
        public ProvisioningState? ProvisioningState { get; internal set; }
    }
}
