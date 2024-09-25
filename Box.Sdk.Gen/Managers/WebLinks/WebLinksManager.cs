using System.Text.Json.Serialization;
using System.Collections.Generic;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen;
using System.Collections.ObjectModel;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class WebLinksManager : IWebLinksManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public WebLinksManager(NetworkSession? networkSession = default) {
            NetworkSession = networkSession ?? new NetworkSession();
        }
        /// <summary>
        /// Creates a web link object within a folder.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createWebLink method
        /// </param>
        /// <param name="headers">
        /// Headers of createWebLink method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<WebLink> CreateWebLinkAsync(CreateWebLinkRequestBody requestBody, CreateWebLinkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateWebLinkHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(new FetchOptions(url: string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/web_links"), networkSession: this.NetworkSession) { Method = "POST", Headers = headersMap, Data = SimpleJsonSerializer.Serialize(requestBody), ContentType = "application/json", ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<WebLink>(response.Data);
        }

        /// <summary>
        /// Retrieve information about a web link.
        /// </summary>
        /// <param name="webLinkId">
        /// The ID of the web link.
        /// Example: "12345"
        /// </param>
        /// <param name="headers">
        /// Headers of getWebLinkById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<WebLink> GetWebLinkByIdAsync(string webLinkId, GetWebLinkByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetWebLinkByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() { { "boxapi", StringUtils.ToStringRepresentation(headers.Boxapi) } }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(new FetchOptions(url: string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/web_links/", StringUtils.ToStringRepresentation(webLinkId)), networkSession: this.NetworkSession) { Method = "GET", Headers = headersMap, ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<WebLink>(response.Data);
        }

        /// <summary>
        /// Updates a web link object.
        /// </summary>
        /// <param name="webLinkId">
        /// The ID of the web link.
        /// Example: "12345"
        /// </param>
        /// <param name="requestBody">
        /// Request body of updateWebLinkById method
        /// </param>
        /// <param name="headers">
        /// Headers of updateWebLinkById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<WebLink> UpdateWebLinkByIdAsync(string webLinkId, UpdateWebLinkByIdRequestBody? requestBody = default, UpdateWebLinkByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            requestBody = requestBody ?? new UpdateWebLinkByIdRequestBody();
            headers = headers ?? new UpdateWebLinkByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(new FetchOptions(url: string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/web_links/", StringUtils.ToStringRepresentation(webLinkId)), networkSession: this.NetworkSession) { Method = "PUT", Headers = headersMap, Data = SimpleJsonSerializer.Serialize(requestBody), ContentType = "application/json", ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<WebLink>(response.Data);
        }

        /// <summary>
        /// Deletes a web link.
        /// </summary>
        /// <param name="webLinkId">
        /// The ID of the web link.
        /// Example: "12345"
        /// </param>
        /// <param name="headers">
        /// Headers of deleteWebLinkById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteWebLinkByIdAsync(string webLinkId, DeleteWebLinkByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteWebLinkByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(new FetchOptions(url: string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/web_links/", StringUtils.ToStringRepresentation(webLinkId)), networkSession: this.NetworkSession) { Method = "DELETE", Headers = headersMap, ResponseFormat = null, Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
        }

    }
}