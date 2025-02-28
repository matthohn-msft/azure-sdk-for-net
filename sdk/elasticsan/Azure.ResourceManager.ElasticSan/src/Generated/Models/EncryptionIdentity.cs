// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ElasticSan.Models
{
    /// <summary> Encryption identity for the volume group. </summary>
    internal partial class EncryptionIdentity
    {
        /// <summary> Initializes a new instance of EncryptionIdentity. </summary>
        public EncryptionIdentity()
        {
        }

        /// <summary> Initializes a new instance of EncryptionIdentity. </summary>
        /// <param name="encryptionUserAssignedIdentity"> Resource identifier of the UserAssigned identity to be associated with server-side encryption on the volume group. </param>
        internal EncryptionIdentity(string encryptionUserAssignedIdentity)
        {
            EncryptionUserAssignedIdentity = encryptionUserAssignedIdentity;
        }

        /// <summary> Resource identifier of the UserAssigned identity to be associated with server-side encryption on the volume group. </summary>
        public string EncryptionUserAssignedIdentity { get; set; }
    }
}
