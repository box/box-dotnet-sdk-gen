using System.IO;
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
    public class FileMetadataManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public FileMetadataManager() {
            
        }
        public async System.Threading.Tasks.Task<Metadatas> GetFileMetadata(string fileId, GetFileMetadataHeadersArg? headers = default) {
            headers = headers ?? new GetFileMetadataHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", fileId, "/metadata"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Metadatas>(response.Text);
        }

        public async System.Threading.Tasks.Task<MetadataFull> GetFileMetadataById(string fileId, GetFileMetadataByIdScopeArg scope, string templateKey, GetFileMetadataByIdHeadersArg? headers = default) {
            headers = headers ?? new GetFileMetadataByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", fileId, "/metadata/", scope, "/", templateKey), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<MetadataFull>(response.Text);
        }

        public async System.Threading.Tasks.Task<Metadata> CreateFileMetadataById(string fileId, CreateFileMetadataByIdScopeArg scope, string templateKey, CreateFileMetadataByIdRequestBodyArg requestBody, CreateFileMetadataByIdHeadersArg? headers = default) {
            headers = headers ?? new CreateFileMetadataByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", fileId, "/metadata/", scope, "/", templateKey), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Metadata>(response.Text);
        }

        public async System.Threading.Tasks.Task<Metadata> UpdateFileMetadataById(string fileId, UpdateFileMetadataByIdScopeArg scope, string templateKey, IReadOnlyList<UpdateFileMetadataByIdRequestBodyArg> requestBody, UpdateFileMetadataByIdHeadersArg? headers = default) {
            headers = headers ?? new UpdateFileMetadataByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", fileId, "/metadata/", scope, "/", templateKey), new FetchOptions(method: "PUT", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json-patch+json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Metadata>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteFileMetadataById(string fileId, DeleteFileMetadataByIdScopeArg scope, string templateKey, DeleteFileMetadataByIdHeadersArg? headers = default) {
            headers = headers ?? new DeleteFileMetadataByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", fileId, "/metadata/", scope, "/", templateKey), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

    }
}