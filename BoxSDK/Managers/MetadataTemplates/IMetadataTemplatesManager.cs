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

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<MetadataTemplates> GetMetadataTemplatesByInstanceIdAsync(GetMetadataTemplatesByInstanceIdQueryParams queryParams, GetMetadataTemplatesByInstanceIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataTemplate> GetMetadataTemplateAsync(GetMetadataTemplateScope scope, string templateKey, GetMetadataTemplateHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataTemplate> UpdateMetadataTemplateAsync(UpdateMetadataTemplateScope scope, string templateKey, IReadOnlyList<UpdateMetadataTemplateRequestBody> requestBody, UpdateMetadataTemplateHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteMetadataTemplateAsync(DeleteMetadataTemplateScope scope, string templateKey, DeleteMetadataTemplateHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataTemplate> GetMetadataTemplateByIdAsync(string templateId, GetMetadataTemplateByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataTemplates> GetGlobalMetadataTemplatesAsync(GetGlobalMetadataTemplatesQueryParams? queryParams = default, GetGlobalMetadataTemplatesHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataTemplates> GetEnterpriseMetadataTemplatesAsync(GetEnterpriseMetadataTemplatesQueryParams? queryParams = default, GetEnterpriseMetadataTemplatesHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataTemplate> CreateMetadataTemplateAsync(CreateMetadataTemplateRequestBody requestBody, CreateMetadataTemplateHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}