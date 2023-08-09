using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileVersions {
        [JsonPropertyName("total_count")]
        public int? TotalCount { get; }

        [JsonPropertyName("limit")]
        public int? Limit { get; }

        [JsonPropertyName("offset")]
        public int? Offset { get; }

        [JsonPropertyName("order")]
        public IReadOnlyList<FileVersionsOrderField> Order { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<FileVersion> Entries { get; }

        public FileVersions(int? totalCount, int? limit, int? offset, IReadOnlyList<FileVersionsOrderField> order, IReadOnlyList<FileVersion> entries) {
            TotalCount = totalCount;
            Limit = limit;
            Offset = offset;
            Order = order;
            Entries = entries;
        }
    }
}