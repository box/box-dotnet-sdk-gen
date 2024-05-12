using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class RetentionPolicyAssignmentCountsField {
        /// <summary>
        /// The number of enterprise assignments this policy has. The maximum value is 1.
        /// </summary>
        [JsonPropertyName("enterprise")]
        public long? Enterprise { get; set; } = default;

        /// <summary>
        /// The number of folder assignments this policy has.
        /// </summary>
        [JsonPropertyName("folder")]
        public long? Folder { get; set; } = default;

        /// <summary>
        /// The number of metadata template assignments this policy has.
        /// </summary>
        [JsonPropertyName("metadata_template")]
        public long? MetadataTemplate { get; set; } = default;

        public RetentionPolicyAssignmentCountsField() {
            
        }
    }
}