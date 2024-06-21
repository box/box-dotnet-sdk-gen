using Unions;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class DevicePinners {
        /// <summary>
        /// A list of device pins
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<DevicePinner>? Entries { get; init; }

        /// <summary>
        /// The limit that was used for these entries. This will be the same as the
        /// `limit` query parameter unless that value exceeded the maximum value
        /// allowed.
        /// </summary>
        [JsonPropertyName("limit")]
        public long? Limit { get; init; }

        /// <summary>
        /// The marker for the start of the next page of results.
        /// </summary>
        [JsonPropertyName("next_marker")]
        public long? NextMarker { get; init; }

        /// <summary>
        /// The order by which items are returned.
        /// </summary>
        [JsonPropertyName("order")]
        public IReadOnlyList<DevicePinnersOrderField>? Order { get; init; }

        public DevicePinners() {
            
        }
    }
}