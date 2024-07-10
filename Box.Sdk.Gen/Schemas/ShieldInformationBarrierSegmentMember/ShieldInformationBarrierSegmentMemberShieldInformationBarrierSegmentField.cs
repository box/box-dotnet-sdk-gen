using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class ShieldInformationBarrierSegmentMemberShieldInformationBarrierSegmentField {
        /// <summary>
        /// The ID reference of the requesting
        /// shield information barrier segment.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// The type of the shield information barrier segment
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<ShieldInformationBarrierSegmentMemberShieldInformationBarrierSegmentTypeField>))]
        public StringEnum<ShieldInformationBarrierSegmentMemberShieldInformationBarrierSegmentTypeField>? Type { get; init; }

        public ShieldInformationBarrierSegmentMemberShieldInformationBarrierSegmentField() {
            
        }
    }
}