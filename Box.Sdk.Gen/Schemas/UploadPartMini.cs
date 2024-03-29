using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class UploadPartMini {
        /// <summary>
        /// The unique ID of the chunk.
        /// </summary>
        [JsonPropertyName("part_id")]
        public string? PartId { get; set; } = default;

        /// <summary>
        /// The offset of the chunk within the file
        /// in bytes. The lower bound of the position
        /// of the chunk within the file.
        /// </summary>
        [JsonPropertyName("offset")]
        public long? Offset { get; set; } = default;

        /// <summary>
        /// The size of the chunk in bytes.
        /// </summary>
        [JsonPropertyName("size")]
        public long? Size { get; set; } = default;

        public UploadPartMini() {
            
        }
    }
}