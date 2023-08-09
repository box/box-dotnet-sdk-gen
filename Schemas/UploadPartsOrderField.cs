using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class UploadPartsOrderField {
        [JsonPropertyName("by")]
        public string By { get; }

        [JsonPropertyName("direction")]
        public UploadPartsOrderFieldDirectionField Direction { get; }

        public UploadPartsOrderField(string by, UploadPartsOrderFieldDirectionField direction) {
            By = by;
            Direction = direction;
        }
    }
}