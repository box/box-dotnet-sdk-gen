using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class RetentionPolicyAssignmentBase {
        /// <summary>
        /// The unique identifier that represents a file version.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// `retention_policy_assignment`
        /// </summary>
        [JsonPropertyName("type")]
        public RetentionPolicyAssignmentBaseTypeField Type { get; set; }

        public RetentionPolicyAssignmentBase(string id, RetentionPolicyAssignmentBaseTypeField type) {
            Id = id;
            Type = type;
        }
    }
}