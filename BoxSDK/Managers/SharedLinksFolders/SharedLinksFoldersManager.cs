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
    public class SharedLinksFoldersManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public SharedLinksFoldersManager() {
            
        }
        public async System.Threading.Tasks.Task<FolderFull> GetSharedItemFolders(GetSharedItemFoldersHeadersArg headers, GetSharedItemFoldersQueryParamsArg? queryParams = default) {
            queryParams = queryParams ?? new GetSharedItemFoldersQueryParamsArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() { { "if-none-match", StringUtils.ToStringRepresentation(headers.IfNoneMatch) }, { "boxapi", StringUtils.ToStringRepresentation(headers.Boxapi) } }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/shared_items#folders"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FolderFull>(response.Text);
        }

        public async System.Threading.Tasks.Task<FolderFull> GetFolderGetSharedLink(string folderId, GetFolderGetSharedLinkQueryParamsArg queryParams, GetFolderGetSharedLinkHeadersArg? headers = default) {
            headers = headers ?? new GetFolderGetSharedLinkHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders/", StringUtils.ToStringRepresentation(folderId), "#get_shared_link"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FolderFull>(response.Text);
        }

        public async System.Threading.Tasks.Task<FolderFull> UpdateFolderAddSharedLink(string folderId, UpdateFolderAddSharedLinkQueryParamsArg queryParams, UpdateFolderAddSharedLinkRequestBodyArg? requestBody = default, UpdateFolderAddSharedLinkHeadersArg? headers = default) {
            requestBody = requestBody ?? new UpdateFolderAddSharedLinkRequestBodyArg();
            headers = headers ?? new UpdateFolderAddSharedLinkHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders/", StringUtils.ToStringRepresentation(folderId), "#add_shared_link"), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FolderFull>(response.Text);
        }

        public async System.Threading.Tasks.Task<FolderFull> UpdateFolderUpdateSharedLink(string folderId, UpdateFolderUpdateSharedLinkQueryParamsArg queryParams, UpdateFolderUpdateSharedLinkRequestBodyArg? requestBody = default, UpdateFolderUpdateSharedLinkHeadersArg? headers = default) {
            requestBody = requestBody ?? new UpdateFolderUpdateSharedLinkRequestBodyArg();
            headers = headers ?? new UpdateFolderUpdateSharedLinkHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders/", StringUtils.ToStringRepresentation(folderId), "#update_shared_link"), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FolderFull>(response.Text);
        }

        public async System.Threading.Tasks.Task<FolderFull> UpdateFolderRemoveSharedLink(string folderId, UpdateFolderRemoveSharedLinkQueryParamsArg queryParams, UpdateFolderRemoveSharedLinkRequestBodyArg? requestBody = default, UpdateFolderRemoveSharedLinkHeadersArg? headers = default) {
            requestBody = requestBody ?? new UpdateFolderRemoveSharedLinkRequestBodyArg();
            headers = headers ?? new UpdateFolderRemoveSharedLinkHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders/", StringUtils.ToStringRepresentation(folderId), "#remove_shared_link"), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FolderFull>(response.Text);
        }

    }
}