// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.DigitalTwins.Models;

namespace Azure.ResourceManager.DigitalTwins
{
    /// <summary> The DigitalTwins service client. </summary>
    public partial class DigitalTwinsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal DigitalTwinsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of DigitalTwinsClient for mocking. </summary>
        protected DigitalTwinsClient()
        {
        }
        /// <summary> Initializes a new instance of DigitalTwinsClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal DigitalTwinsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2020-03-01-preview")
        {
            RestClient = new DigitalTwinsRestClient(clientDiagnostics, pipeline, subscriptionId, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Get DigitalTwinsInstances resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the DigitalTwinsInstance. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DigitalTwinsDescription>> GetAsync(string resourceGroupName, string resourceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DigitalTwinsClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, resourceName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get DigitalTwinsInstances resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the DigitalTwinsInstance. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DigitalTwinsDescription> Get(string resourceGroupName, string resourceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DigitalTwinsClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, resourceName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Check if a DigitalTwinsInstance name is available. </summary>
        /// <param name="location"> Location of DigitalTwinsInstance. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> The type of resource, for instance Microsoft.DigitalTwins/digitalTwinsInstances. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CheckNameResult>> CheckNameAvailabilityAsync(string location, string name, string type = "Microsoft.DigitalTwins/digitalTwinsInstances", CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DigitalTwinsClient.CheckNameAvailability");
            scope.Start();
            try
            {
                return await RestClient.CheckNameAvailabilityAsync(location, name, type, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Check if a DigitalTwinsInstance name is available. </summary>
        /// <param name="location"> Location of DigitalTwinsInstance. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> The type of resource, for instance Microsoft.DigitalTwins/digitalTwinsInstances. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CheckNameResult> CheckNameAvailability(string location, string name, string type = "Microsoft.DigitalTwins/digitalTwinsInstances", CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DigitalTwinsClient.CheckNameAvailability");
            scope.Start();
            try
            {
                return RestClient.CheckNameAvailability(location, name, type, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get all the DigitalTwinsInstances in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<DigitalTwinsDescription> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DigitalTwinsDescription>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DigitalTwinsClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DigitalTwinsDescription>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DigitalTwinsClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Get all the DigitalTwinsInstances in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<DigitalTwinsDescription> List(CancellationToken cancellationToken = default)
        {
            Page<DigitalTwinsDescription> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DigitalTwinsClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DigitalTwinsDescription> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DigitalTwinsClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Get all the DigitalTwinsInstances in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the DigitalTwinsInstance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<DigitalTwinsDescription> ListByResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<DigitalTwinsDescription>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DigitalTwinsClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DigitalTwinsDescription>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DigitalTwinsClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupNextPageAsync(nextLink, resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Get all the DigitalTwinsInstances in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the DigitalTwinsInstance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<DigitalTwinsDescription> ListByResourceGroup(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<DigitalTwinsDescription> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DigitalTwinsClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroup(resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DigitalTwinsDescription> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DigitalTwinsClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroupNextPage(nextLink, resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Create or update the metadata of a DigitalTwinsInstance. The usual pattern to modify a property is to retrieve the DigitalTwinsInstance and security metadata, and then combine them with the modified values in a new body to update the DigitalTwinsInstance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the DigitalTwinsInstance. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="digitalTwinsCreate"> The DigitalTwinsInstance and security metadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<DigitalTwinsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string resourceName, DigitalTwinsDescription digitalTwinsCreate, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (digitalTwinsCreate == null)
            {
                throw new ArgumentNullException(nameof(digitalTwinsCreate));
            }

            using var scope = _clientDiagnostics.CreateScope("DigitalTwinsClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, resourceName, digitalTwinsCreate, cancellationToken).ConfigureAwait(false);
                return new DigitalTwinsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, resourceName, digitalTwinsCreate).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update the metadata of a DigitalTwinsInstance. The usual pattern to modify a property is to retrieve the DigitalTwinsInstance and security metadata, and then combine them with the modified values in a new body to update the DigitalTwinsInstance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the DigitalTwinsInstance. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="digitalTwinsCreate"> The DigitalTwinsInstance and security metadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual DigitalTwinsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string resourceName, DigitalTwinsDescription digitalTwinsCreate, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (digitalTwinsCreate == null)
            {
                throw new ArgumentNullException(nameof(digitalTwinsCreate));
            }

            using var scope = _clientDiagnostics.CreateScope("DigitalTwinsClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, resourceName, digitalTwinsCreate, cancellationToken);
                return new DigitalTwinsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, resourceName, digitalTwinsCreate).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update metadata of DigitalTwinsInstance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the DigitalTwinsInstance. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="tags"> Instance tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<DigitalTwinsUpdateOperation> StartUpdateAsync(string resourceGroupName, string resourceName, IDictionary<string, string> tags = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }

            using var scope = _clientDiagnostics.CreateScope("DigitalTwinsClient.StartUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.UpdateAsync(resourceGroupName, resourceName, tags, cancellationToken).ConfigureAwait(false);
                return new DigitalTwinsUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateUpdateRequest(resourceGroupName, resourceName, tags).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update metadata of DigitalTwinsInstance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the DigitalTwinsInstance. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="tags"> Instance tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual DigitalTwinsUpdateOperation StartUpdate(string resourceGroupName, string resourceName, IDictionary<string, string> tags = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }

            using var scope = _clientDiagnostics.CreateScope("DigitalTwinsClient.StartUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Update(resourceGroupName, resourceName, tags, cancellationToken);
                return new DigitalTwinsUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateUpdateRequest(resourceGroupName, resourceName, tags).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a DigitalTwinsInstance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the DigitalTwinsInstance. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<DigitalTwinsDeleteOperation> StartDeleteAsync(string resourceGroupName, string resourceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }

            using var scope = _clientDiagnostics.CreateScope("DigitalTwinsClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, resourceName, cancellationToken).ConfigureAwait(false);
                return new DigitalTwinsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, resourceName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a DigitalTwinsInstance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the DigitalTwinsInstance. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual DigitalTwinsDeleteOperation StartDelete(string resourceGroupName, string resourceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }

            using var scope = _clientDiagnostics.CreateScope("DigitalTwinsClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, resourceName, cancellationToken);
                return new DigitalTwinsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, resourceName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
