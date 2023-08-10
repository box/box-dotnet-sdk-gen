using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class MetadataTemplatesManager {
        public IAuth Auth { get; }

        public NetworkSession NetworkSession { get; }

        public MetadataTemplatesManager(IAuth auth, NetworkSession networkSession) {
            Auth = auth;
            NetworkSession = networkSession;
        }
        public async System.Threading.Tasks.Task<MetadataTemplates> GetMetadataTemplates(GetMetadataTemplatesQueryParamsArg queryParams, GetMetadataTemplatesHeadersArg headers) {
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string>() { { "metadata_instance_id", Utils.ToString(queryParams.MetadataInstanceId) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/metadata_templates"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<MetadataTemplates>(response.Text);
        }

        public async System.Threading.Tasks.Task<MetadataTemplate> GetMetadataTemplateSchema(GetMetadataTemplateSchemaScopeArg scope, string templateKey, GetMetadataTemplateSchemaHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/metadata_templates/", scope, "/", templateKey, "/schema"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<MetadataTemplate>(response.Text);
        }

        public async System.Threading.Tasks.Task<MetadataTemplate> UpdateMetadataTemplateSchema(UpdateMetadataTemplateSchemaScopeArg scope, string templateKey, IReadOnlyList<UpdateMetadataTemplateSchemaRequestBodyArg> requestBody, UpdateMetadataTemplateSchemaHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/metadata_templates/", scope, "/", templateKey, "/schema"), new FetchOptions(method: "PUT", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json-patch+json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<MetadataTemplate>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteMetadataTemplateSchema(DeleteMetadataTemplateSchemaScopeArg scope, string templateKey, DeleteMetadataTemplateSchemaHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/metadata_templates/", scope, "/", templateKey, "/schema"), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

        public async System.Threading.Tasks.Task<MetadataTemplate> GetMetadataTemplateById(string templateId, GetMetadataTemplateByIdHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/metadata_templates/", templateId), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<MetadataTemplate>(response.Text);
        }

        public async System.Threading.Tasks.Task<MetadataTemplates> GetMetadataTemplateGlobal(GetMetadataTemplateGlobalQueryParamsArg queryParams, GetMetadataTemplateGlobalHeadersArg headers) {
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string>() { { "marker", Utils.ToString(queryParams.Marker) }, { "limit", Utils.ToString(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/metadata_templates/global"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<MetadataTemplates>(response.Text);
        }

        public async System.Threading.Tasks.Task<MetadataTemplates> GetMetadataTemplateEnterprise(GetMetadataTemplateEnterpriseQueryParamsArg queryParams, GetMetadataTemplateEnterpriseHeadersArg headers) {
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string>() { { "marker", Utils.ToString(queryParams.Marker) }, { "limit", Utils.ToString(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/metadata_templates/enterprise"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<MetadataTemplates>(response.Text);
        }

        public async System.Threading.Tasks.Task<MetadataTemplate> CreateMetadataTemplateSchema(CreateMetadataTemplateSchemaRequestBodyArg requestBody, CreateMetadataTemplateSchemaHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/metadata_templates/schema"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<MetadataTemplate>(response.Text);
        }

    }
}