// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class ApplicationGatewayBackendAddress : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Fqdn != null)
            {
                writer.WritePropertyName("fqdn");
                writer.WriteStringValue(Fqdn);
            }
            if (IpAddress != null)
            {
                writer.WritePropertyName("ipAddress");
                writer.WriteStringValue(IpAddress);
            }
            writer.WriteEndObject();
        }
        internal static ApplicationGatewayBackendAddress DeserializeApplicationGatewayBackendAddress(JsonElement element)
        {
            ApplicationGatewayBackendAddress result = new ApplicationGatewayBackendAddress();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fqdn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Fqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipAddress"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.IpAddress = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
