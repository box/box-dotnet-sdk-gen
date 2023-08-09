using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class ShieldInformationBarrierSegmentRestrictionMiniShieldInformationBarrierSegmentField {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public ShieldInformationBarrierSegmentRestrictionMiniShieldInformationBarrierSegmentFieldTypeField Type { get; }

        public ShieldInformationBarrierSegmentRestrictionMiniShieldInformationBarrierSegmentField(string id, ShieldInformationBarrierSegmentRestrictionMiniShieldInformationBarrierSegmentFieldTypeField type) {
            Id = id;
            Type = type;
        }
    }
}