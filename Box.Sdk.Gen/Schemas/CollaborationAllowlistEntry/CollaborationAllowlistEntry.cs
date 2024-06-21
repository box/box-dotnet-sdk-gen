using Unions;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;

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
        [JsonConverter(typeof(StringEnumConverter<CollaborationAllowlistEntryTypeField>))]
        public StringEnum<CollaborationAllowlistEntryTypeField>? Type { get; init; }

        /// <summary>
        /// The whitelisted domain
        /// </summary>
        [JsonPropertyName("domain")]
        public string? Domain { get; init; }

        /// <summary>
        /// The direction of the collaborations to allow.
        /// </summary>
        [JsonPropertyName("direction")]
        [JsonConverter(typeof(StringEnumConverter<CollaborationAllowlistEntryDirectionField>))]
        public StringEnum<CollaborationAllowlistEntryDirectionField>? Direction { get; init; }

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