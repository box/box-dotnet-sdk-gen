using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class RetentionPolicyAssignmentAssignedToField {
        /// <summary>
        /// The ID of the folder, enterprise, or metadata template
        /// the policy is assigned to.
        /// Set to null or omit when type is set to enterprise.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// The type of resource the policy is assigned to.
        /// </summary>
        [JsonPropertyName("type")]
        public RetentionPolicyAssignmentAssignedToTypeField? Type { get; set; } = default;

        public RetentionPolicyAssignmentAssignedToField() {
            
        }
    }
}