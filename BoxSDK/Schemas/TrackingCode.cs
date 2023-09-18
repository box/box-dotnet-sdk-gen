using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class TrackingCode {
        /// <summary>
        /// `tracking_code`
        /// </summary>
        [JsonPropertyName("type")]
        public TrackingCodeTypeField? Type { get; set; } = default;

        /// <summary>
        /// The name of the tracking code, which must be preconfigured in
        /// the Admin Console
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        /// <summary>
        /// The value of the tracking code
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get; set; } = default;

        public TrackingCode() {
            
        }
    }
}