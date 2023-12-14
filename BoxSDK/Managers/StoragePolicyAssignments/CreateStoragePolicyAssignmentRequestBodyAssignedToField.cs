using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateStoragePolicyAssignmentRequestBodyAssignedToField {
        /// <summary>
        /// The type to assign the policy to.
        /// </summary>
        [JsonPropertyName("type")]
        public CreateStoragePolicyAssignmentRequestBodyAssignedToTypeField Type { get; set; }

        /// <summary>
        /// The ID of the user or enterprise
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public CreateStoragePolicyAssignmentRequestBodyAssignedToField(CreateStoragePolicyAssignmentRequestBodyAssignedToTypeField type, string id) {
            Type = type;
            Id = id;
        }
    }
}