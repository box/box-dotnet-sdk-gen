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
    public class StoragePolicyAssignmentsManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public StoragePolicyAssignmentsManager() {
            
        }
        public async System.Threading.Tasks.Task<StoragePolicyAssignments> GetStoragePolicyAssignments(GetStoragePolicyAssignmentsQueryParamsArg queryParams, GetStoragePolicyAssignmentsHeadersArg? headers = default) {
            headers = headers ?? new GetStoragePolicyAssignmentsHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "resolved_for_type", StringUtils.ToStringRepresentation(queryParams.ResolvedForType) }, { "resolved_for_id", StringUtils.ToStringRepresentation(queryParams.ResolvedForId) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/storage_policy_assignments"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<StoragePolicyAssignments>(response.Text);
        }

        public async System.Threading.Tasks.Task<StoragePolicyAssignment> CreateStoragePolicyAssignment(CreateStoragePolicyAssignmentRequestBodyArg requestBody, CreateStoragePolicyAssignmentHeadersArg? headers = default) {
            headers = headers ?? new CreateStoragePolicyAssignmentHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/storage_policy_assignments"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<StoragePolicyAssignment>(response.Text);
        }

        public async System.Threading.Tasks.Task<StoragePolicyAssignment> GetStoragePolicyAssignmentById(string storagePolicyAssignmentId, GetStoragePolicyAssignmentByIdHeadersArg? headers = default) {
            headers = headers ?? new GetStoragePolicyAssignmentByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/storage_policy_assignments/", StringUtils.ToStringRepresentation(storagePolicyAssignmentId)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<StoragePolicyAssignment>(response.Text);
        }

        public async System.Threading.Tasks.Task<StoragePolicyAssignment> UpdateStoragePolicyAssignmentById(string storagePolicyAssignmentId, UpdateStoragePolicyAssignmentByIdRequestBodyArg requestBody, UpdateStoragePolicyAssignmentByIdHeadersArg? headers = default) {
            headers = headers ?? new UpdateStoragePolicyAssignmentByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/storage_policy_assignments/", StringUtils.ToStringRepresentation(storagePolicyAssignmentId)), new FetchOptions(method: "PUT", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<StoragePolicyAssignment>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteStoragePolicyAssignmentById(string storagePolicyAssignmentId, DeleteStoragePolicyAssignmentByIdHeadersArg? headers = default) {
            headers = headers ?? new DeleteStoragePolicyAssignmentByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/storage_policy_assignments/", StringUtils.ToStringRepresentation(storagePolicyAssignmentId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

    }
}