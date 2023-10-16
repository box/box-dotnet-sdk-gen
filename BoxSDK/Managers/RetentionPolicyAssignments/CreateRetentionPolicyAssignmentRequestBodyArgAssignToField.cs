using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateRetentionPolicyAssignmentRequestBodyArgAssignToField {
        /// <summary>
        /// The type of item to assign the policy to.
        /// </summary>
        [JsonPropertyName("type")]
        public CreateRetentionPolicyAssignmentRequestBodyArgAssignToFieldTypeField Type { get; set; }

        /// <summary>
        /// The ID of item to assign the policy to.
        /// Set to `null` or omit when `type` is set to
        /// `enterprise`.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        public CreateRetentionPolicyAssignmentRequestBodyArgAssignToField(CreateRetentionPolicyAssignmentRequestBodyArgAssignToFieldTypeField type) {
            Type = type;
        }
    }
}