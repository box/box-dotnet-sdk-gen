using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class TemplateSignerInputDimensionsField {
        /// <summary>
        /// Relative width to the page the input is on, ranging from 0 to 1.
        /// </summary>
        [JsonPropertyName("width")]
        public double? Width { get; init; }

        /// <summary>
        /// Relative height to the page the input is on, ranging from 0 to 1.
        /// </summary>
        [JsonPropertyName("height")]
        public double? Height { get; init; }

        public TemplateSignerInputDimensionsField() {
            
        }
    }
}