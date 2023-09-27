using Box.Schemas;
using System;
using System.Threading.Tasks;

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
        
        public OAuthConfig(string clientId, string clientSecret, ITokenStorage tokenStorage = default) {
            ClientId = clientId;
            ClientSecret = clientSecret;
            TokenStorage = tokenStorage ?? new InMemoryTokenStorage();
        }
    }

    /// <summary>
    /// Class used to authenticate with Box using a OAuth 2.0.
    /// </summary>
    public class BoxOAuth : IAuth
    {
        /// <summary>
        /// Creates OAuth 2.0 from parameters.
        /// </summary>
        /// <param name="config"></param>
        /// <returns>An OAuth 2.0 config.</returns>
        public BoxOAuth(OAuthConfig config)
        {
            throw new NotImplementedException();
        }

        public async Task<AccessToken> RetrieveTokenAsync(NetworkSession? NetworkSession = null)
        {
            throw new NotImplementedException();
        }

        public async Task<AccessToken> RefreshTokenAsync(NetworkSession? NetworkSession = null)
        {
            throw new NotImplementedException();
        }

        public string GetAuthorizeUrl()
        {
            throw new NotImplementedException();
        }
    }
}
