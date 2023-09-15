using Box.Schemas;
using System.Threading.Tasks;

namespace Box
{
    /// <summary>
    /// Class used for storing Access Token in memory.
    /// </summary>
    public class InMemoryTokenStorage : ITokenStorage
    {

        private AccessToken _token;

        /// <summary>
        /// Stores access token.
        /// </summary>
        public async System.Threading.Tasks.Task Store(AccessToken token) {
            _token = token;
        }

        /// <summary>
        /// Gets stored the token.
        /// </summary>
        /// <returns>An access token.</returns>
        public async Task<AccessToken> Get() {
            return _token;
        }

        /// <summary>
        /// Clears the stored token.
        /// </summary>
        public async System.Threading.Tasks.Task Clear() {
            _token = null;
        }
    }
}
