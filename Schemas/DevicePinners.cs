using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class DevicePinners {
        [JsonPropertyName("entries")]
        public IReadOnlyList<DevicePinner> Entries { get; }

        [JsonPropertyName("limit")]
        public long? Limit { get; }

        [JsonPropertyName("next_marker")]
        public long? NextMarker { get; }

        [JsonPropertyName("order")]
        public IReadOnlyList<DevicePinnersOrderField> Order { get; }

        public DevicePinners(IReadOnlyList<DevicePinner> entries, long? limit, long? nextMarker, IReadOnlyList<DevicePinnersOrderField> order) {
            Entries = entries;
            Limit = limit;
            NextMarker = nextMarker;
            Order = order;
        }
    }
}