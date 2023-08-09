using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileFullWatermarkInfoField {
        [JsonPropertyName("is_watermarked")]
        public bool? IsWatermarked { get; }

        public FileFullWatermarkInfoField(bool? isWatermarked) {
            IsWatermarked = isWatermarked;
        }
    }
}