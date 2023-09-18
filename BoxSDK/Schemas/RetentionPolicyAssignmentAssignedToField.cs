using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class RetentionPolicyAssignmentAssignedToField {
        /// <summary>
        /// The ID of the folder, enterprise, or metadata template
        /// the policy is assigned to.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// The type of resource the policy is assigned to.
        /// </summary>
        [JsonPropertyName("type")]
        public RetentionPolicyAssignmentAssignedToFieldTypeField? Type { get; set; } = default;

        public RetentionPolicyAssignmentAssignedToField() {
            
        }
    }
}