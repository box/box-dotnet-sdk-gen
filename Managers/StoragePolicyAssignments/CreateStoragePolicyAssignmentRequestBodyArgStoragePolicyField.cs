using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateStoragePolicyAssignmentRequestBodyArgStoragePolicyField {
        [JsonPropertyName("type")]
        public CreateStoragePolicyAssignmentRequestBodyArgStoragePolicyFieldTypeField Type { get; }

        [JsonPropertyName("id")]
        public string Id { get; }

        public CreateStoragePolicyAssignmentRequestBodyArgStoragePolicyField(CreateStoragePolicyAssignmentRequestBodyArgStoragePolicyFieldTypeField type, string id) {
            Type = type;
            Id = id;
        }
    }
}