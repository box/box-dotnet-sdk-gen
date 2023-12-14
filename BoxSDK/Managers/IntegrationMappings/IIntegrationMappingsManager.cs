using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IIntegrationMappingsManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<IntegrationMappings> GetIntegrationMappingSlackAsync(GetIntegrationMappingSlackQueryParams? queryParams = default, GetIntegrationMappingSlackHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<IntegrationMapping> CreateIntegrationMappingSlackAsync(IntegrationMappingSlackCreateRequest requestBody, CreateIntegrationMappingSlackHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<IntegrationMapping> UpdateIntegrationMappingSlackByIdAsync(string integrationMappingId, UpdateIntegrationMappingSlackByIdRequestBody? requestBody = default, UpdateIntegrationMappingSlackByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteIntegrationMappingSlackByIdAsync(string integrationMappingId, DeleteIntegrationMappingSlackByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}