using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class ClassificationTemplateFieldsFieldOptionsField {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("key")]
        public string Key { get; }

        [JsonPropertyName("staticConfig")]
        public ClassificationTemplateFieldsFieldOptionsFieldStaticConfigField StaticConfig { get; }

        public ClassificationTemplateFieldsFieldOptionsField(string id, string key, ClassificationTemplateFieldsFieldOptionsFieldStaticConfigField staticConfig) {
            Id = id;
            Key = key;
            StaticConfig = staticConfig;
        }
    }
}