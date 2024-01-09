using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IWorkflowsManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<Workflows> GetWorkflowsAsync(GetWorkflowsQueryParams queryParams, GetWorkflowsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task StartWorkflowAsync(string workflowId, StartWorkflowRequestBody requestBody, StartWorkflowHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}