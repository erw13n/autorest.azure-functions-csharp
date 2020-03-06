// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class NetworkInterfacePropertiesFormat : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (VirtualMachine != null)
            {
                writer.WritePropertyName("virtualMachine");
                writer.WriteObjectValue(VirtualMachine);
            }
            if (NetworkSecurityGroup != null)
            {
                writer.WritePropertyName("networkSecurityGroup");
                writer.WriteObjectValue(NetworkSecurityGroup);
            }
            if (PrivateEndpoint != null)
            {
                writer.WritePropertyName("privateEndpoint");
                writer.WriteObjectValue(PrivateEndpoint);
            }
            if (IpConfigurations != null)
            {
                writer.WritePropertyName("ipConfigurations");
                writer.WriteStartArray();
                foreach (var item in IpConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (TapConfigurations != null)
            {
                writer.WritePropertyName("tapConfigurations");
                writer.WriteStartArray();
                foreach (var item in TapConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (DnsSettings != null)
            {
                writer.WritePropertyName("dnsSettings");
                writer.WriteObjectValue(DnsSettings);
            }
            if (MacAddress != null)
            {
                writer.WritePropertyName("macAddress");
                writer.WriteStringValue(MacAddress);
            }
            if (Primary != null)
            {
                writer.WritePropertyName("primary");
                writer.WriteBooleanValue(Primary.Value);
            }
            if (EnableAcceleratedNetworking != null)
            {
                writer.WritePropertyName("enableAcceleratedNetworking");
                writer.WriteBooleanValue(EnableAcceleratedNetworking.Value);
            }
            if (EnableIPForwarding != null)
            {
                writer.WritePropertyName("enableIPForwarding");
                writer.WriteBooleanValue(EnableIPForwarding.Value);
            }
            if (HostedWorkloads != null)
            {
                writer.WritePropertyName("hostedWorkloads");
                writer.WriteStartArray();
                foreach (var item in HostedWorkloads)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (ResourceGuid != null)
            {
                writer.WritePropertyName("resourceGuid");
                writer.WriteStringValue(ResourceGuid);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
        }
        internal static NetworkInterfacePropertiesFormat DeserializeNetworkInterfacePropertiesFormat(JsonElement element)
        {
            NetworkInterfacePropertiesFormat result = new NetworkInterfacePropertiesFormat();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualMachine"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.VirtualMachine = SubResource.DeserializeSubResource(property.Value);
                    continue;
                }
                if (property.NameEquals("networkSecurityGroup"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.NetworkSecurityGroup = NetworkSecurityGroup.DeserializeNetworkSecurityGroup(property.Value);
                    continue;
                }
                if (property.NameEquals("privateEndpoint"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.PrivateEndpoint = PrivateEndpoint.DeserializePrivateEndpoint(property.Value);
                    continue;
                }
                if (property.NameEquals("ipConfigurations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.IpConfigurations = new List<NetworkInterfaceIPConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.IpConfigurations.Add(NetworkInterfaceIPConfiguration.DeserializeNetworkInterfaceIPConfiguration(item));
                    }
                    continue;
                }
                if (property.NameEquals("tapConfigurations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.TapConfigurations = new List<NetworkInterfaceTapConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.TapConfigurations.Add(NetworkInterfaceTapConfiguration.DeserializeNetworkInterfaceTapConfiguration(item));
                    }
                    continue;
                }
                if (property.NameEquals("dnsSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.DnsSettings = NetworkInterfaceDnsSettings.DeserializeNetworkInterfaceDnsSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("macAddress"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.MacAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primary"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Primary = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableAcceleratedNetworking"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.EnableAcceleratedNetworking = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableIPForwarding"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.EnableIPForwarding = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("hostedWorkloads"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.HostedWorkloads = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.HostedWorkloads.Add(item.GetString());
                    }
                    continue;
                }
                if (property.NameEquals("resourceGuid"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ResourceGuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ProvisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
            }
            return result;
        }
    }
}
