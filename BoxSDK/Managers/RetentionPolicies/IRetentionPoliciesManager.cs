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

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<RetentionPolicies> GetRetentionPoliciesAsync(GetRetentionPoliciesQueryParams? queryParams = default, GetRetentionPoliciesHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<RetentionPolicy> CreateRetentionPolicyAsync(CreateRetentionPolicyRequestBody requestBody, CreateRetentionPolicyHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<RetentionPolicy> GetRetentionPolicyByIdAsync(string retentionPolicyId, GetRetentionPolicyByIdQueryParams? queryParams = default, GetRetentionPolicyByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<RetentionPolicy> UpdateRetentionPolicyByIdAsync(string retentionPolicyId, UpdateRetentionPolicyByIdRequestBody? requestBody = default, UpdateRetentionPolicyByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteRetentionPolicyByIdAsync(string retentionPolicyId, DeleteRetentionPolicyByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}