using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class MetadataQueryResults {
        [JsonPropertyName("entries")]
        public IReadOnlyList<MetadataQueryResultsEntriesField> Entries { get; }

        [JsonPropertyName("limit")]
        public long? Limit { get; }

        [JsonPropertyName("next_marker")]
        public string NextMarker { get; }

        public MetadataQueryResults(IReadOnlyList<MetadataQueryResultsEntriesField> entries, long? limit, string nextMarker) {
            Entries = entries;
            Limit = limit;
            NextMarker = nextMarker;
        }
    }
}