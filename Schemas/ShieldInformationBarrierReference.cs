using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class ShieldInformationBarrierReference {
        [JsonPropertyName("shield_information_barrier")]
        public ShieldInformationBarrierBase ShieldInformationBarrier { get; }

        public ShieldInformationBarrierReference(ShieldInformationBarrierBase shieldInformationBarrier) {
            ShieldInformationBarrier = shieldInformationBarrier;
        }
    }
}