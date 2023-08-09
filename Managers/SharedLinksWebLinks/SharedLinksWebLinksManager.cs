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
        public IAuth Auth { get; }

        public NetworkSession NetworkSession { get; }

        public SharedLinksWebLinksManager(IAuth auth, NetworkSession networkSession) {
            Auth = auth;
            NetworkSession = networkSession;
        }
        public async System.Threading.Tasks.Task<WebLink> GetSharedItemWebLinks(GetSharedItemWebLinksQueryParamsArg queryParams, GetSharedItemWebLinksHeadersArg headers) {
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() { { "if-none-match", Utils.ToString(headers.IfNoneMatch) }, { "boxapi", Utils.ToString(headers.Boxapi) } }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/shared_items#web_links"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<WebLink>(response.Text);
        }

        public async System.Threading.Tasks.Task<WebLink> GetWebLinkGetSharedLink(string webLinkId, GetWebLinkGetSharedLinkQueryParamsArg queryParams, GetWebLinkGetSharedLinkHeadersArg headers) {
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/web_links/", webLinkId, "#get_shared_link"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<WebLink>(response.Text);
        }

        public async System.Threading.Tasks.Task<WebLink> UpdateWebLinkAddSharedLink(string webLinkId, UpdateWebLinkAddSharedLinkRequestBodyArg requestBody, UpdateWebLinkAddSharedLinkQueryParamsArg queryParams, UpdateWebLinkAddSharedLinkHeadersArg headers) {
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/web_links/", webLinkId, "#add_shared_link"), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<WebLink>(response.Text);
        }

        public async System.Threading.Tasks.Task<WebLink> UpdateWebLinkUpdateSharedLink(string webLinkId, UpdateWebLinkUpdateSharedLinkRequestBodyArg requestBody, UpdateWebLinkUpdateSharedLinkQueryParamsArg queryParams, UpdateWebLinkUpdateSharedLinkHeadersArg headers) {
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/web_links/", webLinkId, "#update_shared_link"), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<WebLink>(response.Text);
        }

        public async System.Threading.Tasks.Task<WebLink> UpdateWebLinkRemoveSharedLink(string webLinkId, UpdateWebLinkRemoveSharedLinkRequestBodyArg requestBody, UpdateWebLinkRemoveSharedLinkQueryParamsArg queryParams, UpdateWebLinkRemoveSharedLinkHeadersArg headers) {
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/web_links/", webLinkId, "#remove_shared_link"), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<WebLink>(response.Text);
        }

    }
}