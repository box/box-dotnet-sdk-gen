using System.Text.Json.Serialization;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateWebLinkRequestBodyArg {
        /// <summary>
        /// The URL that this web link links to. Must start with
        /// `"http://"` or `"https://"`.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// The parent folder to create the web link within.
        /// </summary>
        [JsonPropertyName("parent")]
        public CreateWebLinkRequestBodyArgParentField Parent { get; set; }

        /// <summary>
        /// Name of the web link. Defaults to the URL if not set.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        /// <summary>
        /// Description of the web link.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; } = default;

        public CreateWebLinkRequestBodyArg(string url, CreateWebLinkRequestBodyArgParentField parent) {
            Url = url;
            Parent = parent;
        }
    }
}