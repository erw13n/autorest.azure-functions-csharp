// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class Probe : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Etag != null)
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (LoadBalancingRules != null)
            {
                writer.WritePropertyName("loadBalancingRules");
                writer.WriteStartArray();
                foreach (var item in LoadBalancingRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Protocol != null)
            {
                writer.WritePropertyName("protocol");
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Port != null)
            {
                writer.WritePropertyName("port");
                writer.WriteNumberValue(Port.Value);
            }
            if (IntervalInSeconds != null)
            {
                writer.WritePropertyName("intervalInSeconds");
                writer.WriteNumberValue(IntervalInSeconds.Value);
            }
            if (NumberOfProbes != null)
            {
                writer.WritePropertyName("numberOfProbes");
                writer.WriteNumberValue(NumberOfProbes.Value);
            }
            if (RequestPath != null)
            {
                writer.WritePropertyName("requestPath");
                writer.WriteStringValue(RequestPath);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static Probe DeserializeProbe(JsonElement element)
        {
            string name = default;
            string etag = default;
            string type = default;
            string id = default;
            IList<SubResource> loadBalancingRules = default;
            ProbeProtocol? protocol = default;
            int? port = default;
            int? intervalInSeconds = default;
            int? numberOfProbes = default;
            string requestPath = default;
            ProvisioningState? provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("loadBalancingRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeserializeSubResource(item));
                            }
                            loadBalancingRules = array;
                            continue;
                        }
                        if (property0.NameEquals("protocol"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            protocol = new ProbeProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("port"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            port = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("intervalInSeconds"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            intervalInSeconds = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("numberOfProbes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfProbes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("requestPath"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            requestPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new Probe(id, name, etag, type, loadBalancingRules, protocol, port, intervalInSeconds, numberOfProbes, requestPath, provisioningState);
        }
    }
}
