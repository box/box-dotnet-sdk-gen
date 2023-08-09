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
        public int? Offset { get; }

        [JsonPropertyName("size")]
        public int? Size { get; }

        public UploadPartMini(string partId, int? offset, int? size) {
            PartId = partId;
            Offset = offset;
            Size = size;
        }
    }
}