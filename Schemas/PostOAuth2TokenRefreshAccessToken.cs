using System.IO;
using Unions;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    public class PostOAuth2TokenRefreshAccessToken {
        [JsonPropertyName("grant_type")]
        public PostOAuth2TokenRefreshAccessTokenGrantTypeField GrantType { get; }

        [JsonPropertyName("client_id")]
        public string ClientId { get; }

        [JsonPropertyName("client_secret")]
        public string ClientSecret { get; }

        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; }

        public PostOAuth2TokenRefreshAccessToken(PostOAuth2TokenRefreshAccessTokenGrantTypeField grantType, string clientId, string clientSecret, string refreshToken) {
            GrantType = grantType;
            ClientId = clientId;
            ClientSecret = clientSecret;
            RefreshToken = refreshToken;
        }
    }
}