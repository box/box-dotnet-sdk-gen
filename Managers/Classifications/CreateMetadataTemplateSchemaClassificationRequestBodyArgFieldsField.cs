using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsField {
        [JsonPropertyName("type")]
        public CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsFieldTypeField Type { get; }

        [JsonPropertyName("key")]
        public CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsFieldKeyField Key { get; }

        [JsonPropertyName("displayName")]
        public CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsFieldDisplayNameField DisplayName { get; }

        [JsonPropertyName("hidden")]
        public bool? Hidden { get; }

        [JsonPropertyName("options")]
        public IReadOnlyList<CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsFieldOptionsField> Options { get; }

        public CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsField(CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsFieldTypeField type, CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsFieldKeyField key, CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsFieldDisplayNameField displayName, bool? hidden, IReadOnlyList<CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsFieldOptionsField> options) {
            Type = type;
            Key = key;
            DisplayName = displayName;
            Hidden = hidden;
            Options = options;
        }
    }
}