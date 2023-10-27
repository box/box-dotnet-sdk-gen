using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using StringExtensions;
using DictionaryExtensions;
using Serializer;
using Fetch;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class TrashedWebLinksManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public TrashedWebLinksManager() {
            
        }
        /// <summary>
        /// Restores a web link that has been moved to the trash.
        /// 
        /// An optional new parent ID can be provided to restore the  web link to in case
        /// the original folder has been deleted.
        /// </summary>
        /// <param name="webLinkId">
        /// The ID of the web link.
        /// Example: "12345"
        /// </param>
        /// <param name="requestBody">
        /// Request body of restoreWeblinkFromTrash method
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of restoreWeblinkFromTrash method
        /// </param>
        /// <param name="headers">
        /// Headers of restoreWeblinkFromTrash method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<TrashWebLinkRestored> RestoreWeblinkFromTrashAsync(string webLinkId, RestoreWeblinkFromTrashRequestBodyArg? requestBody = default, RestoreWeblinkFromTrashQueryParamsArg? queryParams = default, RestoreWeblinkFromTrashHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            requestBody = requestBody ?? new RestoreWeblinkFromTrashRequestBodyArg();
            queryParams = queryParams ?? new RestoreWeblinkFromTrashQueryParamsArg();
            headers = headers ?? new RestoreWeblinkFromTrashHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/web_links/", StringUtils.ToStringRepresentation(webLinkId)), new FetchOptions(method: "POST", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<TrashWebLinkRestored>(response.Text);
        }

        /// <summary>
        /// Retrieves a web link that has been moved to the trash.
        /// </summary>
        /// <param name="webLinkId">
        /// The ID of the web link.
        /// Example: "12345"
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of getWebLinkTrash method
        /// </param>
        /// <param name="headers">
        /// Headers of getWebLinkTrash method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<TrashWebLink> GetWebLinkTrashAsync(string webLinkId, GetWebLinkTrashQueryParamsArg? queryParams = default, GetWebLinkTrashHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetWebLinkTrashQueryParamsArg();
            headers = headers ?? new GetWebLinkTrashHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/web_links/", StringUtils.ToStringRepresentation(webLinkId), "/trash"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<TrashWebLink>(response.Text);
        }

        /// <summary>
        /// Permanently deletes a web link that is in the trash.
        /// This action cannot be undone.
        /// </summary>
        /// <param name="webLinkId">
        /// The ID of the web link.
        /// Example: "12345"
        /// </param>
        /// <param name="headers">
        /// Headers of deleteWebLinkTrash method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteWebLinkTrashAsync(string webLinkId, DeleteWebLinkTrashHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteWebLinkTrashHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/web_links/", StringUtils.ToStringRepresentation(webLinkId), "/trash"), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

    }
}