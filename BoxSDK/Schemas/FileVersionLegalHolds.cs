using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class FileVersionLegalHolds {
        /// <summary>
        /// The limit that was used for these entries. This will be the same as the
        /// `limit` query parameter unless that value exceeded the maximum value
        /// allowed. The maximum value varies by API.
        /// </summary>
        [JsonPropertyName("limit")]
        public long? Limit { get; set; } = default;

        /// <summary>
        /// The marker for the start of the next page of results.
        /// </summary>
        [JsonPropertyName("next_marker")]
        public long? NextMarker { get; set; } = default;

        /// <summary>
        /// The marker for the start of the previous page of results.
        /// </summary>
        [JsonPropertyName("prev_marker")]
        public long? PrevMarker { get; set; } = default;

        /// <summary>
        /// A list of file version legal holds
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<FileVersionLegalHold>? Entries { get; set; } = default;

        public FileVersionLegalHolds() {
            
        }
    }
}