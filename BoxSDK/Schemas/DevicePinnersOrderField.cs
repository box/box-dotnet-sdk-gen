using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class DevicePinnersOrderField {
        /// <summary>
        /// The field that is ordered by
        /// </summary>
        [JsonPropertyName("by")]
        public DevicePinnersOrderFieldByField? By { get; set; } = default;

        /// <summary>
        /// The direction to order by, either ascending or descending
        /// </summary>
        [JsonPropertyName("direction")]
        public DevicePinnersOrderFieldDirectionField? Direction { get; set; } = default;

        public DevicePinnersOrderField() {
            
        }
    }
}