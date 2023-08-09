using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateMetadataTemplateSchemaRequestBodyArgFieldsFieldOptionsField {
        [JsonPropertyName("key")]
        public string Key { get; }

        public CreateMetadataTemplateSchemaRequestBodyArgFieldsFieldOptionsField(string key) {
            Key = key;
        }
    }
}