using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class AiExtractStructuredMetadataTemplateField {
        /// <summary>
        /// The name of the metadata template.
        /// </summary>
        [JsonPropertyName("template_key")]
        public string? TemplateKey { get; init; }

        /// <summary>
        /// Value is always `metadata_template`.
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<AiExtractStructuredMetadataTemplateTypeField>))]
        public StringEnum<AiExtractStructuredMetadataTemplateTypeField>? Type { get; init; }

        /// <summary>
        /// The scope of the metadata template that can either be global or
        /// enterprise. 
        /// * The **global** scope is used for templates that are
        /// available to any Box enterprise. 
        /// * The **enterprise** scope represents templates created within a specific enterprise,
        ///   containing the ID of that enterprise.
        /// </summary>
        [JsonPropertyName("scope")]
        public string? Scope { get; init; }

        public AiExtractStructuredMetadataTemplateField() {
            
        }
    }
}