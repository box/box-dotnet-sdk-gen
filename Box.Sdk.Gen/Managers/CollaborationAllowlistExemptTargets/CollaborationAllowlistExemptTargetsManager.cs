using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class CollaborationAllowlistExemptTargetsManager : ICollaborationAllowlistExemptTargetsManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public CollaborationAllowlistExemptTargetsManager(NetworkSession? networkSession = default) {
            NetworkSession = networkSession ?? new NetworkSession();
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
        public async System.Threading.Tasks.Task<CollaborationAllowlistExemptTargets> GetCollaborationWhitelistExemptTargetsAsync(GetCollaborationWhitelistExemptTargetsQueryParams? queryParams = default, GetCollaborationWhitelistExemptTargetsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetCollaborationWhitelistExemptTargetsQueryParams();
            headers = headers ?? new GetCollaborationWhitelistExemptTargetsHeaders();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/collaboration_whitelist_exempt_targets"), new FetchOptions(networkSession: this.NetworkSession) { Method = "GET", Parameters = queryParamsMap, Headers = headersMap, ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
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
        public async System.Threading.Tasks.Task<CollaborationAllowlistExemptTarget> CreateCollaborationWhitelistExemptTargetAsync(CreateCollaborationWhitelistExemptTargetRequestBody requestBody, CreateCollaborationWhitelistExemptTargetHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateCollaborationWhitelistExemptTargetHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/collaboration_whitelist_exempt_targets"), new FetchOptions(networkSession: this.NetworkSession) { Method = "POST", Headers = headersMap, Data = SimpleJsonSerializer.Serialize(requestBody), ContentType = "application/json", ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
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
        public async System.Threading.Tasks.Task<CollaborationAllowlistExemptTarget> GetCollaborationWhitelistExemptTargetByIdAsync(string collaborationWhitelistExemptTargetId, GetCollaborationWhitelistExemptTargetByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetCollaborationWhitelistExemptTargetByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/collaboration_whitelist_exempt_targets/", StringUtils.ToStringRepresentation(collaborationWhitelistExemptTargetId)), new FetchOptions(networkSession: this.NetworkSession) { Method = "GET", Headers = headersMap, ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
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
        public async System.Threading.Tasks.Task DeleteCollaborationWhitelistExemptTargetByIdAsync(string collaborationWhitelistExemptTargetId, DeleteCollaborationWhitelistExemptTargetByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteCollaborationWhitelistExemptTargetByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/collaboration_whitelist_exempt_targets/", StringUtils.ToStringRepresentation(collaborationWhitelistExemptTargetId)), new FetchOptions(networkSession: this.NetworkSession) { Method = "DELETE", Headers = headersMap, ResponseFormat = null, Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
        }

    }
}