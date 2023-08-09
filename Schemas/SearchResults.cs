using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SearchResults {
        [JsonPropertyName("total_count")]
        public int? TotalCount { get; }

        [JsonPropertyName("limit")]
        public int? Limit { get; }

        [JsonPropertyName("offset")]
        public int? Offset { get; }

        [JsonPropertyName("type")]
        public SearchResultsTypeField Type { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<SearchResultsEntriesField> Entries { get; }

        public SearchResults(int? totalCount, int? limit, int? offset, SearchResultsTypeField type, IReadOnlyList<SearchResultsEntriesField> entries) {
            TotalCount = totalCount;
            Limit = limit;
            Offset = offset;
            Type = type;
            Entries = entries;
        }
    }
}