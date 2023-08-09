using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetAuthorizeQueryParamsArg {
        public GetAuthorizeQueryParamsArgResponseTypeField ResponseType { get; }

        public string ClientId { get; }

        public string RedirectUri { get; }

        public string State { get; }

        public string Scope { get; }

        public GetAuthorizeQueryParamsArg(GetAuthorizeQueryParamsArgResponseTypeField responseType, string clientId, string redirectUri, string state, string scope) {
            ResponseType = responseType;
            ClientId = clientId;
            RedirectUri = redirectUri;
            State = state;
            Scope = scope;
        }
    }
}