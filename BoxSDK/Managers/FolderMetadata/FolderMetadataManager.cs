using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using DictionaryExtensions;
using Fetch;
using Serializer;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class FolderMetadataManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public FolderMetadataManager() {
            
        }
        public async System.Threading.Tasks.Task<Metadatas> GetFolderMetadata(string folderId, GetFolderMetadataHeadersArg? headers = default) {
            headers = headers ?? new GetFolderMetadataHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders/", folderId, "/metadata"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Metadatas>(response.Text);
        }

        public async System.Threading.Tasks.Task<MetadataFull> GetFolderMetadataById(string folderId, GetFolderMetadataByIdScopeArg scope, string templateKey, GetFolderMetadataByIdHeadersArg? headers = default) {
            headers = headers ?? new GetFolderMetadataByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders/", folderId, "/metadata/", scope, "/", templateKey), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<MetadataFull>(response.Text);
        }

        public async System.Threading.Tasks.Task<Metadata> CreateFolderMetadataById(string folderId, CreateFolderMetadataByIdScopeArg scope, string templateKey, CreateFolderMetadataByIdRequestBodyArg requestBody, CreateFolderMetadataByIdHeadersArg? headers = default) {
            headers = headers ?? new CreateFolderMetadataByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders/", folderId, "/metadata/", scope, "/", templateKey), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Metadata>(response.Text);
        }

        public async System.Threading.Tasks.Task<Metadata> UpdateFolderMetadataById(string folderId, UpdateFolderMetadataByIdScopeArg scope, string templateKey, IReadOnlyList<UpdateFolderMetadataByIdRequestBodyArg> requestBody, UpdateFolderMetadataByIdHeadersArg? headers = default) {
            headers = headers ?? new UpdateFolderMetadataByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders/", folderId, "/metadata/", scope, "/", templateKey), new FetchOptions(method: "PUT", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json-patch+json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Metadata>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteFolderMetadataById(string folderId, DeleteFolderMetadataByIdScopeArg scope, string templateKey, DeleteFolderMetadataByIdHeadersArg? headers = default) {
            headers = headers ?? new DeleteFolderMetadataByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders/", folderId, "/metadata/", scope, "/", templateKey), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

    }
}