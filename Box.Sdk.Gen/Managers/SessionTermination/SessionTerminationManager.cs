using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class SessionTerminationManager : ISessionTerminationManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public SessionTerminationManager(NetworkSession? networkSession = default) {
            NetworkSession = networkSession ?? new NetworkSession();
        }
        /// <summary>
        /// Validates the roles and permissions of the user,
        /// and creates asynchronous jobs
        /// to terminate the user's sessions.
        /// Returns the status for the POST request.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of terminateUsersSessions method
        /// </param>
        /// <param name="headers">
        /// Headers of terminateUsersSessions method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<SessionTerminationMessage> TerminateUsersSessionsAsync(TerminateUsersSessionsRequestBody requestBody, TerminateUsersSessionsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new TerminateUsersSessionsHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/users/terminate_sessions"), new FetchOptions(networkSession: this.NetworkSession) { Method = "POST", Headers = headersMap, Data = SimpleJsonSerializer.Serialize(requestBody), ContentType = "application/json", ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<SessionTerminationMessage>(response.Data);
        }

        /// <summary>
        /// Validates the roles and permissions of the group,
        /// and creates asynchronous jobs
        /// to terminate the group's sessions.
        /// Returns the status for the POST request.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of terminateGroupsSessions method
        /// </param>
        /// <param name="headers">
        /// Headers of terminateGroupsSessions method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<SessionTerminationMessage> TerminateGroupsSessionsAsync(TerminateGroupsSessionsRequestBody requestBody, TerminateGroupsSessionsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new TerminateGroupsSessionsHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/groups/terminate_sessions"), new FetchOptions(networkSession: this.NetworkSession) { Method = "POST", Headers = headersMap, Data = SimpleJsonSerializer.Serialize(requestBody), ContentType = "application/json", ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<SessionTerminationMessage>(response.Data);
        }

    }
}