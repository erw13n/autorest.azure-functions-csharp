// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class MagnitudeScoringParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("boostingRangeStart");
            writer.WriteNumberValue(BoostingRangeStart);
            writer.WritePropertyName("boostingRangeEnd");
            writer.WriteNumberValue(BoostingRangeEnd);
            if (ShouldBoostBeyondRangeByConstant != null)
            {
                writer.WritePropertyName("constantBoostBeyondRange");
                writer.WriteBooleanValue(ShouldBoostBeyondRangeByConstant.Value);
            }
            writer.WriteEndObject();
        }
        internal static MagnitudeScoringParameters DeserializeMagnitudeScoringParameters(JsonElement element)
        {
            MagnitudeScoringParameters result = new MagnitudeScoringParameters();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("boostingRangeStart"))
                {
                    result.BoostingRangeStart = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("boostingRangeEnd"))
                {
                    result.BoostingRangeEnd = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("constantBoostBeyondRange"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ShouldBoostBeyondRangeByConstant = property.Value.GetBoolean();
                    continue;
                }
            }
            return result;
        }
    }
}