using Box.Schemas;
using System;
using System.Threading.Tasks;

namespace Box
{
    /// <summary>
    /// Class used to authenticate with Box using a developer token.
    /// </summary>
    public class DeveloperTokenAuth : IAuth
    {
        /// <summary>
        /// Developer token.
        /// </summary>
        public AccessToken Token;


        /// <summary>
        /// Creates DeveloperTokenAuth from parameters.
        /// </summary>
        /// <param name="token"></param>
        /// <returns>A DeveloperTokenAuth.</returns>
        public DeveloperTokenAuth(string token)
        {
            Token = new AccessToken() { AccessTokenField = token };
        }

        public async Task<AccessToken> RetrieveToken(NetworkSession? NetworkSession = null)
        {
            return await System.Threading.Tasks.Task.FromResult(Token);
        }

        public async Task<AccessToken> RefreshToken(NetworkSession? NetworkSession = null)
        {
            throw new Exception("Developer token has expired. Please provide a new one.");
        }
    }
}
