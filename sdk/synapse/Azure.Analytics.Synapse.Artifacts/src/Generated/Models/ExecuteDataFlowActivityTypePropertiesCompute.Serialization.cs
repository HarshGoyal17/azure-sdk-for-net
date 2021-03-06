// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class ExecuteDataFlowActivityTypePropertiesCompute : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (ComputeType != null)
            {
                writer.WritePropertyName("computeType");
                writer.WriteStringValue(ComputeType.Value.ToString());
            }
            if (CoreCount != null)
            {
                writer.WritePropertyName("coreCount");
                writer.WriteNumberValue(CoreCount.Value);
            }
            writer.WriteEndObject();
        }

        internal static ExecuteDataFlowActivityTypePropertiesCompute DeserializeExecuteDataFlowActivityTypePropertiesCompute(JsonElement element)
        {
            DataFlowComputeType? computeType = default;
            int? coreCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("computeType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    computeType = new DataFlowComputeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("coreCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    coreCount = property.Value.GetInt32();
                    continue;
                }
            }
            return new ExecuteDataFlowActivityTypePropertiesCompute(computeType, coreCount);
        }
    }
}
