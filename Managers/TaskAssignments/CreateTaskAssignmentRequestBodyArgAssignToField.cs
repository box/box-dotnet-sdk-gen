using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateTaskAssignmentRequestBodyArgAssignToField {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("login")]
        public string Login { get; }

        public CreateTaskAssignmentRequestBodyArgAssignToField(string id, string login) {
            Id = id;
            Login = login;
        }
    }
}