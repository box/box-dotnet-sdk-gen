using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class ClassificationTemplateFieldsField {
        /// <summary>
        /// The unique ID of the field.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// `enum`
        /// </summary>
        [JsonPropertyName("type")]
        public ClassificationTemplateFieldsFieldTypeField? Type { get; set; } = default;

        /// <summary>
        /// `Box__Security__Classification__Key`
        /// </summary>
        [JsonPropertyName("key")]
        public ClassificationTemplateFieldsFieldKeyField? Key { get; set; } = default;

        /// <summary>
        /// `Classification`
        /// </summary>
        [JsonPropertyName("displayName")]
        public ClassificationTemplateFieldsFieldDisplayNameField? DisplayName { get; set; } = default;

        /// <summary>
        /// Classifications are always visible to web and mobile users.
        /// </summary>
        [JsonPropertyName("hidden")]
        public bool? Hidden { get; set; } = default;

        /// <summary>
        /// A list of classifications available in this enterprise.
        /// </summary>
        [JsonPropertyName("options")]
        public IReadOnlyList<ClassificationTemplateFieldsFieldOptionsField>? Options { get; set; } = default;

        public ClassificationTemplateFieldsField() {
            
        }
    }
}