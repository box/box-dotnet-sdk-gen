using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class TrashFilePathCollectionField {
        [JsonPropertyName("total_count")]
        public long TotalCount { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<TrashFilePathCollectionFieldEntriesField> Entries { get; }

        public TrashFilePathCollectionField(long totalCount, IReadOnlyList<TrashFilePathCollectionFieldEntriesField> entries) {
            TotalCount = totalCount;
            Entries = entries;
        }
    }
}