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
        public async System.Threading.Tasks.Task<TrashWebLinkRestored> CreateWebLinkById(string webLinkId, CreateWebLinkByIdRequestBodyArg? requestBody = default, CreateWebLinkByIdQueryParamsArg? queryParams = default, CreateWebLinkByIdHeadersArg? headers = default) {
            requestBody = requestBody ?? new CreateWebLinkByIdRequestBodyArg();
            queryParams = queryParams ?? new CreateWebLinkByIdQueryParamsArg();
            headers = headers ?? new CreateWebLinkByIdHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/web_links/", StringUtils.ToStringRepresentation(webLinkId)), new FetchOptions(method: "POST", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<TrashWebLinkRestored>(response.Text);
        }

        public async System.Threading.Tasks.Task<TrashWebLink> GetWebLinkTrash(string webLinkId, GetWebLinkTrashQueryParamsArg? queryParams = default, GetWebLinkTrashHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetWebLinkTrashQueryParamsArg();
            headers = headers ?? new GetWebLinkTrashHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/web_links/", StringUtils.ToStringRepresentation(webLinkId), "/trash"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<TrashWebLink>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteWebLinkTrash(string webLinkId, DeleteWebLinkTrashHeadersArg? headers = default) {
            headers = headers ?? new DeleteWebLinkTrashHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/web_links/", StringUtils.ToStringRepresentation(webLinkId), "/trash"), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

    }
}