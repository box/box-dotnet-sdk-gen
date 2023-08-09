using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class UsersOrderField {
        [JsonPropertyName("by")]
        public string By { get; }

        [JsonPropertyName("direction")]
        public UsersOrderFieldDirectionField Direction { get; }

        public UsersOrderField(string by, UsersOrderFieldDirectionField direction) {
            By = by;
            Direction = direction;
        }
    }
}