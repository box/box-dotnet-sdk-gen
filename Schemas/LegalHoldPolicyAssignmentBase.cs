using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class LegalHoldPolicyAssignmentBase {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public LegalHoldPolicyAssignmentBaseTypeField Type { get; }

        public LegalHoldPolicyAssignmentBase(string id, LegalHoldPolicyAssignmentBaseTypeField type) {
            Id = id;
            Type = type;
        }
    }
}