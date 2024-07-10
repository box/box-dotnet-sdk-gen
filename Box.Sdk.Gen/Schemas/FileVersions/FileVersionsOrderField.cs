using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
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
        [JsonConverter(typeof(StringEnumConverter<FileVersionsOrderDirectionField>))]
        public StringEnum<FileVersionsOrderDirectionField>? Direction { get; init; }

        public FileVersionsOrderField() {
            
        }
    }
}