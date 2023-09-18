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
    public class MetadataCascadePoliciesManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public MetadataCascadePoliciesManager() {
            
        }
        public async System.Threading.Tasks.Task<MetadataCascadePolicies> GetMetadataCascadePolicies(GetMetadataCascadePoliciesQueryParamsArg queryParams, GetMetadataCascadePoliciesHeadersArg? headers = default) {
            headers = headers ?? new GetMetadataCascadePoliciesHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "folder_id", Utils.ToString(queryParams.FolderId) }, { "owner_enterprise_id", Utils.ToString(queryParams.OwnerEnterpriseId) }, { "marker", Utils.ToString(queryParams.Marker) }, { "offset", Utils.ToString(queryParams.Offset) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/metadata_cascade_policies"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<MetadataCascadePolicies>(response.Text);
        }

        public async System.Threading.Tasks.Task<MetadataCascadePolicy> CreateMetadataCascadePolicy(CreateMetadataCascadePolicyRequestBodyArg requestBody, CreateMetadataCascadePolicyHeadersArg? headers = default) {
            headers = headers ?? new CreateMetadataCascadePolicyHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/metadata_cascade_policies"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<MetadataCascadePolicy>(response.Text);
        }

        public async System.Threading.Tasks.Task<MetadataCascadePolicy> GetMetadataCascadePolicyById(string metadataCascadePolicyId, GetMetadataCascadePolicyByIdHeadersArg? headers = default) {
            headers = headers ?? new GetMetadataCascadePolicyByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/metadata_cascade_policies/", metadataCascadePolicyId), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<MetadataCascadePolicy>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteMetadataCascadePolicyById(string metadataCascadePolicyId, DeleteMetadataCascadePolicyByIdHeadersArg? headers = default) {
            headers = headers ?? new DeleteMetadataCascadePolicyByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/metadata_cascade_policies/", metadataCascadePolicyId), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

        public async System.Threading.Tasks.Task CreateMetadataCascadePolicyApply(string metadataCascadePolicyId, CreateMetadataCascadePolicyApplyRequestBodyArg requestBody, CreateMetadataCascadePolicyApplyHeadersArg? headers = default) {
            headers = headers ?? new CreateMetadataCascadePolicyApplyHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/metadata_cascade_policies/", metadataCascadePolicyId, "/apply"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

    }
}