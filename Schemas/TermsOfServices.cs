using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class TermsOfServices {
        [JsonPropertyName("total_count")]
        public long? TotalCount { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<TermsOfService> Entries { get; }

        public TermsOfServices(long? totalCount, IReadOnlyList<TermsOfService> entries) {
            TotalCount = totalCount;
            Entries = entries;
        }
    }
}