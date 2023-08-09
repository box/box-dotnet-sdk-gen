using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileVersionsOrderField {
        [JsonPropertyName("by")]
        public string By { get; }

        [JsonPropertyName("direction")]
        public FileVersionsOrderFieldDirectionField Direction { get; }

        public FileVersionsOrderField(string by, FileVersionsOrderFieldDirectionField direction) {
            By = by;
            Direction = direction;
        }
    }
}