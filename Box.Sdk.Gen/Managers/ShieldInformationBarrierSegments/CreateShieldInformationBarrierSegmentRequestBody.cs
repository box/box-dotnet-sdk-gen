using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Managers {
    public class CreateShieldInformationBarrierSegmentRequestBody {
        [JsonPropertyName("shield_information_barrier")]
        public ShieldInformationBarrierBase ShieldInformationBarrier { get; }

        /// <summary>
        /// Name of the shield information barrier segment
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Description of the shield information barrier segment
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; init; }

        public CreateShieldInformationBarrierSegmentRequestBody(ShieldInformationBarrierBase shieldInformationBarrier, string name) {
            ShieldInformationBarrier = shieldInformationBarrier;
            Name = name;
        }
    }
}