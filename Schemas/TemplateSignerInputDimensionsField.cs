using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class TemplateSignerInputDimensionsField {
        [JsonPropertyName("width")]
        public int? Width { get; }

        [JsonPropertyName("height")]
        public int? Height { get; }

        public TemplateSignerInputDimensionsField(int? width, int? height) {
            Width = width;
            Height = height;
        }
    }
}