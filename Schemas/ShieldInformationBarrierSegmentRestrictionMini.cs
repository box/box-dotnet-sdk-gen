using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class ShieldInformationBarrierSegmentRestrictionMini : ShieldInformationBarrierSegmentRestrictionBase {
        [JsonPropertyName("shield_information_barrier_segment")]
        public ShieldInformationBarrierSegmentRestrictionMiniShieldInformationBarrierSegmentField ShieldInformationBarrierSegment { get; }

        [JsonPropertyName("restricted_segment")]
        public ShieldInformationBarrierSegmentRestrictionMiniRestrictedSegmentField RestrictedSegment { get; }

        public ShieldInformationBarrierSegmentRestrictionMini(ShieldInformationBarrierSegmentRestrictionBaseTypeField type, string id, ShieldInformationBarrierSegmentRestrictionMiniShieldInformationBarrierSegmentField shieldInformationBarrierSegment, ShieldInformationBarrierSegmentRestrictionMiniRestrictedSegmentField restrictedSegment) : base(type, id) {
            ShieldInformationBarrierSegment = shieldInformationBarrierSegment;
            RestrictedSegment = restrictedSegment;
        }
    }
}