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
        public long? TotalCount { get; }

        [JsonPropertyName("limit")]
        public long? Limit { get; }

        [JsonPropertyName("offset")]
        public long? Offset { get; }

        [JsonPropertyName("type")]
        public SearchResultsWithSharedLinksTypeField Type { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<SearchResultWithSharedLink> Entries { get; }

        public SearchResultsWithSharedLinks(long? totalCount, long? limit, long? offset, SearchResultsWithSharedLinksTypeField type, IReadOnlyList<SearchResultWithSharedLink> entries) {
            TotalCount = totalCount;
            Limit = limit;
            Offset = offset;
            Type = type;
            Entries = entries;
        }
    }
}