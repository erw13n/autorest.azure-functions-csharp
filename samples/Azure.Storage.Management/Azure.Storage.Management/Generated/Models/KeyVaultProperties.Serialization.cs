// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Management.Models
{
    public partial class KeyVaultProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (KeyName != null)
            {
                writer.WritePropertyName("keyname");
                writer.WriteStringValue(KeyName);
            }
            if (KeyVersion != null)
            {
                writer.WritePropertyName("keyversion");
                writer.WriteStringValue(KeyVersion);
            }
            if (KeyVaultUri != null)
            {
                writer.WritePropertyName("keyvaulturi");
                writer.WriteStringValue(KeyVaultUri);
            }
            writer.WriteEndObject();
        }
        internal static KeyVaultProperties DeserializeKeyVaultProperties(JsonElement element)
        {
            KeyVaultProperties result = new KeyVaultProperties();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyname"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.KeyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyversion"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.KeyVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyvaulturi"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.KeyVaultUri = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
