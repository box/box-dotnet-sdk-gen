using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class WorkflowsManager {
        public IAuth Auth { get; }

        public NetworkSession NetworkSession { get; }

        public WorkflowsManager(IAuth auth, NetworkSession networkSession) {
            Auth = auth;
            NetworkSession = networkSession;
        }
        public async System.Threading.Tasks.Task<Workflows> GetWorkflows(GetWorkflowsQueryParamsArg queryParams, GetWorkflowsHeadersArg headers) {
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string>() { { "folder_id", Utils.ToString(queryParams.FolderId) }, { "trigger_type", Utils.ToString(queryParams.TriggerType) }, { "limit", Utils.ToString(queryParams.Limit) }, { "marker", Utils.ToString(queryParams.Marker) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/workflows"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Workflows>(response.Text);
        }

        public async System.Threading.Tasks.Task CreateWorkflowStart(string workflowId, CreateWorkflowStartRequestBodyArg requestBody, CreateWorkflowStartHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/workflows/", workflowId, "/start"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

    }
}