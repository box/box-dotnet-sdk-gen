using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class Watermark {
        [JsonPropertyName("watermark")]
        public WatermarkWatermarkField? WatermarkField { get; set; } = default;

        public Watermark() {
            
        }
    }
}