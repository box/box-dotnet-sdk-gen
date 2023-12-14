using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Unions;
using DictionaryExtensions;
using Serializer;
using Fetch;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class SessionTerminationManager : ISessionTerminationManager {
        public IAuthentication? Auth { get; set; } = default;

        public NetworkSession NetworkSession { get; set; }

        public SessionTerminationManager(NetworkSession networkSession = default) {
            NetworkSession = networkSession ?? new NetworkSession();
        }
        /// <summary>
        /// Validates the roles and permissions of the user,
        /// and creates asynchronous jobs
        /// to terminate the user's sessions.
        /// Returns the status for the POST request.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createUserTerminateSession method
        /// </param>
        /// <param name="headers">
        /// Headers of createUserTerminateSession method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<SessionTerminationMessage> CreateUserTerminateSessionAsync(CreateUserTerminateSessionRequestBody requestBody, CreateUserTerminateSessionHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateUserTerminateSessionHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/users/terminate_sessions"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<SessionTerminationMessage>(response.Data);
        }

        /// <summary>
        /// Validates the roles and permissions of the group,
        /// and creates asynchronous jobs
        /// to terminate the group's sessions.
        /// Returns the status for the POST request.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createGroupTerminateSession method
        /// </param>
        /// <param name="headers">
        /// Headers of createGroupTerminateSession method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<SessionTerminationMessage> CreateGroupTerminateSessionAsync(CreateGroupTerminateSessionRequestBody requestBody, CreateGroupTerminateSessionHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateGroupTerminateSessionHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/groups/terminate_sessions"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<SessionTerminationMessage>(response.Data);
        }

    }
}