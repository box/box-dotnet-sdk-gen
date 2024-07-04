using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    public class ShieldInformationBarrierSegmentMemberBase {
        /// <summary>
        /// The unique identifier for the
        /// shield information barrier segment member
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// The type of the shield information barrier segment member
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<ShieldInformationBarrierSegmentMemberBaseTypeField>))]
        public StringEnum<ShieldInformationBarrierSegmentMemberBaseTypeField>? Type { get; init; }

        public ShieldInformationBarrierSegmentMemberBase() {
            
        }
    }
}