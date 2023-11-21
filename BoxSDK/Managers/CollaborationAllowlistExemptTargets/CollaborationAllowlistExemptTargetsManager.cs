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
    public class CollaborationAllowlistExemptTargetsManager : ICollaborationAllowlistExemptTargetsManager {
        public IAuthentication? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public CollaborationAllowlistExemptTargetsManager() {
            
        }
        /// <summary>
        /// Returns a list of users who have been exempt from the collaboration
        /// domain restrictions.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getCollaborationWhitelistExemptTargets method
        /// </param>
        /// <param name="headers">
        /// Headers of getCollaborationWhitelistExemptTargets method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<CollaborationAllowlistExemptTargets> GetCollaborationWhitelistExemptTargetsAsync(GetCollaborationWhitelistExemptTargetsQueryParamsArg? queryParams = default, GetCollaborationWhitelistExemptTargetsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetCollaborationWhitelistExemptTargetsQueryParamsArg();
            headers = headers ?? new GetCollaborationWhitelistExemptTargetsHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/collaboration_whitelist_exempt_targets"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<CollaborationAllowlistExemptTargets>(response.Data);
        }

        /// <summary>
        /// Exempts a user from the restrictions set out by the allowed list of domains
        /// for collaborations.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createCollaborationWhitelistExemptTarget method
        /// </param>
        /// <param name="headers">
        /// Headers of createCollaborationWhitelistExemptTarget method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<CollaborationAllowlistExemptTarget> CreateCollaborationWhitelistExemptTargetAsync(CreateCollaborationWhitelistExemptTargetRequestBodyArg requestBody, CreateCollaborationWhitelistExemptTargetHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateCollaborationWhitelistExemptTargetHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/collaboration_whitelist_exempt_targets"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<CollaborationAllowlistExemptTarget>(response.Data);
        }

        /// <summary>
        /// Returns a users who has been exempt from the collaboration
        /// domain restrictions.
        /// </summary>
        /// <param name="collaborationWhitelistExemptTargetId">
        /// The ID of the exemption to the list.
        /// Example: "984923"
        /// </param>
        /// <param name="headers">
        /// Headers of getCollaborationWhitelistExemptTargetById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<CollaborationAllowlistExemptTarget> GetCollaborationWhitelistExemptTargetByIdAsync(string collaborationWhitelistExemptTargetId, GetCollaborationWhitelistExemptTargetByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetCollaborationWhitelistExemptTargetByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/collaboration_whitelist_exempt_targets/", StringUtils.ToStringRepresentation(collaborationWhitelistExemptTargetId)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<CollaborationAllowlistExemptTarget>(response.Data);
        }

        /// <summary>
        /// Removes a user's exemption from the restrictions set out by the allowed list
        /// of domains for collaborations.
        /// </summary>
        /// <param name="collaborationWhitelistExemptTargetId">
        /// The ID of the exemption to the list.
        /// Example: "984923"
        /// </param>
        /// <param name="headers">
        /// Headers of deleteCollaborationWhitelistExemptTargetById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteCollaborationWhitelistExemptTargetByIdAsync(string collaborationWhitelistExemptTargetId, DeleteCollaborationWhitelistExemptTargetByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteCollaborationWhitelistExemptTargetByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/collaboration_whitelist_exempt_targets/", StringUtils.ToStringRepresentation(collaborationWhitelistExemptTargetId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

    }
}