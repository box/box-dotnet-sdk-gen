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
    public class SharedLinksFoldersManager {
        public IAuth Auth { get; }

        public NetworkSession NetworkSession { get; }

        public SharedLinksFoldersManager(IAuth auth, NetworkSession networkSession) {
            Auth = auth;
            NetworkSession = networkSession;
        }
        public async System.Threading.Tasks.Task<FolderFull> GetSharedItemFolders(GetSharedItemFoldersQueryParamsArg queryParams, GetSharedItemFoldersHeadersArg headers) {
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() { { "if-none-match", Utils.ToString(headers.IfNoneMatch) }, { "boxapi", Utils.ToString(headers.Boxapi) } }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/shared_items#folders"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FolderFull>(response.Text);
        }

        public async System.Threading.Tasks.Task<FolderFull> GetFolderGetSharedLink(string folderId, GetFolderGetSharedLinkQueryParamsArg queryParams, GetFolderGetSharedLinkHeadersArg headers) {
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders/", folderId, "#get_shared_link"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FolderFull>(response.Text);
        }

        public async System.Threading.Tasks.Task<FolderFull> UpdateFolderAddSharedLink(string folderId, UpdateFolderAddSharedLinkRequestBodyArg requestBody, UpdateFolderAddSharedLinkQueryParamsArg queryParams, UpdateFolderAddSharedLinkHeadersArg headers) {
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders/", folderId, "#add_shared_link"), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FolderFull>(response.Text);
        }

        public async System.Threading.Tasks.Task<FolderFull> UpdateFolderUpdateSharedLink(string folderId, UpdateFolderUpdateSharedLinkRequestBodyArg requestBody, UpdateFolderUpdateSharedLinkQueryParamsArg queryParams, UpdateFolderUpdateSharedLinkHeadersArg headers) {
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders/", folderId, "#update_shared_link"), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FolderFull>(response.Text);
        }

        public async System.Threading.Tasks.Task<FolderFull> UpdateFolderRemoveSharedLink(string folderId, UpdateFolderRemoveSharedLinkRequestBodyArg requestBody, UpdateFolderRemoveSharedLinkQueryParamsArg queryParams, UpdateFolderRemoveSharedLinkHeadersArg headers) {
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders/", folderId, "#remove_shared_link"), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FolderFull>(response.Text);
        }

    }
}