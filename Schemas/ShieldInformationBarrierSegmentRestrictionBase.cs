using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class ShieldInformationBarrierSegmentRestrictionBase {
        [JsonPropertyName("type")]
        public ShieldInformationBarrierSegmentRestrictionBaseTypeField Type { get; }

        [JsonPropertyName("id")]
        public string Id { get; }

        public ShieldInformationBarrierSegmentRestrictionBase(ShieldInformationBarrierSegmentRestrictionBaseTypeField type, string id) {
            Type = type;
            Id = id;
        }
    }
}