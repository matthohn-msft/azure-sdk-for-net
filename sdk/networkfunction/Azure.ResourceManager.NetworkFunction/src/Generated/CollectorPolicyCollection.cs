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

namespace Azure.ResourceManager.NetworkFunction
{
    /// <summary>
    /// A class representing a collection of <see cref="CollectorPolicyResource" /> and their operations.
    /// Each <see cref="CollectorPolicyResource" /> in the collection will belong to the same instance of <see cref="AzureTrafficCollectorResource" />.
    /// To get a <see cref="CollectorPolicyCollection" /> instance call the GetCollectorPolicies method from an instance of <see cref="AzureTrafficCollectorResource" />.
    /// </summary>
    public partial class CollectorPolicyCollection : ArmCollection, IEnumerable<CollectorPolicyResource>, IAsyncEnumerable<CollectorPolicyResource>
    {
        private readonly ClientDiagnostics _collectorPolicyClientDiagnostics;
        private readonly CollectorPoliciesRestOperations _collectorPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="CollectorPolicyCollection"/> class for mocking. </summary>
        protected CollectorPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CollectorPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CollectorPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _collectorPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetworkFunction", CollectorPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CollectorPolicyResource.ResourceType, out string collectorPolicyApiVersion);
            _collectorPolicyRestClient = new CollectorPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, collectorPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AzureTrafficCollectorResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AzureTrafficCollectorResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a Collector Policy resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkFunction/azureTrafficCollectors/{azureTrafficCollectorName}/collectorPolicies/{collectorPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CollectorPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="collectorPolicyName"> Collector Policy Name. </param>
        /// <param name="data"> The parameters to provide for the created Collector Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="collectorPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="collectorPolicyName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CollectorPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string collectorPolicyName, CollectorPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(collectorPolicyName, nameof(collectorPolicyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _collectorPolicyClientDiagnostics.CreateScope("CollectorPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _collectorPolicyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, collectorPolicyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkFunctionArmOperation<CollectorPolicyResource>(new CollectorPolicyOperationSource(Client), _collectorPolicyClientDiagnostics, Pipeline, _collectorPolicyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, collectorPolicyName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a Collector Policy resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkFunction/azureTrafficCollectors/{azureTrafficCollectorName}/collectorPolicies/{collectorPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CollectorPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="collectorPolicyName"> Collector Policy Name. </param>
        /// <param name="data"> The parameters to provide for the created Collector Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="collectorPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="collectorPolicyName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CollectorPolicyResource> CreateOrUpdate(WaitUntil waitUntil, string collectorPolicyName, CollectorPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(collectorPolicyName, nameof(collectorPolicyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _collectorPolicyClientDiagnostics.CreateScope("CollectorPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _collectorPolicyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, collectorPolicyName, data, cancellationToken);
                var operation = new NetworkFunctionArmOperation<CollectorPolicyResource>(new CollectorPolicyOperationSource(Client), _collectorPolicyClientDiagnostics, Pipeline, _collectorPolicyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, collectorPolicyName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the collector policy in a specified Traffic Collector
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkFunction/azureTrafficCollectors/{azureTrafficCollectorName}/collectorPolicies/{collectorPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CollectorPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="collectorPolicyName"> Collector Policy Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="collectorPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="collectorPolicyName"/> is null. </exception>
        public virtual async Task<Response<CollectorPolicyResource>> GetAsync(string collectorPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(collectorPolicyName, nameof(collectorPolicyName));

            using var scope = _collectorPolicyClientDiagnostics.CreateScope("CollectorPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _collectorPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, collectorPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CollectorPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the collector policy in a specified Traffic Collector
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkFunction/azureTrafficCollectors/{azureTrafficCollectorName}/collectorPolicies/{collectorPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CollectorPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="collectorPolicyName"> Collector Policy Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="collectorPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="collectorPolicyName"/> is null. </exception>
        public virtual Response<CollectorPolicyResource> Get(string collectorPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(collectorPolicyName, nameof(collectorPolicyName));

            using var scope = _collectorPolicyClientDiagnostics.CreateScope("CollectorPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _collectorPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, collectorPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CollectorPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Return list of Collector policies in a Azure Traffic Collector
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkFunction/azureTrafficCollectors/{azureTrafficCollectorName}/collectorPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CollectorPolicies_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CollectorPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CollectorPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _collectorPolicyRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _collectorPolicyRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new CollectorPolicyResource(Client, CollectorPolicyData.DeserializeCollectorPolicyData(e)), _collectorPolicyClientDiagnostics, Pipeline, "CollectorPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Return list of Collector policies in a Azure Traffic Collector
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkFunction/azureTrafficCollectors/{azureTrafficCollectorName}/collectorPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CollectorPolicies_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CollectorPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CollectorPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _collectorPolicyRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _collectorPolicyRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new CollectorPolicyResource(Client, CollectorPolicyData.DeserializeCollectorPolicyData(e)), _collectorPolicyClientDiagnostics, Pipeline, "CollectorPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkFunction/azureTrafficCollectors/{azureTrafficCollectorName}/collectorPolicies/{collectorPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CollectorPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="collectorPolicyName"> Collector Policy Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="collectorPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="collectorPolicyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string collectorPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(collectorPolicyName, nameof(collectorPolicyName));

            using var scope = _collectorPolicyClientDiagnostics.CreateScope("CollectorPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _collectorPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, collectorPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkFunction/azureTrafficCollectors/{azureTrafficCollectorName}/collectorPolicies/{collectorPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CollectorPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="collectorPolicyName"> Collector Policy Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="collectorPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="collectorPolicyName"/> is null. </exception>
        public virtual Response<bool> Exists(string collectorPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(collectorPolicyName, nameof(collectorPolicyName));

            using var scope = _collectorPolicyClientDiagnostics.CreateScope("CollectorPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _collectorPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, collectorPolicyName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkFunction/azureTrafficCollectors/{azureTrafficCollectorName}/collectorPolicies/{collectorPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CollectorPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="collectorPolicyName"> Collector Policy Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="collectorPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="collectorPolicyName"/> is null. </exception>
        public virtual async Task<NullableResponse<CollectorPolicyResource>> GetIfExistsAsync(string collectorPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(collectorPolicyName, nameof(collectorPolicyName));

            using var scope = _collectorPolicyClientDiagnostics.CreateScope("CollectorPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _collectorPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, collectorPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CollectorPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new CollectorPolicyResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkFunction/azureTrafficCollectors/{azureTrafficCollectorName}/collectorPolicies/{collectorPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CollectorPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="collectorPolicyName"> Collector Policy Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="collectorPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="collectorPolicyName"/> is null. </exception>
        public virtual NullableResponse<CollectorPolicyResource> GetIfExists(string collectorPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(collectorPolicyName, nameof(collectorPolicyName));

            using var scope = _collectorPolicyClientDiagnostics.CreateScope("CollectorPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _collectorPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, collectorPolicyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CollectorPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new CollectorPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CollectorPolicyResource> IEnumerable<CollectorPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CollectorPolicyResource> IAsyncEnumerable<CollectorPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
