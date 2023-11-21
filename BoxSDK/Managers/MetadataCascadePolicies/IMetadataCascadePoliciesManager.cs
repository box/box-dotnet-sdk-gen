using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IMetadataCascadePoliciesManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<MetadataCascadePolicies> GetMetadataCascadePoliciesAsync(GetMetadataCascadePoliciesQueryParamsArg queryParams, GetMetadataCascadePoliciesHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataCascadePolicy> CreateMetadataCascadePolicyAsync(CreateMetadataCascadePolicyRequestBodyArg requestBody, CreateMetadataCascadePolicyHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataCascadePolicy> GetMetadataCascadePolicyByIdAsync(string metadataCascadePolicyId, GetMetadataCascadePolicyByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteMetadataCascadePolicyByIdAsync(string metadataCascadePolicyId, DeleteMetadataCascadePolicyByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task CreateMetadataCascadePolicyApplyAsync(string metadataCascadePolicyId, CreateMetadataCascadePolicyApplyRequestBodyArg requestBody, CreateMetadataCascadePolicyApplyHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}