using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class CollaborationsOrderField {
        [JsonPropertyName("by")]
        public string By { get; }

        [JsonPropertyName("direction")]
        public CollaborationsOrderFieldDirectionField Direction { get; }

        public CollaborationsOrderField(string by, CollaborationsOrderFieldDirectionField direction) {
            By = by;
            Direction = direction;
        }
    }
}