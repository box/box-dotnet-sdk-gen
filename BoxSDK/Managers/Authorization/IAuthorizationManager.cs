using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IAuthorizationManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task AuthorizeUserAsync(AuthorizeUserQueryParams queryParams, AuthorizeUserHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<AccessToken> RequestAccessTokenAsync(PostOAuth2Token requestBody, RequestAccessTokenHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<AccessToken> RefreshAccessTokenAsync(PostOAuth2TokenRefreshAccessToken requestBody, RefreshAccessTokenHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task RevokeAccessTokenAsync(PostOAuth2Revoke requestBody, RevokeAccessTokenHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}