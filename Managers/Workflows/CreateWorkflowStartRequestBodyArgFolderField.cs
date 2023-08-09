using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateWorkflowStartRequestBodyArgFolderField {
        [JsonPropertyName("type")]
        public CreateWorkflowStartRequestBodyArgFolderFieldTypeField Type { get; }

        [JsonPropertyName("id")]
        public string Id { get; }

        public CreateWorkflowStartRequestBodyArgFolderField(CreateWorkflowStartRequestBodyArgFolderFieldTypeField type, string id) {
            Type = type;
            Id = id;
        }
    }
}