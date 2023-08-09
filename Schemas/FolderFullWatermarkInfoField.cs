using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class FolderFullWatermarkInfoField {
        [JsonPropertyName("is_watermarked")]
        public bool? IsWatermarked { get; }

        public FolderFullWatermarkInfoField(bool? isWatermarked) {
            IsWatermarked = isWatermarked;
        }
    }
}