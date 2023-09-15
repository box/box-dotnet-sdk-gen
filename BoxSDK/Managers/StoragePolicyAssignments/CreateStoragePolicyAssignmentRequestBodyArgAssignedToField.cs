using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateStoragePolicyAssignmentRequestBodyArgAssignedToField {
        /// <summary>
        /// The type to assign the policy to.
        /// </summary>
        [JsonPropertyName("type")]
        public CreateStoragePolicyAssignmentRequestBodyArgAssignedToFieldTypeField Type { get; set; }

        /// <summary>
        /// The ID of the user or enterprise
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public CreateStoragePolicyAssignmentRequestBodyArgAssignedToField(CreateStoragePolicyAssignmentRequestBodyArgAssignedToFieldTypeField type, string id) {
            Type = type;
            Id = id;
        }
    }
}