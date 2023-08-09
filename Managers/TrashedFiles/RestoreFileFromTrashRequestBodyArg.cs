using System.IO;
using Unions;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class RestoreFileFromTrashRequestBodyArg {
        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("parent")]
        public RestoreFileFromTrashRequestBodyArgParentField Parent { get; }

        public RestoreFileFromTrashRequestBodyArg(string name, RestoreFileFromTrashRequestBodyArgParentField parent) {
            Name = name;
            Parent = parent;
        }
    }
}