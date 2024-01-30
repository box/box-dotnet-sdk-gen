using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class WatermarkWatermarkField {
        /// <summary>
        /// When this watermark was created
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; set; } = default;

        /// <summary>
        /// When this task was modified
        /// </summary>
        [JsonPropertyName("modified_at")]
        public System.DateTimeOffset? ModifiedAt { get; set; } = default;

        public WatermarkWatermarkField() {
            
        }
    }
}