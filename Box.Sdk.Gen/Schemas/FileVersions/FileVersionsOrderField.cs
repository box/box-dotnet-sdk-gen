using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class FileVersionsOrderField {
        /// <summary>
        /// The field to order by
        /// </summary>
        [JsonPropertyName("by")]
        public string? By { get; init; }

        /// <summary>
        /// The direction to order by, either ascending or descending
        /// </summary>
        [JsonPropertyName("direction")]
        public FileVersionsOrderDirectionField? Direction { get; init; }

        public FileVersionsOrderField() {
            
        }
    }
}