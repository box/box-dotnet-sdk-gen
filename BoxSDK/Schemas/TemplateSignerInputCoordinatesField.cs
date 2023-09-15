using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class TemplateSignerInputCoordinatesField {
        /// <summary>
        /// Relative x coordinate to the page the input is on, ranging from 0 to 1.
        /// </summary>
        [JsonPropertyName("x")]
        public int? X { get; set; } = default;

        /// <summary>
        /// Relative y coordinate to the page the input is on, ranging from 0 to 1.
        /// </summary>
        [JsonPropertyName("y")]
        public int? Y { get; set; } = default;

        public TemplateSignerInputCoordinatesField() {
            
        }
    }
}