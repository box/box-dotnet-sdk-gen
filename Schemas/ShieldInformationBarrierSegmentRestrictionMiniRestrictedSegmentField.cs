using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class ShieldInformationBarrierSegmentRestrictionMiniRestrictedSegmentField {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public ShieldInformationBarrierSegmentRestrictionMiniRestrictedSegmentFieldTypeField Type { get; }

        public ShieldInformationBarrierSegmentRestrictionMiniRestrictedSegmentField(string id, ShieldInformationBarrierSegmentRestrictionMiniRestrictedSegmentFieldTypeField type) {
            Id = id;
            Type = type;
        }
    }
}