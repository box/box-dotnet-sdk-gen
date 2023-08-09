using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class WatermarkWatermarkField {
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("modified_at")]
        public string ModifiedAt { get; }

        public WatermarkWatermarkField(string createdAt, string modifiedAt) {
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
        }
    }
}