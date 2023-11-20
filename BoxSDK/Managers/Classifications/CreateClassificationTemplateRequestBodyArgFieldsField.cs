using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateClassificationTemplateRequestBodyArgFieldsField {
        /// <summary>
        /// The type of the field
        /// that is always enum.
        /// </summary>
        [JsonPropertyName("type")]
        public CreateClassificationTemplateRequestBodyArgFieldsFieldTypeField Type { get; set; }

        /// <summary>
        /// Defines classifications 
        /// available in the enterprise.
        /// </summary>
        [JsonPropertyName("key")]
        public CreateClassificationTemplateRequestBodyArgFieldsFieldKeyField Key { get; set; }

        /// <summary>
        /// A display name for the classification.
        /// </summary>
        [JsonPropertyName("displayName")]
        public CreateClassificationTemplateRequestBodyArgFieldsFieldDisplayNameField DisplayName { get; set; }

        /// <summary>
        /// Determines if the classification
        /// template is
        /// hidden or available on
        /// web and mobile
        /// devices.
        /// </summary>
        [JsonPropertyName("hidden")]
        public bool? Hidden { get; set; } = default;

        /// <summary>
        /// The actual list of classifications that are present on
        /// this template.
        /// </summary>
        [JsonPropertyName("options")]
        public IReadOnlyList<CreateClassificationTemplateRequestBodyArgFieldsFieldOptionsField> Options { get; set; }

        public CreateClassificationTemplateRequestBodyArgFieldsField(CreateClassificationTemplateRequestBodyArgFieldsFieldTypeField type, CreateClassificationTemplateRequestBodyArgFieldsFieldKeyField key, CreateClassificationTemplateRequestBodyArgFieldsFieldDisplayNameField displayName, IReadOnlyList<CreateClassificationTemplateRequestBodyArgFieldsFieldOptionsField> options) {
            Type = type;
            Key = key;
            DisplayName = displayName;
            Options = options;
        }
    }
}