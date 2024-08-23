using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class RetentionPolicyAssignmentFilterFieldsField {
        [JsonInclude]
        [JsonPropertyName("_isfieldSet")]
        protected bool _isFieldSet { get; set; }

        [JsonInclude]
        [JsonPropertyName("_isvalueSet")]
        protected bool _isValueSet { get; set; }

        protected string? _field { get; set; }

        protected string? _value { get; set; }

        /// <summary>
        /// The metadata attribute key id.
        /// </summary>
        [JsonPropertyName("field")]
        public string? Field { get => _field; init { _field = value; _isFieldSet = true; } }

        /// <summary>
        /// The metadata attribute field id. For value, only
        /// enum and multiselect types are supported.
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get => _value; init { _value = value; _isValueSet = true; } }

        public RetentionPolicyAssignmentFilterFieldsField() {
            
        }
    }
}