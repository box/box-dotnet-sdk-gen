using Box.Schemas;
using System;
using System.Threading.Tasks;

namespace Box
{
    /// <summary>
    /// Config used for CCG authentication
    /// </summary>
    public class CcgConfig
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
        /// The ID of the Box Developer Edition enterprise.
        /// </summary>
        public string EnterpriseId { get; private init; }

        /// <summary>
        /// The user ID to authenticate.
        /// </summary>
        public string UserId { get; private init; }
        
        /// <summary>
        /// Token storage
        /// </summary>
        public ITokenStorage TokenStorage { get; private init; }
        
        public CcgConfig(string clientId, string clientSecret, string enterpriseId, string userId, ITokenStorage tokenStorage = default) {
            ClientId = clientId;
            ClientSecret = clientSecret;
            EnterpriseId = enterpriseId;
            UserId = userId;
            TokenStorage = tokenStorage ?? new InMemoryTokenStorage();
        }
    }

    /// <summary>
    /// Class used to authenticate with Box using a CCG Auth.
    /// </summary>
    public class BoxCcgAuth : IAuth
    {
        /// <summary>
        /// Creates CCgAuth from parameters.
        /// </summary>
        /// <param name="config"></param>
        /// <returns>A CCG config.</returns>
        public BoxCcgAuth(CcgConfig config)
        {
            throw new NotImplementedException();
        }

        public async Task<AccessToken> RetrieveToken(NetworkSession? NetworkSession = null)
        {
            throw new NotImplementedException();
        }

        public async Task<AccessToken> RefreshToken(NetworkSession? NetworkSession = null)
        {
            throw new NotImplementedException();
        }
        
        public async System.Threading.Tasks.Task AsUser(string userId)
        {
            throw new NotImplementedException();
        }  

        public async System.Threading.Tasks.Task AsEnterprise(string enterpriseid)
        {
            throw new NotImplementedException();
        }   
    }
}
