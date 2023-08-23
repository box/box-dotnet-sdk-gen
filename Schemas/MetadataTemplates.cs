using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class MetadataTemplates {
        [JsonPropertyName("limit")]
        public long? Limit { get; }

        [JsonPropertyName("next_marker")]
        public long? NextMarker { get; }

        [JsonPropertyName("prev_marker")]
        public long? PrevMarker { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<MetadataTemplate> Entries { get; }

        public MetadataTemplates(long? limit, long? nextMarker, long? prevMarker, IReadOnlyList<MetadataTemplate> entries) {
            Limit = limit;
            NextMarker = nextMarker;
            PrevMarker = prevMarker;
            Entries = entries;
        }
    }
}