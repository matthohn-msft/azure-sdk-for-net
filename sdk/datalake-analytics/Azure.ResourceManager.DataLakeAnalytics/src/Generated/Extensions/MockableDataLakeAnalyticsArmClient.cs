// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.DataLakeAnalytics;

namespace Azure.ResourceManager.DataLakeAnalytics.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableDataLakeAnalyticsArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableDataLakeAnalyticsArmClient"/> class for mocking. </summary>
        protected MockableDataLakeAnalyticsArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableDataLakeAnalyticsArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableDataLakeAnalyticsArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableDataLakeAnalyticsArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataLakeAnalyticsAccountResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataLakeAnalyticsAccountResource.CreateResourceIdentifier" /> to create a <see cref="DataLakeAnalyticsAccountResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataLakeAnalyticsAccountResource" /> object. </returns>
        public virtual DataLakeAnalyticsAccountResource GetDataLakeAnalyticsAccountResource(ResourceIdentifier id)
        {
            DataLakeAnalyticsAccountResource.ValidateResourceId(id);
            return new DataLakeAnalyticsAccountResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataLakeStoreAccountInformationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataLakeStoreAccountInformationResource.CreateResourceIdentifier" /> to create a <see cref="DataLakeStoreAccountInformationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataLakeStoreAccountInformationResource" /> object. </returns>
        public virtual DataLakeStoreAccountInformationResource GetDataLakeStoreAccountInformationResource(ResourceIdentifier id)
        {
            DataLakeStoreAccountInformationResource.ValidateResourceId(id);
            return new DataLakeStoreAccountInformationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataLakeAnalyticsStorageAccountInformationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataLakeAnalyticsStorageAccountInformationResource.CreateResourceIdentifier" /> to create a <see cref="DataLakeAnalyticsStorageAccountInformationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataLakeAnalyticsStorageAccountInformationResource" /> object. </returns>
        public virtual DataLakeAnalyticsStorageAccountInformationResource GetDataLakeAnalyticsStorageAccountInformationResource(ResourceIdentifier id)
        {
            DataLakeAnalyticsStorageAccountInformationResource.ValidateResourceId(id);
            return new DataLakeAnalyticsStorageAccountInformationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataLakeAnalyticsStorageContainerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataLakeAnalyticsStorageContainerResource.CreateResourceIdentifier" /> to create a <see cref="DataLakeAnalyticsStorageContainerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataLakeAnalyticsStorageContainerResource" /> object. </returns>
        public virtual DataLakeAnalyticsStorageContainerResource GetDataLakeAnalyticsStorageContainerResource(ResourceIdentifier id)
        {
            DataLakeAnalyticsStorageContainerResource.ValidateResourceId(id);
            return new DataLakeAnalyticsStorageContainerResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataLakeAnalyticsComputePolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataLakeAnalyticsComputePolicyResource.CreateResourceIdentifier" /> to create a <see cref="DataLakeAnalyticsComputePolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataLakeAnalyticsComputePolicyResource" /> object. </returns>
        public virtual DataLakeAnalyticsComputePolicyResource GetDataLakeAnalyticsComputePolicyResource(ResourceIdentifier id)
        {
            DataLakeAnalyticsComputePolicyResource.ValidateResourceId(id);
            return new DataLakeAnalyticsComputePolicyResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataLakeAnalyticsFirewallRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataLakeAnalyticsFirewallRuleResource.CreateResourceIdentifier" /> to create a <see cref="DataLakeAnalyticsFirewallRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataLakeAnalyticsFirewallRuleResource" /> object. </returns>
        public virtual DataLakeAnalyticsFirewallRuleResource GetDataLakeAnalyticsFirewallRuleResource(ResourceIdentifier id)
        {
            DataLakeAnalyticsFirewallRuleResource.ValidateResourceId(id);
            return new DataLakeAnalyticsFirewallRuleResource(Client, id);
        }
    }
}
