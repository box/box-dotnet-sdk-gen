using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IRetentionPoliciesManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<RetentionPolicies> GetRetentionPoliciesAsync(GetRetentionPoliciesQueryParamsArg? queryParams = default, GetRetentionPoliciesHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<RetentionPolicy> CreateRetentionPolicyAsync(CreateRetentionPolicyRequestBodyArg requestBody, CreateRetentionPolicyHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<RetentionPolicy> GetRetentionPolicyByIdAsync(string retentionPolicyId, GetRetentionPolicyByIdQueryParamsArg? queryParams = default, GetRetentionPolicyByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<RetentionPolicy> UpdateRetentionPolicyByIdAsync(string retentionPolicyId, UpdateRetentionPolicyByIdRequestBodyArg? requestBody = default, UpdateRetentionPolicyByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteRetentionPolicyByIdAsync(string retentionPolicyId, DeleteRetentionPolicyByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}