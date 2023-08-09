using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateTaskAssignmentRequestBodyArgTaskField {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public CreateTaskAssignmentRequestBodyArgTaskFieldTypeField Type { get; }

        public CreateTaskAssignmentRequestBodyArgTaskField(string id, CreateTaskAssignmentRequestBodyArgTaskFieldTypeField type) {
            Id = id;
            Type = type;
        }
    }
}