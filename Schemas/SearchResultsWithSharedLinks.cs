using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SearchResultsWithSharedLinks {
        [JsonPropertyName("total_count")]
        public int? TotalCount { get; }

        [JsonPropertyName("limit")]
        public int? Limit { get; }

        [JsonPropertyName("offset")]
        public int? Offset { get; }

        [JsonPropertyName("type")]
        public SearchResultsWithSharedLinksTypeField Type { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<SearchResultWithSharedLink> Entries { get; }

        public SearchResultsWithSharedLinks(int? totalCount, int? limit, int? offset, SearchResultsWithSharedLinksTypeField type, IReadOnlyList<SearchResultWithSharedLink> entries) {
            TotalCount = totalCount;
            Limit = limit;
            Offset = offset;
            Type = type;
            Entries = entries;
        }
    }
}