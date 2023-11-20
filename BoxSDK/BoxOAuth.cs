using Box.Schemas;
using Fetch;
using Serializer;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Json;

namespace Box
{
    /// <summary>
    /// Config used for OAuth 2.0 authentication
    /// </summary>
    public class OAuthConfig
    {
        /// <summary>
        /// Used for identifying the application the user is authenticating with.
        /// </summary>
        public string ClientId { get; }

        /// <summary>
        /// Box API secret used for making auth requests.
        /// </summary>
        public string ClientSecret { get; }

        /// <summary>
        /// Token storage
        /// </summary>
        public ITokenStorage TokenStorage { get; private init; }

        public OAuthConfig(string clientId, string clientSecret, ITokenStorage? tokenStorage = default)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            TokenStorage = tokenStorage ?? new InMemoryTokenStorage();
        }
    }

    static class OAuthGrantType
    {
        public const string RefreshToken = "refresh_token";
        public const string AuthorizationCode = "authorization_code";
    }

    /// <summary>
    /// Options for GetAuthorizeUrl method of BoxOAuth
    /// </summary>
    public class GetAuthorizeUrlOptions
    {
        /// <summary>
        /// The Client ID of the application that is requesting to authenticate the user.
        /// </summary>
        public string? ClientId { get; set; }
        /// <summary>
        /// The URI to which Box redirects the browser after the user has granted or denied the application permission
        /// </summary>
        public string? RedirectUri { get; set; }
        /// <summary>
        /// he type of response we'd like to receive. Must be 'code'.
        /// </summary>
        public string? ResponseType { get; set; }
        /// <summary>
        /// A custom string of your choice used to protect from CSRF attacks. Box will pass the same string to the redirect URL when authentication is complete.
        /// </summary>
        public string? State { get; set; }
        /// <summary>
        /// A comma-separated list of application scopes you'd like to authenticate the user for.
        /// </summary>
        public string? Scope { get; set; }

        public GetAuthorizeUrlOptions() {}
    }


    /// <summary>
    /// Class used to authenticate with Box using a OAuth 2.0.
    /// </summary>
    public class BoxOAuth : IAuth
    {
        ITokenStorage _tokenStorage { get; set; }

        /// <summary>
        /// Box OAuth configuration.
        /// </summary>
        public OAuthConfig Config { get; }

        /// <summary>
        /// Creates OAuth 2.0 from parameters.
        /// </summary>
        /// <param name="config"></param>
        /// <returns>An OAuth 2.0 config.</returns>
        public BoxOAuth(OAuthConfig config)
        {
            Config = config;

            _tokenStorage = config.TokenStorage;
        }

        public async Task<AccessToken> RetrieveTokenAsync(NetworkSession? networkSession = null)
        {
            var token = await _tokenStorage.GetAsync().ConfigureAwait(false);
            if (token == null)
            {
                throw new ArgumentException("Access and refresh tokens not available. Authenticate before making any API call first.");
            }
            return token;
        }

        /// <summary>
        /// Refreshes the token.
        /// </summary>
        /// <returns>An access token.</returns>
        public async Task<AccessToken> RefreshTokenAsync(NetworkSession? networkSession = null)
        {
            return await RefreshTokenAsync(networkSession, null).ConfigureAwait(false);
        }


        public async Task<AccessToken> RefreshTokenAsync(NetworkSession? networkSession = null, string? refreshToken = null)
        {
            var oldToken = await _tokenStorage.GetAsync().ConfigureAwait(false);

            var tokenForRefresh = oldToken?.RefreshToken ?? refreshToken;

            if (tokenForRefresh == null)
            {
                throw new ArgumentException("No refresh token is available.");
            }

            var payload = new Dictionary<string, string>()
            {
                { "grant_type", OAuthGrantType.RefreshToken },
                { "refresh_token", tokenForRefresh },
                { "client_id", Config.ClientId },
                { "client_secret", Config.ClientSecret }
            };

            var newToken = await SendTokenRequest(payload, networkSession).ConfigureAwait(false);
            await _tokenStorage.StoreAsync(newToken).ConfigureAwait(false);

            return newToken;
        }

        /// <summary>
        /// Get the authorization URL for the app user.
        /// </summary>
        /// <param name="options">The parameters for the authorization URL.</param>
        /// <returns>AuthorizationURL as string</returns>
        public string GetAuthorizeUrl(GetAuthorizeUrlOptions? options = null)
        {
            var parameters = new Dictionary<string, string>()
            {
                { "client_id", options?.ClientId ?? Config.ClientId },
                { "response_type", options?.ResponseType ?? "code" }
            };

            if (options?.RedirectUri != null)
            {
                parameters["redirect_uri"] = options.RedirectUri;
            }
            if (options?.State != null)
            {
                parameters["state"] = options.State;
            }
            if (options?.Scope != null)
            {
                parameters["scope"] = options.Scope;
            }

            return HttpUtils.BuildUri("https://account.box.com/api/oauth2/authorize", parameters).ToString();
        }

        /// <summary>
        /// Send token request and return the access_token
        /// </summary>
        /// <param name="code">Short-lived authorization code.</param>
        /// <param name="networkSession">An object to keep network session state.</param>
        /// <returns>AccessToken</returns>
        public async Task<AccessToken> GetTokensAuthorizationCodeGrantAsync(string code, NetworkSession? networkSession = null)
        {
            var payload = new Dictionary<string, string>()
            {
                { "grant_type", OAuthGrantType.AuthorizationCode },
                { "code", code },
                { "client_id", Config.ClientId },
                { "client_secret", Config.ClientSecret }
            };

            var newToken = await SendTokenRequest(payload, networkSession).ConfigureAwait(false);
            await _tokenStorage.StoreAsync(newToken).ConfigureAwait(false);

            return newToken;
        }

        private async Task<AccessToken> SendTokenRequest(Dictionary<string, string> payload, NetworkSession? networkSession)
        {
            var tokenUrl = "https://api.box.com/oauth2/token";

            var response = await HttpClientAdapter.FetchAsync(tokenUrl, new FetchOptions
            {
                Method = "POST",
                Data = SimpleJsonSerializer.Serialize(payload),
                ContentType = ContentTypes.FormUrlEncoded,
                NetworkSession = networkSession
            }).ConfigureAwait(false);

            return SimpleJsonSerializer.Deserialize<AccessToken>(response.Data);
        }

    }
}
