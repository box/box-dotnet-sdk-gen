using System.IO;
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
    public class SharedLinksWebLinksManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public SharedLinksWebLinksManager() {
            
        }
        public async System.Threading.Tasks.Task<WebLink> GetSharedItemWebLinks(GetSharedItemWebLinksHeadersArg headers, GetSharedItemWebLinksQueryParamsArg? queryParams = default) {
            queryParams = queryParams ?? new GetSharedItemWebLinksQueryParamsArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() { { "if-none-match", Utils.ToString(headers.IfNoneMatch) }, { "boxapi", Utils.ToString(headers.Boxapi) } }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/shared_items#web_links"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<WebLink>(response.Text);
        }

        public async System.Threading.Tasks.Task<WebLink> GetWebLinkGetSharedLink(string webLinkId, GetWebLinkGetSharedLinkQueryParamsArg queryParams, GetWebLinkGetSharedLinkHeadersArg? headers = default) {
            headers = headers ?? new GetWebLinkGetSharedLinkHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/web_links/", webLinkId, "#get_shared_link"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<WebLink>(response.Text);
        }

        public async System.Threading.Tasks.Task<WebLink> UpdateWebLinkAddSharedLink(string webLinkId, UpdateWebLinkAddSharedLinkQueryParamsArg queryParams, UpdateWebLinkAddSharedLinkRequestBodyArg? requestBody = default, UpdateWebLinkAddSharedLinkHeadersArg? headers = default) {
            requestBody = requestBody ?? new UpdateWebLinkAddSharedLinkRequestBodyArg();
            headers = headers ?? new UpdateWebLinkAddSharedLinkHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/web_links/", webLinkId, "#add_shared_link"), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<WebLink>(response.Text);
        }

        public async System.Threading.Tasks.Task<WebLink> UpdateWebLinkUpdateSharedLink(string webLinkId, UpdateWebLinkUpdateSharedLinkQueryParamsArg queryParams, UpdateWebLinkUpdateSharedLinkRequestBodyArg? requestBody = default, UpdateWebLinkUpdateSharedLinkHeadersArg? headers = default) {
            requestBody = requestBody ?? new UpdateWebLinkUpdateSharedLinkRequestBodyArg();
            headers = headers ?? new UpdateWebLinkUpdateSharedLinkHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/web_links/", webLinkId, "#update_shared_link"), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<WebLink>(response.Text);
        }

        public async System.Threading.Tasks.Task<WebLink> UpdateWebLinkRemoveSharedLink(string webLinkId, UpdateWebLinkRemoveSharedLinkQueryParamsArg queryParams, UpdateWebLinkRemoveSharedLinkRequestBodyArg? requestBody = default, UpdateWebLinkRemoveSharedLinkHeadersArg? headers = default) {
            requestBody = requestBody ?? new UpdateWebLinkRemoveSharedLinkRequestBodyArg();
            headers = headers ?? new UpdateWebLinkRemoveSharedLinkHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/web_links/", webLinkId, "#remove_shared_link"), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<WebLink>(response.Text);
        }

    }
}