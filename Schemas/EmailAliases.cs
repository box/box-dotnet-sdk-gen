using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class EmailAliases {
        [JsonPropertyName("total_count")]
        public int? TotalCount { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<EmailAlias> Entries { get; }

        public EmailAliases(int? totalCount, IReadOnlyList<EmailAlias> entries) {
            TotalCount = totalCount;
            Entries = entries;
        }
    }
}