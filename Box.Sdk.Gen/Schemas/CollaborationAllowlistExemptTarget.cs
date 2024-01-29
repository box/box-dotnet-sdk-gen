using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class CollaborationAllowlistExemptTarget {
        /// <summary>
        /// The unique identifier for this exemption
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// `collaboration_whitelist_exempt_target`
        /// </summary>
        [JsonPropertyName("type")]
        public CollaborationAllowlistExemptTargetTypeField? Type { get; set; } = default;

        [JsonPropertyName("enterprise")]
        public CollaborationAllowlistExemptTargetEnterpriseField? Enterprise { get; set; } = default;

        [JsonPropertyName("user")]
        public UserMini? User { get; set; } = default;

        /// <summary>
        /// The time the entry was created
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; set; } = default;

        /// <summary>
        /// The time the entry was modified
        /// </summary>
        [JsonPropertyName("modified_at")]
        public System.DateTimeOffset? ModifiedAt { get; set; } = default;

        public CollaborationAllowlistExemptTarget() {
            
        }
    }
}