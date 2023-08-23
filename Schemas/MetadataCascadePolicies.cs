using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class MetadataCascadePolicies {
        [JsonPropertyName("limit")]
        public long? Limit { get; }

        [JsonPropertyName("next_marker")]
        public long? NextMarker { get; }

        [JsonPropertyName("prev_marker")]
        public long? PrevMarker { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<MetadataCascadePolicy> Entries { get; }

        public MetadataCascadePolicies(long? limit, long? nextMarker, long? prevMarker, IReadOnlyList<MetadataCascadePolicy> entries) {
            Limit = limit;
            NextMarker = nextMarker;
            PrevMarker = prevMarker;
            Entries = entries;
        }
    }
}