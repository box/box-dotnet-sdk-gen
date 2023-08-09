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
    public class FileClassificationsManager {
        public IAuth Auth { get; }

        public NetworkSession NetworkSession { get; }

        public FileClassificationsManager(IAuth auth, NetworkSession networkSession) {
            Auth = auth;
            NetworkSession = networkSession;
        }
        public async System.Threading.Tasks.Task<Classification> GetFileMetadataEnterpriseSecurityClassification6VmVochwUWo(string fileId, GetFileMetadataEnterpriseSecurityClassification6VmVochwUWoHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", fileId, "/metadata/enterprise/securityClassification-6VMVochwUWo"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Classification>(response.Text);
        }

        public async System.Threading.Tasks.Task<Classification> CreateFileMetadataEnterpriseSecurityClassification(string fileId, CreateFileMetadataEnterpriseSecurityClassificationRequestBodyArg requestBody, CreateFileMetadataEnterpriseSecurityClassificationHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", fileId, "/metadata/enterprise/securityClassification-6VMVochwUWo"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Classification>(response.Text);
        }

        public async System.Threading.Tasks.Task<Classification> UpdateFileMetadataEnterpriseSecurityClassification(string fileId, UpdateFileMetadataEnterpriseSecurityClassificationRequestBodyArg requestBody, UpdateFileMetadataEnterpriseSecurityClassificationHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", fileId, "/metadata/enterprise/securityClassification-6VMVochwUWo"), new FetchOptions(method: "PUT", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json-patch+json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Classification>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteFileMetadataEnterpriseSecurityClassification(string fileId, DeleteFileMetadataEnterpriseSecurityClassificationHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", fileId, "/metadata/enterprise/securityClassification-6VMVochwUWo"), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

    }
}