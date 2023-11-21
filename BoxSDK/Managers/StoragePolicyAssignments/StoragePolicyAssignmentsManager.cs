using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using StringExtensions;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class StoragePolicyAssignmentsManager : IStoragePolicyAssignmentsManager {
        public IAuthentication? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public StoragePolicyAssignmentsManager() {
            
        }
        /// <summary>
        /// Fetches all the storage policy assignment for an enterprise or user.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getStoragePolicyAssignments method
        /// </param>
        /// <param name="headers">
        /// Headers of getStoragePolicyAssignments method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<StoragePolicyAssignments> GetStoragePolicyAssignmentsAsync(GetStoragePolicyAssignmentsQueryParamsArg queryParams, GetStoragePolicyAssignmentsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetStoragePolicyAssignmentsHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "resolved_for_type", StringUtils.ToStringRepresentation(queryParams.ResolvedForType) }, { "resolved_for_id", StringUtils.ToStringRepresentation(queryParams.ResolvedForId) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/storage_policy_assignments"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<StoragePolicyAssignments>(response.Data);
        }

        /// <summary>
        /// Creates a storage policy assignment for an enterprise or user.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createStoragePolicyAssignment method
        /// </param>
        /// <param name="headers">
        /// Headers of createStoragePolicyAssignment method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<StoragePolicyAssignment> CreateStoragePolicyAssignmentAsync(CreateStoragePolicyAssignmentRequestBodyArg requestBody, CreateStoragePolicyAssignmentHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateStoragePolicyAssignmentHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/storage_policy_assignments"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<StoragePolicyAssignment>(response.Data);
        }

        /// <summary>
        /// Fetches a specific storage policy assignment.
        /// </summary>
        /// <param name="storagePolicyAssignmentId">
        /// The ID of the storage policy assignment.
        /// Example: "932483"
        /// </param>
        /// <param name="headers">
        /// Headers of getStoragePolicyAssignmentById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<StoragePolicyAssignment> GetStoragePolicyAssignmentByIdAsync(string storagePolicyAssignmentId, GetStoragePolicyAssignmentByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetStoragePolicyAssignmentByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/storage_policy_assignments/", StringUtils.ToStringRepresentation(storagePolicyAssignmentId)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<StoragePolicyAssignment>(response.Data);
        }

        /// <summary>
        /// Updates a specific storage policy assignment.
        /// </summary>
        /// <param name="storagePolicyAssignmentId">
        /// The ID of the storage policy assignment.
        /// Example: "932483"
        /// </param>
        /// <param name="requestBody">
        /// Request body of updateStoragePolicyAssignmentById method
        /// </param>
        /// <param name="headers">
        /// Headers of updateStoragePolicyAssignmentById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<StoragePolicyAssignment> UpdateStoragePolicyAssignmentByIdAsync(string storagePolicyAssignmentId, UpdateStoragePolicyAssignmentByIdRequestBodyArg requestBody, UpdateStoragePolicyAssignmentByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new UpdateStoragePolicyAssignmentByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/storage_policy_assignments/", StringUtils.ToStringRepresentation(storagePolicyAssignmentId)), new FetchOptions(method: "PUT", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<StoragePolicyAssignment>(response.Data);
        }

        /// <summary>
        /// Delete a storage policy assignment.
        /// 
        /// Deleting a storage policy assignment on a user
        /// will have the user inherit the enterprise's default
        /// storage policy.
        /// 
        /// There is a rate limit for calling this endpoint of only
        /// twice per user in a 24 hour time frame.
        /// </summary>
        /// <param name="storagePolicyAssignmentId">
        /// The ID of the storage policy assignment.
        /// Example: "932483"
        /// </param>
        /// <param name="headers">
        /// Headers of deleteStoragePolicyAssignmentById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteStoragePolicyAssignmentByIdAsync(string storagePolicyAssignmentId, DeleteStoragePolicyAssignmentByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteStoragePolicyAssignmentByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/storage_policy_assignments/", StringUtils.ToStringRepresentation(storagePolicyAssignmentId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

    }
}