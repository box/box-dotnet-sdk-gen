using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface ITaskAssignmentsManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<TaskAssignments> GetTaskAssignmentsAsync(string taskId, GetTaskAssignmentsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<TaskAssignment> CreateTaskAssignmentAsync(CreateTaskAssignmentRequestBodyArg requestBody, CreateTaskAssignmentHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<TaskAssignment> GetTaskAssignmentByIdAsync(string taskAssignmentId, GetTaskAssignmentByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<TaskAssignment> UpdateTaskAssignmentByIdAsync(string taskAssignmentId, UpdateTaskAssignmentByIdRequestBodyArg? requestBody = default, UpdateTaskAssignmentByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteTaskAssignmentByIdAsync(string taskAssignmentId, DeleteTaskAssignmentByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}