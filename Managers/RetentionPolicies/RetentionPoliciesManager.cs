using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class RetentionPoliciesManager {
        public IAuth Auth { get; }

        public NetworkSession NetworkSession { get; }

        public RetentionPoliciesManager(IAuth auth, NetworkSession networkSession) {
            Auth = auth;
            NetworkSession = networkSession;
        }
        public async System.Threading.Tasks.Task<RetentionPolicies> GetRetentionPolicies(GetRetentionPoliciesQueryParamsArg queryParams, GetRetentionPoliciesHeadersArg headers) {
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string>() { { "policy_name", Utils.ToString(queryParams.PolicyName) }, { "policy_type", Utils.ToString(queryParams.PolicyType) }, { "created_by_user_id", Utils.ToString(queryParams.CreatedByUserId) }, { "fields", Utils.ToString(queryParams.Fields) }, { "limit", Utils.ToString(queryParams.Limit) }, { "marker", Utils.ToString(queryParams.Marker) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/retention_policies"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<RetentionPolicies>(response.Text);
        }

        public async System.Threading.Tasks.Task<RetentionPolicy> CreateRetentionPolicy(CreateRetentionPolicyRequestBodyArg requestBody, CreateRetentionPolicyHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/retention_policies"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<RetentionPolicy>(response.Text);
        }

        public async System.Threading.Tasks.Task<RetentionPolicy> GetRetentionPolicyById(string retentionPolicyId, GetRetentionPolicyByIdQueryParamsArg queryParams, GetRetentionPolicyByIdHeadersArg headers) {
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/retention_policies/", retentionPolicyId), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<RetentionPolicy>(response.Text);
        }

        public async System.Threading.Tasks.Task<RetentionPolicy> UpdateRetentionPolicyById(string retentionPolicyId, UpdateRetentionPolicyByIdRequestBodyArg requestBody, UpdateRetentionPolicyByIdHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/retention_policies/", retentionPolicyId), new FetchOptions(method: "PUT", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<RetentionPolicy>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteRetentionPolicyById(string retentionPolicyId, DeleteRetentionPolicyByIdHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/retention_policies/", retentionPolicyId), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

    }
}