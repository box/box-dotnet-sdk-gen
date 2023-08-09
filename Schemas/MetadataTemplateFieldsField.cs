using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class MetadataTemplateFieldsField {
        [JsonPropertyName("type")]
        public MetadataTemplateFieldsFieldTypeField Type { get; }

        [JsonPropertyName("key")]
        public string Key { get; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; }

        [JsonPropertyName("description")]
        public string Description { get; }

        [JsonPropertyName("hidden")]
        public bool? Hidden { get; }

        [JsonPropertyName("options")]
        public IReadOnlyList<MetadataTemplateFieldsFieldOptionsField> Options { get; }

        [JsonPropertyName("id")]
        public string Id { get; }

        public MetadataTemplateFieldsField(MetadataTemplateFieldsFieldTypeField type, string key, string displayName, string description, bool? hidden, IReadOnlyList<MetadataTemplateFieldsFieldOptionsField> options, string id) {
            Type = type;
            Key = key;
            DisplayName = displayName;
            Description = description;
            Hidden = hidden;
            Options = options;
            Id = id;
        }
    }
}