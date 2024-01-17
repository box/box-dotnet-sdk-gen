using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class ShieldInformationBarrierSegment {
        /// <summary>
        /// The unique identifier for the shield information barrier segment
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// The type of the shield information barrier segment
        /// </summary>
        [JsonPropertyName("type")]
        public ShieldInformationBarrierSegmentTypeField? Type { get; set; } = default;

        [JsonPropertyName("shield_information_barrier")]
        public ShieldInformationBarrierBase? ShieldInformationBarrier { get; set; } = default;

        /// <summary>
        /// Name of the shield information barrier segment
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        /// <summary>
        /// Description of the shield information barrier segment
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; } = default;

        /// <summary>
        /// ISO date time string when this shield information
        /// barrier object was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; } = default;

        [JsonPropertyName("created_by")]
        public UserBase? CreatedBy { get; set; } = default;

        /// <summary>
        /// ISO date time string when this
        /// shield information barrier segment was updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; } = default;

        [JsonPropertyName("updated_by")]
        public UserBase? UpdatedBy { get; set; } = default;

        public ShieldInformationBarrierSegment() {
            
        }
    }
}