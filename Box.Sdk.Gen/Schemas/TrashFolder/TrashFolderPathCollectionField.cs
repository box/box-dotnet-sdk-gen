using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class TrashFolderPathCollectionField {
        /// <summary>
        /// The number of folders in this list.
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; }

        /// <summary>
        /// Array of folders for this item's path collection
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<TrashFolderPathCollectionEntriesField> Entries { get; }

        public TrashFolderPathCollectionField(long totalCount, IReadOnlyList<TrashFolderPathCollectionEntriesField> entries) {
            TotalCount = totalCount;
            Entries = entries;
        }
    }
}