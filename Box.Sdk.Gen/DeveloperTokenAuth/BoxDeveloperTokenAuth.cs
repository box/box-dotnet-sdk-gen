using Unions;
using Errors;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen {
    public class BoxDeveloperTokenAuth : IAuthentication {
        public string Token { get; set; }

        public BoxDeveloperTokenAuth(string token) {
            Token = token;
        }
        /// <summary>
        /// Retrieves stored developer token
        /// </summary>
        /// <param name="networkSession">
        /// An object to keep network session state
        /// </param>
        public async System.Threading.Tasks.Task<AccessToken> RetrieveTokenAsync(NetworkSession? networkSession = null) {
            return new AccessToken() { AccessTokenField = this.Token };
        }

        /// <summary>
        /// Developer token cannot be refreshed
        /// </summary>
        /// <param name="networkSession">
        /// An object to keep network session state
        /// </param>
        public async System.Threading.Tasks.Task<AccessToken> RefreshTokenAsync(NetworkSession? networkSession = null) {
            throw new BoxSdkError(message: "Developer token has expired. Please provide a new one.");
        }

    }
}