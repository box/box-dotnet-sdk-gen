using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class ShieldInformationBarrierSegmentRestriction : ShieldInformationBarrierSegmentRestrictionMini {
        [JsonPropertyName("shield_information_barrier")]
        public ShieldInformationBarrierBase ShieldInformationBarrier { get; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("created_by")]
        public UserBase CreatedBy { get; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; }

        [JsonPropertyName("updated_by")]
        public UserBase UpdatedBy { get; }

        public ShieldInformationBarrierSegmentRestriction(ShieldInformationBarrierSegmentRestrictionBaseTypeField type, string id, ShieldInformationBarrierSegmentRestrictionMiniShieldInformationBarrierSegmentField shieldInformationBarrierSegment, ShieldInformationBarrierSegmentRestrictionMiniRestrictedSegmentField restrictedSegment, ShieldInformationBarrierBase shieldInformationBarrier, string createdAt, UserBase createdBy, string updatedAt, UserBase updatedBy) : base(type, id, shieldInformationBarrierSegment, restrictedSegment) {
            ShieldInformationBarrier = shieldInformationBarrier;
            CreatedAt = createdAt;
            CreatedBy = createdBy;
            UpdatedAt = updatedAt;
            UpdatedBy = updatedBy;
        }
    }
}