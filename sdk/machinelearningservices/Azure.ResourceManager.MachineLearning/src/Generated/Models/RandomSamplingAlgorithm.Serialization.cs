// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class RandomSamplingAlgorithm : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Logbase))
            {
                if (Logbase != null)
                {
                    writer.WritePropertyName("logbase"u8);
                    writer.WriteStringValue(Logbase);
                }
                else
                {
                    writer.WriteNull("logbase");
                }
            }
            if (Optional.IsDefined(Rule))
            {
                writer.WritePropertyName("rule"u8);
                writer.WriteStringValue(Rule.Value.ToString());
            }
            if (Optional.IsDefined(Seed))
            {
                if (Seed != null)
                {
                    writer.WritePropertyName("seed"u8);
                    writer.WriteNumberValue(Seed.Value);
                }
                else
                {
                    writer.WriteNull("seed");
                }
            }
            writer.WritePropertyName("samplingAlgorithmType"u8);
            writer.WriteStringValue(SamplingAlgorithmType.ToString());
            writer.WriteEndObject();
        }

        internal static RandomSamplingAlgorithm DeserializeRandomSamplingAlgorithm(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> logbase = default;
            Optional<RandomSamplingAlgorithmRule> rule = default;
            Optional<int?> seed = default;
            SamplingAlgorithmType samplingAlgorithmType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("logbase"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        logbase = null;
                        continue;
                    }
                    logbase = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rule = new RandomSamplingAlgorithmRule(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("seed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        seed = null;
                        continue;
                    }
                    seed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("samplingAlgorithmType"u8))
                {
                    samplingAlgorithmType = new SamplingAlgorithmType(property.Value.GetString());
                    continue;
                }
            }
            return new RandomSamplingAlgorithm(samplingAlgorithmType, logbase.Value, Optional.ToNullable(rule), Optional.ToNullable(seed));
        }
    }
}
