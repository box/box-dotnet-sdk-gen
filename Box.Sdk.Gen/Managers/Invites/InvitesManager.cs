using System.Text.Json.Serialization;
using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using StringExtensions;
using DictionaryExtensions;
using Serializer;
using Fetch;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class InvitesManager : IInvitesManager {
        public IAuthentication? Auth { get; set; } = default;

        public NetworkSession NetworkSession { get; set; }

        public InvitesManager(NetworkSession networkSession = default) {
            NetworkSession = networkSession ?? new NetworkSession();
        }
        /// <summary>
        /// Invites an existing external user to join an enterprise.
        /// 
        /// The existing user can not be part of another enterprise and
        /// must already have a Box account. Once invited, the user will receive an
        /// email and are prompted to accept the invitation within the
        /// Box web application.
        /// 
        /// This method requires the "Manage An Enterprise" scope enabled for
        /// the application, which can be enabled within the developer console.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createInvite method
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of createInvite method
        /// </param>
        /// <param name="headers">
        /// Headers of createInvite method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Invite> CreateInviteAsync(CreateInviteRequestBody requestBody, CreateInviteQueryParams? queryParams = default, CreateInviteHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new CreateInviteQueryParams();
            headers = headers ?? new CreateInviteHeaders();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/invites"), new FetchOptions(method: "POST", parameters: queryParamsMap, headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Invite>(response.Data);
        }

        /// <summary>
        /// Returns the status of a user invite.
        /// </summary>
        /// <param name="inviteId">
        /// The ID of an invite.
        /// Example: "213723"
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of getInviteById method
        /// </param>
        /// <param name="headers">
        /// Headers of getInviteById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Invite> GetInviteByIdAsync(string inviteId, GetInviteByIdQueryParams? queryParams = default, GetInviteByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetInviteByIdQueryParams();
            headers = headers ?? new GetInviteByIdHeaders();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/invites/", StringUtils.ToStringRepresentation(inviteId)), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Invite>(response.Data);
        }

    }
}