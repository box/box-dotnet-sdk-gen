using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public interface IRetentionPoliciesManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<RetentionPolicies> GetRetentionPoliciesAsync(GetRetentionPoliciesQueryParams? queryParams = default, GetRetentionPoliciesHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<RetentionPolicy> CreateRetentionPolicyAsync(CreateRetentionPolicyRequestBody requestBody, CreateRetentionPolicyHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<RetentionPolicy> GetRetentionPolicyByIdAsync(string retentionPolicyId, GetRetentionPolicyByIdQueryParams? queryParams = default, GetRetentionPolicyByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<RetentionPolicy> UpdateRetentionPolicyByIdAsync(string retentionPolicyId, UpdateRetentionPolicyByIdRequestBody? requestBody = default, UpdateRetentionPolicyByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task DeleteRetentionPolicyByIdAsync(string retentionPolicyId, DeleteRetentionPolicyByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

    }
}