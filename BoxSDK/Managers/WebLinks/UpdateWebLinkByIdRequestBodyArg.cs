using System.Text.Json.Serialization;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateWebLinkByIdRequestBodyArg {
        /// <summary>
        /// The new URL that the web link links to. Must start with
        /// `"http://"` or `"https://"`.
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; } = default;

        [JsonPropertyName("parent")]
        public UpdateWebLinkByIdRequestBodyArgParentField? Parent { get; set; } = default;

        /// <summary>
        /// A new name for the web link. Defaults to the URL if not set.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        /// <summary>
        /// A new description of the web link.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; } = default;

        /// <summary>
        /// The settings for the shared link to update.
        /// </summary>
        [JsonPropertyName("shared_link")]
        public UpdateWebLinkByIdRequestBodyArgSharedLinkField? SharedLink { get; set; } = default;

        public UpdateWebLinkByIdRequestBodyArg() {
            
        }
    }
}