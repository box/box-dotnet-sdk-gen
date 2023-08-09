using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateShieldInformationBarrierSegmentRequestBodyArg {
        [JsonPropertyName("shield_information_barrier")]
        public ShieldInformationBarrierBase ShieldInformationBarrier { get; }

        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("description")]
        public string Description { get; }

        public CreateShieldInformationBarrierSegmentRequestBodyArg(ShieldInformationBarrierBase shieldInformationBarrier, string name, string description) {
            ShieldInformationBarrier = shieldInformationBarrier;
            Name = name;
            Description = description;
        }
    }
}