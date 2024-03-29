using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class Collaboration {
        /// <summary>
        /// The unique identifier for this collaboration.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// `collaboration`
        /// </summary>
        [JsonPropertyName("type")]
        public CollaborationTypeField Type { get; set; }

        [JsonPropertyName("item")]
        public FileOrFolderOrWebLink? Item { get; set; } = default;

        [JsonPropertyName("accessible_by")]
        public GroupMiniOrUserCollaborations? AccessibleBy { get; set; } = default;

        /// <summary>
        /// The email address used to invite an unregistered collaborator, if
        /// they are not a registered user.
        /// </summary>
        [JsonPropertyName("invite_email")]
        public string? InviteEmail { get; set; } = default;

        /// <summary>
        /// The level of access granted.
        /// </summary>
        [JsonPropertyName("role")]
        public CollaborationRoleField? Role { get; set; } = default;

        /// <summary>
        /// When the collaboration will expire, or `null` if no expiration
        /// date is set.
        /// </summary>
        [JsonPropertyName("expires_at")]
        public System.DateTimeOffset? ExpiresAt { get; set; } = default;

        /// <summary>
        /// If set to `true`, collaborators have access to
        /// shared items, but such items won't be visible in the
        /// All Files list. Additionally, collaborators won't
        /// see the the path to the root folder for the
        /// shared item.
        /// </summary>
        [JsonPropertyName("is_access_only")]
        public bool? IsAccessOnly { get; set; } = default;

        /// <summary>
        /// The status of the collaboration invitation. If the status
        /// is `pending`, `login` and `name` return an empty string.
        /// </summary>
        [JsonPropertyName("status")]
        public CollaborationStatusField? Status { get; set; } = default;

        /// <summary>
        /// When the `status` of the collaboration object changed to
        /// `accepted` or `rejected`.
        /// </summary>
        [JsonPropertyName("acknowledged_at")]
        public System.DateTimeOffset? AcknowledgedAt { get; set; } = default;

        [JsonPropertyName("created_by")]
        public UserCollaborations? CreatedBy { get; set; } = default;

        /// <summary>
        /// When the collaboration object was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; set; } = default;

        /// <summary>
        /// When the collaboration object was last modified.
        /// </summary>
        [JsonPropertyName("modified_at")]
        public System.DateTimeOffset? ModifiedAt { get; set; } = default;

        [JsonPropertyName("acceptance_requirements_status")]
        public CollaborationAcceptanceRequirementsStatusField? AcceptanceRequirementsStatus { get; set; } = default;

        public Collaboration(string id, CollaborationTypeField type) {
            Id = id;
            Type = type;
        }
    }
}