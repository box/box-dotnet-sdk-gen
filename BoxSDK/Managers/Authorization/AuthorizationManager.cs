using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public async System.Threading.Tasks.Task GetAuthorize(GetAuthorizeQueryParamsArg queryParams, GetAuthorizeHeadersArg? headers = default) {
            headers = headers ?? new GetAuthorizeHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "response_type", Utils.ToString(queryParams.ResponseType) }, { "client_id", Utils.ToString(queryParams.ClientId) }, { "redirect_uri", Utils.ToString(queryParams.RedirectUri) }, { "state", Utils.ToString(queryParams.State) }, { "scope", Utils.ToString(queryParams.Scope) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://account.box.com/api/oauth2/authorize"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

    }
}