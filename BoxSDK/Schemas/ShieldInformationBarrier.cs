using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class ShieldInformationBarrier {
        /// <summary>
        /// The unique identifier for the shield information barrier
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// The type of the shield information barrier
        /// </summary>
        [JsonPropertyName("type")]
        public ShieldInformationBarrierTypeField? Type { get; set; } = default;

        [JsonPropertyName("enterprise")]
        public EnterpriseBase? Enterprise { get; set; } = default;

        /// <summary>
        /// Status of the shield information barrier
        /// </summary>
        [JsonPropertyName("status")]
        public ShieldInformationBarrierStatusField? Status { get; set; } = default;

        /// <summary>
        /// ISO date time string when this
        /// shield information barrier object was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; } = default;

        [JsonPropertyName("created_by")]
        public UserBase? CreatedBy { get; set; } = default;

        /// <summary>
        /// ISO date time string when this shield information barrier was updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; } = default;

        [JsonPropertyName("updated_by")]
        public UserBase? UpdatedBy { get; set; } = default;

        /// <summary>
        /// ISO date time string when this shield information barrier was enabled.
        /// </summary>
        [JsonPropertyName("enabled_at")]
        public string? EnabledAt { get; set; } = default;

        [JsonPropertyName("enabled_by")]
        public UserBase? EnabledBy { get; set; } = default;

        public ShieldInformationBarrier() {
            
        }
    }
}