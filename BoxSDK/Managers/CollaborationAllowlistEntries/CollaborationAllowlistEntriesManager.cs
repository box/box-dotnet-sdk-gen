using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using StringExtensions;
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
        /// <summary>
        /// Returns the list domains that have been deemed safe to create collaborations
        /// for within the current enterprise.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getCollaborationWhitelistEntries method
        /// </param>
        /// <param name="headers">
        /// Headers of getCollaborationWhitelistEntries method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<CollaborationAllowlistEntries> GetCollaborationWhitelistEntriesAsync(GetCollaborationWhitelistEntriesQueryParamsArg? queryParams = default, GetCollaborationWhitelistEntriesHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetCollaborationWhitelistEntriesQueryParamsArg();
            headers = headers ?? new GetCollaborationWhitelistEntriesHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/collaboration_whitelist_entries"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<CollaborationAllowlistEntries>(response.Data);
        }

        /// <summary>
        /// Creates a new entry in the list of allowed domains to allow
        /// collaboration for.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createCollaborationWhitelistEntry method
        /// </param>
        /// <param name="headers">
        /// Headers of createCollaborationWhitelistEntry method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<CollaborationAllowlistEntry> CreateCollaborationWhitelistEntryAsync(CreateCollaborationWhitelistEntryRequestBodyArg requestBody, CreateCollaborationWhitelistEntryHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateCollaborationWhitelistEntryHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/collaboration_whitelist_entries"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<CollaborationAllowlistEntry>(response.Data);
        }

        /// <summary>
        /// Returns a domain that has been deemed safe to create collaborations
        /// for within the current enterprise.
        /// </summary>
        /// <param name="collaborationWhitelistEntryId">
        /// The ID of the entry in the list.
        /// Example: "213123"
        /// </param>
        /// <param name="headers">
        /// Headers of getCollaborationWhitelistEntryById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<CollaborationAllowlistEntry> GetCollaborationWhitelistEntryByIdAsync(string collaborationWhitelistEntryId, GetCollaborationWhitelistEntryByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetCollaborationWhitelistEntryByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/collaboration_whitelist_entries/", StringUtils.ToStringRepresentation(collaborationWhitelistEntryId)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<CollaborationAllowlistEntry>(response.Data);
        }

        /// <summary>
        /// Removes a domain from the list of domains that have been deemed safe to create
        /// collaborations for within the current enterprise.
        /// </summary>
        /// <param name="collaborationWhitelistEntryId">
        /// The ID of the entry in the list.
        /// Example: "213123"
        /// </param>
        /// <param name="headers">
        /// Headers of deleteCollaborationWhitelistEntryById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteCollaborationWhitelistEntryByIdAsync(string collaborationWhitelistEntryId, DeleteCollaborationWhitelistEntryByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteCollaborationWhitelistEntryByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/collaboration_whitelist_entries/", StringUtils.ToStringRepresentation(collaborationWhitelistEntryId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

    }
}