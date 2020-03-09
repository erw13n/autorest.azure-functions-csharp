// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class PrivateLinkServiceIpConfigurationProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (PrivateIPAddress != null)
            {
                writer.WritePropertyName("privateIPAddress");
                writer.WriteStringValue(PrivateIPAddress);
            }
            if (PrivateIPAllocationMethod != null)
            {
                writer.WritePropertyName("privateIPAllocationMethod");
                writer.WriteStringValue(PrivateIPAllocationMethod.Value.ToString());
            }
            if (Subnet != null)
            {
                writer.WritePropertyName("subnet");
                writer.WriteObjectValue(Subnet);
            }
            if (Primary != null)
            {
                writer.WritePropertyName("primary");
                writer.WriteBooleanValue(Primary.Value);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (PrivateIPAddressVersion != null)
            {
                writer.WritePropertyName("privateIPAddressVersion");
                writer.WriteStringValue(PrivateIPAddressVersion.Value.ToString());
            }
            writer.WriteEndObject();
        }
        internal static PrivateLinkServiceIpConfigurationProperties DeserializePrivateLinkServiceIpConfigurationProperties(JsonElement element)
        {
            PrivateLinkServiceIpConfigurationProperties result = new PrivateLinkServiceIpConfigurationProperties();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateIPAddress"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.PrivateIPAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateIPAllocationMethod"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.PrivateIPAllocationMethod = new IPAllocationMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subnet"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Subnet = Subnet.DeserializeSubnet(property.Value);
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
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ProvisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("privateIPAddressVersion"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.PrivateIPAddressVersion = new IPVersion(property.Value.GetString());
                    continue;
                }
            }
            return result;
        }
    }
}
