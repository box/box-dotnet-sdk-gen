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
    public class LegalHoldPoliciesManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public LegalHoldPoliciesManager() {
            
        }
        public async System.Threading.Tasks.Task<LegalHoldPolicies> GetLegalHoldPolicies(GetLegalHoldPoliciesQueryParamsArg? queryParams = default, GetLegalHoldPoliciesHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetLegalHoldPoliciesQueryParamsArg();
            headers = headers ?? new GetLegalHoldPoliciesHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "policy_name", Utils.ToString(queryParams.PolicyName) }, { "fields", Utils.ToString(queryParams.Fields) }, { "marker", Utils.ToString(queryParams.Marker) }, { "limit", Utils.ToString(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/legal_hold_policies"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<LegalHoldPolicies>(response.Text);
        }

        public async System.Threading.Tasks.Task<LegalHoldPolicy> CreateLegalHoldPolicy(CreateLegalHoldPolicyRequestBodyArg requestBody, CreateLegalHoldPolicyHeadersArg? headers = default) {
            headers = headers ?? new CreateLegalHoldPolicyHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/legal_hold_policies"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<LegalHoldPolicy>(response.Text);
        }

        public async System.Threading.Tasks.Task<LegalHoldPolicy> GetLegalHoldPolicyById(string legalHoldPolicyId, GetLegalHoldPolicyByIdHeadersArg? headers = default) {
            headers = headers ?? new GetLegalHoldPolicyByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/legal_hold_policies/", legalHoldPolicyId), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<LegalHoldPolicy>(response.Text);
        }

        public async System.Threading.Tasks.Task<LegalHoldPolicy> UpdateLegalHoldPolicyById(string legalHoldPolicyId, UpdateLegalHoldPolicyByIdRequestBodyArg? requestBody = default, UpdateLegalHoldPolicyByIdHeadersArg? headers = default) {
            requestBody = requestBody ?? new UpdateLegalHoldPolicyByIdRequestBodyArg();
            headers = headers ?? new UpdateLegalHoldPolicyByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/legal_hold_policies/", legalHoldPolicyId), new FetchOptions(method: "PUT", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<LegalHoldPolicy>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteLegalHoldPolicyById(string legalHoldPolicyId, DeleteLegalHoldPolicyByIdHeadersArg? headers = default) {
            headers = headers ?? new DeleteLegalHoldPolicyByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/legal_hold_policies/", legalHoldPolicyId), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

    }
}