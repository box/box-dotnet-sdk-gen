using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class MetadataTemplateFieldsFieldOptionsField {
        [JsonPropertyName("key")]
        public string Key { get; }

        [JsonPropertyName("id")]
        public string Id { get; }

        public MetadataTemplateFieldsFieldOptionsField(string key, string id) {
            Key = key;
            Id = id;
        }
    }
}