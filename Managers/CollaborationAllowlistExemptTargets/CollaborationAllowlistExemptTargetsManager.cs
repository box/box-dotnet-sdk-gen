using System.IO;
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
    public class CollaborationAllowlistExemptTargetsManager {
        public IAuth Auth { get; }

        public NetworkSession NetworkSession { get; }

        public CollaborationAllowlistExemptTargetsManager(IAuth auth, NetworkSession networkSession) {
            Auth = auth;
            NetworkSession = networkSession;
        }
        public async System.Threading.Tasks.Task<CollaborationAllowlistExemptTargets> GetCollaborationWhitelistExemptTargets(GetCollaborationWhitelistExemptTargetsQueryParamsArg queryParams, GetCollaborationWhitelistExemptTargetsHeadersArg headers) {
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string>() { { "marker", Utils.ToString(queryParams.Marker) }, { "limit", Utils.ToString(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/collaboration_whitelist_exempt_targets"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<CollaborationAllowlistExemptTargets>(response.Text);
        }

        public async System.Threading.Tasks.Task<CollaborationAllowlistExemptTarget> CreateCollaborationWhitelistExemptTarget(CreateCollaborationWhitelistExemptTargetRequestBodyArg requestBody, CreateCollaborationWhitelistExemptTargetHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/collaboration_whitelist_exempt_targets"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<CollaborationAllowlistExemptTarget>(response.Text);
        }

        public async System.Threading.Tasks.Task<CollaborationAllowlistExemptTarget> GetCollaborationWhitelistExemptTargetById(string collaborationWhitelistExemptTargetId, GetCollaborationWhitelistExemptTargetByIdHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/collaboration_whitelist_exempt_targets/", collaborationWhitelistExemptTargetId), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<CollaborationAllowlistExemptTarget>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteCollaborationWhitelistExemptTargetById(string collaborationWhitelistExemptTargetId, DeleteCollaborationWhitelistExemptTargetByIdHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/collaboration_whitelist_exempt_targets/", collaborationWhitelistExemptTargetId), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

    }
}