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

        public System.Threading.Tasks.Task<MetadataTemplates> GetMetadataTemplatesByInstanceIdAsync(GetMetadataTemplatesByInstanceIdQueryParamsArg queryParams, GetMetadataTemplatesByInstanceIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataTemplate> GetMetadataTemplateAsync(GetMetadataTemplateScopeArg scope, string templateKey, GetMetadataTemplateHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataTemplate> UpdateMetadataTemplateAsync(UpdateMetadataTemplateScopeArg scope, string templateKey, IReadOnlyList<UpdateMetadataTemplateRequestBodyArg> requestBody, UpdateMetadataTemplateHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteMetadataTemplateAsync(DeleteMetadataTemplateScopeArg scope, string templateKey, DeleteMetadataTemplateHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataTemplate> GetMetadataTemplateByIdAsync(string templateId, GetMetadataTemplateByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataTemplates> GetGlobalMetadataTemplatesAsync(GetGlobalMetadataTemplatesQueryParamsArg? queryParams = default, GetGlobalMetadataTemplatesHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataTemplates> GetEnterpriseMetadataTemplatesAsync(GetEnterpriseMetadataTemplatesQueryParamsArg? queryParams = default, GetEnterpriseMetadataTemplatesHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataTemplate> CreateMetadataTemplateAsync(CreateMetadataTemplateRequestBodyArg requestBody, CreateMetadataTemplateHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}