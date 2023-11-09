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
    public class RetentionPoliciesManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public RetentionPoliciesManager() {
            
        }
        /// <summary>
        /// Retrieves all of the retention policies for an enterprise.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getRetentionPolicies method
        /// </param>
        /// <param name="headers">
        /// Headers of getRetentionPolicies method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<RetentionPolicies> GetRetentionPoliciesAsync(GetRetentionPoliciesQueryParamsArg? queryParams = default, GetRetentionPoliciesHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetRetentionPoliciesQueryParamsArg();
            headers = headers ?? new GetRetentionPoliciesHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "policy_name", StringUtils.ToStringRepresentation(queryParams.PolicyName) }, { "policy_type", StringUtils.ToStringRepresentation(queryParams.PolicyType) }, { "created_by_user_id", StringUtils.ToStringRepresentation(queryParams.CreatedByUserId) }, { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) }, { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/retention_policies"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<RetentionPolicies>(response.Data);
        }

        /// <summary>
        /// Creates a retention policy.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createRetentionPolicy method
        /// </param>
        /// <param name="headers">
        /// Headers of createRetentionPolicy method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<RetentionPolicy> CreateRetentionPolicyAsync(CreateRetentionPolicyRequestBodyArg requestBody, CreateRetentionPolicyHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateRetentionPolicyHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/retention_policies"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<RetentionPolicy>(response.Data);
        }

        /// <summary>
        /// Retrieves a retention policy.
        /// </summary>
        /// <param name="retentionPolicyId">
        /// The ID of the retention policy.
        /// Example: "982312"
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of getRetentionPolicyById method
        /// </param>
        /// <param name="headers">
        /// Headers of getRetentionPolicyById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<RetentionPolicy> GetRetentionPolicyByIdAsync(string retentionPolicyId, GetRetentionPolicyByIdQueryParamsArg? queryParams = default, GetRetentionPolicyByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetRetentionPolicyByIdQueryParamsArg();
            headers = headers ?? new GetRetentionPolicyByIdHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/retention_policies/", StringUtils.ToStringRepresentation(retentionPolicyId)), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<RetentionPolicy>(response.Data);
        }

        /// <summary>
        /// Updates a retention policy.
        /// </summary>
        /// <param name="retentionPolicyId">
        /// The ID of the retention policy.
        /// Example: "982312"
        /// </param>
        /// <param name="requestBody">
        /// Request body of updateRetentionPolicyById method
        /// </param>
        /// <param name="headers">
        /// Headers of updateRetentionPolicyById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<RetentionPolicy> UpdateRetentionPolicyByIdAsync(string retentionPolicyId, UpdateRetentionPolicyByIdRequestBodyArg? requestBody = default, UpdateRetentionPolicyByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            requestBody = requestBody ?? new UpdateRetentionPolicyByIdRequestBodyArg();
            headers = headers ?? new UpdateRetentionPolicyByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/retention_policies/", StringUtils.ToStringRepresentation(retentionPolicyId)), new FetchOptions(method: "PUT", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<RetentionPolicy>(response.Data);
        }

        /// <summary>
        /// Permanently deletes a retention policy.
        /// </summary>
        /// <param name="retentionPolicyId">
        /// The ID of the retention policy.
        /// Example: "982312"
        /// </param>
        /// <param name="headers">
        /// Headers of deleteRetentionPolicyById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteRetentionPolicyByIdAsync(string retentionPolicyId, DeleteRetentionPolicyByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteRetentionPolicyByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/retention_policies/", StringUtils.ToStringRepresentation(retentionPolicyId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

    }
}