using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class ClassificationTemplate {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public ClassificationTemplateTypeField Type { get; }

        [JsonPropertyName("scope")]
        public string Scope { get; }

        [JsonPropertyName("templateKey")]
        public ClassificationTemplateTemplateKeyField TemplateKey { get; }

        [JsonPropertyName("displayName")]
        public ClassificationTemplateDisplayNameField DisplayName { get; }

        [JsonPropertyName("hidden")]
        public bool? Hidden { get; }

        [JsonPropertyName("copyInstanceOnItemCopy")]
        public bool? CopyInstanceOnItemCopy { get; }

        [JsonPropertyName("fields")]
        public IReadOnlyList<ClassificationTemplateFieldsField> Fields { get; }

        public ClassificationTemplate(string id, ClassificationTemplateTypeField type, string scope, ClassificationTemplateTemplateKeyField templateKey, ClassificationTemplateDisplayNameField displayName, bool? hidden, bool? copyInstanceOnItemCopy, IReadOnlyList<ClassificationTemplateFieldsField> fields) {
            Id = id;
            Type = type;
            Scope = scope;
            TemplateKey = templateKey;
            DisplayName = displayName;
            Hidden = hidden;
            CopyInstanceOnItemCopy = copyInstanceOnItemCopy;
            Fields = fields;
        }
    }
}