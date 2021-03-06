// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineScaleSetVMProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (OsProfile != null)
            {
                writer.WritePropertyName("osProfile");
                writer.WriteObjectValue(OsProfile);
            }
            if (StorageProfile != null)
            {
                writer.WritePropertyName("storageProfile");
                writer.WriteObjectValue(StorageProfile);
            }
            if (NetworkProfile != null)
            {
                writer.WritePropertyName("networkProfile");
                writer.WriteObjectValue(NetworkProfile);
            }
            if (DiagnosticsProfile != null)
            {
                writer.WritePropertyName("diagnosticsProfile");
                writer.WriteObjectValue(DiagnosticsProfile);
            }
            if (ExtensionProfile != null)
            {
                writer.WritePropertyName("extensionProfile");
                writer.WriteObjectValue(ExtensionProfile);
            }
            if (LicenseType != null)
            {
                writer.WritePropertyName("licenseType");
                writer.WriteStringValue(LicenseType);
            }
            if (Priority != null)
            {
                writer.WritePropertyName("priority");
                writer.WriteStringValue(Priority.Value.ToString());
            }
            if (EvictionPolicy != null)
            {
                writer.WritePropertyName("evictionPolicy");
                writer.WriteStringValue(EvictionPolicy.Value.ToString());
            }
            if (BillingProfile != null)
            {
                writer.WritePropertyName("billingProfile");
                writer.WriteObjectValue(BillingProfile);
            }
            if (ScheduledEventsProfile != null)
            {
                writer.WritePropertyName("scheduledEventsProfile");
                writer.WriteObjectValue(ScheduledEventsProfile);
            }
            writer.WriteEndObject();
        }

        internal static VirtualMachineScaleSetVMProfile DeserializeVirtualMachineScaleSetVMProfile(JsonElement element)
        {
            VirtualMachineScaleSetOSProfile osProfile = default;
            VirtualMachineScaleSetStorageProfile storageProfile = default;
            VirtualMachineScaleSetNetworkProfile networkProfile = default;
            DiagnosticsProfile diagnosticsProfile = default;
            VirtualMachineScaleSetExtensionProfile extensionProfile = default;
            string licenseType = default;
            VirtualMachinePriorityTypes? priority = default;
            VirtualMachineEvictionPolicyTypes? evictionPolicy = default;
            BillingProfile billingProfile = default;
            ScheduledEventsProfile scheduledEventsProfile = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("osProfile"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osProfile = VirtualMachineScaleSetOSProfile.DeserializeVirtualMachineScaleSetOSProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("storageProfile"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageProfile = VirtualMachineScaleSetStorageProfile.DeserializeVirtualMachineScaleSetStorageProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("networkProfile"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkProfile = VirtualMachineScaleSetNetworkProfile.DeserializeVirtualMachineScaleSetNetworkProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("diagnosticsProfile"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diagnosticsProfile = DiagnosticsProfile.DeserializeDiagnosticsProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("extensionProfile"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extensionProfile = VirtualMachineScaleSetExtensionProfile.DeserializeVirtualMachineScaleSetExtensionProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("licenseType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    licenseType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("priority"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    priority = new VirtualMachinePriorityTypes(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("evictionPolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    evictionPolicy = new VirtualMachineEvictionPolicyTypes(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("billingProfile"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingProfile = BillingProfile.DeserializeBillingProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("scheduledEventsProfile"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduledEventsProfile = ScheduledEventsProfile.DeserializeScheduledEventsProfile(property.Value);
                    continue;
                }
            }
            return new VirtualMachineScaleSetVMProfile(osProfile, storageProfile, networkProfile, diagnosticsProfile, extensionProfile, licenseType, priority, evictionPolicy, billingProfile, scheduledEventsProfile);
        }
    }
}
