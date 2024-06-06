using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface ILegalHoldPoliciesManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<LegalHoldPolicies> GetLegalHoldPoliciesAsync(GetLegalHoldPoliciesQueryParams? queryParams = default, GetLegalHoldPoliciesHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<LegalHoldPolicy> CreateLegalHoldPolicyAsync(CreateLegalHoldPolicyRequestBody requestBody, CreateLegalHoldPolicyHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<LegalHoldPolicy> GetLegalHoldPolicyByIdAsync(string legalHoldPolicyId, GetLegalHoldPolicyByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<LegalHoldPolicy> UpdateLegalHoldPolicyByIdAsync(string legalHoldPolicyId, UpdateLegalHoldPolicyByIdRequestBody? requestBody = default, UpdateLegalHoldPolicyByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task DeleteLegalHoldPolicyByIdAsync(string legalHoldPolicyId, DeleteLegalHoldPolicyByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

    }
}