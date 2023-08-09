using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class FoldersManager {
        public IAuth Auth { get; }

        public NetworkSession NetworkSession { get; }

        public FoldersManager(IAuth auth, NetworkSession networkSession) {
            Auth = auth;
            NetworkSession = networkSession;
        }
        public async System.Threading.Tasks.Task<FolderFull> GetFolderById(string folderId, GetFolderByIdQueryParamsArg queryParams, GetFolderByIdHeadersArg headers) {
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string>() { { "fields", Utils.ToString(queryParams.Fields) }, { "sort", Utils.ToString(queryParams.Sort) }, { "direction", Utils.ToString(queryParams.Direction) }, { "offset", Utils.ToString(queryParams.Offset) }, { "limit", Utils.ToString(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() { { "if-none-match", Utils.ToString(headers.IfNoneMatch) }, { "boxapi", Utils.ToString(headers.Boxapi) } }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders/", folderId), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FolderFull>(response.Text);
        }

        public async System.Threading.Tasks.Task<FolderFull> UpdateFolderById(string folderId, UpdateFolderByIdRequestBodyArg requestBody, UpdateFolderByIdQueryParamsArg queryParams, UpdateFolderByIdHeadersArg headers) {
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() { { "if-match", Utils.ToString(headers.IfMatch) } }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders/", folderId), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FolderFull>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteFolderById(string folderId, DeleteFolderByIdQueryParamsArg queryParams, DeleteFolderByIdHeadersArg headers) {
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string>() { { "recursive", Utils.ToString(queryParams.Recursive) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() { { "if-match", Utils.ToString(headers.IfMatch) } }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders/", folderId), new FetchOptions(method: "DELETE", parameters: queryParamsMap, headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

        public async System.Threading.Tasks.Task<Items> GetFolderItems(string folderId, GetFolderItemsQueryParamsArg queryParams, GetFolderItemsHeadersArg headers) {
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string>() { { "fields", Utils.ToString(queryParams.Fields) }, { "usemarker", Utils.ToString(queryParams.Usemarker) }, { "marker", Utils.ToString(queryParams.Marker) }, { "offset", Utils.ToString(queryParams.Offset) }, { "limit", Utils.ToString(queryParams.Limit) }, { "sort", Utils.ToString(queryParams.Sort) }, { "direction", Utils.ToString(queryParams.Direction) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() { { "boxapi", Utils.ToString(headers.Boxapi) } }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders/", folderId, "/items"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Items>(response.Text);
        }

        public async System.Threading.Tasks.Task<FolderFull> CreateFolder(CreateFolderRequestBodyArg requestBody, CreateFolderQueryParamsArg queryParams, CreateFolderHeadersArg headers) {
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders"), new FetchOptions(method: "POST", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FolderFull>(response.Text);
        }

        public async System.Threading.Tasks.Task<FolderFull> CopyFolder(string folderId, CopyFolderRequestBodyArg requestBody, CopyFolderQueryParamsArg queryParams, CopyFolderHeadersArg headers) {
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders/", folderId, "/copy"), new FetchOptions(method: "POST", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FolderFull>(response.Text);
        }

    }
}