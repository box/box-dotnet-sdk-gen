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
    public class SharedLinksWebLinksManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public SharedLinksWebLinksManager() {
            
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
        public async System.Threading.Tasks.Task<WebLink> GetSharedItemWebLinksAsync(GetSharedItemWebLinksHeadersArg headers, GetSharedItemWebLinksQueryParamsArg? queryParams = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetSharedItemWebLinksQueryParamsArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() { { "if-none-match", StringUtils.ToStringRepresentation(headers.IfNoneMatch) }, { "boxapi", StringUtils.ToStringRepresentation(headers.Boxapi) } }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/shared_items#web_links"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
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
        public async System.Threading.Tasks.Task<WebLink> GetWebLinkGetSharedLinkAsync(string webLinkId, GetWebLinkGetSharedLinkQueryParamsArg queryParams, GetWebLinkGetSharedLinkHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetWebLinkGetSharedLinkHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/web_links/", StringUtils.ToStringRepresentation(webLinkId), "#get_shared_link"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
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
        public async System.Threading.Tasks.Task<WebLink> UpdateWebLinkAddSharedLinkAsync(string webLinkId, UpdateWebLinkAddSharedLinkQueryParamsArg queryParams, UpdateWebLinkAddSharedLinkRequestBodyArg? requestBody = default, UpdateWebLinkAddSharedLinkHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            requestBody = requestBody ?? new UpdateWebLinkAddSharedLinkRequestBodyArg();
            headers = headers ?? new UpdateWebLinkAddSharedLinkHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/web_links/", StringUtils.ToStringRepresentation(webLinkId), "#add_shared_link"), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
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
        public async System.Threading.Tasks.Task<WebLink> UpdateWebLinkUpdateSharedLinkAsync(string webLinkId, UpdateWebLinkUpdateSharedLinkQueryParamsArg queryParams, UpdateWebLinkUpdateSharedLinkRequestBodyArg? requestBody = default, UpdateWebLinkUpdateSharedLinkHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            requestBody = requestBody ?? new UpdateWebLinkUpdateSharedLinkRequestBodyArg();
            headers = headers ?? new UpdateWebLinkUpdateSharedLinkHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/web_links/", StringUtils.ToStringRepresentation(webLinkId), "#update_shared_link"), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
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
        public async System.Threading.Tasks.Task<WebLink> UpdateWebLinkRemoveSharedLinkAsync(string webLinkId, UpdateWebLinkRemoveSharedLinkQueryParamsArg queryParams, UpdateWebLinkRemoveSharedLinkRequestBodyArg? requestBody = default, UpdateWebLinkRemoveSharedLinkHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            requestBody = requestBody ?? new UpdateWebLinkRemoveSharedLinkRequestBodyArg();
            headers = headers ?? new UpdateWebLinkRemoveSharedLinkHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/web_links/", StringUtils.ToStringRepresentation(webLinkId), "#remove_shared_link"), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<WebLink>(response.Data);
        }

    }
}