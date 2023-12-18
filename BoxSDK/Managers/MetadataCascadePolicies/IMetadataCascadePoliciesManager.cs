using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IMetadataCascadePoliciesManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<MetadataCascadePolicies> GetMetadataCascadePoliciesAsync(GetMetadataCascadePoliciesQueryParams queryParams, GetMetadataCascadePoliciesHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataCascadePolicy> CreateMetadataCascadePolicyAsync(CreateMetadataCascadePolicyRequestBody requestBody, CreateMetadataCascadePolicyHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataCascadePolicy> GetMetadataCascadePolicyByIdAsync(string metadataCascadePolicyId, GetMetadataCascadePolicyByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteMetadataCascadePolicyByIdAsync(string metadataCascadePolicyId, DeleteMetadataCascadePolicyByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task ApplyMetadataCascadePolicyAsync(string metadataCascadePolicyId, ApplyMetadataCascadePolicyRequestBody requestBody, ApplyMetadataCascadePolicyHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}