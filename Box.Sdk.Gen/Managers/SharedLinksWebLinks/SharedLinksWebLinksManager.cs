using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using StringExtensions;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class SharedLinksWebLinksManager : ISharedLinksWebLinksManager {
        public IAuthentication? Auth { get; set; } = default;

        public NetworkSession NetworkSession { get; set; }

        public SharedLinksWebLinksManager(NetworkSession networkSession = default) {
            NetworkSession = networkSession ?? new NetworkSession();
        }
        /// <summary>
        /// Returns the web link represented by a shared link.
        /// 
        /// A shared web link can be represented by a shared link,
        /// which can originate within the current enterprise or within another.
        /// 
        /// This endpoint allows an application to retrieve information about a
        /// shared web link when only given a shared link.
        /// </summary>
        /// <param name="headers">
        /// Headers of findWebLinkForSharedLink method
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of findWebLinkForSharedLink method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<WebLink> FindWebLinkForSharedLinkAsync(FindWebLinkForSharedLinkHeaders headers, FindWebLinkForSharedLinkQueryParams? queryParams = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new FindWebLinkForSharedLinkQueryParams();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() { { "if-none-match", StringUtils.ToStringRepresentation(headers.IfNoneMatch) }, { "boxapi", StringUtils.ToStringRepresentation(headers.Boxapi) } }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/shared_items#web_links"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<WebLink>(response.Data);
        }

        /// <summary>
        /// Gets the information for a shared link on a web link.
        /// </summary>
        /// <param name="webLinkId">
        /// The ID of the web link.
        /// Example: "12345"
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of getSharedLinkForWebLink method
        /// </param>
        /// <param name="headers">
        /// Headers of getSharedLinkForWebLink method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<WebLink> GetSharedLinkForWebLinkAsync(string webLinkId, GetSharedLinkForWebLinkQueryParams queryParams, GetSharedLinkForWebLinkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetSharedLinkForWebLinkHeaders();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/web_links/", StringUtils.ToStringRepresentation(webLinkId), "#get_shared_link"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<WebLink>(response.Data);
        }

        /// <summary>
        /// Adds a shared link to a web link.
        /// </summary>
        /// <param name="webLinkId">
        /// The ID of the web link.
        /// Example: "12345"
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of addShareLinkToWebLink method
        /// </param>
        /// <param name="requestBody">
        /// Request body of addShareLinkToWebLink method
        /// </param>
        /// <param name="headers">
        /// Headers of addShareLinkToWebLink method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<WebLink> AddShareLinkToWebLinkAsync(string webLinkId, AddShareLinkToWebLinkQueryParams queryParams, AddShareLinkToWebLinkRequestBody? requestBody = default, AddShareLinkToWebLinkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            requestBody = requestBody ?? new AddShareLinkToWebLinkRequestBody();
            headers = headers ?? new AddShareLinkToWebLinkHeaders();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/web_links/", StringUtils.ToStringRepresentation(webLinkId), "#add_shared_link"), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<WebLink>(response.Data);
        }

        /// <summary>
        /// Updates a shared link on a web link.
        /// </summary>
        /// <param name="webLinkId">
        /// The ID of the web link.
        /// Example: "12345"
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of updateSharedLinkOnWebLink method
        /// </param>
        /// <param name="requestBody">
        /// Request body of updateSharedLinkOnWebLink method
        /// </param>
        /// <param name="headers">
        /// Headers of updateSharedLinkOnWebLink method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<WebLink> UpdateSharedLinkOnWebLinkAsync(string webLinkId, UpdateSharedLinkOnWebLinkQueryParams queryParams, UpdateSharedLinkOnWebLinkRequestBody? requestBody = default, UpdateSharedLinkOnWebLinkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            requestBody = requestBody ?? new UpdateSharedLinkOnWebLinkRequestBody();
            headers = headers ?? new UpdateSharedLinkOnWebLinkHeaders();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/web_links/", StringUtils.ToStringRepresentation(webLinkId), "#update_shared_link"), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<WebLink>(response.Data);
        }

        /// <summary>
        /// Removes a shared link from a web link.
        /// </summary>
        /// <param name="webLinkId">
        /// The ID of the web link.
        /// Example: "12345"
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of removeSharedLinkFromWebLink method
        /// </param>
        /// <param name="requestBody">
        /// Request body of removeSharedLinkFromWebLink method
        /// </param>
        /// <param name="headers">
        /// Headers of removeSharedLinkFromWebLink method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<WebLink> RemoveSharedLinkFromWebLinkAsync(string webLinkId, RemoveSharedLinkFromWebLinkQueryParams queryParams, RemoveSharedLinkFromWebLinkRequestBody? requestBody = default, RemoveSharedLinkFromWebLinkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            requestBody = requestBody ?? new RemoveSharedLinkFromWebLinkRequestBody();
            headers = headers ?? new RemoveSharedLinkFromWebLinkHeaders();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/web_links/", StringUtils.ToStringRepresentation(webLinkId), "#remove_shared_link"), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<WebLink>(response.Data);
        }

    }
}