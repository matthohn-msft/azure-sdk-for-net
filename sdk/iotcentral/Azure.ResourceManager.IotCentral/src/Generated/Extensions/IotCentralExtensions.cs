// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.IotCentral.Mocking;
using Azure.ResourceManager.IotCentral.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.IotCentral
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.IotCentral. </summary>
    public static partial class IotCentralExtensions
    {
        private static MockableIotCentralArmClient GetMockableIotCentralArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableIotCentralArmClient(client0));
        }

        private static MockableIotCentralResourceGroupResource GetMockableIotCentralResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableIotCentralResourceGroupResource(client, resource.Id));
        }

        private static MockableIotCentralSubscriptionResource GetMockableIotCentralSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableIotCentralSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing an <see cref="IotCentralAppResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="IotCentralAppResource.CreateResourceIdentifier" /> to create an <see cref="IotCentralAppResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotCentralArmClient.GetIotCentralAppResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="IotCentralAppResource" /> object. </returns>
        public static IotCentralAppResource GetIotCentralAppResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableIotCentralArmClient(client).GetIotCentralAppResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="IotCentralPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="IotCentralPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create an <see cref="IotCentralPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotCentralArmClient.GetIotCentralPrivateEndpointConnectionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="IotCentralPrivateEndpointConnectionResource" /> object. </returns>
        public static IotCentralPrivateEndpointConnectionResource GetIotCentralPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableIotCentralArmClient(client).GetIotCentralPrivateEndpointConnectionResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="IotCentralPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="IotCentralPrivateLinkResource.CreateResourceIdentifier" /> to create an <see cref="IotCentralPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotCentralArmClient.GetIotCentralPrivateLinkResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="IotCentralPrivateLinkResource" /> object. </returns>
        public static IotCentralPrivateLinkResource GetIotCentralPrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableIotCentralArmClient(client).GetIotCentralPrivateLinkResource(id);
        }

        /// <summary>
        /// Gets a collection of IotCentralAppResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotCentralResourceGroupResource.GetIotCentralApps()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of IotCentralAppResources and their operations over a IotCentralAppResource. </returns>
        public static IotCentralAppCollection GetIotCentralApps(this ResourceGroupResource resourceGroupResource)
        {
            return GetMockableIotCentralResourceGroupResource(resourceGroupResource).GetIotCentralApps();
        }

        /// <summary>
        /// Get the metadata of an IoT Central application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTCentral/iotApps/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotCentralResourceGroupResource.GetIotCentralAppAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="resourceName"> The ARM resource name of the IoT Central application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<IotCentralAppResource>> GetIotCentralAppAsync(this ResourceGroupResource resourceGroupResource, string resourceName, CancellationToken cancellationToken = default)
        {
            return await GetMockableIotCentralResourceGroupResource(resourceGroupResource).GetIotCentralAppAsync(resourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the metadata of an IoT Central application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTCentral/iotApps/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotCentralResourceGroupResource.GetIotCentralApp(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="resourceName"> The ARM resource name of the IoT Central application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<IotCentralAppResource> GetIotCentralApp(this ResourceGroupResource resourceGroupResource, string resourceName, CancellationToken cancellationToken = default)
        {
            return GetMockableIotCentralResourceGroupResource(resourceGroupResource).GetIotCentralApp(resourceName, cancellationToken);
        }

        /// <summary>
        /// Get all IoT Central Applications in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.IoTCentral/iotApps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotCentralSubscriptionResource.GetIotCentralApps(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IotCentralAppResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<IotCentralAppResource> GetIotCentralAppsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMockableIotCentralSubscriptionResource(subscriptionResource).GetIotCentralAppsAsync(cancellationToken);
        }

        /// <summary>
        /// Get all IoT Central Applications in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.IoTCentral/iotApps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotCentralSubscriptionResource.GetIotCentralApps(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IotCentralAppResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<IotCentralAppResource> GetIotCentralApps(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMockableIotCentralSubscriptionResource(subscriptionResource).GetIotCentralApps(cancellationToken);
        }

        /// <summary>
        /// Check if an IoT Central application name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.IoTCentral/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotCentralSubscriptionResource.CheckIotCentralAppNameAvailability(IotCentralAppNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Set the name parameter in the OperationInputs structure to the name of the IoT Central application to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<IotCentralAppNameAvailabilityResponse>> CheckIotCentralAppNameAvailabilityAsync(this SubscriptionResource subscriptionResource, IotCentralAppNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return await GetMockableIotCentralSubscriptionResource(subscriptionResource).CheckIotCentralAppNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check if an IoT Central application name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.IoTCentral/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotCentralSubscriptionResource.CheckIotCentralAppNameAvailability(IotCentralAppNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Set the name parameter in the OperationInputs structure to the name of the IoT Central application to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<IotCentralAppNameAvailabilityResponse> CheckIotCentralAppNameAvailability(this SubscriptionResource subscriptionResource, IotCentralAppNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return GetMockableIotCentralSubscriptionResource(subscriptionResource).CheckIotCentralAppNameAvailability(content, cancellationToken);
        }

        /// <summary>
        /// Check if an IoT Central application subdomain is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.IoTCentral/checkSubdomainAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_CheckSubdomainAvailability</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotCentralSubscriptionResource.CheckIotCentralAppSubdomainAvailability(IotCentralAppNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Set the name parameter in the OperationInputs structure to the subdomain of the IoT Central application to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<IotCentralAppNameAvailabilityResponse>> CheckIotCentralAppSubdomainAvailabilityAsync(this SubscriptionResource subscriptionResource, IotCentralAppNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return await GetMockableIotCentralSubscriptionResource(subscriptionResource).CheckIotCentralAppSubdomainAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check if an IoT Central application subdomain is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.IoTCentral/checkSubdomainAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_CheckSubdomainAvailability</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotCentralSubscriptionResource.CheckIotCentralAppSubdomainAvailability(IotCentralAppNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Set the name parameter in the OperationInputs structure to the subdomain of the IoT Central application to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<IotCentralAppNameAvailabilityResponse> CheckIotCentralAppSubdomainAvailability(this SubscriptionResource subscriptionResource, IotCentralAppNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return GetMockableIotCentralSubscriptionResource(subscriptionResource).CheckIotCentralAppSubdomainAvailability(content, cancellationToken);
        }

        /// <summary>
        /// Get all available application templates.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.IoTCentral/appTemplates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_ListTemplates</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotCentralSubscriptionResource.GetTemplatesApps(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IotCentralAppTemplate" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<IotCentralAppTemplate> GetTemplatesAppsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMockableIotCentralSubscriptionResource(subscriptionResource).GetTemplatesAppsAsync(cancellationToken);
        }

        /// <summary>
        /// Get all available application templates.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.IoTCentral/appTemplates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_ListTemplates</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotCentralSubscriptionResource.GetTemplatesApps(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IotCentralAppTemplate" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<IotCentralAppTemplate> GetTemplatesApps(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMockableIotCentralSubscriptionResource(subscriptionResource).GetTemplatesApps(cancellationToken);
        }
    }
}
