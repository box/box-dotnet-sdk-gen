using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateCollaborationRequestBodyArgAccessibleByField {
        [JsonPropertyName("type")]
        public CreateCollaborationRequestBodyArgAccessibleByFieldTypeField Type { get; }

        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("login")]
        public string Login { get; }

        public CreateCollaborationRequestBodyArgAccessibleByField(CreateCollaborationRequestBodyArgAccessibleByFieldTypeField type, string id, string login) {
            Type = type;
            Id = id;
            Login = login;
        }
    }
}