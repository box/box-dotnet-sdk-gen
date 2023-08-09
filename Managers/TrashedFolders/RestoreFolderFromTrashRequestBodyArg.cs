using System.IO;
using Unions;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class RestoreFolderFromTrashRequestBodyArg {
        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("parent")]
        public RestoreFolderFromTrashRequestBodyArgParentField Parent { get; }

        public RestoreFolderFromTrashRequestBodyArg(string name, RestoreFolderFromTrashRequestBodyArgParentField parent) {
            Name = name;
            Parent = parent;
        }
    }
}