using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class Collaboration {
        /// <summary>
        /// The unique identifier for this collaboration.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        /// <summary>
        /// `collaboration`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<CollaborationTypeField>))]
        public StringEnum<CollaborationTypeField> Type { get; }

        [JsonPropertyName("item")]
        public FileOrFolderOrWebLink? Item { get; init; }

        [JsonPropertyName("accessible_by")]
        public GroupMiniOrUserCollaborations? AccessibleBy { get; init; }

        /// <summary>
        /// The email address used to invite an unregistered collaborator, if
        /// they are not a registered user.
        /// </summary>
        [JsonPropertyName("invite_email")]
        public string? InviteEmail { get; init; }

        /// <summary>
        /// The level of access granted.
        /// </summary>
        [JsonPropertyName("role")]
        [JsonConverter(typeof(StringEnumConverter<CollaborationRoleField>))]
        public StringEnum<CollaborationRoleField>? Role { get; init; }

        /// <summary>
        /// When the collaboration will expire, or `null` if no expiration
        /// date is set.
        /// </summary>
        [JsonPropertyName("expires_at")]
        public System.DateTimeOffset? ExpiresAt { get; init; }

        /// <summary>
        /// If set to `true`, collaborators have access to
        /// shared items, but such items won't be visible in the
        /// All Files list. Additionally, collaborators won't
        /// see the the path to the root folder for the
        /// shared item.
        /// </summary>
        [JsonPropertyName("is_access_only")]
        public bool? IsAccessOnly { get; init; }

        /// <summary>
        /// The status of the collaboration invitation. If the status
        /// is `pending`, `login` and `name` return an empty string.
        /// </summary>
        [JsonPropertyName("status")]
        [JsonConverter(typeof(StringEnumConverter<CollaborationStatusField>))]
        public StringEnum<CollaborationStatusField>? Status { get; init; }

        /// <summary>
        /// When the `status` of the collaboration object changed to
        /// `accepted` or `rejected`.
        /// </summary>
        [JsonPropertyName("acknowledged_at")]
        public System.DateTimeOffset? AcknowledgedAt { get; init; }

        [JsonPropertyName("created_by")]
        public UserCollaborations? CreatedBy { get; init; }

        /// <summary>
        /// When the collaboration object was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; init; }

        /// <summary>
        /// When the collaboration object was last modified.
        /// </summary>
        [JsonPropertyName("modified_at")]
        public System.DateTimeOffset? ModifiedAt { get; init; }

        [JsonPropertyName("acceptance_requirements_status")]
        public CollaborationAcceptanceRequirementsStatusField? AcceptanceRequirementsStatus { get; init; }

        public Collaboration(string id, CollaborationTypeField type = CollaborationTypeField.Collaboration) {
            Id = id;
            Type = type;
        }
        
        [JsonConstructorAttribute]
        internal Collaboration(string id, StringEnum<CollaborationTypeField> type) {
            Id = id;
            Type = CollaborationTypeField.Collaboration;
        }
    }
}