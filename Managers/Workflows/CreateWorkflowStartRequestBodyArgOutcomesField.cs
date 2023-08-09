using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateWorkflowStartRequestBodyArgOutcomesField {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public CreateWorkflowStartRequestBodyArgOutcomesFieldTypeField Type { get; }

        [JsonPropertyName("parameter")]
        public string Parameter { get; }

        public CreateWorkflowStartRequestBodyArgOutcomesField(string id, CreateWorkflowStartRequestBodyArgOutcomesFieldTypeField type, string parameter) {
            Id = id;
            Type = type;
            Parameter = parameter;
        }
    }
}