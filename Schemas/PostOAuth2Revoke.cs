using System.IO;
using Unions;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    public class PostOAuth2Revoke {
        [JsonPropertyName("client_id")]
        public string ClientId { get; }

        [JsonPropertyName("client_secret")]
        public string ClientSecret { get; }

        [JsonPropertyName("token")]
        public string Token { get; }

        public PostOAuth2Revoke(string clientId, string clientSecret, string token) {
            ClientId = clientId;
            ClientSecret = clientSecret;
            Token = token;
        }
    }
}