using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class TemplateSignerInputDimensionsField {
        /// <summary>
        /// Relative width to the page the input is on, ranging from 0 to 1.
        /// </summary>
        [JsonPropertyName("width")]
        public double? Width { get; set; } = default;

        /// <summary>
        /// Relative height to the page the input is on, ranging from 0 to 1.
        /// </summary>
        [JsonPropertyName("height")]
        public double? Height { get; set; } = default;

        public TemplateSignerInputDimensionsField() {
            
        }
    }
}