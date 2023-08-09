using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateMetadataTemplateSchemaRequestBodyArgFieldsField {
        [JsonPropertyName("type")]
        public CreateMetadataTemplateSchemaRequestBodyArgFieldsFieldTypeField Type { get; }

        [JsonPropertyName("key")]
        public string Key { get; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; }

        [JsonPropertyName("description")]
        public string Description { get; }

        [JsonPropertyName("hidden")]
        public bool? Hidden { get; }

        [JsonPropertyName("options")]
        public IReadOnlyList<CreateMetadataTemplateSchemaRequestBodyArgFieldsFieldOptionsField> Options { get; }

        public CreateMetadataTemplateSchemaRequestBodyArgFieldsField(CreateMetadataTemplateSchemaRequestBodyArgFieldsFieldTypeField type, string key, string displayName, string description, bool? hidden, IReadOnlyList<CreateMetadataTemplateSchemaRequestBodyArgFieldsFieldOptionsField> options) {
            Type = type;
            Key = key;
            DisplayName = displayName;
            Description = description;
            Hidden = hidden;
            Options = options;
        }
    }
}