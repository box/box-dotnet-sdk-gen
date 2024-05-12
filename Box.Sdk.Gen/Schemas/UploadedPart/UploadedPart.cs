using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class UploadedPart {
        [JsonPropertyName("part")]
        public UploadPart? Part { get; set; } = default;

        public UploadedPart() {
            
        }
    }
}