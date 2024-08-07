using Box.Sdk.Gen;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class ClassificationTemplateFieldsOptionsField {
        /// <summary>
        /// The unique ID of this classification.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        /// <summary>
        /// The display name and key for this classification.
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; }

        /// <summary>
        /// Additional information about the classification.
        /// </summary>
        [JsonPropertyName("staticConfig")]
        public ClassificationTemplateFieldsOptionsStaticConfigField? StaticConfig { get; init; }

        public ClassificationTemplateFieldsOptionsField(string id, string key) {
            Id = id;
            Key = key;
        }
    }
}