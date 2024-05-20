using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface ILegalHoldPolicyAssignmentsManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<LegalHoldPolicyAssignments> GetLegalHoldPolicyAssignmentsAsync(GetLegalHoldPolicyAssignmentsQueryParams queryParams, GetLegalHoldPolicyAssignmentsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<LegalHoldPolicyAssignment> CreateLegalHoldPolicyAssignmentAsync(CreateLegalHoldPolicyAssignmentRequestBody requestBody, CreateLegalHoldPolicyAssignmentHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<LegalHoldPolicyAssignment> GetLegalHoldPolicyAssignmentByIdAsync(string legalHoldPolicyAssignmentId, GetLegalHoldPolicyAssignmentByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteLegalHoldPolicyAssignmentByIdAsync(string legalHoldPolicyAssignmentId, DeleteLegalHoldPolicyAssignmentByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FilesOnHold> GetLegalHoldPolicyAssignmentFileOnHoldAsync(string legalHoldPolicyAssignmentId, GetLegalHoldPolicyAssignmentFileOnHoldQueryParams? queryParams = default, GetLegalHoldPolicyAssignmentFileOnHoldHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}