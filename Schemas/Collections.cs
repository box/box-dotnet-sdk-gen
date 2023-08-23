using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class Collections {
        [JsonPropertyName("total_count")]
        public long? TotalCount { get; }

        [JsonPropertyName("limit")]
        public long? Limit { get; }

        [JsonPropertyName("offset")]
        public long? Offset { get; }

        [JsonPropertyName("order")]
        public IReadOnlyList<CollectionsOrderField> Order { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<Collection> Entries { get; }

        public Collections(long? totalCount, long? limit, long? offset, IReadOnlyList<CollectionsOrderField> order, IReadOnlyList<Collection> entries) {
            TotalCount = totalCount;
            Limit = limit;
            Offset = offset;
            Order = order;
            Entries = entries;
        }
    }
}