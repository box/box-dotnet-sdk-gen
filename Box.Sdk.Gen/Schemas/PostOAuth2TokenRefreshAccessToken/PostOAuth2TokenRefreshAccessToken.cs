using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class PostOAuth2TokenRefreshAccessToken {
        /// <summary>
        /// The type of request being made, in this case a refresh request.
        /// </summary>
        [JsonPropertyName("grant_type")]
        public PostOAuth2TokenRefreshAccessTokenGrantTypeField GrantType { get; }

        /// <summary>
        /// The client ID of the application requesting to refresh the token.
        /// </summary>
        [JsonPropertyName("client_id")]
        public string ClientId { get; }

        /// <summary>
        /// The client secret of the application requesting to refresh the token.
        /// </summary>
        [JsonPropertyName("client_secret")]
        public string ClientSecret { get; }

        /// <summary>
        /// The refresh token to refresh.
        /// </summary>
        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; }

        public PostOAuth2TokenRefreshAccessToken(string clientId, string clientSecret, string refreshToken, PostOAuth2TokenRefreshAccessTokenGrantTypeField grantType = PostOAuth2TokenRefreshAccessTokenGrantTypeField.RefreshToken) {
            GrantType = grantType;
            ClientId = clientId;
            ClientSecret = clientSecret;
            RefreshToken = refreshToken;
        }
    }
}