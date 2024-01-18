using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class ShieldInformationBarrierSegmentMemberMini : ShieldInformationBarrierSegmentMemberBase {
        [JsonPropertyName("user")]
        public UserBase? User { get; set; } = default;

        public ShieldInformationBarrierSegmentMemberMini() {
            
        }
    }
}