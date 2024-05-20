using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface ITaskAssignmentsManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<TaskAssignments> GetTaskAssignmentsAsync(string taskId, GetTaskAssignmentsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<TaskAssignment> CreateTaskAssignmentAsync(CreateTaskAssignmentRequestBody requestBody, CreateTaskAssignmentHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<TaskAssignment> GetTaskAssignmentByIdAsync(string taskAssignmentId, GetTaskAssignmentByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<TaskAssignment> UpdateTaskAssignmentByIdAsync(string taskAssignmentId, UpdateTaskAssignmentByIdRequestBody? requestBody = default, UpdateTaskAssignmentByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteTaskAssignmentByIdAsync(string taskAssignmentId, DeleteTaskAssignmentByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}