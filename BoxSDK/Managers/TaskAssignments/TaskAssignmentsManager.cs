using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using DictionaryExtensions;
using StringExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class TaskAssignmentsManager : ITaskAssignmentsManager {
        public IAuthentication? Auth { get; set; } = default;

        public NetworkSession NetworkSession { get; set; }

        public TaskAssignmentsManager(NetworkSession networkSession = default) {
            NetworkSession = networkSession ?? new NetworkSession();
        }
        /// <summary>
        /// Lists all of the assignments for a given task.
        /// </summary>
        /// <param name="taskId">
        /// The ID of the task.
        /// Example: "12345"
        /// </param>
        /// <param name="headers">
        /// Headers of getTaskAssignments method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<TaskAssignments> GetTaskAssignmentsAsync(string taskId, GetTaskAssignmentsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetTaskAssignmentsHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/tasks/", StringUtils.ToStringRepresentation(taskId), "/assignments"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<TaskAssignments>(response.Data);
        }

        /// <summary>
        /// Assigns a task to a user.
        /// 
        /// A task can be assigned to more than one user by creating multiple
        /// assignments.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createTaskAssignment method
        /// </param>
        /// <param name="headers">
        /// Headers of createTaskAssignment method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<TaskAssignment> CreateTaskAssignmentAsync(CreateTaskAssignmentRequestBody requestBody, CreateTaskAssignmentHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateTaskAssignmentHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/task_assignments"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<TaskAssignment>(response.Data);
        }

        /// <summary>
        /// Retrieves information about a task assignment.
        /// </summary>
        /// <param name="taskAssignmentId">
        /// The ID of the task assignment.
        /// Example: "12345"
        /// </param>
        /// <param name="headers">
        /// Headers of getTaskAssignmentById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<TaskAssignment> GetTaskAssignmentByIdAsync(string taskAssignmentId, GetTaskAssignmentByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetTaskAssignmentByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/task_assignments/", StringUtils.ToStringRepresentation(taskAssignmentId)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<TaskAssignment>(response.Data);
        }

        /// <summary>
        /// Updates a task assignment. This endpoint can be
        /// used to update the state of a task assigned to a user.
        /// </summary>
        /// <param name="taskAssignmentId">
        /// The ID of the task assignment.
        /// Example: "12345"
        /// </param>
        /// <param name="requestBody">
        /// Request body of updateTaskAssignmentById method
        /// </param>
        /// <param name="headers">
        /// Headers of updateTaskAssignmentById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<TaskAssignment> UpdateTaskAssignmentByIdAsync(string taskAssignmentId, UpdateTaskAssignmentByIdRequestBody? requestBody = default, UpdateTaskAssignmentByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            requestBody = requestBody ?? new UpdateTaskAssignmentByIdRequestBody();
            headers = headers ?? new UpdateTaskAssignmentByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/task_assignments/", StringUtils.ToStringRepresentation(taskAssignmentId)), new FetchOptions(method: "PUT", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<TaskAssignment>(response.Data);
        }

        /// <summary>
        /// Deletes a specific task assignment.
        /// </summary>
        /// <param name="taskAssignmentId">
        /// The ID of the task assignment.
        /// Example: "12345"
        /// </param>
        /// <param name="headers">
        /// Headers of deleteTaskAssignmentById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteTaskAssignmentByIdAsync(string taskAssignmentId, DeleteTaskAssignmentByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteTaskAssignmentByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/task_assignments/", StringUtils.ToStringRepresentation(taskAssignmentId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

    }
}