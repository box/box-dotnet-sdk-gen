using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateCommentRequestBodyArgItemField {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public CreateCommentRequestBodyArgItemFieldTypeField Type { get; }

        public CreateCommentRequestBodyArgItemField(string id, CreateCommentRequestBodyArgItemFieldTypeField type) {
            Id = id;
            Type = type;
        }
    }
}