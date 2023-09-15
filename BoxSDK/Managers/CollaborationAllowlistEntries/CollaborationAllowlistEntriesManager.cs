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
    public class CollaborationAllowlistEntriesManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public CollaborationAllowlistEntriesManager() {
            
        }
        public async System.Threading.Tasks.Task<CollaborationAllowlistEntries> GetCollaborationWhitelistEntries(GetCollaborationWhitelistEntriesQueryParamsArg? queryParams = default, GetCollaborationWhitelistEntriesHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetCollaborationWhitelistEntriesQueryParamsArg();
            headers = headers ?? new GetCollaborationWhitelistEntriesHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "marker", Utils.ToString(queryParams.Marker) }, { "limit", Utils.ToString(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/collaboration_whitelist_entries"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<CollaborationAllowlistEntries>(response.Text);
        }

        public async System.Threading.Tasks.Task<CollaborationAllowlistEntry> CreateCollaborationWhitelistEntry(CreateCollaborationWhitelistEntryRequestBodyArg requestBody, CreateCollaborationWhitelistEntryHeadersArg? headers = default) {
            headers = headers ?? new CreateCollaborationWhitelistEntryHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/collaboration_whitelist_entries"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<CollaborationAllowlistEntry>(response.Text);
        }

        public async System.Threading.Tasks.Task<CollaborationAllowlistEntry> GetCollaborationWhitelistEntryById(string collaborationWhitelistEntryId, GetCollaborationWhitelistEntryByIdHeadersArg? headers = default) {
            headers = headers ?? new GetCollaborationWhitelistEntryByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/collaboration_whitelist_entries/", collaborationWhitelistEntryId), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<CollaborationAllowlistEntry>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteCollaborationWhitelistEntryById(string collaborationWhitelistEntryId, DeleteCollaborationWhitelistEntryByIdHeadersArg? headers = default) {
            headers = headers ?? new DeleteCollaborationWhitelistEntryByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/collaboration_whitelist_entries/", collaborationWhitelistEntryId), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

    }
}