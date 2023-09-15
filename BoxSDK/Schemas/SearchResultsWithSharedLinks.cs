using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SearchResultsWithSharedLinks {
        /// <summary>
        /// One greater than the offset of the last entry in the search results.
        /// The total number of entries in the collection may be less than
        /// `total_count`.
        /// </summary>
        [JsonPropertyName("total_count")]
        public long? TotalCount { get; set; } = default;

        /// <summary>
        /// The limit that was used for this search. This will be the same as the
        /// `limit` query parameter unless that value exceeded the maximum value
        /// allowed.
        /// </summary>
        [JsonPropertyName("limit")]
        public long? Limit { get; set; } = default;

        /// <summary>
        /// The 0-based offset of the first entry in this set. This will be the same
        /// as the `offset` query parameter used.
        /// </summary>
        [JsonPropertyName("offset")]
        public long? Offset { get; set; } = default;

        /// <summary>
        /// Specifies the response as search result items with shared links
        /// </summary>
        [JsonPropertyName("type")]
        public SearchResultsWithSharedLinksTypeField Type { get; set; }

        /// <summary>
        /// The search results for the query provided, including the
        /// additional information about any shared links through
        /// which the item has been shared with the user.
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<SearchResultWithSharedLink>? Entries { get; set; } = default;

        public SearchResultsWithSharedLinks(SearchResultsWithSharedLinksTypeField type) {
            Type = type;
        }
    }
}