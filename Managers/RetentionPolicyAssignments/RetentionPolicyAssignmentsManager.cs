using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class RetentionPolicyAssignmentsManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public RetentionPolicyAssignmentsManager() {
            
        }
        public async System.Threading.Tasks.Task<RetentionPolicyAssignments> GetRetentionPolicyAssignments(string retentionPolicyId, GetRetentionPolicyAssignmentsQueryParamsArg? queryParams = default, GetRetentionPolicyAssignmentsHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetRetentionPolicyAssignmentsQueryParamsArg();
            headers = headers ?? new GetRetentionPolicyAssignmentsHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "type", Utils.ToString(queryParams.Type) }, { "fields", Utils.ToString(queryParams.Fields) }, { "marker", Utils.ToString(queryParams.Marker) }, { "limit", Utils.ToString(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/retention_policies/", retentionPolicyId, "/assignments"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<RetentionPolicyAssignments>(response.Text);
        }

        public async System.Threading.Tasks.Task<RetentionPolicyAssignment> CreateRetentionPolicyAssignment(CreateRetentionPolicyAssignmentRequestBodyArg requestBody, CreateRetentionPolicyAssignmentHeadersArg? headers = default) {
            headers = headers ?? new CreateRetentionPolicyAssignmentHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/retention_policy_assignments"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<RetentionPolicyAssignment>(response.Text);
        }

        public async System.Threading.Tasks.Task<RetentionPolicyAssignment> GetRetentionPolicyAssignmentById(string retentionPolicyAssignmentId, GetRetentionPolicyAssignmentByIdQueryParamsArg? queryParams = default, GetRetentionPolicyAssignmentByIdHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetRetentionPolicyAssignmentByIdQueryParamsArg();
            headers = headers ?? new GetRetentionPolicyAssignmentByIdHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/retention_policy_assignments/", retentionPolicyAssignmentId), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<RetentionPolicyAssignment>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteRetentionPolicyAssignmentById(string retentionPolicyAssignmentId, DeleteRetentionPolicyAssignmentByIdHeadersArg? headers = default) {
            headers = headers ?? new DeleteRetentionPolicyAssignmentByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/retention_policy_assignments/", retentionPolicyAssignmentId), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

        public async System.Threading.Tasks.Task<FilesUnderRetention> GetRetentionPolicyAssignmentFileUnderRetention(string retentionPolicyAssignmentId, GetRetentionPolicyAssignmentFileUnderRetentionQueryParamsArg? queryParams = default, GetRetentionPolicyAssignmentFileUnderRetentionHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetRetentionPolicyAssignmentFileUnderRetentionQueryParamsArg();
            headers = headers ?? new GetRetentionPolicyAssignmentFileUnderRetentionHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "marker", Utils.ToString(queryParams.Marker) }, { "limit", Utils.ToString(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/retention_policy_assignments/", retentionPolicyAssignmentId, "/files_under_retention"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FilesUnderRetention>(response.Text);
        }

        public async System.Threading.Tasks.Task<FilesUnderRetention> GetRetentionPolicyAssignmentFileVersionUnderRetention(string retentionPolicyAssignmentId, GetRetentionPolicyAssignmentFileVersionUnderRetentionQueryParamsArg? queryParams = default, GetRetentionPolicyAssignmentFileVersionUnderRetentionHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetRetentionPolicyAssignmentFileVersionUnderRetentionQueryParamsArg();
            headers = headers ?? new GetRetentionPolicyAssignmentFileVersionUnderRetentionHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "marker", Utils.ToString(queryParams.Marker) }, { "limit", Utils.ToString(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/retention_policy_assignments/", retentionPolicyAssignmentId, "/file_versions_under_retention"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FilesUnderRetention>(response.Text);
        }

    }
}