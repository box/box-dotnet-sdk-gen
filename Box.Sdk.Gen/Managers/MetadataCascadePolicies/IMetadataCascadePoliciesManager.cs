using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public interface IMetadataCascadePoliciesManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<MetadataCascadePolicies> GetMetadataCascadePoliciesAsync(GetMetadataCascadePoliciesQueryParams queryParams, GetMetadataCascadePoliciesHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<MetadataCascadePolicy> CreateMetadataCascadePolicyAsync(CreateMetadataCascadePolicyRequestBody requestBody, CreateMetadataCascadePolicyHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<MetadataCascadePolicy> GetMetadataCascadePolicyByIdAsync(string metadataCascadePolicyId, GetMetadataCascadePolicyByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task DeleteMetadataCascadePolicyByIdAsync(string metadataCascadePolicyId, DeleteMetadataCascadePolicyByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task ApplyMetadataCascadePolicyAsync(string metadataCascadePolicyId, ApplyMetadataCascadePolicyRequestBody requestBody, ApplyMetadataCascadePolicyHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

    }
}