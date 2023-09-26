using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using StringExtensions;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class MetadataTemplatesManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public MetadataTemplatesManager() {
            
        }
        public async System.Threading.Tasks.Task<MetadataTemplates> GetMetadataTemplates(GetMetadataTemplatesQueryParamsArg queryParams, GetMetadataTemplatesHeadersArg? headers = default) {
            headers = headers ?? new GetMetadataTemplatesHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "metadata_instance_id", StringUtils.ToStringRepresentation(queryParams.MetadataInstanceId) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/metadata_templates"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<MetadataTemplates>(response.Text);
        }

        public async System.Threading.Tasks.Task<MetadataTemplate> GetMetadataTemplateSchema(GetMetadataTemplateSchemaScopeArg scope, string templateKey, GetMetadataTemplateSchemaHeadersArg? headers = default) {
            headers = headers ?? new GetMetadataTemplateSchemaHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/metadata_templates/", StringUtils.ToStringRepresentation(scope), "/", StringUtils.ToStringRepresentation(templateKey), "/schema"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<MetadataTemplate>(response.Text);
        }

        public async System.Threading.Tasks.Task<MetadataTemplate> UpdateMetadataTemplateSchema(UpdateMetadataTemplateSchemaScopeArg scope, string templateKey, IReadOnlyList<UpdateMetadataTemplateSchemaRequestBodyArg> requestBody, UpdateMetadataTemplateSchemaHeadersArg? headers = default) {
            headers = headers ?? new UpdateMetadataTemplateSchemaHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/metadata_templates/", StringUtils.ToStringRepresentation(scope), "/", StringUtils.ToStringRepresentation(templateKey), "/schema"), new FetchOptions(method: "PUT", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json-patch+json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<MetadataTemplate>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteMetadataTemplateSchema(DeleteMetadataTemplateSchemaScopeArg scope, string templateKey, DeleteMetadataTemplateSchemaHeadersArg? headers = default) {
            headers = headers ?? new DeleteMetadataTemplateSchemaHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/metadata_templates/", StringUtils.ToStringRepresentation(scope), "/", StringUtils.ToStringRepresentation(templateKey), "/schema"), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

        public async System.Threading.Tasks.Task<MetadataTemplate> GetMetadataTemplateById(string templateId, GetMetadataTemplateByIdHeadersArg? headers = default) {
            headers = headers ?? new GetMetadataTemplateByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/metadata_templates/", StringUtils.ToStringRepresentation(templateId)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<MetadataTemplate>(response.Text);
        }

        public async System.Threading.Tasks.Task<MetadataTemplates> GetMetadataTemplateGlobal(GetMetadataTemplateGlobalQueryParamsArg? queryParams = default, GetMetadataTemplateGlobalHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetMetadataTemplateGlobalQueryParamsArg();
            headers = headers ?? new GetMetadataTemplateGlobalHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/metadata_templates/global"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<MetadataTemplates>(response.Text);
        }

        public async System.Threading.Tasks.Task<MetadataTemplates> GetMetadataTemplateEnterprise(GetMetadataTemplateEnterpriseQueryParamsArg? queryParams = default, GetMetadataTemplateEnterpriseHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetMetadataTemplateEnterpriseQueryParamsArg();
            headers = headers ?? new GetMetadataTemplateEnterpriseHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/metadata_templates/enterprise"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<MetadataTemplates>(response.Text);
        }

        public async System.Threading.Tasks.Task<MetadataTemplate> CreateMetadataTemplateSchema(CreateMetadataTemplateSchemaRequestBodyArg requestBody, CreateMetadataTemplateSchemaHeadersArg? headers = default) {
            headers = headers ?? new CreateMetadataTemplateSchemaHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/metadata_templates/schema"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<MetadataTemplate>(response.Text);
        }

    }
}