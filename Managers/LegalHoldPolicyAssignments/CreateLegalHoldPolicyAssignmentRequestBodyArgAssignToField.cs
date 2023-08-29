using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateLegalHoldPolicyAssignmentRequestBodyArgAssignToField {
        /// <summary>
        /// The type of item to assign the policy to
        /// </summary>
        [JsonPropertyName("type")]
        public CreateLegalHoldPolicyAssignmentRequestBodyArgAssignToFieldTypeField Type { get; set; }

        /// <summary>
        /// The ID of item to assign the policy to
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public CreateLegalHoldPolicyAssignmentRequestBodyArgAssignToField(CreateLegalHoldPolicyAssignmentRequestBodyArgAssignToFieldTypeField type, string id) {
            Type = type;
            Id = id;
        }
    }
}