using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileFullClassificationField {
        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("definition")]
        public string Definition { get; }

        [JsonPropertyName("color")]
        public string Color { get; }

        public FileFullClassificationField(string name, string definition, string color) {
            Name = name;
            Definition = definition;
            Color = color;
        }
    }
}