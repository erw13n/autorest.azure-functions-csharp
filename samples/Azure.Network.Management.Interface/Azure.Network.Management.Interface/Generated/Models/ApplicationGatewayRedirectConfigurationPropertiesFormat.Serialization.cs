// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class ApplicationGatewayRedirectConfigurationPropertiesFormat : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (RedirectType != null)
            {
                writer.WritePropertyName("redirectType");
                writer.WriteStringValue(RedirectType.Value.ToString());
            }
            if (TargetListener != null)
            {
                writer.WritePropertyName("targetListener");
                writer.WriteObjectValue(TargetListener);
            }
            if (TargetUrl != null)
            {
                writer.WritePropertyName("targetUrl");
                writer.WriteStringValue(TargetUrl);
            }
            if (IncludePath != null)
            {
                writer.WritePropertyName("includePath");
                writer.WriteBooleanValue(IncludePath.Value);
            }
            if (IncludeQueryString != null)
            {
                writer.WritePropertyName("includeQueryString");
                writer.WriteBooleanValue(IncludeQueryString.Value);
            }
            if (RequestRoutingRules != null)
            {
                writer.WritePropertyName("requestRoutingRules");
                writer.WriteStartArray();
                foreach (var item in RequestRoutingRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (UrlPathMaps != null)
            {
                writer.WritePropertyName("urlPathMaps");
                writer.WriteStartArray();
                foreach (var item in UrlPathMaps)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (PathRules != null)
            {
                writer.WritePropertyName("pathRules");
                writer.WriteStartArray();
                foreach (var item in PathRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
        internal static ApplicationGatewayRedirectConfigurationPropertiesFormat DeserializeApplicationGatewayRedirectConfigurationPropertiesFormat(JsonElement element)
        {
            ApplicationGatewayRedirectConfigurationPropertiesFormat result = new ApplicationGatewayRedirectConfigurationPropertiesFormat();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("redirectType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.RedirectType = new ApplicationGatewayRedirectType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetListener"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.TargetListener = SubResource.DeserializeSubResource(property.Value);
                    continue;
                }
                if (property.NameEquals("targetUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.TargetUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("includePath"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.IncludePath = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("includeQueryString"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.IncludeQueryString = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("requestRoutingRules"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.RequestRoutingRules = new List<SubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.RequestRoutingRules.Add(SubResource.DeserializeSubResource(item));
                    }
                    continue;
                }
                if (property.NameEquals("urlPathMaps"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.UrlPathMaps = new List<SubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.UrlPathMaps.Add(SubResource.DeserializeSubResource(item));
                    }
                    continue;
                }
                if (property.NameEquals("pathRules"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.PathRules = new List<SubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.PathRules.Add(SubResource.DeserializeSubResource(item));
                    }
                    continue;
                }
            }
            return result;
        }
    }
}
