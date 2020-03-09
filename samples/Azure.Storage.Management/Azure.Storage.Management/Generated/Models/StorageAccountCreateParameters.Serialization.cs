// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Management.Models
{
    public partial class StorageAccountCreateParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sku");
            writer.WriteObjectValue(Sku);
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            if (Tags != null)
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Identity != null)
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (CustomDomain != null)
            {
                writer.WritePropertyName("customDomain");
                writer.WriteObjectValue(CustomDomain);
            }
            if (Encryption != null)
            {
                writer.WritePropertyName("encryption");
                writer.WriteObjectValue(Encryption);
            }
            if (NetworkRuleSet != null)
            {
                writer.WritePropertyName("networkAcls");
                writer.WriteObjectValue(NetworkRuleSet);
            }
            if (AccessTier != null)
            {
                writer.WritePropertyName("accessTier");
                writer.WriteStringValue(AccessTier.Value.ToSerialString());
            }
            if (AzureFilesIdentityBasedAuthentication != null)
            {
                writer.WritePropertyName("azureFilesIdentityBasedAuthentication");
                writer.WriteObjectValue(AzureFilesIdentityBasedAuthentication);
            }
            if (EnableHttpsTrafficOnly != null)
            {
                writer.WritePropertyName("supportsHttpsTrafficOnly");
                writer.WriteBooleanValue(EnableHttpsTrafficOnly.Value);
            }
            if (IsHnsEnabled != null)
            {
                writer.WritePropertyName("isHnsEnabled");
                writer.WriteBooleanValue(IsHnsEnabled.Value);
            }
            if (LargeFileSharesState != null)
            {
                writer.WritePropertyName("largeFileSharesState");
                writer.WriteStringValue(LargeFileSharesState.Value.ToString());
            }
            if (RoutingPreference != null)
            {
                writer.WritePropertyName("routingPreference");
                writer.WriteObjectValue(RoutingPreference);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
        internal static StorageAccountCreateParameters DeserializeStorageAccountCreateParameters(JsonElement element)
        {
            StorageAccountCreateParameters result = new StorageAccountCreateParameters();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    result.Sku = Sku.DeserializeSku(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    result.Kind = new Kind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    result.Location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Tags = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        result.Tags.Add(property0.Name, property0.Value.GetString());
                    }
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Identity = Identity.DeserializeIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("customDomain"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.CustomDomain = CustomDomain.DeserializeCustomDomain(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("encryption"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.Encryption = Encryption.DeserializeEncryption(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("networkAcls"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.NetworkRuleSet = NetworkRuleSet.DeserializeNetworkRuleSet(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("accessTier"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.AccessTier = property0.Value.GetString().ToAccessTier();
                            continue;
                        }
                        if (property0.NameEquals("azureFilesIdentityBasedAuthentication"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.AzureFilesIdentityBasedAuthentication = AzureFilesIdentityBasedAuthentication.DeserializeAzureFilesIdentityBasedAuthentication(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("supportsHttpsTrafficOnly"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.EnableHttpsTrafficOnly = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isHnsEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.IsHnsEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("largeFileSharesState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.LargeFileSharesState = new LargeFileSharesState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("routingPreference"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.RoutingPreference = RoutingPreference.DeserializeRoutingPreference(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return result;
        }
    }
}
