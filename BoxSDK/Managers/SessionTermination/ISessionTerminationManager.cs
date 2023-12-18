using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface ISessionTerminationManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<SessionTerminationMessage> TerminateUsersSessionsAsync(TerminateUsersSessionsRequestBody requestBody, TerminateUsersSessionsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<SessionTerminationMessage> TerminateGroupsSessionsAsync(TerminateGroupsSessionsRequestBody requestBody, TerminateGroupsSessionsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}