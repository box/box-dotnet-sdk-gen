using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class RetentionPolicyAssignmentFilterFieldsField {
        /// <summary>
        /// The metadata attribute key id.
        /// </summary>
        [JsonPropertyName("field")]
        public string? Field { get; set; } = default;

        /// <summary>
        /// The metadata attribute field id. For value, only
        /// enum and multiselect types are supported.
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get; set; } = default;

        public RetentionPolicyAssignmentFilterFieldsField() {
            
        }
    }
}