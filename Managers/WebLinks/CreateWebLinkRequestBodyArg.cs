using System.IO;
using System.Text.Json.Serialization;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateWebLinkRequestBodyArg {
        [JsonPropertyName("url")]
        public string Url { get; }

        [JsonPropertyName("parent")]
        public CreateWebLinkRequestBodyArgParentField Parent { get; }

        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("description")]
        public string Description { get; }

        public CreateWebLinkRequestBodyArg(string url, CreateWebLinkRequestBodyArgParentField parent, string name, string description) {
            Url = url;
            Parent = parent;
            Name = name;
            Description = description;
        }
    }
}