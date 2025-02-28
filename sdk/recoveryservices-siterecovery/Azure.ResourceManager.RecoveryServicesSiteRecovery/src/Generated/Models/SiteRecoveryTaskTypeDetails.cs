// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary>
    /// Task details based on specific task type.
    /// Please note <see cref="SiteRecoveryTaskTypeDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AutomationRunbookTaskDetails"/>, <see cref="ConsistencyCheckTaskDetails"/>, <see cref="FabricReplicationGroupTaskDetails"/>, <see cref="SiteRecoveryJobTaskDetails"/>, <see cref="ManualActionTaskDetails"/>, <see cref="ScriptActionTaskDetails"/>, <see cref="SiteRecoveryVmTaskDetails"/> and <see cref="VmNicUpdatesTaskDetails"/>.
    /// </summary>
    public abstract partial class SiteRecoveryTaskTypeDetails
    {
        /// <summary> Initializes a new instance of SiteRecoveryTaskTypeDetails. </summary>
        protected SiteRecoveryTaskTypeDetails()
        {
        }

        /// <summary> Initializes a new instance of SiteRecoveryTaskTypeDetails. </summary>
        /// <param name="instanceType"> The type of task details. </param>
        internal SiteRecoveryTaskTypeDetails(string instanceType)
        {
            InstanceType = instanceType;
        }

        /// <summary> The type of task details. </summary>
        internal string InstanceType { get; set; }
    }
}
