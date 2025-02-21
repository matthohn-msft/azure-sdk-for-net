// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.BillingBenefits.Models
{
    /// <summary> Savings plan patch request. </summary>
    public partial class BillingBenefitsSavingsPlanPatchProperties
    {
        /// <summary> Initializes a new instance of BillingBenefitsSavingsPlanPatchProperties. </summary>
        public BillingBenefitsSavingsPlanPatchProperties()
        {
        }

        /// <summary> Display name. </summary>
        public string DisplayName { get; set; }
        /// <summary> Type of the Applied Scope. </summary>
        public BillingBenefitsAppliedScopeType? AppliedScopeType { get; set; }
        /// <summary> Properties specific to applied scope type. Not required if not applicable. </summary>
        public BillingBenefitsAppliedScopeProperties AppliedScopeProperties { get; set; }
        /// <summary> Setting this to true will automatically purchase a new benefit on the expiration date time. </summary>
        public bool? IsRenewed { get; set; }
        /// <summary> Gets or sets the renew properties. </summary>
        internal RenewProperties RenewProperties { get; set; }
        /// <summary> Gets or sets the renew purchase properties. </summary>
        public BillingBenefitsPurchaseContent RenewPurchaseProperties
        {
            get => RenewProperties is null ? default : RenewProperties.PurchaseProperties;
            set
            {
                if (RenewProperties is null)
                    RenewProperties = new RenewProperties();
                RenewProperties.PurchaseProperties = value;
            }
        }
    }
}
