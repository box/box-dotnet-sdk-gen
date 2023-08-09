using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class ClassificationTemplateFieldsField {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public ClassificationTemplateFieldsFieldTypeField Type { get; }

        [JsonPropertyName("key")]
        public ClassificationTemplateFieldsFieldKeyField Key { get; }

        [JsonPropertyName("displayName")]
        public ClassificationTemplateFieldsFieldDisplayNameField DisplayName { get; }

        [JsonPropertyName("hidden")]
        public bool? Hidden { get; }

        [JsonPropertyName("options")]
        public IReadOnlyList<ClassificationTemplateFieldsFieldOptionsField> Options { get; }

        public ClassificationTemplateFieldsField(string id, ClassificationTemplateFieldsFieldTypeField type, ClassificationTemplateFieldsFieldKeyField key, ClassificationTemplateFieldsFieldDisplayNameField displayName, bool? hidden, IReadOnlyList<ClassificationTemplateFieldsFieldOptionsField> options) {
            Id = id;
            Type = type;
            Key = key;
            DisplayName = displayName;
            Hidden = hidden;
            Options = options;
        }
    }
}