using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class ShieldInformationBarrierSegmentRestriction : ShieldInformationBarrierSegmentRestrictionMini {
        [JsonPropertyName("shield_information_barrier")]
        public ShieldInformationBarrierBase? ShieldInformationBarrier { get; set; } = default;

        /// <summary>
        /// ISO date time string when this
        /// shield information barrier
        /// Segment Restriction object was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; } = default;

        [JsonPropertyName("created_by")]
        public UserBase? CreatedBy { get; set; } = default;

        /// <summary>
        /// ISO date time string when this
        /// shield information barrier segment
        /// Restriction was updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; } = default;

        [JsonPropertyName("updated_by")]
        public UserBase? UpdatedBy { get; set; } = default;

        public ShieldInformationBarrierSegmentRestriction(ShieldInformationBarrierSegmentRestrictionMiniShieldInformationBarrierSegmentField shieldInformationBarrierSegment, ShieldInformationBarrierSegmentRestrictionMiniRestrictedSegmentField restrictedSegment) : base(shieldInformationBarrierSegment, restrictedSegment) {
            
        }
    }
}