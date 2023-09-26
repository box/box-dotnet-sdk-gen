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
    public class TasksManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public TasksManager() {
            
        }
        public async System.Threading.Tasks.Task<Tasks> GetFileTasks(string fileId, GetFileTasksHeadersArg? headers = default) {
            headers = headers ?? new GetFileTasksHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", StringUtils.ToStringRepresentation(fileId), "/tasks"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Tasks>(response.Text);
        }

        public async System.Threading.Tasks.Task<Task> CreateTask(CreateTaskRequestBodyArg requestBody, CreateTaskHeadersArg? headers = default) {
            headers = headers ?? new CreateTaskHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/tasks"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Task>(response.Text);
        }

        public async System.Threading.Tasks.Task<Task> GetTaskById(string taskId, GetTaskByIdHeadersArg? headers = default) {
            headers = headers ?? new GetTaskByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/tasks/", StringUtils.ToStringRepresentation(taskId)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Task>(response.Text);
        }

        public async System.Threading.Tasks.Task<Task> UpdateTaskById(string taskId, UpdateTaskByIdRequestBodyArg? requestBody = default, UpdateTaskByIdHeadersArg? headers = default) {
            requestBody = requestBody ?? new UpdateTaskByIdRequestBodyArg();
            headers = headers ?? new UpdateTaskByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/tasks/", StringUtils.ToStringRepresentation(taskId)), new FetchOptions(method: "PUT", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Task>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteTaskById(string taskId, DeleteTaskByIdHeadersArg? headers = default) {
            headers = headers ?? new DeleteTaskByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/tasks/", StringUtils.ToStringRepresentation(taskId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

    }
}