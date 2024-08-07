using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    public class MetadataQueryOrderByField {
        /// <summary>
        /// The metadata template field to order by.
        /// 
        /// The `field_key` represents the `key` value of a field from the
        /// metadata template being searched for.
        /// </summary>
        [JsonPropertyName("field_key")]
        public string? FieldKey { get; init; }

        /// <summary>
        /// The direction to order by, either ascending or descending.
        /// 
        /// The `ordering` direction must be the same for each item in the
        /// array.
        /// </summary>
        [JsonPropertyName("direction")]
        [JsonConverter(typeof(StringEnumConverter<MetadataQueryOrderByDirectionField>))]
        public StringEnum<MetadataQueryOrderByDirectionField>? Direction { get; init; }

        public MetadataQueryOrderByField() {
            
        }
    }
}