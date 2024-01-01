using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class ShieldInformationBarrierSegmentMemberBase {
        /// <summary>
        /// The unique identifier for the
        /// shield information barrier segment member
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// The type of the shield information barrier segment member
        /// </summary>
        [JsonPropertyName("type")]
        public ShieldInformationBarrierSegmentMemberBaseTypeField? Type { get; set; } = default;

        public ShieldInformationBarrierSegmentMemberBase() {
            
        }
    }
}