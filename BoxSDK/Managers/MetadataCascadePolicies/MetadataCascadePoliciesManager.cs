using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using StringExtensions;
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
        /// <summary>
        /// Retrieves a list of all the metadata cascade policies
        /// that are applied to a given folder. This can not be used on the root
        /// folder with ID `0`.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getMetadataCascadePolicies method
        /// </param>
        /// <param name="headers">
        /// Headers of getMetadataCascadePolicies method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<MetadataCascadePolicies> GetMetadataCascadePoliciesAsync(GetMetadataCascadePoliciesQueryParamsArg queryParams, GetMetadataCascadePoliciesHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetMetadataCascadePoliciesHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "folder_id", StringUtils.ToStringRepresentation(queryParams.FolderId) }, { "owner_enterprise_id", StringUtils.ToStringRepresentation(queryParams.OwnerEnterpriseId) }, { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "offset", StringUtils.ToStringRepresentation(queryParams.Offset) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/metadata_cascade_policies"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<MetadataCascadePolicies>(response.Text);
        }

        /// <summary>
        /// Creates a new metadata cascade policy that applies a given
        /// metadata template to a given folder and automatically
        /// cascades it down to any files within that folder.
        /// 
        /// In order for the policy to be applied a metadata instance must first
        /// be applied to the folder the policy is to be applied to.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createMetadataCascadePolicy method
        /// </param>
        /// <param name="headers">
        /// Headers of createMetadataCascadePolicy method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<MetadataCascadePolicy> CreateMetadataCascadePolicyAsync(CreateMetadataCascadePolicyRequestBodyArg requestBody, CreateMetadataCascadePolicyHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateMetadataCascadePolicyHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/metadata_cascade_policies"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<MetadataCascadePolicy>(response.Text);
        }

        /// <summary>
        /// Retrieve a specific metadata cascade policy assigned to a folder.
        /// </summary>
        /// <param name="metadataCascadePolicyId">
        /// The ID of the metadata cascade policy.
        /// Example: "6fd4ff89-8fc1-42cf-8b29-1890dedd26d7"
        /// </param>
        /// <param name="headers">
        /// Headers of getMetadataCascadePolicyById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<MetadataCascadePolicy> GetMetadataCascadePolicyByIdAsync(string metadataCascadePolicyId, GetMetadataCascadePolicyByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetMetadataCascadePolicyByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/metadata_cascade_policies/", StringUtils.ToStringRepresentation(metadataCascadePolicyId)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<MetadataCascadePolicy>(response.Text);
        }

        /// <summary>
        /// Deletes a metadata cascade policy.
        /// </summary>
        /// <param name="metadataCascadePolicyId">
        /// The ID of the metadata cascade policy.
        /// Example: "6fd4ff89-8fc1-42cf-8b29-1890dedd26d7"
        /// </param>
        /// <param name="headers">
        /// Headers of deleteMetadataCascadePolicyById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteMetadataCascadePolicyByIdAsync(string metadataCascadePolicyId, DeleteMetadataCascadePolicyByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteMetadataCascadePolicyByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/metadata_cascade_policies/", StringUtils.ToStringRepresentation(metadataCascadePolicyId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

        /// <summary>
        /// Force the metadata on a folder with a metadata cascade policy to be applied to
        /// all of its children. This can be used after creating a new cascade policy to
        /// enforce the metadata to be cascaded down to all existing files within that
        /// folder.
        /// </summary>
        /// <param name="metadataCascadePolicyId">
        /// The ID of the cascade policy to force-apply.
        /// Example: "6fd4ff89-8fc1-42cf-8b29-1890dedd26d7"
        /// </param>
        /// <param name="requestBody">
        /// Request body of createMetadataCascadePolicyApply method
        /// </param>
        /// <param name="headers">
        /// Headers of createMetadataCascadePolicyApply method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task CreateMetadataCascadePolicyApplyAsync(string metadataCascadePolicyId, CreateMetadataCascadePolicyApplyRequestBodyArg requestBody, CreateMetadataCascadePolicyApplyHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateMetadataCascadePolicyApplyHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/metadata_cascade_policies/", StringUtils.ToStringRepresentation(metadataCascadePolicyId), "/apply"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

    }
}