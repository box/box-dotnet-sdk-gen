using System.Text.Json.Serialization;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DictionaryExtensions;
using Serializer;
using Fetch;
using StringExtensions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class WebLinksManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public WebLinksManager() {
            
        }
        public async System.Threading.Tasks.Task<WebLink> CreateWebLink(CreateWebLinkRequestBodyArg requestBody, CreateWebLinkHeadersArg? headers = default) {
            headers = headers ?? new CreateWebLinkHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/web_links"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<WebLink>(response.Text);
        }

        public async System.Threading.Tasks.Task<WebLink> GetWebLinkById(string webLinkId, GetWebLinkByIdHeadersArg? headers = default) {
            headers = headers ?? new GetWebLinkByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() { { "boxapi", StringUtils.ToStringRepresentation(headers.Boxapi) } }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/web_links/", StringUtils.ToStringRepresentation(webLinkId)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<WebLink>(response.Text);
        }

        public async System.Threading.Tasks.Task<WebLink> UpdateWebLinkById(string webLinkId, UpdateWebLinkByIdRequestBodyArg? requestBody = default, UpdateWebLinkByIdHeadersArg? headers = default) {
            requestBody = requestBody ?? new UpdateWebLinkByIdRequestBodyArg();
            headers = headers ?? new UpdateWebLinkByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/web_links/", StringUtils.ToStringRepresentation(webLinkId)), new FetchOptions(method: "PUT", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<WebLink>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteWebLinkById(string webLinkId, DeleteWebLinkByIdHeadersArg? headers = default) {
            headers = headers ?? new DeleteWebLinkByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/web_links/", StringUtils.ToStringRepresentation(webLinkId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

    }
}