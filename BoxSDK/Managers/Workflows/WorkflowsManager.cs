using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using StringExtensions;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class WorkflowsManager : IWorkflowsManager {
        public IAuthentication? Auth { get; set; } = default;

        public NetworkSession NetworkSession { get; set; }

        public WorkflowsManager(NetworkSession networkSession = default) {
            NetworkSession = networkSession ?? new NetworkSession();
        }
        /// <summary>
        /// Returns list of workflows that act on a given `folder ID`, and
        /// have a flow with a trigger type of `WORKFLOW_MANUAL_START`.
        /// 
        /// You application must be authorized to use the `Manage Box Relay` application
        /// scope within the developer console in to use this endpoint.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getWorkflows method
        /// </param>
        /// <param name="headers">
        /// Headers of getWorkflows method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Workflows> GetWorkflowsAsync(GetWorkflowsQueryParams queryParams, GetWorkflowsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetWorkflowsHeaders();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "folder_id", StringUtils.ToStringRepresentation(queryParams.FolderId) }, { "trigger_type", StringUtils.ToStringRepresentation(queryParams.TriggerType) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) }, { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/workflows"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Workflows>(response.Data);
        }

        /// <summary>
        /// Initiates a flow with a trigger type of `WORKFLOW_MANUAL_START`.
        /// 
        /// You application must be authorized to use the `Manage Box Relay` application
        /// scope within the developer console.
        /// </summary>
        /// <param name="workflowId">
        /// The ID of the workflow.
        /// Example: "12345"
        /// </param>
        /// <param name="requestBody">
        /// Request body of createWorkflowStart method
        /// </param>
        /// <param name="headers">
        /// Headers of createWorkflowStart method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task CreateWorkflowStartAsync(string workflowId, CreateWorkflowStartRequestBody requestBody, CreateWorkflowStartHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateWorkflowStartHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/workflows/", StringUtils.ToStringRepresentation(workflowId), "/start"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

    }
}