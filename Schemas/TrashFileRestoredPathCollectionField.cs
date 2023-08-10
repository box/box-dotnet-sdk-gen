using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class TrashFileRestoredPathCollectionField {
        [JsonPropertyName("total_count")]
        public int TotalCount { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<FolderMini> Entries { get; }

        public TrashFileRestoredPathCollectionField(int totalCount, IReadOnlyList<FolderMini> entries) {
            TotalCount = totalCount;
            Entries = entries;
        }
    }
}