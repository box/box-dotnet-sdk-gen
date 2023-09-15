using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateShieldInformationBarrierSegmentRequestBodyArg {
        [JsonPropertyName("shield_information_barrier")]
        public ShieldInformationBarrierBase ShieldInformationBarrier { get; set; }

        /// <summary>
        /// Name of the shield information barrier segment
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Description of the shield information barrier segment
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; } = default;

        public CreateShieldInformationBarrierSegmentRequestBodyArg(ShieldInformationBarrierBase shieldInformationBarrier, string name) {
            ShieldInformationBarrier = shieldInformationBarrier;
            Name = name;
        }
    }
}