// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class ServiceAssociationLinkPropertiesFormat : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (LinkedResourceType != null)
            {
                writer.WritePropertyName("linkedResourceType");
                writer.WriteStringValue(LinkedResourceType);
            }
            if (Link != null)
            {
                writer.WritePropertyName("link");
                writer.WriteStringValue(Link);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (AllowDelete != null)
            {
                writer.WritePropertyName("allowDelete");
                writer.WriteBooleanValue(AllowDelete.Value);
            }
            if (Locations != null)
            {
                writer.WritePropertyName("locations");
                writer.WriteStartArray();
                foreach (var item in Locations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
        internal static ServiceAssociationLinkPropertiesFormat DeserializeServiceAssociationLinkPropertiesFormat(JsonElement element)
        {
            ServiceAssociationLinkPropertiesFormat result = new ServiceAssociationLinkPropertiesFormat();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedResourceType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.LinkedResourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("link"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Link = property.Value.GetString();
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
                if (property.NameEquals("allowDelete"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.AllowDelete = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("locations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Locations = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Locations.Add(item.GetString());
                    }
                    continue;
                }
            }
            return result;
        }
    }
}
