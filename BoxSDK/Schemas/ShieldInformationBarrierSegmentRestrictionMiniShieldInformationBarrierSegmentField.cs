using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class ShieldInformationBarrierSegmentRestrictionMiniShieldInformationBarrierSegmentField {
        /// <summary>
        /// The ID reference of the
        /// requesting shield information barrier segment.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// The type of the shield information barrier segment
        /// </summary>
        [JsonPropertyName("type")]
        public ShieldInformationBarrierSegmentRestrictionMiniShieldInformationBarrierSegmentFieldTypeField? Type { get; set; } = default;

        public ShieldInformationBarrierSegmentRestrictionMiniShieldInformationBarrierSegmentField() {
            
        }
    }
}