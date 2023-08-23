using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class UploadPartMini {
        [JsonPropertyName("part_id")]
        public string PartId { get; }

        [JsonPropertyName("offset")]
        public long? Offset { get; }

        [JsonPropertyName("size")]
        public long? Size { get; }

        public UploadPartMini(string partId, long? offset, long? size) {
            PartId = partId;
            Offset = offset;
            Size = size;
        }
    }
}