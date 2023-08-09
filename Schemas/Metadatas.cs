using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class Metadatas {
        [JsonPropertyName("entries")]
        public IReadOnlyList<Metadata> Entries { get; }

        [JsonPropertyName("limit")]
        public int? Limit { get; }

        public Metadatas(IReadOnlyList<Metadata> entries, int? limit) {
            Entries = entries;
            Limit = limit;
        }
    }
}