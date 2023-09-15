using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateRetentionPolicyAssignmentRequestBodyArgFilterFieldsField {
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

        public CreateRetentionPolicyAssignmentRequestBodyArgFilterFieldsField() {
            
        }
    }
}