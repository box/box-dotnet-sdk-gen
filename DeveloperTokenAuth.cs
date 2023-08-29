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
        public string Token;
        

        /// <summary>
        /// Creates DeveloperTokenAuth from parameters.
        /// </summary>
        /// <param name="token"></param>
        /// <returns>A DeveloperTokenAuth.</returns>
        public DeveloperTokenAuth(string token)
        {
            Token = token;
        }

        public async Task<string> RetrieveToken(NetworkSession? NetworkSession = null)
        {
            return await Task.FromResult(Token);
        }

        public async Task<string> RefreshToken(NetworkSession? NetworkSession = null)
        {
            throw new Exception("Developer token has expired. Please provide a new one.");
        }
    }
}
