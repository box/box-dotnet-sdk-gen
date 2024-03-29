using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class UploadPart : UploadPartMini {
        /// <summary>
        /// The SHA1 hash of the chunk.
        /// </summary>
        [JsonPropertyName("sha1")]
        public string? Sha1 { get; set; } = default;

        public UploadPart() {
            
        }
    }
}