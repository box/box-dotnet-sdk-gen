using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class UploadPart : UploadPartMini {
        /// <summary>
        /// The SHA1 hash of the chunk.
        /// </summary>
        [JsonPropertyName("sha1")]
        public string? Sha1 { get; init; }

        public UploadPart() {
            
        }
    }
}