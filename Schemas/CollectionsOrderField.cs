using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class CollectionsOrderField {
        [JsonPropertyName("by")]
        public string By { get; }

        [JsonPropertyName("direction")]
        public CollectionsOrderFieldDirectionField Direction { get; }

        public CollectionsOrderField(string by, CollectionsOrderFieldDirectionField direction) {
            By = by;
            Direction = direction;
        }
    }
}