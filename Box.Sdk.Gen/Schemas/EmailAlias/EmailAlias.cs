using Unions;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;

namespace Box.Sdk.Gen.Schemas {
    public class EmailAlias {
        /// <summary>
        /// The unique identifier for this object
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// `email_alias`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<EmailAliasTypeField>))]
        public StringEnum<EmailAliasTypeField>? Type { get; init; }

        /// <summary>
        /// The email address
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; init; }

        /// <summary>
        /// Whether the email address has been confirmed
        /// </summary>
        [JsonPropertyName("is_confirmed")]
        public bool? IsConfirmed { get; init; }

        public EmailAlias() {
            
        }
    }
}