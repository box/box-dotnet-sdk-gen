using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class Collections {
        [JsonPropertyName("total_count")]
        public int? TotalCount { get; }

        [JsonPropertyName("limit")]
        public int? Limit { get; }

        [JsonPropertyName("offset")]
        public int? Offset { get; }

        [JsonPropertyName("order")]
        public IReadOnlyList<CollectionsOrderField> Order { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<Collection> Entries { get; }

        public Collections(int? totalCount, int? limit, int? offset, IReadOnlyList<CollectionsOrderField> order, IReadOnlyList<Collection> entries) {
            TotalCount = totalCount;
            Limit = limit;
            Offset = offset;
            Order = order;
            Entries = entries;
        }
    }
}