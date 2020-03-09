// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class EffectiveNetworkSecurityGroupAssociation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Subnet != null)
            {
                writer.WritePropertyName("subnet");
                writer.WriteObjectValue(Subnet);
            }
            if (NetworkInterface != null)
            {
                writer.WritePropertyName("networkInterface");
                writer.WriteObjectValue(NetworkInterface);
            }
            writer.WriteEndObject();
        }
        internal static EffectiveNetworkSecurityGroupAssociation DeserializeEffectiveNetworkSecurityGroupAssociation(JsonElement element)
        {
            EffectiveNetworkSecurityGroupAssociation result = new EffectiveNetworkSecurityGroupAssociation();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subnet"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Subnet = SubResource.DeserializeSubResource(property.Value);
                    continue;
                }
                if (property.NameEquals("networkInterface"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.NetworkInterface = SubResource.DeserializeSubResource(property.Value);
                    continue;
                }
            }
            return result;
        }
    }
}
