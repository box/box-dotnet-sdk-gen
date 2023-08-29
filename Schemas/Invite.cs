using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class Invite {
        /// <summary>
        /// The unique identifier for this invite
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// `invite`
        /// </summary>
        [JsonPropertyName("type")]
        public InviteTypeField? Type { get; set; } = default;

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
        public string? CreatedAt { get; set; } = default;

        /// <summary>
        /// When the invite was modified.
        /// </summary>
        [JsonPropertyName("modified_at")]
        public string? ModifiedAt { get; set; } = default;

        public Invite() {
            
        }
    }
}