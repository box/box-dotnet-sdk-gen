using System.IO;
using Unions;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateWebLinkByIdRequestBodyArg {
        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("parent")]
        public CreateWebLinkByIdRequestBodyArgParentField Parent { get; }

        public CreateWebLinkByIdRequestBodyArg(string name, CreateWebLinkByIdRequestBodyArgParentField parent) {
            Name = name;
            Parent = parent;
        }
    }
}