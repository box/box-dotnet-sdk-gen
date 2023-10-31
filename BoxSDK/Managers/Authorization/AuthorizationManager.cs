using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using StringExtensions;
using DictionaryExtensions;
using Fetch;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class AuthorizationManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public AuthorizationManager() {
            
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
        /// Query parameters of getAuthorize method
        /// </param>
        /// <param name="headers">
        /// Headers of getAuthorize method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task GetAuthorizeAsync(GetAuthorizeQueryParamsArg queryParams, GetAuthorizeHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetAuthorizeHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "response_type", StringUtils.ToStringRepresentation(queryParams.ResponseType) }, { "client_id", StringUtils.ToStringRepresentation(queryParams.ClientId) }, { "redirect_uri", StringUtils.ToStringRepresentation(queryParams.RedirectUri) }, { "state", StringUtils.ToStringRepresentation(queryParams.State) }, { "scope", StringUtils.ToStringRepresentation(queryParams.Scope) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://account.box.com/api/oauth2/authorize"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

    }
}