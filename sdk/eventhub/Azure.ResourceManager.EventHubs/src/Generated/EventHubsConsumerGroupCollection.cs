// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary>
    /// A class representing a collection of <see cref="EventHubsConsumerGroupResource" /> and their operations.
    /// Each <see cref="EventHubsConsumerGroupResource" /> in the collection will belong to the same instance of <see cref="EventHubResource" />.
    /// To get an <see cref="EventHubsConsumerGroupCollection" /> instance call the GetEventHubsConsumerGroups method from an instance of <see cref="EventHubResource" />.
    /// </summary>
    public partial class EventHubsConsumerGroupCollection : ArmCollection, IEnumerable<EventHubsConsumerGroupResource>, IAsyncEnumerable<EventHubsConsumerGroupResource>
    {
        private readonly ClientDiagnostics _eventHubsConsumerGroupConsumerGroupsClientDiagnostics;
        private readonly ConsumerGroupsRestOperations _eventHubsConsumerGroupConsumerGroupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="EventHubsConsumerGroupCollection"/> class for mocking. </summary>
        protected EventHubsConsumerGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EventHubsConsumerGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EventHubsConsumerGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _eventHubsConsumerGroupConsumerGroupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventHubs", EventHubsConsumerGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(EventHubsConsumerGroupResource.ResourceType, out string eventHubsConsumerGroupConsumerGroupsApiVersion);
            _eventHubsConsumerGroupConsumerGroupsRestClient = new ConsumerGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, eventHubsConsumerGroupConsumerGroupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != EventHubResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, EventHubResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an Event Hubs consumer group as a nested resource within a Namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}/consumergroups/{consumerGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConsumerGroups_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="consumerGroupName"> The consumer group name. </param>
        /// <param name="data"> Parameters supplied to create or update a consumer group resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="consumerGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="consumerGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<EventHubsConsumerGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string consumerGroupName, EventHubsConsumerGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(consumerGroupName, nameof(consumerGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _eventHubsConsumerGroupConsumerGroupsClientDiagnostics.CreateScope("EventHubsConsumerGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _eventHubsConsumerGroupConsumerGroupsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, consumerGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new EventHubsArmOperation<EventHubsConsumerGroupResource>(Response.FromValue(new EventHubsConsumerGroupResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates an Event Hubs consumer group as a nested resource within a Namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}/consumergroups/{consumerGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConsumerGroups_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="consumerGroupName"> The consumer group name. </param>
        /// <param name="data"> Parameters supplied to create or update a consumer group resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="consumerGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="consumerGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<EventHubsConsumerGroupResource> CreateOrUpdate(WaitUntil waitUntil, string consumerGroupName, EventHubsConsumerGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(consumerGroupName, nameof(consumerGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _eventHubsConsumerGroupConsumerGroupsClientDiagnostics.CreateScope("EventHubsConsumerGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _eventHubsConsumerGroupConsumerGroupsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, consumerGroupName, data, cancellationToken);
                var operation = new EventHubsArmOperation<EventHubsConsumerGroupResource>(Response.FromValue(new EventHubsConsumerGroupResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a description for the specified consumer group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}/consumergroups/{consumerGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConsumerGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="consumerGroupName"> The consumer group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="consumerGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="consumerGroupName"/> is null. </exception>
        public virtual async Task<Response<EventHubsConsumerGroupResource>> GetAsync(string consumerGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(consumerGroupName, nameof(consumerGroupName));

            using var scope = _eventHubsConsumerGroupConsumerGroupsClientDiagnostics.CreateScope("EventHubsConsumerGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _eventHubsConsumerGroupConsumerGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, consumerGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventHubsConsumerGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a description for the specified consumer group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}/consumergroups/{consumerGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConsumerGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="consumerGroupName"> The consumer group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="consumerGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="consumerGroupName"/> is null. </exception>
        public virtual Response<EventHubsConsumerGroupResource> Get(string consumerGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(consumerGroupName, nameof(consumerGroupName));

            using var scope = _eventHubsConsumerGroupConsumerGroupsClientDiagnostics.CreateScope("EventHubsConsumerGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _eventHubsConsumerGroupConsumerGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, consumerGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventHubsConsumerGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the consumer groups in a Namespace. An empty feed is returned if no consumer group exists in the Namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}/consumergroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConsumerGroups_ListByEventHub</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EventHubsConsumerGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EventHubsConsumerGroupResource> GetAllAsync(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventHubsConsumerGroupConsumerGroupsRestClient.CreateListByEventHubRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skip, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventHubsConsumerGroupConsumerGroupsRestClient.CreateListByEventHubNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skip, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new EventHubsConsumerGroupResource(Client, EventHubsConsumerGroupData.DeserializeEventHubsConsumerGroupData(e)), _eventHubsConsumerGroupConsumerGroupsClientDiagnostics, Pipeline, "EventHubsConsumerGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the consumer groups in a Namespace. An empty feed is returned if no consumer group exists in the Namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}/consumergroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConsumerGroups_ListByEventHub</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EventHubsConsumerGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EventHubsConsumerGroupResource> GetAll(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventHubsConsumerGroupConsumerGroupsRestClient.CreateListByEventHubRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skip, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventHubsConsumerGroupConsumerGroupsRestClient.CreateListByEventHubNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skip, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new EventHubsConsumerGroupResource(Client, EventHubsConsumerGroupData.DeserializeEventHubsConsumerGroupData(e)), _eventHubsConsumerGroupConsumerGroupsClientDiagnostics, Pipeline, "EventHubsConsumerGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}/consumergroups/{consumerGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConsumerGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="consumerGroupName"> The consumer group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="consumerGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="consumerGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string consumerGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(consumerGroupName, nameof(consumerGroupName));

            using var scope = _eventHubsConsumerGroupConsumerGroupsClientDiagnostics.CreateScope("EventHubsConsumerGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _eventHubsConsumerGroupConsumerGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, consumerGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}/consumergroups/{consumerGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConsumerGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="consumerGroupName"> The consumer group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="consumerGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="consumerGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string consumerGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(consumerGroupName, nameof(consumerGroupName));

            using var scope = _eventHubsConsumerGroupConsumerGroupsClientDiagnostics.CreateScope("EventHubsConsumerGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _eventHubsConsumerGroupConsumerGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, consumerGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}/consumergroups/{consumerGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConsumerGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="consumerGroupName"> The consumer group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="consumerGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="consumerGroupName"/> is null. </exception>
        public virtual async Task<NullableResponse<EventHubsConsumerGroupResource>> GetIfExistsAsync(string consumerGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(consumerGroupName, nameof(consumerGroupName));

            using var scope = _eventHubsConsumerGroupConsumerGroupsClientDiagnostics.CreateScope("EventHubsConsumerGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _eventHubsConsumerGroupConsumerGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, consumerGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<EventHubsConsumerGroupResource>(response.GetRawResponse());
                return Response.FromValue(new EventHubsConsumerGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}/consumergroups/{consumerGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConsumerGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="consumerGroupName"> The consumer group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="consumerGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="consumerGroupName"/> is null. </exception>
        public virtual NullableResponse<EventHubsConsumerGroupResource> GetIfExists(string consumerGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(consumerGroupName, nameof(consumerGroupName));

            using var scope = _eventHubsConsumerGroupConsumerGroupsClientDiagnostics.CreateScope("EventHubsConsumerGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _eventHubsConsumerGroupConsumerGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, consumerGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<EventHubsConsumerGroupResource>(response.GetRawResponse());
                return Response.FromValue(new EventHubsConsumerGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EventHubsConsumerGroupResource> IEnumerable<EventHubsConsumerGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EventHubsConsumerGroupResource> IAsyncEnumerable<EventHubsConsumerGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
