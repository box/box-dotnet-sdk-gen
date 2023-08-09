using System.IO;
using System.Text.Json.Serialization;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateWebLinkByIdRequestBodyArg {
        [JsonPropertyName("url")]
        public string Url { get; }

        [JsonPropertyName("parent")]
        public UpdateWebLinkByIdRequestBodyArgParentField Parent { get; }

        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("description")]
        public string Description { get; }

        [JsonPropertyName("shared_link")]
        public UpdateWebLinkByIdRequestBodyArgSharedLinkField SharedLink { get; }

        public UpdateWebLinkByIdRequestBodyArg(string url, UpdateWebLinkByIdRequestBodyArgParentField parent, string name, string description, UpdateWebLinkByIdRequestBodyArgSharedLinkField sharedLink) {
            Url = url;
            Parent = parent;
            Name = name;
            Description = description;
            SharedLink = sharedLink;
        }
    }
}