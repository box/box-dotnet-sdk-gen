using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class TemplateSignerInputCoordinatesField {
        /// <summary>
        /// Relative x coordinate to the page the input is on, ranging from 0 to 1.
        /// </summary>
        [JsonPropertyName("x")]
        public double? X { get; init; }

        /// <summary>
        /// Relative y coordinate to the page the input is on, ranging from 0 to 1.
        /// </summary>
        [JsonPropertyName("y")]
        public double? Y { get; init; }

        public TemplateSignerInputCoordinatesField() {
            
        }
    }
}