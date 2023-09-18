using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsField {
        /// <summary>
        /// `enum`
        /// </summary>
        [JsonPropertyName("type")]
        public CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsFieldTypeField? Type { get; set; } = default;

        /// <summary>
        /// `Box__Security__Classification__Key`
        /// </summary>
        [JsonPropertyName("key")]
        public CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsFieldKeyField? Key { get; set; } = default;

        /// <summary>
        /// `Classification`
        /// </summary>
        [JsonPropertyName("displayName")]
        public CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsFieldDisplayNameField? DisplayName { get; set; } = default;

        /// <summary>
        /// `false`
        /// </summary>
        [JsonPropertyName("hidden")]
        public bool? Hidden { get; set; } = default;

        /// <summary>
        /// The actual list of classifications that are present on
        /// this template.
        /// </summary>
        [JsonPropertyName("options")]
        public IReadOnlyList<CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsFieldOptionsField>? Options { get; set; } = default;

        public CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsField() {
            
        }
    }
}