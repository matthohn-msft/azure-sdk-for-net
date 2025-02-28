// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.ConnectedVMwarevSphere;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableConnectedVMwarevSphereArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableConnectedVMwarevSphereArmClient"/> class for mocking. </summary>
        protected MockableConnectedVMwarevSphereArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableConnectedVMwarevSphereArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableConnectedVMwarevSphereArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableConnectedVMwarevSphereArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="ResourcePoolResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ResourcePoolResource.CreateResourceIdentifier" /> to create a <see cref="ResourcePoolResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ResourcePoolResource" /> object. </returns>
        public virtual ResourcePoolResource GetResourcePoolResource(ResourceIdentifier id)
        {
            ResourcePoolResource.ValidateResourceId(id);
            return new ResourcePoolResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="VMwareClusterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VMwareClusterResource.CreateResourceIdentifier" /> to create a <see cref="VMwareClusterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VMwareClusterResource" /> object. </returns>
        public virtual VMwareClusterResource GetVMwareClusterResource(ResourceIdentifier id)
        {
            VMwareClusterResource.ValidateResourceId(id);
            return new VMwareClusterResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="VMwareHostResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VMwareHostResource.CreateResourceIdentifier" /> to create a <see cref="VMwareHostResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VMwareHostResource" /> object. </returns>
        public virtual VMwareHostResource GetVMwareHostResource(ResourceIdentifier id)
        {
            VMwareHostResource.ValidateResourceId(id);
            return new VMwareHostResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="VMwareDatastoreResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VMwareDatastoreResource.CreateResourceIdentifier" /> to create a <see cref="VMwareDatastoreResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VMwareDatastoreResource" /> object. </returns>
        public virtual VMwareDatastoreResource GetVMwareDatastoreResource(ResourceIdentifier id)
        {
            VMwareDatastoreResource.ValidateResourceId(id);
            return new VMwareDatastoreResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="VCenterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VCenterResource.CreateResourceIdentifier" /> to create a <see cref="VCenterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VCenterResource" /> object. </returns>
        public virtual VCenterResource GetVCenterResource(ResourceIdentifier id)
        {
            VCenterResource.ValidateResourceId(id);
            return new VCenterResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="VirtualMachineResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VirtualMachineResource.CreateResourceIdentifier" /> to create a <see cref="VirtualMachineResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineResource" /> object. </returns>
        public virtual VirtualMachineResource GetVirtualMachineResource(ResourceIdentifier id)
        {
            VirtualMachineResource.ValidateResourceId(id);
            return new VirtualMachineResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="VirtualMachineTemplateResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VirtualMachineTemplateResource.CreateResourceIdentifier" /> to create a <see cref="VirtualMachineTemplateResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineTemplateResource" /> object. </returns>
        public virtual VirtualMachineTemplateResource GetVirtualMachineTemplateResource(ResourceIdentifier id)
        {
            VirtualMachineTemplateResource.ValidateResourceId(id);
            return new VirtualMachineTemplateResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="VirtualNetworkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VirtualNetworkResource.CreateResourceIdentifier" /> to create a <see cref="VirtualNetworkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualNetworkResource" /> object. </returns>
        public virtual VirtualNetworkResource GetVirtualNetworkResource(ResourceIdentifier id)
        {
            VirtualNetworkResource.ValidateResourceId(id);
            return new VirtualNetworkResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="InventoryItemResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="InventoryItemResource.CreateResourceIdentifier" /> to create an <see cref="InventoryItemResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="InventoryItemResource" /> object. </returns>
        public virtual InventoryItemResource GetInventoryItemResource(ResourceIdentifier id)
        {
            InventoryItemResource.ValidateResourceId(id);
            return new InventoryItemResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HybridIdentityMetadataResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridIdentityMetadataResource.CreateResourceIdentifier" /> to create a <see cref="HybridIdentityMetadataResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HybridIdentityMetadataResource" /> object. </returns>
        public virtual HybridIdentityMetadataResource GetHybridIdentityMetadataResource(ResourceIdentifier id)
        {
            HybridIdentityMetadataResource.ValidateResourceId(id);
            return new HybridIdentityMetadataResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineExtensionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineExtensionResource.CreateResourceIdentifier" /> to create a <see cref="MachineExtensionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineExtensionResource" /> object. </returns>
        public virtual MachineExtensionResource GetMachineExtensionResource(ResourceIdentifier id)
        {
            MachineExtensionResource.ValidateResourceId(id);
            return new MachineExtensionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="GuestAgentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="GuestAgentResource.CreateResourceIdentifier" /> to create a <see cref="GuestAgentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GuestAgentResource" /> object. </returns>
        public virtual GuestAgentResource GetGuestAgentResource(ResourceIdentifier id)
        {
            GuestAgentResource.ValidateResourceId(id);
            return new GuestAgentResource(Client, id);
        }
    }
}
