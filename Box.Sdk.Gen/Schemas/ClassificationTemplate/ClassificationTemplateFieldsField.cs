using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Sdk.Gen.Schemas {
    public class ClassificationTemplateFieldsField {
        /// <summary>
        /// The unique ID of the field.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        /// <summary>
        /// The array item type.
        /// </summary>
        [JsonPropertyName("type")]
        public ClassificationTemplateFieldsTypeField Type { get; }

        /// <summary>
        /// Defines classifications 
        /// available in the enterprise.
        /// </summary>
        [JsonPropertyName("key")]
        public ClassificationTemplateFieldsKeyField Key { get; }

        /// <summary>
        /// `Classification`
        /// </summary>
        [JsonPropertyName("displayName")]
        public ClassificationTemplateFieldsDisplayNameField DisplayName { get; }

        /// <summary>
        /// Classifications are always visible to web and mobile users.
        /// </summary>
        [JsonPropertyName("hidden")]
        public bool? Hidden { get; init; }

        /// <summary>
        /// A list of classifications available in this enterprise.
        /// </summary>
        [JsonPropertyName("options")]
        public IReadOnlyList<ClassificationTemplateFieldsOptionsField> Options { get; }

        public ClassificationTemplateFieldsField(string id, IReadOnlyList<ClassificationTemplateFieldsOptionsField> options, ClassificationTemplateFieldsTypeField type = ClassificationTemplateFieldsTypeField.Enum, ClassificationTemplateFieldsKeyField key = ClassificationTemplateFieldsKeyField.BoxSecurityClassificationKey, ClassificationTemplateFieldsDisplayNameField displayName = ClassificationTemplateFieldsDisplayNameField.Classification) {
            Id = id;
            Type = type;
            Key = key;
            DisplayName = displayName;
            Options = options;
        }
    }
}