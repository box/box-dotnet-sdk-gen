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
    public class ClassificationsManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public ClassificationsManager() {
            
        }
        public async System.Threading.Tasks.Task<ClassificationTemplate> GetMetadataTemplateEnterpriseSecurityClassificationSchema(GetMetadataTemplateEnterpriseSecurityClassificationSchemaHeadersArg? headers = default) {
            headers = headers ?? new GetMetadataTemplateEnterpriseSecurityClassificationSchemaHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/metadata_templates/enterprise/securityClassification-6VMVochwUWo/schema"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<ClassificationTemplate>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteMetadataTemplateEnterpriseSecurityClassificationSchema(DeleteMetadataTemplateEnterpriseSecurityClassificationSchemaHeadersArg? headers = default) {
            headers = headers ?? new DeleteMetadataTemplateEnterpriseSecurityClassificationSchemaHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/metadata_templates/enterprise/securityClassification-6VMVochwUWo/schema"), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

        public async System.Threading.Tasks.Task<ClassificationTemplate> UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAdd(IReadOnlyList<UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArg> requestBody, UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddHeadersArg? headers = default) {
            headers = headers ?? new UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/metadata_templates/enterprise/securityClassification-6VMVochwUWo/schema#add"), new FetchOptions(method: "PUT", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json-patch+json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<ClassificationTemplate>(response.Text);
        }

        public async System.Threading.Tasks.Task<ClassificationTemplate> UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaUpdate(IReadOnlyList<UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaUpdateRequestBodyArg> requestBody, UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaUpdateHeadersArg? headers = default) {
            headers = headers ?? new UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaUpdateHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/metadata_templates/enterprise/securityClassification-6VMVochwUWo/schema#update"), new FetchOptions(method: "PUT", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json-patch+json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<ClassificationTemplate>(response.Text);
        }

        public async System.Threading.Tasks.Task<ClassificationTemplate> UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaDelete(IReadOnlyList<UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaDeleteRequestBodyArg> requestBody, UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaDeleteHeadersArg? headers = default) {
            headers = headers ?? new UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaDeleteHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/metadata_templates/enterprise/securityClassification-6VMVochwUWo/schema#delete"), new FetchOptions(method: "PUT", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json-patch+json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<ClassificationTemplate>(response.Text);
        }

        public async System.Threading.Tasks.Task<ClassificationTemplate> CreateMetadataTemplateSchemaClassification(CreateMetadataTemplateSchemaClassificationRequestBodyArg requestBody, CreateMetadataTemplateSchemaClassificationHeadersArg? headers = default) {
            headers = headers ?? new CreateMetadataTemplateSchemaClassificationHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/metadata_templates/schema#classifications"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<ClassificationTemplate>(response.Text);
        }

    }
}