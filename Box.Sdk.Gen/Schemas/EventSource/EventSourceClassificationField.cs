using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class EventSourceClassificationField {
        /// <summary>
        /// The classification's name
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        public EventSourceClassificationField() {
            
        }
    }
}