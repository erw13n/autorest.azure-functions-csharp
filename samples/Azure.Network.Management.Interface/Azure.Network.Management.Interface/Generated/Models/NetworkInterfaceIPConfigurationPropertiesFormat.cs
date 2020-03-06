// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> Properties of IP configuration. </summary>
    public partial class NetworkInterfaceIPConfigurationPropertiesFormat
    {
        /// <summary> The reference to Virtual Network Taps. </summary>
        public ICollection<VirtualNetworkTap> VirtualNetworkTaps { get; set; }
        /// <summary> The reference to ApplicationGatewayBackendAddressPool resource. </summary>
        public ICollection<ApplicationGatewayBackendAddressPool> ApplicationGatewayBackendAddressPools { get; set; }
        /// <summary> The reference to LoadBalancerBackendAddressPool resource. </summary>
        public ICollection<BackendAddressPool> LoadBalancerBackendAddressPools { get; set; }
        /// <summary> A list of references of LoadBalancerInboundNatRules. </summary>
        public ICollection<InboundNatRule> LoadBalancerInboundNatRules { get; set; }
        /// <summary> Private IP address of the IP configuration. </summary>
        public string PrivateIPAddress { get; set; }
        /// <summary> The private IP address allocation method. </summary>
        public IPAllocationMethod? PrivateIPAllocationMethod { get; set; }
        /// <summary> Whether the specific IP configuration is IPv4 or IPv6. Default is IPv4. </summary>
        public IPVersion? PrivateIPAddressVersion { get; set; }
        /// <summary> Subnet bound to the IP configuration. </summary>
        public Subnet Subnet { get; set; }
        /// <summary> Whether this is a primary customer address on the network interface. </summary>
        public bool? Primary { get; set; }
        /// <summary> Public IP address bound to the IP configuration. </summary>
        public PublicIPAddress PublicIPAddress { get; set; }
        /// <summary> Application security groups in which the IP configuration is included. </summary>
        public ICollection<ApplicationSecurityGroup> ApplicationSecurityGroups { get; set; }
        /// <summary> The provisioning state of the network interface IP configuration. </summary>
        public ProvisioningState? ProvisioningState { get; internal set; }
        /// <summary> PrivateLinkConnection properties for the network interface. </summary>
        public NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties PrivateLinkConnectionProperties { get; internal set; }
    }
}
