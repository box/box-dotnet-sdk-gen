using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class MetadataTemplateFieldsOptionsField {
        /// <summary>
        /// The text value of the option. This represents both the display name of the
        /// option and the internal key used when updating templates.
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; }

        /// <summary>
        /// The internal unique identifier of the the option.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        public MetadataTemplateFieldsOptionsField(string key) {
            Key = key;
        }
    }
}