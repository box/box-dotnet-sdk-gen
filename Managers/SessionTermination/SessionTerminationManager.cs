using System.IO;
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
        public async System.Threading.Tasks.Task<SessionTerminationMessage> CreateUserTerminateSession(CreateUserTerminateSessionRequestBodyArg requestBody, CreateUserTerminateSessionHeadersArg? headers = default) {
            headers = headers ?? new CreateUserTerminateSessionHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/users/terminate_sessions"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<SessionTerminationMessage>(response.Text);
        }

        public async System.Threading.Tasks.Task<SessionTerminationMessage> CreateGroupTerminateSession(CreateGroupTerminateSessionRequestBodyArg requestBody, CreateGroupTerminateSessionHeadersArg? headers = default) {
            headers = headers ?? new CreateGroupTerminateSessionHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/groups/terminate_sessions"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<SessionTerminationMessage>(response.Text);
        }

    }
}