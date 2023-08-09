using System.IO;
using Unions;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class RestoreFolderFromTrashRequestBodyArgParentField {
        [JsonPropertyName("id")]
        public string Id { get; }

        public RestoreFolderFromTrashRequestBodyArgParentField(string id) {
            Id = id;
        }
    }
}