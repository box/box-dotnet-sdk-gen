using Box.Sdk.Gen;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class PostOAuth2Revoke {
        /// <summary>
        /// The Client ID of the application requesting to revoke the
        /// access token.
        /// </summary>
        [JsonPropertyName("client_id")]
        public string? ClientId { get; init; }

        /// <summary>
        /// The client secret of the application requesting to revoke
        /// an access token.
        /// </summary>
        [JsonPropertyName("client_secret")]
        public string? ClientSecret { get; init; }

        /// <summary>
        /// The access token to revoke.
        /// </summary>
        [JsonPropertyName("token")]
        public string? Token { get; init; }

        public PostOAuth2Revoke() {
            
        }
    }
}