using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class DevicePinnersOrderField {
        [JsonPropertyName("by")]
        public DevicePinnersOrderFieldByField By { get; }

        [JsonPropertyName("direction")]
        public DevicePinnersOrderFieldDirectionField Direction { get; }

        public DevicePinnersOrderField(DevicePinnersOrderFieldByField by, DevicePinnersOrderFieldDirectionField direction) {
            By = by;
            Direction = direction;
        }
    }
}