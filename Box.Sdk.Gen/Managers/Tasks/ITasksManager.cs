using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface ITasksManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<Tasks> GetFileTasksAsync(string fileId, GetFileTasksHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Task> CreateTaskAsync(CreateTaskRequestBody requestBody, CreateTaskHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Task> GetTaskByIdAsync(string taskId, GetTaskByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Task> UpdateTaskByIdAsync(string taskId, UpdateTaskByIdRequestBody? requestBody = default, UpdateTaskByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteTaskByIdAsync(string taskId, DeleteTaskByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}