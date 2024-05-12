using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class Watermark {
        [JsonPropertyName("watermark")]
        public WatermarkWatermarkField? WatermarkField { get; set; } = default;

        public Watermark() {
            
        }
    }
}