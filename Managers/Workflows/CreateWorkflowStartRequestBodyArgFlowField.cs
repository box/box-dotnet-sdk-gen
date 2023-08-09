using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateWorkflowStartRequestBodyArgFlowField {
        [JsonPropertyName("type")]
        public string Type { get; }

        [JsonPropertyName("id")]
        public string Id { get; }

        public CreateWorkflowStartRequestBodyArgFlowField(string type, string id) {
            Type = type;
            Id = id;
        }
    }
}