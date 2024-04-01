using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class Invite {
        /// <summary>
        /// The unique identifier for this invite
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// `invite`
        /// </summary>
        [JsonPropertyName("type")]
        public InviteTypeField Type { get; set; }

        /// <summary>
        /// A representation of a Box enterprise
        /// </summary>
        [JsonPropertyName("invited_to")]
        public InviteInvitedToField? InvitedTo { get; set; } = default;

        [JsonPropertyName("actionable_by")]
        public UserMini? ActionableBy { get; set; } = default;

        [JsonPropertyName("invited_by")]
        public UserMini? InvitedBy { get; set; } = default;

        /// <summary>
        /// The status of the invite
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; } = default;

        /// <summary>
        /// When the invite was created
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; set; } = default;

        /// <summary>
        /// When the invite was modified.
        /// </summary>
        [JsonPropertyName("modified_at")]
        public System.DateTimeOffset? ModifiedAt { get; set; } = default;

        public Invite(string id, InviteTypeField type = InviteTypeField.Invite) {
            Id = id;
            Type = type;
        }
    }
}