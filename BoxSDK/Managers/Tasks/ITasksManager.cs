using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface ITasksManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<Tasks> GetFileTasksAsync(string fileId, GetFileTasksHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Task> CreateTaskAsync(CreateTaskRequestBodyArg requestBody, CreateTaskHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Task> GetTaskByIdAsync(string taskId, GetTaskByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Task> UpdateTaskByIdAsync(string taskId, UpdateTaskByIdRequestBodyArg? requestBody = default, UpdateTaskByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteTaskByIdAsync(string taskId, DeleteTaskByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}