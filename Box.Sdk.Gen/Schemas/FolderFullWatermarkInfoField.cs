using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class FolderFullWatermarkInfoField {
        /// <summary>
        /// Specifies if this item has a watermark applied.
        /// </summary>
        [JsonPropertyName("is_watermarked")]
        public bool? IsWatermarked { get; set; } = default;

        public FolderFullWatermarkInfoField() {
            
        }
    }
}