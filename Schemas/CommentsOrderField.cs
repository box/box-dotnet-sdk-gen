using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class CommentsOrderField {
        [JsonPropertyName("by")]
        public string By { get; }

        [JsonPropertyName("direction")]
        public CommentsOrderFieldDirectionField Direction { get; }

        public CommentsOrderField(string by, CommentsOrderFieldDirectionField direction) {
            By = by;
            Direction = direction;
        }
    }
}