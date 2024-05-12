using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class EmailAlias {
        /// <summary>
        /// The unique identifier for this object
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// `email_alias`
        /// </summary>
        [JsonPropertyName("type")]
        public EmailAliasTypeField? Type { get; set; } = default;

        /// <summary>
        /// The email address
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; } = default;

        /// <summary>
        /// Whether the email address has been confirmed
        /// </summary>
        [JsonPropertyName("is_confirmed")]
        public bool? IsConfirmed { get; set; } = default;

        public EmailAlias() {
            
        }
    }
}