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
    public class MetadataTemplatesManager : IMetadataTemplatesManager {
        public IAuthentication? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public MetadataTemplatesManager() {
            
        }
        /// <summary>
        /// Finds a metadata template by searching for the ID of an instance of the
        /// template.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getMetadataTemplates method
        /// </param>
        /// <param name="headers">
        /// Headers of getMetadataTemplates method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<MetadataTemplates> GetMetadataTemplatesAsync(GetMetadataTemplatesQueryParamsArg queryParams, GetMetadataTemplatesHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetMetadataTemplatesHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "metadata_instance_id", StringUtils.ToStringRepresentation(queryParams.MetadataInstanceId) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/metadata_templates"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<MetadataTemplates>(response.Data);
        }

        /// <summary>
        /// Retrieves a metadata template by its `scope` and `templateKey` values.
        /// 
        /// To find the `scope` and `templateKey` for a template, list all templates for
        /// an enterprise or globally, or list all templates applied to a file or folder.
        /// </summary>
        /// <param name="scope">
        /// The scope of the metadata template
        /// Example: "global"
        /// </param>
        /// <param name="templateKey">
        /// The name of the metadata template
        /// Example: "properties"
        /// </param>
        /// <param name="headers">
        /// Headers of getMetadataTemplateSchema method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<MetadataTemplate> GetMetadataTemplateSchemaAsync(GetMetadataTemplateSchemaScopeArg scope, string templateKey, GetMetadataTemplateSchemaHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetMetadataTemplateSchemaHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/metadata_templates/", StringUtils.ToStringRepresentation(scope), "/", StringUtils.ToStringRepresentation(templateKey), "/schema"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<MetadataTemplate>(response.Data);
        }

        /// <summary>
        /// Updates a metadata template.
        /// 
        /// The metadata template can only be updated if the template
        /// already exists.
        /// 
        /// The update is applied atomically. If any errors occur during the
        /// application of the operations, the metadata template will not be changed.
        /// </summary>
        /// <param name="scope">
        /// The scope of the metadata template
        /// Example: "global"
        /// </param>
        /// <param name="templateKey">
        /// The name of the metadata template
        /// Example: "properties"
        /// </param>
        /// <param name="requestBody">
        /// Request body of updateMetadataTemplateSchema method
        /// </param>
        /// <param name="headers">
        /// Headers of updateMetadataTemplateSchema method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<MetadataTemplate> UpdateMetadataTemplateSchemaAsync(UpdateMetadataTemplateSchemaScopeArg scope, string templateKey, IReadOnlyList<UpdateMetadataTemplateSchemaRequestBodyArg> requestBody, UpdateMetadataTemplateSchemaHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new UpdateMetadataTemplateSchemaHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/metadata_templates/", StringUtils.ToStringRepresentation(scope), "/", StringUtils.ToStringRepresentation(templateKey), "/schema"), new FetchOptions(method: "PUT", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json-patch+json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<MetadataTemplate>(response.Data);
        }

        /// <summary>
        /// Delete a metadata template and its instances.
        /// This deletion is permanent and can not be reversed.
        /// </summary>
        /// <param name="scope">
        /// The scope of the metadata template
        /// Example: "global"
        /// </param>
        /// <param name="templateKey">
        /// The name of the metadata template
        /// Example: "properties"
        /// </param>
        /// <param name="headers">
        /// Headers of deleteMetadataTemplateSchema method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteMetadataTemplateSchemaAsync(DeleteMetadataTemplateSchemaScopeArg scope, string templateKey, DeleteMetadataTemplateSchemaHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteMetadataTemplateSchemaHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/metadata_templates/", StringUtils.ToStringRepresentation(scope), "/", StringUtils.ToStringRepresentation(templateKey), "/schema"), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves a metadata template by its ID.
        /// </summary>
        /// <param name="templateId">
        /// The ID of the template
        /// Example: "f7a9891f"
        /// </param>
        /// <param name="headers">
        /// Headers of getMetadataTemplateById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<MetadataTemplate> GetMetadataTemplateByIdAsync(string templateId, GetMetadataTemplateByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetMetadataTemplateByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/metadata_templates/", StringUtils.ToStringRepresentation(templateId)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<MetadataTemplate>(response.Data);
        }

        /// <summary>
        /// Used to retrieve all generic, global metadata templates available to all
        /// enterprises using Box.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getMetadataTemplateGlobal method
        /// </param>
        /// <param name="headers">
        /// Headers of getMetadataTemplateGlobal method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<MetadataTemplates> GetMetadataTemplateGlobalAsync(GetMetadataTemplateGlobalQueryParamsArg? queryParams = default, GetMetadataTemplateGlobalHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetMetadataTemplateGlobalQueryParamsArg();
            headers = headers ?? new GetMetadataTemplateGlobalHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/metadata_templates/global"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<MetadataTemplates>(response.Data);
        }

        /// <summary>
        /// Used to retrieve all metadata templates created to be used specifically within
        /// the user's enterprise
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getMetadataTemplateEnterprise method
        /// </param>
        /// <param name="headers">
        /// Headers of getMetadataTemplateEnterprise method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<MetadataTemplates> GetMetadataTemplateEnterpriseAsync(GetMetadataTemplateEnterpriseQueryParamsArg? queryParams = default, GetMetadataTemplateEnterpriseHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetMetadataTemplateEnterpriseQueryParamsArg();
            headers = headers ?? new GetMetadataTemplateEnterpriseHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/metadata_templates/enterprise"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<MetadataTemplates>(response.Data);
        }

        /// <summary>
        /// Creates a new metadata template that can be applied to
        /// files and folders.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createMetadataTemplateSchema method
        /// </param>
        /// <param name="headers">
        /// Headers of createMetadataTemplateSchema method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<MetadataTemplate> CreateMetadataTemplateSchemaAsync(CreateMetadataTemplateSchemaRequestBodyArg requestBody, CreateMetadataTemplateSchemaHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateMetadataTemplateSchemaHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/metadata_templates/schema"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<MetadataTemplate>(response.Data);
        }

    }
}