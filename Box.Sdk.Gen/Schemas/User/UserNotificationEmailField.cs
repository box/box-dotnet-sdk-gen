using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class UserNotificationEmailField {
        /// <summary>
        /// The email address to send the notifications to.
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; init; }

        /// <summary>
        /// Specifies if this email address has been confirmed.
        /// </summary>
        [JsonPropertyName("is_confirmed")]
        public bool? IsConfirmed { get; init; }

        public UserNotificationEmailField() {
            
        }
    }
}