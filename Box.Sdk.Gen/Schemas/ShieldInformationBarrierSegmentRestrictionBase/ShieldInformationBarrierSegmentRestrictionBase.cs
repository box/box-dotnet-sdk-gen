using Unions;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;

namespace Box.Sdk.Gen.Schemas {
    public class ShieldInformationBarrierSegmentRestrictionBase {
        /// <summary>
        /// Shield information barrier segment restriction
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<ShieldInformationBarrierSegmentRestrictionBaseTypeField>))]
        public StringEnum<ShieldInformationBarrierSegmentRestrictionBaseTypeField>? Type { get; init; }

        /// <summary>
        /// The unique identifier for the
        /// shield information barrier segment restriction.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        public ShieldInformationBarrierSegmentRestrictionBase() {
            
        }
    }
}