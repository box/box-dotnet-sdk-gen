using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class FolderLocks {
        /// <summary>
        /// A list of folder locks
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<FolderLock>? Entries { get; init; }

        /// <summary>
        /// The limit that was used for these entries. This will be the same as the
        /// `limit` query parameter unless that value exceeded the maximum value
        /// allowed. The maximum value varies by API.
        /// </summary>
        [JsonPropertyName("limit")]
        public string? Limit { get; init; }

        /// <summary>
        /// The marker for the start of the next page of results.
        /// </summary>
        [JsonPropertyName("next_marker")]
        public string? NextMarker { get; init; }

        public FolderLocks() {
            
        }
    }
}