using Unions;
using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public interface IIntegrationMappingsManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<IntegrationMappings> GetSlackIntegrationMappingAsync(GetSlackIntegrationMappingQueryParams? queryParams = default, GetSlackIntegrationMappingHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<IntegrationMapping> CreateSlackIntegrationMappingAsync(IntegrationMappingSlackCreateRequest requestBody, CreateSlackIntegrationMappingHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<IntegrationMapping> UpdateSlackIntegrationMappingByIdAsync(string integrationMappingId, UpdateSlackIntegrationMappingByIdRequestBody? requestBody = default, UpdateSlackIntegrationMappingByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task DeleteSlackIntegrationMappingByIdAsync(string integrationMappingId, DeleteSlackIntegrationMappingByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

    }
}