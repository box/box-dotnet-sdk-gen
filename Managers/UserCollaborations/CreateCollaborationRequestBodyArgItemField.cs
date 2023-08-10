using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateCollaborationRequestBodyArgItemField {
        [JsonPropertyName("type")]
        public CreateCollaborationRequestBodyArgItemFieldTypeField Type { get; }

        [JsonPropertyName("id")]
        public string Id { get; }

        public CreateCollaborationRequestBodyArgItemField(CreateCollaborationRequestBodyArgItemFieldTypeField type, string id) {
            Type = type;
            Id = id;
        }
    }
}