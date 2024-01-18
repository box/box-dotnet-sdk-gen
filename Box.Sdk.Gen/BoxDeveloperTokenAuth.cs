using Box.Sdk.Gen.Schemas;
using System;
using System.Threading.Tasks;

namespace Box.Sdk.Gen
{
    /// <summary>
    /// Class used to authenticate with Box using a developer token.
    /// </summary>
    public class BoxDeveloperTokenAuth : IAuthentication
    {
        /// <summary>
        /// Developer token.
        /// </summary>
        public AccessToken Token;


        /// <summary>
        /// Creates BoxDeveloperTokenAuth from parameters.
        /// </summary>
        /// <param name="token"></param>
        /// <returns>A BoxDeveloperTokenAuth.</returns>
        public BoxDeveloperTokenAuth(string token)
        {
            Token = new AccessToken() { AccessTokenField = token };
        }

        public async Task<AccessToken> RetrieveTokenAsync(NetworkSession? networkSession = null)
        {
            return await System.Threading.Tasks.Task.FromResult(Token);
        }

        public Task<AccessToken> RefreshTokenAsync(NetworkSession? networkSession = null)
        {
            throw new NotSupportedException();
        }
    }
}
