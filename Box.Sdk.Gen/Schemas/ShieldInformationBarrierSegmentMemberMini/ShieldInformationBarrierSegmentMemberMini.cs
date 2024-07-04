using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class ShieldInformationBarrierSegmentMemberMini : ShieldInformationBarrierSegmentMemberBase {
        [JsonPropertyName("user")]
        public UserBase? User { get; init; }

        public ShieldInformationBarrierSegmentMemberMini() {
            
        }
    }
}