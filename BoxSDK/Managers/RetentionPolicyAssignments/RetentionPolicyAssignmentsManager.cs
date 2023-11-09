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
        /// <summary>
        /// Returns a list of all retention policy assignments associated with a specified
        /// retention policy.
        /// </summary>
        /// <param name="retentionPolicyId">
        /// The ID of the retention policy.
        /// Example: "982312"
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of getRetentionPolicyAssignments method
        /// </param>
        /// <param name="headers">
        /// Headers of getRetentionPolicyAssignments method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<RetentionPolicyAssignments> GetRetentionPolicyAssignmentsAsync(string retentionPolicyId, GetRetentionPolicyAssignmentsQueryParamsArg? queryParams = default, GetRetentionPolicyAssignmentsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetRetentionPolicyAssignmentsQueryParamsArg();
            headers = headers ?? new GetRetentionPolicyAssignmentsHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "type", StringUtils.ToStringRepresentation(queryParams.Type) }, { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) }, { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/retention_policies/", StringUtils.ToStringRepresentation(retentionPolicyId), "/assignments"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<RetentionPolicyAssignments>(response.Data);
        }

        /// <summary>
        /// Assigns a retention policy to an item.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createRetentionPolicyAssignment method
        /// </param>
        /// <param name="headers">
        /// Headers of createRetentionPolicyAssignment method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<RetentionPolicyAssignment> CreateRetentionPolicyAssignmentAsync(CreateRetentionPolicyAssignmentRequestBodyArg requestBody, CreateRetentionPolicyAssignmentHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateRetentionPolicyAssignmentHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/retention_policy_assignments"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<RetentionPolicyAssignment>(response.Data);
        }

        /// <summary>
        /// Retrieves a retention policy assignment
        /// </summary>
        /// <param name="retentionPolicyAssignmentId">
        /// The ID of the retention policy assignment.
        /// Example: "1233123"
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of getRetentionPolicyAssignmentById method
        /// </param>
        /// <param name="headers">
        /// Headers of getRetentionPolicyAssignmentById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<RetentionPolicyAssignment> GetRetentionPolicyAssignmentByIdAsync(string retentionPolicyAssignmentId, GetRetentionPolicyAssignmentByIdQueryParamsArg? queryParams = default, GetRetentionPolicyAssignmentByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetRetentionPolicyAssignmentByIdQueryParamsArg();
            headers = headers ?? new GetRetentionPolicyAssignmentByIdHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/retention_policy_assignments/", StringUtils.ToStringRepresentation(retentionPolicyAssignmentId)), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<RetentionPolicyAssignment>(response.Data);
        }

        /// <summary>
        /// Removes a retention policy assignment
        /// applied to content.
        /// </summary>
        /// <param name="retentionPolicyAssignmentId">
        /// The ID of the retention policy assignment.
        /// Example: "1233123"
        /// </param>
        /// <param name="headers">
        /// Headers of deleteRetentionPolicyAssignmentById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteRetentionPolicyAssignmentByIdAsync(string retentionPolicyAssignmentId, DeleteRetentionPolicyAssignmentByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteRetentionPolicyAssignmentByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/retention_policy_assignments/", StringUtils.ToStringRepresentation(retentionPolicyAssignmentId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns a list of files under retention for a retention policy assignment.
        /// </summary>
        /// <param name="retentionPolicyAssignmentId">
        /// The ID of the retention policy assignment.
        /// Example: "1233123"
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of getRetentionPolicyAssignmentFileUnderRetention method
        /// </param>
        /// <param name="headers">
        /// Headers of getRetentionPolicyAssignmentFileUnderRetention method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<FilesUnderRetention> GetRetentionPolicyAssignmentFileUnderRetentionAsync(string retentionPolicyAssignmentId, GetRetentionPolicyAssignmentFileUnderRetentionQueryParamsArg? queryParams = default, GetRetentionPolicyAssignmentFileUnderRetentionHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetRetentionPolicyAssignmentFileUnderRetentionQueryParamsArg();
            headers = headers ?? new GetRetentionPolicyAssignmentFileUnderRetentionHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/retention_policy_assignments/", StringUtils.ToStringRepresentation(retentionPolicyAssignmentId), "/files_under_retention"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<FilesUnderRetention>(response.Data);
        }

        /// <summary>
        /// Returns a list of file versions under retention for a retention policy
        /// assignment.
        /// </summary>
        /// <param name="retentionPolicyAssignmentId">
        /// The ID of the retention policy assignment.
        /// Example: "1233123"
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of getRetentionPolicyAssignmentFileVersionUnderRetention method
        /// </param>
        /// <param name="headers">
        /// Headers of getRetentionPolicyAssignmentFileVersionUnderRetention method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<FilesUnderRetention> GetRetentionPolicyAssignmentFileVersionUnderRetentionAsync(string retentionPolicyAssignmentId, GetRetentionPolicyAssignmentFileVersionUnderRetentionQueryParamsArg? queryParams = default, GetRetentionPolicyAssignmentFileVersionUnderRetentionHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetRetentionPolicyAssignmentFileVersionUnderRetentionQueryParamsArg();
            headers = headers ?? new GetRetentionPolicyAssignmentFileVersionUnderRetentionHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/retention_policy_assignments/", StringUtils.ToStringRepresentation(retentionPolicyAssignmentId), "/file_versions_under_retention"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<FilesUnderRetention>(response.Data);
        }

    }
}