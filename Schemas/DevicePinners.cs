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
        public int? Limit { get; }

        [JsonPropertyName("next_marker")]
        public int? NextMarker { get; }

        [JsonPropertyName("order")]
        public IReadOnlyList<DevicePinnersOrderField> Order { get; }

        public DevicePinners(IReadOnlyList<DevicePinner> entries, int? limit, int? nextMarker, IReadOnlyList<DevicePinnersOrderField> order) {
            Entries = entries;
            Limit = limit;
            NextMarker = nextMarker;
            Order = order;
        }
    }
}