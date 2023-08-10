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
    public class FolderClassificationsManager {
        public IAuth Auth { get; }

        public NetworkSession NetworkSession { get; }

        public FolderClassificationsManager(IAuth auth, NetworkSession networkSession) {
            Auth = auth;
            NetworkSession = networkSession;
        }
        public async System.Threading.Tasks.Task<Classification> GetFolderMetadataEnterpriseSecurityClassification6VmVochwUWo(string folderId, GetFolderMetadataEnterpriseSecurityClassification6VmVochwUWoHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders/", folderId, "/metadata/enterprise/securityClassification-6VMVochwUWo"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Classification>(response.Text);
        }

        public async System.Threading.Tasks.Task<Classification> CreateFolderMetadataEnterpriseSecurityClassification(string folderId, CreateFolderMetadataEnterpriseSecurityClassificationRequestBodyArg requestBody, CreateFolderMetadataEnterpriseSecurityClassificationHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders/", folderId, "/metadata/enterprise/securityClassification-6VMVochwUWo"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Classification>(response.Text);
        }

        public async System.Threading.Tasks.Task<Classification> UpdateFolderMetadataEnterpriseSecurityClassification(string folderId, IReadOnlyList<UpdateFolderMetadataEnterpriseSecurityClassificationRequestBodyArg> requestBody, UpdateFolderMetadataEnterpriseSecurityClassificationHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders/", folderId, "/metadata/enterprise/securityClassification-6VMVochwUWo"), new FetchOptions(method: "PUT", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json-patch+json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Classification>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteFolderMetadataEnterpriseSecurityClassification(string folderId, DeleteFolderMetadataEnterpriseSecurityClassificationHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders/", folderId, "/metadata/enterprise/securityClassification-6VMVochwUWo"), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

    }
}