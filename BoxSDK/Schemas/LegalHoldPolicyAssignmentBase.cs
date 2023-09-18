using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class LegalHoldPolicyAssignmentBase {
        /// <summary>
        /// The unique identifier for this legal hold assignment
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// `legal_hold_policy_assignment`
        /// </summary>
        [JsonPropertyName("type")]
        public LegalHoldPolicyAssignmentBaseTypeField? Type { get; set; } = default;

        public LegalHoldPolicyAssignmentBase() {
            
        }
    }
}