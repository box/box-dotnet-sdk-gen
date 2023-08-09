using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class MetadataTemplate {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public MetadataTemplateTypeField Type { get; }

        [JsonPropertyName("scope")]
        public string Scope { get; }

        [JsonPropertyName("templateKey")]
        public string TemplateKey { get; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; }

        [JsonPropertyName("hidden")]
        public bool? Hidden { get; }

        [JsonPropertyName("fields")]
        public IReadOnlyList<MetadataTemplateFieldsField> Fields { get; }

        [JsonPropertyName("copyInstanceOnItemCopy")]
        public bool? CopyInstanceOnItemCopy { get; }

        public MetadataTemplate(string id, MetadataTemplateTypeField type, string scope, string templateKey, string displayName, bool? hidden, IReadOnlyList<MetadataTemplateFieldsField> fields, bool? copyInstanceOnItemCopy) {
            Id = id;
            Type = type;
            Scope = scope;
            TemplateKey = templateKey;
            DisplayName = displayName;
            Hidden = hidden;
            Fields = fields;
            CopyInstanceOnItemCopy = copyInstanceOnItemCopy;
        }
    }
}