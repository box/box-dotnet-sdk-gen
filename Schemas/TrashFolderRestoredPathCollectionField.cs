using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class TrashFolderRestoredPathCollectionField {
        [JsonPropertyName("total_count")]
        public int TotalCount { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<FolderMini> Entries { get; }

        public TrashFolderRestoredPathCollectionField(int totalCount, IReadOnlyList<FolderMini> entries) {
            TotalCount = totalCount;
            Entries = entries;
        }
    }
}