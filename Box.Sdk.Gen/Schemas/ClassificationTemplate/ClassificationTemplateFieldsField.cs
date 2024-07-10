using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Internal;

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
        [JsonConverter(typeof(StringEnumConverter<ClassificationTemplateFieldsTypeField>))]
        public StringEnum<ClassificationTemplateFieldsTypeField> Type { get; }

        /// <summary>
        /// Defines classifications 
        /// available in the enterprise.
        /// </summary>
        [JsonPropertyName("key")]
        [JsonConverter(typeof(StringEnumConverter<ClassificationTemplateFieldsKeyField>))]
        public StringEnum<ClassificationTemplateFieldsKeyField> Key { get; }

        /// <summary>
        /// `Classification`
        /// </summary>
        [JsonPropertyName("displayName")]
        [JsonConverter(typeof(StringEnumConverter<ClassificationTemplateFieldsDisplayNameField>))]
        public StringEnum<ClassificationTemplateFieldsDisplayNameField> DisplayName { get; }

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
        
        [JsonConstructorAttribute]
        internal ClassificationTemplateFieldsField(string id, IReadOnlyList<ClassificationTemplateFieldsOptionsField> options, StringEnum<ClassificationTemplateFieldsTypeField> type, StringEnum<ClassificationTemplateFieldsKeyField> key, StringEnum<ClassificationTemplateFieldsDisplayNameField> displayName) {
            Id = id;
            Type = ClassificationTemplateFieldsTypeField.Enum;
            Key = ClassificationTemplateFieldsKeyField.BoxSecurityClassificationKey;
            DisplayName = ClassificationTemplateFieldsDisplayNameField.Classification;
            Options = options;
        }
    }
}