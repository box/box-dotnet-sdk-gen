using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface IStoragePolicyAssignmentsManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<StoragePolicyAssignments> GetStoragePolicyAssignmentsAsync(GetStoragePolicyAssignmentsQueryParams queryParams, GetStoragePolicyAssignmentsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<StoragePolicyAssignment> CreateStoragePolicyAssignmentAsync(CreateStoragePolicyAssignmentRequestBody requestBody, CreateStoragePolicyAssignmentHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<StoragePolicyAssignment> GetStoragePolicyAssignmentByIdAsync(string storagePolicyAssignmentId, GetStoragePolicyAssignmentByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<StoragePolicyAssignment> UpdateStoragePolicyAssignmentByIdAsync(string storagePolicyAssignmentId, UpdateStoragePolicyAssignmentByIdRequestBody requestBody, UpdateStoragePolicyAssignmentByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteStoragePolicyAssignmentByIdAsync(string storagePolicyAssignmentId, DeleteStoragePolicyAssignmentByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}