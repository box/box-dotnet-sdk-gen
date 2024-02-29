using Unions;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen {
    public interface IAuthentication {
        public System.Threading.Tasks.Task<AccessToken> RetrieveTokenAsync(NetworkSession? networkSession = null);

        public System.Threading.Tasks.Task<AccessToken> RefreshTokenAsync(NetworkSession? networkSession = null);

        public System.Threading.Tasks.Task<string> RetrieveAuthorizationHeaderAsync(NetworkSession? networkSession = null);

    }
}