// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Request to validate preference of transport and data center. </summary>
    public partial class PreferencesValidationContent : DataBoxValidationInputContent
    {
        /// <summary> Initializes a new instance of PreferencesValidationContent. </summary>
        /// <param name="deviceType"> Device type to be used for the job. </param>
        public PreferencesValidationContent(DataBoxSkuName deviceType)
        {
            DeviceType = deviceType;
            ValidationType = DataBoxValidationInputDiscriminator.ValidatePreferences;
        }

        /// <summary> Preference of transport and data center. </summary>
        public DataBoxOrderPreferences Preference { get; set; }
        /// <summary> Device type to be used for the job. </summary>
        public DataBoxSkuName DeviceType { get; }
    }
}
