// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class ApplicationGatewayTrustedRootCertificatePropertiesFormat : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Data != null)
            {
                writer.WritePropertyName("data");
                writer.WriteStringValue(Data);
            }
            if (KeyVaultSecretId != null)
            {
                writer.WritePropertyName("keyVaultSecretId");
                writer.WriteStringValue(KeyVaultSecretId);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
        }
        internal static ApplicationGatewayTrustedRootCertificatePropertiesFormat DeserializeApplicationGatewayTrustedRootCertificatePropertiesFormat(JsonElement element)
        {
            ApplicationGatewayTrustedRootCertificatePropertiesFormat result = new ApplicationGatewayTrustedRootCertificatePropertiesFormat();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("data"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Data = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultSecretId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.KeyVaultSecretId = property.Value.GetString();
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
