using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using DictionaryExtensions;
using StringExtensions;
using Fetch;
using Serializer;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class TasksManager : ITasksManager {
        public IAuthentication? Auth { get; set; } = default;

        public NetworkSession NetworkSession { get; set; }

        public TasksManager(NetworkSession networkSession = default) {
            NetworkSession = networkSession ?? new NetworkSession();
        }
        /// <summary>
        /// Retrieves a list of all the tasks for a file. This
        /// endpoint does not support pagination.
        /// </summary>
        /// <param name="fileId">
        /// The unique identifier that represents a file.
        /// 
        /// The ID for any file can be determined
        /// by visiting a file in the web application
        /// and copying the ID from the URL. For example,
        /// for the URL `https://*.app.box.com/files/123`
        /// the `file_id` is `123`.
        /// Example: "12345"
        /// </param>
        /// <param name="headers">
        /// Headers of getFileTasks method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Tasks> GetFileTasksAsync(string fileId, GetFileTasksHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetFileTasksHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/files/", StringUtils.ToStringRepresentation(fileId), "/tasks"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Tasks>(response.Data);
        }

        /// <summary>
        /// Creates a single task on a file. This task is not assigned to any user and
        /// will need to be assigned separately.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createTask method
        /// </param>
        /// <param name="headers">
        /// Headers of createTask method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Task> CreateTaskAsync(CreateTaskRequestBody requestBody, CreateTaskHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateTaskHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/tasks"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Task>(response.Data);
        }

        /// <summary>
        /// Retrieves information about a specific task.
        /// </summary>
        /// <param name="taskId">
        /// The ID of the task.
        /// Example: "12345"
        /// </param>
        /// <param name="headers">
        /// Headers of getTaskById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Task> GetTaskByIdAsync(string taskId, GetTaskByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetTaskByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/tasks/", StringUtils.ToStringRepresentation(taskId)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Task>(response.Data);
        }

        /// <summary>
        /// Updates a task. This can be used to update a task's configuration, or to
        /// update its completion state.
        /// </summary>
        /// <param name="taskId">
        /// The ID of the task.
        /// Example: "12345"
        /// </param>
        /// <param name="requestBody">
        /// Request body of updateTaskById method
        /// </param>
        /// <param name="headers">
        /// Headers of updateTaskById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Task> UpdateTaskByIdAsync(string taskId, UpdateTaskByIdRequestBody? requestBody = default, UpdateTaskByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            requestBody = requestBody ?? new UpdateTaskByIdRequestBody();
            headers = headers ?? new UpdateTaskByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/tasks/", StringUtils.ToStringRepresentation(taskId)), new FetchOptions(method: "PUT", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Task>(response.Data);
        }

        /// <summary>
        /// Removes a task from a file.
        /// </summary>
        /// <param name="taskId">
        /// The ID of the task.
        /// Example: "12345"
        /// </param>
        /// <param name="headers">
        /// Headers of deleteTaskById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteTaskByIdAsync(string taskId, DeleteTaskByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteTaskByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/tasks/", StringUtils.ToStringRepresentation(taskId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

    }
}