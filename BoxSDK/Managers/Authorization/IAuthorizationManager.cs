using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IAuthorizationManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task GetAuthorizeAsync(GetAuthorizeQueryParamsArg queryParams, GetAuthorizeHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<AccessToken> CreateOauth2TokenAsync(PostOAuth2Token requestBody, CreateOauth2TokenHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<AccessToken> CreateOauth2TokenRefreshAsync(PostOAuth2TokenRefreshAccessToken requestBody, CreateOauth2TokenRefreshHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task CreateOauth2RevokeAsync(PostOAuth2Revoke requestBody, CreateOauth2RevokeHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}