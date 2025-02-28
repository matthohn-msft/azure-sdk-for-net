// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Support.Models;

namespace Azure.ResourceManager.Support
{
    /// <summary>
    /// A Class representing a TenantSupportTicket along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="TenantSupportTicketResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetTenantSupportTicketResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource" /> using the GetTenantSupportTicket method.
    /// </summary>
    public partial class TenantSupportTicketResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="TenantSupportTicketResource"/> instance. </summary>
        /// <param name="supportTicketName"> The supportTicketName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string supportTicketName)
        {
            var resourceId = $"/providers/Microsoft.Support/supportTickets/{supportTicketName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _tenantSupportTicketSupportTicketsNoSubscriptionClientDiagnostics;
        private readonly SupportTicketsNoSubscriptionRestOperations _tenantSupportTicketSupportTicketsNoSubscriptionRestClient;
        private readonly ClientDiagnostics _supportTicketNoSubCommunicationCommunicationsNoSubscriptionClientDiagnostics;
        private readonly CommunicationsNoSubscriptionRestOperations _supportTicketNoSubCommunicationCommunicationsNoSubscriptionRestClient;
        private readonly SupportTicketData _data;

        /// <summary> Initializes a new instance of the <see cref="TenantSupportTicketResource"/> class for mocking. </summary>
        protected TenantSupportTicketResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "TenantSupportTicketResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal TenantSupportTicketResource(ArmClient client, SupportTicketData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="TenantSupportTicketResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantSupportTicketResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _tenantSupportTicketSupportTicketsNoSubscriptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Support", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string tenantSupportTicketSupportTicketsNoSubscriptionApiVersion);
            _tenantSupportTicketSupportTicketsNoSubscriptionRestClient = new SupportTicketsNoSubscriptionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, tenantSupportTicketSupportTicketsNoSubscriptionApiVersion);
            _supportTicketNoSubCommunicationCommunicationsNoSubscriptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Support", SupportTicketNoSubCommunicationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SupportTicketNoSubCommunicationResource.ResourceType, out string supportTicketNoSubCommunicationCommunicationsNoSubscriptionApiVersion);
            _supportTicketNoSubCommunicationCommunicationsNoSubscriptionRestClient = new CommunicationsNoSubscriptionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, supportTicketNoSubCommunicationCommunicationsNoSubscriptionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Support/supportTickets";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SupportTicketData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of SupportTicketNoSubCommunicationResources in the TenantSupportTicket. </summary>
        /// <returns> An object representing collection of SupportTicketNoSubCommunicationResources and their operations over a SupportTicketNoSubCommunicationResource. </returns>
        public virtual SupportTicketNoSubCommunicationCollection GetSupportTicketNoSubCommunications()
        {
            return GetCachedClient(client => new SupportTicketNoSubCommunicationCollection(client, Id));
        }

