using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class Collaborations {
        [JsonPropertyName("total_count")]
        public long? TotalCount { get; }

        [JsonPropertyName("limit")]
        public long? Limit { get; }

        [JsonPropertyName("offset")]
        public long? Offset { get; }

        [JsonPropertyName("order")]
        public IReadOnlyList<CollaborationsOrderField> Order { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<Collaboration> Entries { get; }

        public Collaborations(long? totalCount, long? limit, long? offset, IReadOnlyList<CollaborationsOrderField> order, IReadOnlyList<Collaboration> entries) {
            TotalCount = totalCount;
            Limit = limit;
            Offset = offset;
            Order = order;
            Entries = entries;
        }
    }
}