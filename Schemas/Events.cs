using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class Events {
        /// <summary>
        /// The number of events returned in this response.
        /// </summary>
        [JsonPropertyName("chunk_size")]
        public long? ChunkSize { get; set; } = default;

        /// <summary>
        /// The stream position of the start of the next page (chunk)
        /// of events.
        /// </summary>
        [JsonPropertyName("next_stream_position")]
        public string? NextStreamPosition { get; set; } = default;

        /// <summary>
        /// A list of events
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<Event>? Entries { get; set; } = default;

        public Events() {
            
        }
    }
}