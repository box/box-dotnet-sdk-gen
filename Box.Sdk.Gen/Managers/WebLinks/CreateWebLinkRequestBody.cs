using System.Text.Json.Serialization;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class CreateWebLinkRequestBody {
        /// <summary>
        /// The URL that this web link links to. Must start with
        /// `"http://"` or `"https://"`.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; }

        /// <summary>
        /// The parent folder to create the web link within.
        /// </summary>
        [JsonPropertyName("parent")]
        public CreateWebLinkRequestBodyParentField Parent { get; }

        /// <summary>
        /// Name of the web link. Defaults to the URL if not set.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        /// <summary>
        /// Description of the web link.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; init; }

        public CreateWebLinkRequestBody(string url, CreateWebLinkRequestBodyParentField parent) {
            Url = url;
            Parent = parent;
        }
    }
}