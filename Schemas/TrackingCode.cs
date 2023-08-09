using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class TrackingCode {
        [JsonPropertyName("type")]
        public TrackingCodeTypeField Type { get; }

        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("value")]
        public string Value { get; }

        public TrackingCode(TrackingCodeTypeField type, string name, string value) {
            Type = type;
            Name = name;
            Value = value;
        }
    }
}