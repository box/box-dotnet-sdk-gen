using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class SearchResultWithSharedLink {
        /// <summary>
        /// The optional shared link through which the user has access to this
        /// item. This value is only returned for items for which the user has
        /// recently accessed the file through a shared link. For all other
        /// items this value will return `null`.
        /// </summary>
        [JsonPropertyName("accessible_via_shared_link")]
        public string? AccessibleViaSharedLink { get; set; } = default;

        [JsonPropertyName("item")]
        public FileFullOrFolderFullOrWebLink? Item { get; set; } = default;

        /// <summary>
        /// The result type. The value is always `search_result`.
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; } = default;

        public SearchResultWithSharedLink() {
            
        }
    }
}