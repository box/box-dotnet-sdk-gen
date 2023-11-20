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
    public class SessionTerminationManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public SessionTerminationManager() {
            
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
        public async System.Threading.Tasks.Task<SessionTerminationMessage> CreateUserTerminateSessionAsync(CreateUserTerminateSessionRequestBodyArg requestBody, CreateUserTerminateSessionHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateUserTerminateSessionHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/users/terminate_sessions"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
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
        public async System.Threading.Tasks.Task<SessionTerminationMessage> CreateGroupTerminateSessionAsync(CreateGroupTerminateSessionRequestBodyArg requestBody, CreateGroupTerminateSessionHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateGroupTerminateSessionHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/groups/terminate_sessions"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<SessionTerminationMessage>(response.Data);
        }

    }
}