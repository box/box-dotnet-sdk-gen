using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsFieldOptionsField {
        /// <summary>
        /// The display name and key this classification. This
        /// will be show in the Box UI.
        /// </summary>
        [JsonPropertyName("key")]
        public string? Key { get; set; } = default;

        /// <summary>
        /// Additional information about the classification.
        /// </summary>
        [JsonPropertyName("staticConfig")]
        public CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsFieldOptionsFieldStaticConfigField? StaticConfig { get; set; } = default;

        public CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsFieldOptionsField() {
            
        }
    }
}