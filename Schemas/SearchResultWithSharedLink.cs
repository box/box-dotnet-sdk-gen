using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SearchResultWithSharedLink {
        [JsonPropertyName("accessible_via_shared_link")]
        public string AccessibleViaSharedLink { get; }

        [JsonPropertyName("item")]
        public SearchResultWithSharedLinkItemField Item { get; }

        [JsonPropertyName("type")]
        public string Type { get; }

        public SearchResultWithSharedLink(string accessibleViaSharedLink, SearchResultWithSharedLinkItemField item, string type) {
            AccessibleViaSharedLink = accessibleViaSharedLink;
            Item = item;
            Type = type;
        }
    }
}