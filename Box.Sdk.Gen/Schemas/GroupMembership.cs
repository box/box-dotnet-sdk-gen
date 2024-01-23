using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class GroupMembership {
        /// <summary>
        /// The unique identifier for this group membership
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// `group_membership`
        /// </summary>
        [JsonPropertyName("type")]
        public GroupMembershipTypeField? Type { get; set; } = default;

        [JsonPropertyName("user")]
        public UserMini? User { get; set; } = default;

        [JsonPropertyName("group")]
        public GroupMini? Group { get; set; } = default;

        /// <summary>
        /// The role of the user in the group.
        /// </summary>
        [JsonPropertyName("role")]
        public GroupMembershipRoleField? Role { get; set; } = default;

        /// <summary>
        /// The time this membership was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; set; } = default;

        /// <summary>
        /// The time this membership was last modified.
        /// </summary>
        [JsonPropertyName("modified_at")]
        public System.DateTimeOffset? ModifiedAt { get; set; } = default;

        public GroupMembership() {
            
        }
    }
}