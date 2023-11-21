using Box.Schemas;
using System.Threading.Tasks;

namespace Box
{
    /// <summary>
    /// Interface used for authentication with BoxAPI.
    /// </summary>
    public interface IAuthentication
    {
        /// <summary>
        /// Retrieves current token. If token is no longer valid, new token is fetched using RefreshToken and then it's returned.
        /// </summary>
        /// <returns>An access token.</returns>
        Task<AccessToken> RetrieveTokenAsync(NetworkSession? networkSession = null);

        /// <summary>
        /// Refreshes the token.
        /// </summary>
        /// <returns>An access token.</returns>
        Task<AccessToken> RefreshTokenAsync(NetworkSession? networkSession = null);
    }
}
