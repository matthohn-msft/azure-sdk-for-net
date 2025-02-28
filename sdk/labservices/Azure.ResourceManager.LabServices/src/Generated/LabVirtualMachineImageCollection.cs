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

namespace Azure.ResourceManager.LabServices
{
    /// <summary>
    /// A class representing a collection of <see cref="LabVirtualMachineImageResource" /> and their operations.
    /// Each <see cref="LabVirtualMachineImageResource" /> in the collection will belong to the same instance of <see cref="LabPlanResource" />.
    /// To get a <see cref="LabVirtualMachineImageCollection" /> instance call the GetLabVirtualMachineImages method from an instance of <see cref="LabPlanResource" />.
    /// </summary>
    public partial class LabVirtualMachineImageCollection : ArmCollection, IEnumerable<LabVirtualMachineImageResource>, IAsyncEnumerable<LabVirtualMachineImageResource>
    {
        private readonly ClientDiagnostics _labVirtualMachineImageImagesClientDiagnostics;
        private readonly ImagesRestOperations _labVirtualMachineImageImagesRestClient;

        /// <summary> Initializes a new instance of the <see cref="LabVirtualMachineImageCollection"/> class for mocking. </summary>
        protected LabVirtualMachineImageCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LabVirtualMachineImageCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LabVirtualMachineImageCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _labVirtualMachineImageImagesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.LabServices", LabVirtualMachineImageResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LabVirtualMachineImageResource.ResourceType, out string labVirtualMachineImageImagesApiVersion);
            _labVirtualMachineImageImagesRestClient = new ImagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, labVirtualMachineImageImagesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != LabPlanResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, LabPlanResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Updates an image resource via PUT. Creating new resources via PUT will not function.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labPlans/{labPlanName}/images/{imageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="imageName"> The image name. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<LabVirtualMachineImageResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string imageName, LabVirtualMachineImageData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(imageName, nameof(imageName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _labVirtualMachineImageImagesClientDiagnostics.CreateScope("LabVirtualMachineImageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _labVirtualMachineImageImagesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, imageName, data, cancellationToken).ConfigureAwait(false);
                var operation = new LabServicesArmOperation<LabVirtualMachineImageResource>(Response.FromValue(new LabVirtualMachineImageResource(Client, response), response.GetRawResponse()));
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
        /// Updates an image resource via PUT. Creating new resources via PUT will not function.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labPlans/{labPlanName}/images/{imageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="imageName"> The image name. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<LabVirtualMachineImageResource> CreateOrUpdate(WaitUntil waitUntil, string imageName, LabVirtualMachineImageData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(imageName, nameof(imageName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _labVirtualMachineImageImagesClientDiagnostics.CreateScope("LabVirtualMachineImageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _labVirtualMachineImageImagesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, imageName, data, cancellationToken);
                var operation = new LabServicesArmOperation<LabVirtualMachineImageResource>(Response.FromValue(new LabVirtualMachineImageResource(Client, response), response.GetRawResponse()));
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
        /// Gets an image resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labPlans/{labPlanName}/images/{imageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="imageName"> The image name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        public virtual async Task<Response<LabVirtualMachineImageResource>> GetAsync(string imageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(imageName, nameof(imageName));

            using var scope = _labVirtualMachineImageImagesClientDiagnostics.CreateScope("LabVirtualMachineImageCollection.Get");
            scope.Start();
            try
            {
                var response = await _labVirtualMachineImageImagesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, imageName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LabVirtualMachineImageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an image resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labPlans/{labPlanName}/images/{imageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="imageName"> The image name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        public virtual Response<LabVirtualMachineImageResource> Get(string imageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(imageName, nameof(imageName));

            using var scope = _labVirtualMachineImageImagesClientDiagnostics.CreateScope("LabVirtualMachineImageCollection.Get");
            scope.Start();
            try
            {
                var response = _labVirtualMachineImageImagesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, imageName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LabVirtualMachineImageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all images from galleries attached to a lab plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labPlans/{labPlanName}/images</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_ListByLabPlan</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LabVirtualMachineImageResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LabVirtualMachineImageResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _labVirtualMachineImageImagesRestClient.CreateListByLabPlanRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _labVirtualMachineImageImagesRestClient.CreateListByLabPlanNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new LabVirtualMachineImageResource(Client, LabVirtualMachineImageData.DeserializeLabVirtualMachineImageData(e)), _labVirtualMachineImageImagesClientDiagnostics, Pipeline, "LabVirtualMachineImageCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all images from galleries attached to a lab plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labPlans/{labPlanName}/images</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_ListByLabPlan</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LabVirtualMachineImageResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LabVirtualMachineImageResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _labVirtualMachineImageImagesRestClient.CreateListByLabPlanRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _labVirtualMachineImageImagesRestClient.CreateListByLabPlanNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new LabVirtualMachineImageResource(Client, LabVirtualMachineImageData.DeserializeLabVirtualMachineImageData(e)), _labVirtualMachineImageImagesClientDiagnostics, Pipeline, "LabVirtualMachineImageCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labPlans/{labPlanName}/images/{imageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="imageName"> The image name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string imageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(imageName, nameof(imageName));

            using var scope = _labVirtualMachineImageImagesClientDiagnostics.CreateScope("LabVirtualMachineImageCollection.Exists");
            scope.Start();
            try
            {
                var response = await _labVirtualMachineImageImagesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, imageName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labPlans/{labPlanName}/images/{imageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="imageName"> The image name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        public virtual Response<bool> Exists(string imageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(imageName, nameof(imageName));

            using var scope = _labVirtualMachineImageImagesClientDiagnostics.CreateScope("LabVirtualMachineImageCollection.Exists");
            scope.Start();
            try
            {
                var response = _labVirtualMachineImageImagesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, imageName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labPlans/{labPlanName}/images/{imageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="imageName"> The image name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        public virtual async Task<NullableResponse<LabVirtualMachineImageResource>> GetIfExistsAsync(string imageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(imageName, nameof(imageName));

            using var scope = _labVirtualMachineImageImagesClientDiagnostics.CreateScope("LabVirtualMachineImageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _labVirtualMachineImageImagesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, imageName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<LabVirtualMachineImageResource>(response.GetRawResponse());
                return Response.FromValue(new LabVirtualMachineImageResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labPlans/{labPlanName}/images/{imageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="imageName"> The image name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        public virtual NullableResponse<LabVirtualMachineImageResource> GetIfExists(string imageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(imageName, nameof(imageName));

            using var scope = _labVirtualMachineImageImagesClientDiagnostics.CreateScope("LabVirtualMachineImageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _labVirtualMachineImageImagesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, imageName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<LabVirtualMachineImageResource>(response.GetRawResponse());
                return Response.FromValue(new LabVirtualMachineImageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LabVirtualMachineImageResource> IEnumerable<LabVirtualMachineImageResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LabVirtualMachineImageResource> IAsyncEnumerable<LabVirtualMachineImageResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
