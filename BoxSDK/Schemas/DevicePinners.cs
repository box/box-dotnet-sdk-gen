using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class DevicePinners {
        /// <summary>
        /// A list of device pins
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<DevicePinner>? Entries { get; set; } = default;

        /// <summary>
        /// The limit that was used for these entries. This will be the same as the
        /// `limit` query parameter unless that value exceeded the maximum value
        /// allowed.
        /// </summary>
        [JsonPropertyName("limit")]
        public long? Limit { get; set; } = default;

        /// <summary>
        /// The marker for the start of the next page of results.
        /// </summary>
        [JsonPropertyName("next_marker")]
        public long? NextMarker { get; set; } = default;

        /// <summary>
        /// The order by which items are returned.
        /// </summary>
        [JsonPropertyName("order")]
        public IReadOnlyList<DevicePinnersOrderField>? Order { get; set; } = default;

        public DevicePinners() {
            
        }
    }
}