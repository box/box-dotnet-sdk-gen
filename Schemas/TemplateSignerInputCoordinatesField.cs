using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class TemplateSignerInputCoordinatesField {
        [JsonPropertyName("x")]
        public int? X { get; }

        [JsonPropertyName("y")]
        public int? Y { get; }

        public TemplateSignerInputCoordinatesField(int? x, int? y) {
            X = x;
            Y = y;
        }
    }
}