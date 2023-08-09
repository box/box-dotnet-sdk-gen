using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class StoragePolicyAssignmentsManager {
        public IAuth Auth { get; }

        public NetworkSession NetworkSession { get; }

        public StoragePolicyAssignmentsManager(IAuth auth, NetworkSession networkSession) {
            Auth = auth;
            NetworkSession = networkSession;
        }
        public async System.Threading.Tasks.Task<StoragePolicyAssignments> GetStoragePolicyAssignments(GetStoragePolicyAssignmentsQueryParamsArg queryParams, GetStoragePolicyAssignmentsHeadersArg headers) {
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string>() { { "marker", Utils.ToString(queryParams.Marker) }, { "resolved_for_type", Utils.ToString(queryParams.ResolvedForType) }, { "resolved_for_id", Utils.ToString(queryParams.ResolvedForId) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/storage_policy_assignments"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<StoragePolicyAssignments>(response.Text);
        }

        public async System.Threading.Tasks.Task<StoragePolicyAssignment> CreateStoragePolicyAssignment(CreateStoragePolicyAssignmentRequestBodyArg requestBody, CreateStoragePolicyAssignmentHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/storage_policy_assignments"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<StoragePolicyAssignment>(response.Text);
        }

        public async System.Threading.Tasks.Task<StoragePolicyAssignment> GetStoragePolicyAssignmentById(string storagePolicyAssignmentId, GetStoragePolicyAssignmentByIdHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/storage_policy_assignments/", storagePolicyAssignmentId), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<StoragePolicyAssignment>(response.Text);
        }

        public async System.Threading.Tasks.Task<StoragePolicyAssignment> UpdateStoragePolicyAssignmentById(string storagePolicyAssignmentId, UpdateStoragePolicyAssignmentByIdRequestBodyArg requestBody, UpdateStoragePolicyAssignmentByIdHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/storage_policy_assignments/", storagePolicyAssignmentId), new FetchOptions(method: "PUT", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<StoragePolicyAssignment>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteStoragePolicyAssignmentById(string storagePolicyAssignmentId, DeleteStoragePolicyAssignmentByIdHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/storage_policy_assignments/", storagePolicyAssignmentId), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

    }
}