using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FolderLocks {
        [JsonPropertyName("limit")]
        public int? Limit { get; }

        [JsonPropertyName("next_marker")]
        public int? NextMarker { get; }

        [JsonPropertyName("prev_marker")]
        public int? PrevMarker { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<FolderLock> Entries { get; }

        public FolderLocks(int? limit, int? nextMarker, int? prevMarker, IReadOnlyList<FolderLock> entries) {
            Limit = limit;
            NextMarker = nextMarker;
            PrevMarker = prevMarker;
            Entries = entries;
        }
    }
}