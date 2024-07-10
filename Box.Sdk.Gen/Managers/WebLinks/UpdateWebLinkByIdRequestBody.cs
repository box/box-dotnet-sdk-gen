using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class UpdateWebLinkByIdRequestBody {
        /// <summary>
        /// The new URL that the web link links to. Must start with
        /// `"http://"` or `"https://"`.
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; init; }

        [JsonPropertyName("parent")]
        public UpdateWebLinkByIdRequestBodyParentField? Parent { get; init; }

        /// <summary>
        /// A new name for the web link. Defaults to the URL if not set.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        /// <summary>
        /// A new description of the web link.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; init; }

        /// <summary>
        /// The settings for the shared link to update.
        /// </summary>
        [JsonPropertyName("shared_link")]
        public UpdateWebLinkByIdRequestBodySharedLinkField? SharedLink { get; init; }

        public UpdateWebLinkByIdRequestBody() {
            
        }
    }
}