        /// <summary>
        /// Returns communication details for a support ticket.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/supportTickets/{supportTicketName}/communications/{communicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunicationsNoSubscription_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="communicationName"> Communication name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="communicationName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SupportTicketNoSubCommunicationResource>> GetSupportTicketNoSubCommunicationAsync(string communicationName, CancellationToken cancellationToken = default)
        {
            return await GetSupportTicketNoSubCommunications().GetAsync(communicationName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns communication details for a support ticket.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/supportTickets/{supportTicketName}/communications/{communicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunicationsNoSubscription_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="communicationName"> Communication name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="communicationName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SupportTicketNoSubCommunicationResource> GetSupportTicketNoSubCommunication(string communicationName, CancellationToken cancellationToken = default)
        {
            return GetSupportTicketNoSubCommunications().Get(communicationName, cancellationToken);
        }

        /// <summary> Gets a collection of SupportTicketNoSubChatTranscriptResources in the TenantSupportTicket. </summary>
        /// <returns> An object representing collection of SupportTicketNoSubChatTranscriptResources and their operations over a SupportTicketNoSubChatTranscriptResource. </returns>
        public virtual SupportTicketNoSubChatTranscriptCollection GetSupportTicketNoSubChatTranscripts()
        {
            return GetCachedClient(client => new SupportTicketNoSubChatTranscriptCollection(client, Id));
        }

        /// <summary>
        /// Returns chatTranscript details for a no subscription support ticket.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/supportTickets/{supportTicketName}/chatTranscripts/{chatTranscriptName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChatTranscriptsNoSubscription_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="chatTranscriptName"> ChatTranscript name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="chatTranscriptName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="chatTranscriptName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SupportTicketNoSubChatTranscriptResource>> GetSupportTicketNoSubChatTranscriptAsync(string chatTranscriptName, CancellationToken cancellationToken = default)
        {
            return await GetSupportTicketNoSubChatTranscripts().GetAsync(chatTranscriptName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns chatTranscript details for a no subscription support ticket.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/supportTickets/{supportTicketName}/chatTranscripts/{chatTranscriptName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChatTranscriptsNoSubscription_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="chatTranscriptName"> ChatTranscript name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="chatTranscriptName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="chatTranscriptName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SupportTicketNoSubChatTranscriptResource> GetSupportTicketNoSubChatTranscript(string chatTranscriptName, CancellationToken cancellationToken = default)
        {
            return GetSupportTicketNoSubChatTranscripts().Get(chatTranscriptName, cancellationToken);
        }

        /// <summary>
        /// Gets details for a specific support ticket. Support ticket data is available for 18 months after ticket creation. If a ticket was created more than 18 months ago, a request for data might cause an error.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/supportTickets/{supportTicketName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupportTicketsNoSubscription_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TenantSupportTicketResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantSupportTicketSupportTicketsNoSubscriptionClientDiagnostics.CreateScope("TenantSupportTicketResource.Get");
            scope.Start();
            try
            {
                var response = await _tenantSupportTicketSupportTicketsNoSubscriptionRestClient.GetAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantSupportTicketResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets details for a specific support ticket. Support ticket data is available for 18 months after ticket creation. If a ticket was created more than 18 months ago, a request for data might cause an error.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/supportTickets/{supportTicketName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupportTicketsNoSubscription_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TenantSupportTicketResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantSupportTicketSupportTicketsNoSubscriptionClientDiagnostics.CreateScope("TenantSupportTicketResource.Get");
            scope.Start();
            try
            {
                var response = _tenantSupportTicketSupportTicketsNoSubscriptionRestClient.Get(Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantSupportTicketResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This API allows you to update the severity level, ticket status, and your contact information in the support ticket.&lt;br/&gt;&lt;br/&gt;Note: The severity levels cannot be changed if a support ticket is actively being worked upon by an Azure support engineer. In such a case, contact your support engineer to request severity update by adding a new communication using the Communications API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/supportTickets/{supportTicketName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupportTicketsNoSubscription_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateSupportTicket"> UpdateSupportTicket object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="updateSupportTicket"/> is null. </exception>
        public virtual async Task<Response<TenantSupportTicketResource>> UpdateAsync(UpdateSupportTicket updateSupportTicket, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(updateSupportTicket, nameof(updateSupportTicket));

            using var scope = _tenantSupportTicketSupportTicketsNoSubscriptionClientDiagnostics.CreateScope("TenantSupportTicketResource.Update");
            scope.Start();
            try
            {
                var response = await _tenantSupportTicketSupportTicketsNoSubscriptionRestClient.UpdateAsync(Id.Name, updateSupportTicket, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new TenantSupportTicketResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This API allows you to update the severity level, ticket status, and your contact information in the support ticket.&lt;br/&gt;&lt;br/&gt;Note: The severity levels cannot be changed if a support ticket is actively being worked upon by an Azure support engineer. In such a case, contact your support engineer to request severity update by adding a new communication using the Communications API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/supportTickets/{supportTicketName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupportTicketsNoSubscription_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateSupportTicket"> UpdateSupportTicket object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="updateSupportTicket"/> is null. </exception>
        public virtual Response<TenantSupportTicketResource> Update(UpdateSupportTicket updateSupportTicket, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(updateSupportTicket, nameof(updateSupportTicket));

            using var scope = _tenantSupportTicketSupportTicketsNoSubscriptionClientDiagnostics.CreateScope("TenantSupportTicketResource.Update");
            scope.Start();
            try
            {
                var response = _tenantSupportTicketSupportTicketsNoSubscriptionRestClient.Update(Id.Name, updateSupportTicket, cancellationToken);
                return Response.FromValue(new TenantSupportTicketResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the availability of a resource name. This API should be used to check the uniqueness of the name for adding a new communication to the support ticket.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/supportTickets/{supportTicketName}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunicationsNoSubscription_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<SupportNameAvailabilityResult>> CheckNameAvailabilityCommunicationsNoSubscriptionAsync(SupportNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _supportTicketNoSubCommunicationCommunicationsNoSubscriptionClientDiagnostics.CreateScope("TenantSupportTicketResource.CheckNameAvailabilityCommunicationsNoSubscription");
            scope.Start();
            try
            {
                var response = await _supportTicketNoSubCommunicationCommunicationsNoSubscriptionRestClient.CheckNameAvailabilityAsync(Id.Name, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the availability of a resource name. This API should be used to check the uniqueness of the name for adding a new communication to the support ticket.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/supportTickets/{supportTicketName}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunicationsNoSubscription_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<SupportNameAvailabilityResult> CheckNameAvailabilityCommunicationsNoSubscription(SupportNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _supportTicketNoSubCommunicationCommunicationsNoSubscriptionClientDiagnostics.CreateScope("TenantSupportTicketResource.CheckNameAvailabilityCommunicationsNoSubscription");
            scope.Start();
            try
            {
                var response = _supportTicketNoSubCommunicationCommunicationsNoSubscriptionRestClient.CheckNameAvailability(Id.Name, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
