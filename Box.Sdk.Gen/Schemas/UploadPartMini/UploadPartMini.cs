using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class UploadPartMini {
        /// <summary>
        /// The unique ID of the chunk.
        /// </summary>
        [JsonPropertyName("part_id")]
        public string? PartId { get; init; }

        /// <summary>
        /// The offset of the chunk within the file
        /// in bytes. The lower bound of the position
        /// of the chunk within the file.
        /// </summary>
        [JsonPropertyName("offset")]
        public long? Offset { get; init; }

        /// <summary>
        /// The size of the chunk in bytes.
        /// </summary>
        [JsonPropertyName("size")]
        public long? Size { get; init; }

        public UploadPartMini() {
            
        }
    }
}