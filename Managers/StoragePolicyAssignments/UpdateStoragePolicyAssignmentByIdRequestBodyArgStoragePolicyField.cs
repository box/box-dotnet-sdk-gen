using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateStoragePolicyAssignmentByIdRequestBodyArgStoragePolicyField {
        [JsonPropertyName("type")]
        public UpdateStoragePolicyAssignmentByIdRequestBodyArgStoragePolicyFieldTypeField Type { get; }

        [JsonPropertyName("id")]
        public string Id { get; }

        public UpdateStoragePolicyAssignmentByIdRequestBodyArgStoragePolicyField(UpdateStoragePolicyAssignmentByIdRequestBodyArgStoragePolicyFieldTypeField type, string id) {
            Type = type;
            Id = id;
        }
    }
}