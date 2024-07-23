using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class StoragePolicyAssignmentsManager : IStoragePolicyAssignmentsManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public StoragePolicyAssignmentsManager(NetworkSession? networkSession = default) {
            NetworkSession = networkSession ?? new NetworkSession();
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
        public async System.Threading.Tasks.Task<StoragePolicyAssignments> GetStoragePolicyAssignmentsAsync(GetStoragePolicyAssignmentsQueryParams queryParams, GetStoragePolicyAssignmentsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetStoragePolicyAssignmentsHeaders();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "resolved_for_type", StringUtils.ToStringRepresentation(queryParams.ResolvedForType) }, { "resolved_for_id", StringUtils.ToStringRepresentation(queryParams.ResolvedForId) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/storage_policy_assignments"), new FetchOptions(networkSession: this.NetworkSession) { Method = "GET", Parameters = queryParamsMap, Headers = headersMap, ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
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
        public async System.Threading.Tasks.Task<StoragePolicyAssignment> CreateStoragePolicyAssignmentAsync(CreateStoragePolicyAssignmentRequestBody requestBody, CreateStoragePolicyAssignmentHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateStoragePolicyAssignmentHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/storage_policy_assignments"), new FetchOptions(networkSession: this.NetworkSession) { Method = "POST", Headers = headersMap, Data = SimpleJsonSerializer.Serialize(requestBody), ContentType = "application/json", ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
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
        public async System.Threading.Tasks.Task<StoragePolicyAssignment> GetStoragePolicyAssignmentByIdAsync(string storagePolicyAssignmentId, GetStoragePolicyAssignmentByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetStoragePolicyAssignmentByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/storage_policy_assignments/", StringUtils.ToStringRepresentation(storagePolicyAssignmentId)), new FetchOptions(networkSession: this.NetworkSession) { Method = "GET", Headers = headersMap, ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
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
        public async System.Threading.Tasks.Task<StoragePolicyAssignment> UpdateStoragePolicyAssignmentByIdAsync(string storagePolicyAssignmentId, UpdateStoragePolicyAssignmentByIdRequestBody requestBody, UpdateStoragePolicyAssignmentByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new UpdateStoragePolicyAssignmentByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/storage_policy_assignments/", StringUtils.ToStringRepresentation(storagePolicyAssignmentId)), new FetchOptions(networkSession: this.NetworkSession) { Method = "PUT", Headers = headersMap, Data = SimpleJsonSerializer.Serialize(requestBody), ContentType = "application/json", ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
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
        public async System.Threading.Tasks.Task DeleteStoragePolicyAssignmentByIdAsync(string storagePolicyAssignmentId, DeleteStoragePolicyAssignmentByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteStoragePolicyAssignmentByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/storage_policy_assignments/", StringUtils.ToStringRepresentation(storagePolicyAssignmentId)), new FetchOptions(networkSession: this.NetworkSession) { Method = "DELETE", Headers = headersMap, ResponseFormat = null, Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
        }

    }
}