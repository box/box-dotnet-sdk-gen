using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IStoragePolicyAssignmentsManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<StoragePolicyAssignments> GetStoragePolicyAssignmentsAsync(GetStoragePolicyAssignmentsQueryParams queryParams, GetStoragePolicyAssignmentsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<StoragePolicyAssignment> CreateStoragePolicyAssignmentAsync(CreateStoragePolicyAssignmentRequestBody requestBody, CreateStoragePolicyAssignmentHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<StoragePolicyAssignment> GetStoragePolicyAssignmentByIdAsync(string storagePolicyAssignmentId, GetStoragePolicyAssignmentByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<StoragePolicyAssignment> UpdateStoragePolicyAssignmentByIdAsync(string storagePolicyAssignmentId, UpdateStoragePolicyAssignmentByIdRequestBody requestBody, UpdateStoragePolicyAssignmentByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteStoragePolicyAssignmentByIdAsync(string storagePolicyAssignmentId, DeleteStoragePolicyAssignmentByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}