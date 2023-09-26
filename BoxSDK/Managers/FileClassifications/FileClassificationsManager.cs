using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using DictionaryExtensions;
using StringExtensions;
using Fetch;
using Serializer;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class FileClassificationsManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public FileClassificationsManager() {
            
        }
        public async System.Threading.Tasks.Task<Classification> GetFileMetadataEnterpriseSecurityClassification6VmVochwUWo(string fileId, GetFileMetadataEnterpriseSecurityClassification6VmVochwUWoHeadersArg? headers = default) {
            headers = headers ?? new GetFileMetadataEnterpriseSecurityClassification6VmVochwUWoHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", StringUtils.ToStringRepresentation(fileId), "/metadata/enterprise/securityClassification-6VMVochwUWo"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Classification>(response.Text);
        }

        public async System.Threading.Tasks.Task<Classification> CreateFileMetadataEnterpriseSecurityClassification(string fileId, CreateFileMetadataEnterpriseSecurityClassificationRequestBodyArg? requestBody = default, CreateFileMetadataEnterpriseSecurityClassificationHeadersArg? headers = default) {
            requestBody = requestBody ?? new CreateFileMetadataEnterpriseSecurityClassificationRequestBodyArg();
            headers = headers ?? new CreateFileMetadataEnterpriseSecurityClassificationHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", StringUtils.ToStringRepresentation(fileId), "/metadata/enterprise/securityClassification-6VMVochwUWo"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Classification>(response.Text);
        }

        public async System.Threading.Tasks.Task<Classification> UpdateFileMetadataEnterpriseSecurityClassification(string fileId, IReadOnlyList<UpdateFileMetadataEnterpriseSecurityClassificationRequestBodyArg> requestBody, UpdateFileMetadataEnterpriseSecurityClassificationHeadersArg? headers = default) {
            headers = headers ?? new UpdateFileMetadataEnterpriseSecurityClassificationHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", StringUtils.ToStringRepresentation(fileId), "/metadata/enterprise/securityClassification-6VMVochwUWo"), new FetchOptions(method: "PUT", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json-patch+json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Classification>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteFileMetadataEnterpriseSecurityClassification(string fileId, DeleteFileMetadataEnterpriseSecurityClassificationHeadersArg? headers = default) {
            headers = headers ?? new DeleteFileMetadataEnterpriseSecurityClassificationHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", StringUtils.ToStringRepresentation(fileId), "/metadata/enterprise/securityClassification-6VMVochwUWo"), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

    }
}