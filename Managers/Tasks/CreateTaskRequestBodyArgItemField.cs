using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateTaskRequestBodyArgItemField {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public CreateTaskRequestBodyArgItemFieldTypeField Type { get; }

        public CreateTaskRequestBodyArgItemField(string id, CreateTaskRequestBodyArgItemFieldTypeField type) {
            Id = id;
            Type = type;
        }
    }
}