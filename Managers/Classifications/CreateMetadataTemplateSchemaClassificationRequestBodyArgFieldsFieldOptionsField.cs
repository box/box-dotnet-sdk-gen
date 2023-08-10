using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsFieldOptionsField {
        [JsonPropertyName("key")]
        public string Key { get; }

        [JsonPropertyName("staticConfig")]
        public CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsFieldOptionsFieldStaticConfigField StaticConfig { get; }

        public CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsFieldOptionsField(string key, CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsFieldOptionsFieldStaticConfigField staticConfig) {
            Key = key;
            StaticConfig = staticConfig;
        }
    }
}