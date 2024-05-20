using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class CreateStoragePolicyAssignmentRequestBodyAssignedToField {
        /// <summary>
        /// The type to assign the policy to.
        /// </summary>
        [JsonPropertyName("type")]
        public CreateStoragePolicyAssignmentRequestBodyAssignedToTypeField Type { get; }

        /// <summary>
        /// The ID of the user or enterprise
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        public CreateStoragePolicyAssignmentRequestBodyAssignedToField(CreateStoragePolicyAssignmentRequestBodyAssignedToTypeField type, string id) {
            Type = type;
            Id = id;
        }
    }
}