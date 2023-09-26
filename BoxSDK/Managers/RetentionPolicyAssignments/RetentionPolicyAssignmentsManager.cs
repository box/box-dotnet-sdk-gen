using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using StringExtensions;
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
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "type", StringUtils.ToStringRepresentation(queryParams.Type) }, { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) }, { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/retention_policies/", StringUtils.ToStringRepresentation(retentionPolicyId), "/assignments"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
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
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/retention_policy_assignments/", StringUtils.ToStringRepresentation(retentionPolicyAssignmentId)), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<RetentionPolicyAssignment>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteRetentionPolicyAssignmentById(string retentionPolicyAssignmentId, DeleteRetentionPolicyAssignmentByIdHeadersArg? headers = default) {
            headers = headers ?? new DeleteRetentionPolicyAssignmentByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/retention_policy_assignments/", StringUtils.ToStringRepresentation(retentionPolicyAssignmentId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

        public async System.Threading.Tasks.Task<FilesUnderRetention> GetRetentionPolicyAssignmentFileUnderRetention(string retentionPolicyAssignmentId, GetRetentionPolicyAssignmentFileUnderRetentionQueryParamsArg? queryParams = default, GetRetentionPolicyAssignmentFileUnderRetentionHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetRetentionPolicyAssignmentFileUnderRetentionQueryParamsArg();
            headers = headers ?? new GetRetentionPolicyAssignmentFileUnderRetentionHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/retention_policy_assignments/", StringUtils.ToStringRepresentation(retentionPolicyAssignmentId), "/files_under_retention"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FilesUnderRetention>(response.Text);
        }

        public async System.Threading.Tasks.Task<FilesUnderRetention> GetRetentionPolicyAssignmentFileVersionUnderRetention(string retentionPolicyAssignmentId, GetRetentionPolicyAssignmentFileVersionUnderRetentionQueryParamsArg? queryParams = default, GetRetentionPolicyAssignmentFileVersionUnderRetentionHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetRetentionPolicyAssignmentFileVersionUnderRetentionQueryParamsArg();
            headers = headers ?? new GetRetentionPolicyAssignmentFileVersionUnderRetentionHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/retention_policy_assignments/", StringUtils.ToStringRepresentation(retentionPolicyAssignmentId), "/file_versions_under_retention"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FilesUnderRetention>(response.Text);
        }

    }
}