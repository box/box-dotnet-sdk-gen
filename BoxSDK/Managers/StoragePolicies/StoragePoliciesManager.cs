using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using StringExtensions;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class StoragePoliciesManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public StoragePoliciesManager() {
            
        }
        /// <summary>
        /// Fetches all the storage policies in the enterprise.
        /// Only a Primary Admin can access this endpoint. The user
        /// needs to generate a token for an account to authenticate this request.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getStoragePolicies method
        /// </param>
        /// <param name="headers">
        /// Headers of getStoragePolicies method
        /// </param>
        public async System.Threading.Tasks.Task<StoragePolicies> GetStoragePoliciesAsync(GetStoragePoliciesQueryParamsArg? queryParams = default, GetStoragePoliciesHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetStoragePoliciesQueryParamsArg();
            headers = headers ?? new GetStoragePoliciesHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) }, { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/storage_policies"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<StoragePolicies>(response.Text);
        }

        /// <summary>
        /// Fetches a specific storage policy. Only a Primary Admin can access this endpoint. The user needs to generate a token for an account to authenticate this request.
        /// </summary>
        /// <param name="storagePolicyId">
        /// The ID of the storage policy.
        /// Example: "34342"
        /// </param>
        /// <param name="headers">
        /// Headers of getStoragePolicyById method
        /// </param>
        public async System.Threading.Tasks.Task<StoragePolicy> GetStoragePolicyByIdAsync(string storagePolicyId, GetStoragePolicyByIdHeadersArg? headers = default) {
            headers = headers ?? new GetStoragePolicyByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/storage_policies/", StringUtils.ToStringRepresentation(storagePolicyId)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<StoragePolicy>(response.Text);
        }

    }
}