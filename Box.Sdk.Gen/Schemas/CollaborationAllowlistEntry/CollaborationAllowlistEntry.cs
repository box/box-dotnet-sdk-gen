using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class CollaborationAllowlistEntry {
        /// <summary>
        /// The unique identifier for this entry
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// `collaboration_whitelist_entry`
        /// </summary>
        [JsonPropertyName("type")]
        public CollaborationAllowlistEntryTypeField? Type { get; init; }

        /// <summary>
        /// The whitelisted domain
        /// </summary>
        [JsonPropertyName("domain")]
        public string? Domain { get; init; }

        /// <summary>
        /// The direction of the collaborations to allow.
        /// </summary>
        [JsonPropertyName("direction")]
        public CollaborationAllowlistEntryDirectionField? Direction { get; init; }

        [JsonPropertyName("enterprise")]
        public CollaborationAllowlistEntryEnterpriseField? Enterprise { get; init; }

        /// <summary>
        /// The time the entry was created at
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; init; }

        public CollaborationAllowlistEntry() {
            
        }
    }
}