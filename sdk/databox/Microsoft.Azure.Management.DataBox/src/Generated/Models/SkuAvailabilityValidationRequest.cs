// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Request to validate sku availability.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ValidateSkuAvailability")]
    public partial class SkuAvailabilityValidationRequest : ValidationInputRequest
    {
        /// <summary>
        /// Initializes a new instance of the SkuAvailabilityValidationRequest
        /// class.
        /// </summary>
        public SkuAvailabilityValidationRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SkuAvailabilityValidationRequest
        /// class.
        /// </summary>
        /// <param name="deviceType">Device type to be used for the job.
        /// Possible values include: 'DataBox', 'DataBoxDisk',
        /// 'DataBoxHeavy'</param>
        /// <param name="country">ISO country code. Country for hardware
        /// shipment. For codes check:
        /// https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2#Officially_assigned_code_elements</param>
        /// <param name="location">Location for data transfer. For locations
        /// check:
        /// https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01</param>
        public SkuAvailabilityValidationRequest(SkuName deviceType, string country, string location)
        {
            DeviceType = deviceType;
            Country = country;
            Location = location;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for SkuAvailabilityValidationRequest class.
        /// </summary>
        static SkuAvailabilityValidationRequest()
        {
            TransferType = "ImportToAzure";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets device type to be used for the job. Possible values
        /// include: 'DataBox', 'DataBoxDisk', 'DataBoxHeavy'
        /// </summary>
        [JsonProperty(PropertyName = "deviceType")]
        public SkuName DeviceType { get; set; }

        /// <summary>
        /// Gets or sets ISO country code. Country for hardware shipment. For
        /// codes check:
        /// https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2#Officially_assigned_code_elements
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets location for data transfer. For locations check:
        /// https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Type of the transfer.
        /// </summary>
        [JsonProperty(PropertyName = "transferType")]
        public static string TransferType { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Country == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Country");
            }
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
        }
    }
}
