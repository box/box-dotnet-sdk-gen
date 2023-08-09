using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class UploadParts {
        [JsonPropertyName("total_count")]
        public int? TotalCount { get; }

        [JsonPropertyName("limit")]
        public int? Limit { get; }

        [JsonPropertyName("offset")]
        public int? Offset { get; }

        [JsonPropertyName("order")]
        public IReadOnlyList<UploadPartsOrderField> Order { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<UploadPart> Entries { get; }

        public UploadParts(int? totalCount, int? limit, int? offset, IReadOnlyList<UploadPartsOrderField> order, IReadOnlyList<UploadPart> entries) {
            TotalCount = totalCount;
            Limit = limit;
            Offset = offset;
            Order = order;
            Entries = entries;
        }
    }
}