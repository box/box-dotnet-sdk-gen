using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IMetadataTemplatesManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<MetadataTemplates> GetMetadataTemplatesAsync(GetMetadataTemplatesQueryParamsArg queryParams, GetMetadataTemplatesHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataTemplate> GetMetadataTemplateSchemaAsync(GetMetadataTemplateSchemaScopeArg scope, string templateKey, GetMetadataTemplateSchemaHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataTemplate> UpdateMetadataTemplateSchemaAsync(UpdateMetadataTemplateSchemaScopeArg scope, string templateKey, IReadOnlyList<UpdateMetadataTemplateSchemaRequestBodyArg> requestBody, UpdateMetadataTemplateSchemaHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteMetadataTemplateSchemaAsync(DeleteMetadataTemplateSchemaScopeArg scope, string templateKey, DeleteMetadataTemplateSchemaHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataTemplate> GetMetadataTemplateByIdAsync(string templateId, GetMetadataTemplateByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataTemplates> GetMetadataTemplateGlobalAsync(GetMetadataTemplateGlobalQueryParamsArg? queryParams = default, GetMetadataTemplateGlobalHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataTemplates> GetMetadataTemplateEnterpriseAsync(GetMetadataTemplateEnterpriseQueryParamsArg? queryParams = default, GetMetadataTemplateEnterpriseHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataTemplate> CreateMetadataTemplateSchemaAsync(CreateMetadataTemplateSchemaRequestBodyArg requestBody, CreateMetadataTemplateSchemaHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}