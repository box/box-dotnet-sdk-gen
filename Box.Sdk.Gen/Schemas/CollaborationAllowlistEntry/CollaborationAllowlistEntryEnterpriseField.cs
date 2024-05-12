using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class CollaborationAllowlistEntryEnterpriseField {
        /// <summary>
        /// The unique identifier for this enterprise.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// `enterprise`
        /// </summary>
        [JsonPropertyName("type")]
        public CollaborationAllowlistEntryEnterpriseTypeField? Type { get; set; } = default;

        /// <summary>
        /// The name of the enterprise
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        public CollaborationAllowlistEntryEnterpriseField() {
            
        }
    }
}