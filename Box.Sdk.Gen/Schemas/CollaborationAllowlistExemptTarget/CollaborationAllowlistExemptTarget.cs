using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class CollaborationAllowlistExemptTarget {
        /// <summary>
        /// The unique identifier for this exemption
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// `collaboration_whitelist_exempt_target`
        /// </summary>
        [JsonPropertyName("type")]
        public CollaborationAllowlistExemptTargetTypeField? Type { get; init; }

        [JsonPropertyName("enterprise")]
        public CollaborationAllowlistExemptTargetEnterpriseField? Enterprise { get; init; }

        [JsonPropertyName("user")]
        public UserMini? User { get; init; }

        /// <summary>
        /// The time the entry was created
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; init; }

        /// <summary>
        /// The time the entry was modified
        /// </summary>
        [JsonPropertyName("modified_at")]
        public System.DateTimeOffset? ModifiedAt { get; init; }

        public CollaborationAllowlistExemptTarget() {
            
        }
    }
}