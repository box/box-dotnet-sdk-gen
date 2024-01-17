using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Sdk.Gen.Schemas {
    public class CollaborationAllowlistEntry {
        /// <summary>
        /// The unique identifier for this entry
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// `collaboration_whitelist_entry`
        /// </summary>
        [JsonPropertyName("type")]
        public CollaborationAllowlistEntryTypeField? Type { get; set; } = default;

        /// <summary>
        /// The whitelisted domain
        /// </summary>
        [JsonPropertyName("domain")]
        public string? Domain { get; set; } = default;

        /// <summary>
        /// The direction of the collaborations to allow.
        /// </summary>
        [JsonPropertyName("direction")]
        public CollaborationAllowlistEntryDirectionField? Direction { get; set; } = default;

        [JsonPropertyName("enterprise")]
        public CollaborationAllowlistEntryEnterpriseField? Enterprise { get; set; } = default;

        /// <summary>
        /// The time the entry was created at
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; } = default;

        public CollaborationAllowlistEntry() {
            
        }
    }
}