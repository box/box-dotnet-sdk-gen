using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class CreateClassificationTemplateRequestBodyFieldsField {
        /// <summary>
        /// The type of the field
        /// that is always enum.
        /// </summary>
        [JsonPropertyName("type")]
        public CreateClassificationTemplateRequestBodyFieldsTypeField Type { get; set; }

        /// <summary>
        /// Defines classifications 
        /// available in the enterprise.
        /// </summary>
        [JsonPropertyName("key")]
        public CreateClassificationTemplateRequestBodyFieldsKeyField Key { get; set; }

        /// <summary>
        /// A display name for the classification.
        /// </summary>
        [JsonPropertyName("displayName")]
        public CreateClassificationTemplateRequestBodyFieldsDisplayNameField DisplayName { get; set; }

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
        public IReadOnlyList<CreateClassificationTemplateRequestBodyFieldsOptionsField> Options { get; set; }

        public CreateClassificationTemplateRequestBodyFieldsField(IReadOnlyList<CreateClassificationTemplateRequestBodyFieldsOptionsField> options, CreateClassificationTemplateRequestBodyFieldsTypeField type = CreateClassificationTemplateRequestBodyFieldsTypeField.Enum, CreateClassificationTemplateRequestBodyFieldsKeyField key = CreateClassificationTemplateRequestBodyFieldsKeyField.BoxSecurityClassificationKey, CreateClassificationTemplateRequestBodyFieldsDisplayNameField displayName = CreateClassificationTemplateRequestBodyFieldsDisplayNameField.Classification) {
            Type = type;
            Key = key;
            DisplayName = displayName;
            Options = options;
        }
    }
}