using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class RetentionPolicyAssignmentBase {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public RetentionPolicyAssignmentBaseTypeField Type { get; }

        public RetentionPolicyAssignmentBase(string id, RetentionPolicyAssignmentBaseTypeField type) {
            Id = id;
            Type = type;
        }
    }
}