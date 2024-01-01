using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class ShieldInformationBarrierSegmentRestrictionMiniRestrictedSegmentField {
        /// <summary>
        /// The ID reference of the
        /// restricted shield information barrier segment.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// The type of the shield information segment
        /// </summary>
        [JsonPropertyName("type")]
        public ShieldInformationBarrierSegmentRestrictionMiniRestrictedSegmentTypeField? Type { get; set; } = default;

        public ShieldInformationBarrierSegmentRestrictionMiniRestrictedSegmentField() {
            
        }
    }
}