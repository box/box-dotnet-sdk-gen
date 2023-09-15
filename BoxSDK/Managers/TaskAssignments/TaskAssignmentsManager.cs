using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class TaskAssignmentsManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public TaskAssignmentsManager() {
            
        }
        public async System.Threading.Tasks.Task<TaskAssignments> GetTaskAssignments(string taskId, GetTaskAssignmentsHeadersArg? headers = default) {
            headers = headers ?? new GetTaskAssignmentsHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/tasks/", taskId, "/assignments"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<TaskAssignments>(response.Text);
        }

        public async System.Threading.Tasks.Task<TaskAssignment> CreateTaskAssignment(CreateTaskAssignmentRequestBodyArg requestBody, CreateTaskAssignmentHeadersArg? headers = default) {
            headers = headers ?? new CreateTaskAssignmentHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/task_assignments"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<TaskAssignment>(response.Text);
        }

        public async System.Threading.Tasks.Task<TaskAssignment> GetTaskAssignmentById(string taskAssignmentId, GetTaskAssignmentByIdHeadersArg? headers = default) {
            headers = headers ?? new GetTaskAssignmentByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/task_assignments/", taskAssignmentId), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<TaskAssignment>(response.Text);
        }

        public async System.Threading.Tasks.Task<TaskAssignment> UpdateTaskAssignmentById(string taskAssignmentId, UpdateTaskAssignmentByIdRequestBodyArg? requestBody = default, UpdateTaskAssignmentByIdHeadersArg? headers = default) {
            requestBody = requestBody ?? new UpdateTaskAssignmentByIdRequestBodyArg();
            headers = headers ?? new UpdateTaskAssignmentByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/task_assignments/", taskAssignmentId), new FetchOptions(method: "PUT", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<TaskAssignment>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteTaskAssignmentById(string taskAssignmentId, DeleteTaskAssignmentByIdHeadersArg? headers = default) {
            headers = headers ?? new DeleteTaskAssignmentByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/task_assignments/", taskAssignmentId), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

    }
}