using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class AiExtractStructuredFieldsOptionsField {
        /// <summary>
        /// A unique identifier for the field.
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; }

        public AiExtractStructuredFieldsOptionsField(string key) {
            Key = key;
        }
    }
}