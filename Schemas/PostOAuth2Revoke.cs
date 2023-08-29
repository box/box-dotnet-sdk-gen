using System.IO;
using Unions;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    public class PostOAuth2Revoke {
        /// <summary>
        /// The Client ID of the application requesting to revoke the
        /// access token.
        /// </summary>
        [JsonPropertyName("client_id")]
        public string? ClientId { get; set; } = default;

        /// <summary>
        /// The client secret of the application requesting to revoke
        /// an access token.
        /// </summary>
        [JsonPropertyName("client_secret")]
        public string? ClientSecret { get; set; } = default;

        /// <summary>
        /// The access token to revoke.
        /// </summary>
        [JsonPropertyName("token")]
        public string? Token { get; set; } = default;

        public PostOAuth2Revoke() {
            
        }
    }
}