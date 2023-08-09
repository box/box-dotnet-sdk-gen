using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class EventSourceClassificationField {
        [JsonPropertyName("name")]
        public string Name { get; }

        public EventSourceClassificationField(string name) {
            Name = name;
        }
    }
}