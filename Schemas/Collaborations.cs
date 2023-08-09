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
        public int? TotalCount { get; }

        [JsonPropertyName("limit")]
        public int? Limit { get; }

        [JsonPropertyName("offset")]
        public int? Offset { get; }

        [JsonPropertyName("order")]
        public IReadOnlyList<CollaborationsOrderField> Order { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<Collaboration> Entries { get; }

        public Collaborations(int? totalCount, int? limit, int? offset, IReadOnlyList<CollaborationsOrderField> order, IReadOnlyList<Collaboration> entries) {
            TotalCount = totalCount;
            Limit = limit;
            Offset = offset;
            Order = order;
            Entries = entries;
        }
    }
}