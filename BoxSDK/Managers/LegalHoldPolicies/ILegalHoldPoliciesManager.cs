using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface ILegalHoldPoliciesManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<LegalHoldPolicies> GetLegalHoldPoliciesAsync(GetLegalHoldPoliciesQueryParamsArg? queryParams = default, GetLegalHoldPoliciesHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<LegalHoldPolicy> CreateLegalHoldPolicyAsync(CreateLegalHoldPolicyRequestBodyArg requestBody, CreateLegalHoldPolicyHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<LegalHoldPolicy> GetLegalHoldPolicyByIdAsync(string legalHoldPolicyId, GetLegalHoldPolicyByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<LegalHoldPolicy> UpdateLegalHoldPolicyByIdAsync(string legalHoldPolicyId, UpdateLegalHoldPolicyByIdRequestBodyArg? requestBody = default, UpdateLegalHoldPolicyByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteLegalHoldPolicyByIdAsync(string legalHoldPolicyId, DeleteLegalHoldPolicyByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}