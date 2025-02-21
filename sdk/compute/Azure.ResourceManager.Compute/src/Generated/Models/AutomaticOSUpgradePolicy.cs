// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The configuration parameters used for performing automatic OS upgrade. </summary>
    public partial class AutomaticOSUpgradePolicy
    {
        /// <summary> Initializes a new instance of AutomaticOSUpgradePolicy. </summary>
        public AutomaticOSUpgradePolicy()
        {
        }

        /// <summary> Initializes a new instance of AutomaticOSUpgradePolicy. </summary>
        /// <param name="enableAutomaticOSUpgrade"> Indicates whether OS upgrades should automatically be applied to scale set instances in a rolling fashion when a newer version of the OS image becomes available. Default value is false. If this is set to true for Windows based scale sets, [enableAutomaticUpdates](https://docs.microsoft.com/dotnet/api/microsoft.azure.management.compute.models.windowsconfiguration.enableautomaticupdates?view=azure-dotnet) is automatically set to false and cannot be set to true. </param>
        /// <param name="disableAutomaticRollback"> Whether OS image rollback feature should be disabled. Default value is false. </param>
        /// <param name="useRollingUpgradePolicy"> Indicates whether rolling upgrade policy should be used during Auto OS Upgrade. Default value is false. Auto OS Upgrade will fallback to the default policy if no policy is defined on the VMSS. </param>
        internal AutomaticOSUpgradePolicy(bool? enableAutomaticOSUpgrade, bool? disableAutomaticRollback, bool? useRollingUpgradePolicy)
        {
            EnableAutomaticOSUpgrade = enableAutomaticOSUpgrade;
            DisableAutomaticRollback = disableAutomaticRollback;
            UseRollingUpgradePolicy = useRollingUpgradePolicy;
        }

        /// <summary> Indicates whether OS upgrades should automatically be applied to scale set instances in a rolling fashion when a newer version of the OS image becomes available. Default value is false. If this is set to true for Windows based scale sets, [enableAutomaticUpdates](https://docs.microsoft.com/dotnet/api/microsoft.azure.management.compute.models.windowsconfiguration.enableautomaticupdates?view=azure-dotnet) is automatically set to false and cannot be set to true. </summary>
        public bool? EnableAutomaticOSUpgrade { get; set; }
        /// <summary> Whether OS image rollback feature should be disabled. Default value is false. </summary>
        public bool? DisableAutomaticRollback { get; set; }
        /// <summary> Indicates whether rolling upgrade policy should be used during Auto OS Upgrade. Default value is false. Auto OS Upgrade will fallback to the default policy if no policy is defined on the VMSS. </summary>
        public bool? UseRollingUpgradePolicy { get; set; }
    }
}
