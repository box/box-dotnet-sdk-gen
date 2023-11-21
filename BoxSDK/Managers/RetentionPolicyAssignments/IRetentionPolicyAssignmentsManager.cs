using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IRetentionPolicyAssignmentsManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<RetentionPolicyAssignments> GetRetentionPolicyAssignmentsAsync(string retentionPolicyId, GetRetentionPolicyAssignmentsQueryParamsArg? queryParams = default, GetRetentionPolicyAssignmentsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<RetentionPolicyAssignment> CreateRetentionPolicyAssignmentAsync(CreateRetentionPolicyAssignmentRequestBodyArg requestBody, CreateRetentionPolicyAssignmentHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<RetentionPolicyAssignment> GetRetentionPolicyAssignmentByIdAsync(string retentionPolicyAssignmentId, GetRetentionPolicyAssignmentByIdQueryParamsArg? queryParams = default, GetRetentionPolicyAssignmentByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteRetentionPolicyAssignmentByIdAsync(string retentionPolicyAssignmentId, DeleteRetentionPolicyAssignmentByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FilesUnderRetention> GetRetentionPolicyAssignmentFileUnderRetentionAsync(string retentionPolicyAssignmentId, GetRetentionPolicyAssignmentFileUnderRetentionQueryParamsArg? queryParams = default, GetRetentionPolicyAssignmentFileUnderRetentionHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FilesUnderRetention> GetRetentionPolicyAssignmentFileVersionUnderRetentionAsync(string retentionPolicyAssignmentId, GetRetentionPolicyAssignmentFileVersionUnderRetentionQueryParamsArg? queryParams = default, GetRetentionPolicyAssignmentFileVersionUnderRetentionHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}