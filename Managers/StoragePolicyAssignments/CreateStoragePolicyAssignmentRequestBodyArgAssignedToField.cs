using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateStoragePolicyAssignmentRequestBodyArgAssignedToField {
        [JsonPropertyName("type")]
        public CreateStoragePolicyAssignmentRequestBodyArgAssignedToFieldTypeField Type { get; }

        [JsonPropertyName("id")]
        public string Id { get; }

        public CreateStoragePolicyAssignmentRequestBodyArgAssignedToField(CreateStoragePolicyAssignmentRequestBodyArgAssignedToFieldTypeField type, string id) {
            Type = type;
            Id = id;
        }
    }
}