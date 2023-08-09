using System.IO;
using Unions;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class RestoreFileFromTrashRequestBodyArgParentField {
        [JsonPropertyName("id")]
        public string Id { get; }

        public RestoreFileFromTrashRequestBodyArgParentField(string id) {
            Id = id;
        }
    }
}