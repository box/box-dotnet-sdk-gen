using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class CreateRetentionPolicyAssignmentRequestBodyFilterFieldsField {
        /// <summary>
        /// The metadata attribute key id.
        /// </summary>
        [JsonPropertyName("field")]
        public string? Field { get; init; }

        /// <summary>
        /// The metadata attribute field id. For value, only
        /// enum and multiselect types are supported.
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get; init; }

        public CreateRetentionPolicyAssignmentRequestBodyFilterFieldsField() {
            
        }
    }
}