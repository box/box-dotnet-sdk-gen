using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateRetentionPolicyAssignmentRequestBodyArgFilterFieldsField {
        [JsonPropertyName("field")]
        public string Field { get; }

        [JsonPropertyName("value")]
        public string Value { get; }

        public CreateRetentionPolicyAssignmentRequestBodyArgFilterFieldsField(string field, string value) {
            Field = field;
            Value = value;
        }
    }
}