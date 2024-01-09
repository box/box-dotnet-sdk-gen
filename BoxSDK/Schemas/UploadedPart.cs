using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class UploadedPart {
        [JsonPropertyName("part")]
        public UploadPart? Part { get; set; } = default;

        public UploadedPart() {
            
        }
    }
}