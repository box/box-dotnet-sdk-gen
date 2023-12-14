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
        /// Headers of getSharedItemWebLinks method
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of getSharedItemWebLinks method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<WebLink> GetSharedItemWebLinksAsync(GetSharedItemWebLinksHeaders headers, GetSharedItemWebLinksQueryParams? queryParams = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetSharedItemWebLinksQueryParams();
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
        /// Query parameters of getWebLinkGetSharedLink method
        /// </param>
        /// <param name="headers">
        /// Headers of getWebLinkGetSharedLink method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<WebLink> GetWebLinkGetSharedLinkAsync(string webLinkId, GetWebLinkGetSharedLinkQueryParams queryParams, GetWebLinkGetSharedLinkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetWebLinkGetSharedLinkHeaders();
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
        /// Query parameters of updateWebLinkAddSharedLink method
        /// </param>
        /// <param name="requestBody">
        /// Request body of updateWebLinkAddSharedLink method
        /// </param>
        /// <param name="headers">
        /// Headers of updateWebLinkAddSharedLink method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<WebLink> UpdateWebLinkAddSharedLinkAsync(string webLinkId, UpdateWebLinkAddSharedLinkQueryParams queryParams, UpdateWebLinkAddSharedLinkRequestBody? requestBody = default, UpdateWebLinkAddSharedLinkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            requestBody = requestBody ?? new UpdateWebLinkAddSharedLinkRequestBody();
            headers = headers ?? new UpdateWebLinkAddSharedLinkHeaders();
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
        /// Query parameters of updateWebLinkUpdateSharedLink method
        /// </param>
        /// <param name="requestBody">
        /// Request body of updateWebLinkUpdateSharedLink method
        /// </param>
        /// <param name="headers">
        /// Headers of updateWebLinkUpdateSharedLink method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<WebLink> UpdateWebLinkUpdateSharedLinkAsync(string webLinkId, UpdateWebLinkUpdateSharedLinkQueryParams queryParams, UpdateWebLinkUpdateSharedLinkRequestBody? requestBody = default, UpdateWebLinkUpdateSharedLinkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            requestBody = requestBody ?? new UpdateWebLinkUpdateSharedLinkRequestBody();
            headers = headers ?? new UpdateWebLinkUpdateSharedLinkHeaders();
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
        /// Query parameters of updateWebLinkRemoveSharedLink method
        /// </param>
        /// <param name="requestBody">
        /// Request body of updateWebLinkRemoveSharedLink method
        /// </param>
        /// <param name="headers">
        /// Headers of updateWebLinkRemoveSharedLink method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<WebLink> UpdateWebLinkRemoveSharedLinkAsync(string webLinkId, UpdateWebLinkRemoveSharedLinkQueryParams queryParams, UpdateWebLinkRemoveSharedLinkRequestBody? requestBody = default, UpdateWebLinkRemoveSharedLinkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            requestBody = requestBody ?? new UpdateWebLinkRemoveSharedLinkRequestBody();
            headers = headers ?? new UpdateWebLinkRemoveSharedLinkHeaders();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/web_links/", StringUtils.ToStringRepresentation(webLinkId), "#remove_shared_link"), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<WebLink>(response.Data);
        }

    }
}