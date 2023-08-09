using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class ItemsOrderField {
        [JsonPropertyName("by")]
        public string By { get; }

        [JsonPropertyName("direction")]
        public ItemsOrderFieldDirectionField Direction { get; }

        public ItemsOrderField(string by, ItemsOrderFieldDirectionField direction) {
            By = by;
            Direction = direction;
        }
    }
}