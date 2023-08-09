using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class RetentionPolicyAssignmentFilterFieldsField {
        [JsonPropertyName("field")]
        public string Field { get; }

        [JsonPropertyName("value")]
        public string Value { get; }

        public RetentionPolicyAssignmentFilterFieldsField(string field, string value) {
            Field = field;
            Value = value;
        }
    }
}