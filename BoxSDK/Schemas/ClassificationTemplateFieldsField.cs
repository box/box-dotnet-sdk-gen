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
        public string Id { get; set; }

        /// <summary>
        /// The array item type.
        /// </summary>
        [JsonPropertyName("type")]
        public ClassificationTemplateFieldsFieldTypeField Type { get; set; }

        /// <summary>
        /// Defines classifications 
        /// available in the enterprise.
        /// </summary>
        [JsonPropertyName("key")]
        public ClassificationTemplateFieldsFieldKeyField Key { get; set; }

        /// <summary>
        /// `Classification`
        /// </summary>
        [JsonPropertyName("displayName")]
        public ClassificationTemplateFieldsFieldDisplayNameField DisplayName { get; set; }

        /// <summary>
        /// Classifications are always visible to web and mobile users.
        /// </summary>
        [JsonPropertyName("hidden")]
        public bool? Hidden { get; set; } = default;

        /// <summary>
        /// A list of classifications available in this enterprise.
        /// </summary>
        [JsonPropertyName("options")]
        public IReadOnlyList<ClassificationTemplateFieldsFieldOptionsField> Options { get; set; }

        public ClassificationTemplateFieldsField(string id, ClassificationTemplateFieldsFieldTypeField type, ClassificationTemplateFieldsFieldKeyField key, ClassificationTemplateFieldsFieldDisplayNameField displayName, IReadOnlyList<ClassificationTemplateFieldsFieldOptionsField> options) {
            Id = id;
            Type = type;
            Key = key;
            DisplayName = displayName;
            Options = options;
        }
    }
}