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
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public FolderClassificationsManager() {
            
        }
        public async System.Threading.Tasks.Task<Classification> GetFolderMetadataEnterpriseSecurityClassification6VmVochwUWo(string folderId, GetFolderMetadataEnterpriseSecurityClassification6VmVochwUWoHeadersArg? headers = default) {
            headers = headers ?? new GetFolderMetadataEnterpriseSecurityClassification6VmVochwUWoHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders/", folderId, "/metadata/enterprise/securityClassification-6VMVochwUWo"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Classification>(response.Text);
        }

        public async System.Threading.Tasks.Task<Classification> CreateFolderMetadataEnterpriseSecurityClassification(string folderId, CreateFolderMetadataEnterpriseSecurityClassificationRequestBodyArg? requestBody = default, CreateFolderMetadataEnterpriseSecurityClassificationHeadersArg? headers = default) {
            requestBody = requestBody ?? new CreateFolderMetadataEnterpriseSecurityClassificationRequestBodyArg();
            headers = headers ?? new CreateFolderMetadataEnterpriseSecurityClassificationHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders/", folderId, "/metadata/enterprise/securityClassification-6VMVochwUWo"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Classification>(response.Text);
        }

        public async System.Threading.Tasks.Task<Classification> UpdateFolderMetadataEnterpriseSecurityClassification(string folderId, IReadOnlyList<UpdateFolderMetadataEnterpriseSecurityClassificationRequestBodyArg> requestBody, UpdateFolderMetadataEnterpriseSecurityClassificationHeadersArg? headers = default) {
            headers = headers ?? new UpdateFolderMetadataEnterpriseSecurityClassificationHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders/", folderId, "/metadata/enterprise/securityClassification-6VMVochwUWo"), new FetchOptions(method: "PUT", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json-patch+json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Classification>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteFolderMetadataEnterpriseSecurityClassification(string folderId, DeleteFolderMetadataEnterpriseSecurityClassificationHeadersArg? headers = default) {
            headers = headers ?? new DeleteFolderMetadataEnterpriseSecurityClassificationHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders/", folderId, "/metadata/enterprise/securityClassification-6VMVochwUWo"), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

    }
}