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
    public class LegalHoldPoliciesManager : ILegalHoldPoliciesManager {
        public IAuthentication? Auth { get; set; } = default;

        public NetworkSession NetworkSession { get; set; }

        public LegalHoldPoliciesManager(NetworkSession networkSession = default) {
            NetworkSession = networkSession ?? new NetworkSession();
        }
        /// <summary>
        /// Retrieves a list of legal hold policies that belong to
        /// an enterprise.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getLegalHoldPolicies method
        /// </param>
        /// <param name="headers">
        /// Headers of getLegalHoldPolicies method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<LegalHoldPolicies> GetLegalHoldPoliciesAsync(GetLegalHoldPoliciesQueryParams? queryParams = default, GetLegalHoldPoliciesHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetLegalHoldPoliciesQueryParams();
            headers = headers ?? new GetLegalHoldPoliciesHeaders();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "policy_name", StringUtils.ToStringRepresentation(queryParams.PolicyName) }, { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) }, { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/legal_hold_policies"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<LegalHoldPolicies>(response.Data);
        }

        /// <summary>
        /// Create a new legal hold policy.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createLegalHoldPolicy method
        /// </param>
        /// <param name="headers">
        /// Headers of createLegalHoldPolicy method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<LegalHoldPolicy> CreateLegalHoldPolicyAsync(CreateLegalHoldPolicyRequestBody requestBody, CreateLegalHoldPolicyHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateLegalHoldPolicyHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/legal_hold_policies"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<LegalHoldPolicy>(response.Data);
        }

        /// <summary>
        /// Retrieve a legal hold policy.
        /// </summary>
        /// <param name="legalHoldPolicyId">
        /// The ID of the legal hold policy
        /// Example: "324432"
        /// </param>
        /// <param name="headers">
        /// Headers of getLegalHoldPolicyById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<LegalHoldPolicy> GetLegalHoldPolicyByIdAsync(string legalHoldPolicyId, GetLegalHoldPolicyByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetLegalHoldPolicyByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/legal_hold_policies/", StringUtils.ToStringRepresentation(legalHoldPolicyId)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<LegalHoldPolicy>(response.Data);
        }

        /// <summary>
        /// Update legal hold policy.
        /// </summary>
        /// <param name="legalHoldPolicyId">
        /// The ID of the legal hold policy
        /// Example: "324432"
        /// </param>
        /// <param name="requestBody">
        /// Request body of updateLegalHoldPolicyById method
        /// </param>
        /// <param name="headers">
        /// Headers of updateLegalHoldPolicyById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<LegalHoldPolicy> UpdateLegalHoldPolicyByIdAsync(string legalHoldPolicyId, UpdateLegalHoldPolicyByIdRequestBody? requestBody = default, UpdateLegalHoldPolicyByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            requestBody = requestBody ?? new UpdateLegalHoldPolicyByIdRequestBody();
            headers = headers ?? new UpdateLegalHoldPolicyByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/legal_hold_policies/", StringUtils.ToStringRepresentation(legalHoldPolicyId)), new FetchOptions(method: "PUT", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<LegalHoldPolicy>(response.Data);
        }

        /// <summary>
        /// Delete an existing legal hold policy.
        /// 
        /// This is an asynchronous process. The policy will not be
        /// fully deleted yet when the response returns.
        /// </summary>
        /// <param name="legalHoldPolicyId">
        /// The ID of the legal hold policy
        /// Example: "324432"
        /// </param>
        /// <param name="headers">
        /// Headers of deleteLegalHoldPolicyById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteLegalHoldPolicyByIdAsync(string legalHoldPolicyId, DeleteLegalHoldPolicyByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteLegalHoldPolicyByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/legal_hold_policies/", StringUtils.ToStringRepresentation(legalHoldPolicyId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

    }
}