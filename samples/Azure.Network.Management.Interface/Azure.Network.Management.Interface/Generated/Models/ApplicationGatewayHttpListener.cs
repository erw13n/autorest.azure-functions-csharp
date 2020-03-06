// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> Http listener of an application gateway. </summary>
    public partial class ApplicationGatewayHttpListener : SubResource
    {
        /// <summary> Name of the HTTP listener that is unique within an Application Gateway. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; internal set; }
        /// <summary> Type of the resource. </summary>
        public string Type { get; internal set; }
        /// <summary> Frontend IP configuration resource of an application gateway. </summary>
        public SubResource FrontendIPConfiguration { get; set; }
        /// <summary> Frontend port resource of an application gateway. </summary>
        public SubResource FrontendPort { get; set; }
        /// <summary> Protocol of the HTTP listener. </summary>
        public ApplicationGatewayProtocol? Protocol { get; set; }
        /// <summary> Host name of HTTP listener. </summary>
        public string HostName { get; set; }
        /// <summary> SSL certificate resource of an application gateway. </summary>
        public SubResource SslCertificate { get; set; }
        /// <summary> Applicable only if protocol is https. Enables SNI for multi-hosting. </summary>
        public bool? RequireServerNameIndication { get; set; }
        /// <summary> The provisioning state of the HTTP listener resource. </summary>
        public ProvisioningState? ProvisioningState { get; internal set; }
        /// <summary> Custom error configurations of the HTTP listener. </summary>
        public ICollection<ApplicationGatewayCustomError> CustomErrorConfigurations { get; set; }
        /// <summary> Reference to the FirewallPolicy resource. </summary>
        public SubResource FirewallPolicy { get; set; }
        /// <summary> List of Host names for HTTP Listener that allows special wildcard characters as well. </summary>
        public ICollection<string> Hostnames { get; set; }
    }
}
