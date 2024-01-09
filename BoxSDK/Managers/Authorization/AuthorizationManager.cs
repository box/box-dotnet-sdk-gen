using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using StringExtensions;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class AuthorizationManager : IAuthorizationManager {
        public IAuthentication? Auth { get; set; } = default;

        public NetworkSession NetworkSession { get; set; }

        public AuthorizationManager(NetworkSession networkSession = default) {
            NetworkSession = networkSession ?? new NetworkSession();
        }
        /// <summary>
        /// Authorize a user by sending them through the [Box](https://box.com)
        /// website and request their permission to act on their behalf.
        /// 
        /// This is the first step when authenticating a user using
        /// OAuth 2.0. To request a user's authorization to use the Box APIs
        /// on their behalf you will need to send a user to the URL with this
        /// format.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of authorizeUser method
        /// </param>
        /// <param name="headers">
        /// Headers of authorizeUser method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task AuthorizeUserAsync(AuthorizeUserQueryParams queryParams, AuthorizeUserHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new AuthorizeUserHeaders();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "response_type", StringUtils.ToStringRepresentation(queryParams.ResponseType) }, { "client_id", StringUtils.ToStringRepresentation(queryParams.ClientId) }, { "redirect_uri", StringUtils.ToStringRepresentation(queryParams.RedirectUri) }, { "state", StringUtils.ToStringRepresentation(queryParams.State) }, { "scope", StringUtils.ToStringRepresentation(queryParams.Scope) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.Oauth2Url, "/authorize"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

        /// <summary>
        /// Request an Access Token using either a client-side obtained OAuth 2.0
        /// authorization code or a server-side JWT assertion.
        /// 
        /// An Access Token is a string that enables Box to verify that a
        /// request belongs to an authorized session. In the normal order of
        /// operations you will begin by requesting authentication from the
        /// [authorize](#get-authorize) endpoint and Box will send you an
        /// authorization code.
        /// 
        /// You will then send this code to this endpoint to exchange it for
        /// an Access Token. The returned Access Token can then be used to to make
        /// Box API calls.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of requestAccessToken method
        /// </param>
        /// <param name="headers">
        /// Headers of requestAccessToken method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<AccessToken> RequestAccessTokenAsync(PostOAuth2Token requestBody, RequestAccessTokenHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new RequestAccessTokenHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/oauth2/token"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/x-www-form-urlencoded", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<AccessToken>(response.Data);
        }

        /// <summary>
        /// Refresh an Access Token using its client ID, secret, and refresh token.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of refreshAccessToken method
        /// </param>
        /// <param name="headers">
        /// Headers of refreshAccessToken method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<AccessToken> RefreshAccessTokenAsync(PostOAuth2TokenRefreshAccessToken requestBody, RefreshAccessTokenHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new RefreshAccessTokenHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/oauth2/token#refresh"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/x-www-form-urlencoded", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<AccessToken>(response.Data);
        }

        /// <summary>
        /// Revoke an active Access Token, effectively logging a user out
        /// that has been previously authenticated.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of revokeAccessToken method
        /// </param>
        /// <param name="headers">
        /// Headers of revokeAccessToken method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task RevokeAccessTokenAsync(PostOAuth2Revoke requestBody, RevokeAccessTokenHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new RevokeAccessTokenHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/oauth2/revoke"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/x-www-form-urlencoded", responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

    }
}