using Unions;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;

namespace Box.Sdk.Gen.Schemas {
    public class MetadataQueryIndexFieldsField {
        /// <summary>
        /// The metadata template field key.
        /// </summary>
        [JsonPropertyName("key")]
        public string? Key { get; init; }

        /// <summary>
        /// The sort direction of the field.
        /// </summary>
        [JsonPropertyName("sort_direction")]
        [JsonConverter(typeof(StringEnumConverter<MetadataQueryIndexFieldsSortDirectionField>))]
        public StringEnum<MetadataQueryIndexFieldsSortDirectionField>? SortDirection { get; init; }

        public MetadataQueryIndexFieldsField() {
            
        }
    }
}