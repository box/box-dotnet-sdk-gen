using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class User : UserMini {
        /// <summary>
        /// When the user object was created
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; init; }

        /// <summary>
        /// When the user object was last modified
        /// </summary>
        [JsonPropertyName("modified_at")]
        public System.DateTimeOffset? ModifiedAt { get; init; }

        /// <summary>
        /// The language of the user, formatted in modified version of the
        /// [ISO 639-1](/guides/api-calls/language-codes) format.
        /// </summary>
        [JsonPropertyName("language")]
        public string? Language { get; init; }

        /// <summary>
        /// The user's timezone
        /// </summary>
        [JsonPropertyName("timezone")]
        public string? Timezone { get; init; }

        /// <summary>
        /// The user’s total available space amount in bytes
        /// </summary>
        [JsonPropertyName("space_amount")]
        public long? SpaceAmount { get; init; }

        /// <summary>
        /// The amount of space in use by the user
        /// </summary>
        [JsonPropertyName("space_used")]
        public long? SpaceUsed { get; init; }

        /// <summary>
        /// The maximum individual file size in bytes the user can have
        /// </summary>
        [JsonPropertyName("max_upload_size")]
        public long? MaxUploadSize { get; init; }

        /// <summary>
        /// The user's account status
        /// </summary>
        [JsonPropertyName("status")]
        public UserStatusField? Status { get; init; }

        /// <summary>
        /// The user’s job title
        /// </summary>
        [JsonPropertyName("job_title")]
        public string? JobTitle { get; init; }

        /// <summary>
        /// The user’s phone number
        /// </summary>
        [JsonPropertyName("phone")]
        public string? Phone { get; init; }

        /// <summary>
        /// The user’s address
        /// </summary>
        [JsonPropertyName("address")]
        public string? Address { get; init; }

        /// <summary>
        /// URL of the user’s avatar image
        /// </summary>
        [JsonPropertyName("avatar_url")]
        public string? AvatarUrl { get; init; }

        /// <summary>
        /// An alternate notification email address to which email
        /// notifications are sent. When it's confirmed, this will be
        /// the email address to which notifications are sent instead of
        /// to the primary email address.
        /// </summary>
        [JsonPropertyName("notification_email")]
        public UserNotificationEmailField? NotificationEmail { get; init; }

        public User(string id, UserBaseTypeField type = UserBaseTypeField.User) : base(id, type) {
            
        }
    }
}