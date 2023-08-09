using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateMetadataTemplateSchemaRequestBodyArg {
        [JsonPropertyName("scope")]
        public string Scope { get; }

        [JsonPropertyName("templateKey")]
        public string TemplateKey { get; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; }

        [JsonPropertyName("hidden")]
        public bool? Hidden { get; }

        [JsonPropertyName("fields")]
        public IReadOnlyList<CreateMetadataTemplateSchemaRequestBodyArgFieldsField> Fields { get; }

        [JsonPropertyName("copyInstanceOnItemCopy")]
        public bool? CopyInstanceOnItemCopy { get; }

        public CreateMetadataTemplateSchemaRequestBodyArg(string scope, string templateKey, string displayName, bool? hidden, IReadOnlyList<CreateMetadataTemplateSchemaRequestBodyArgFieldsField> fields, bool? copyInstanceOnItemCopy) {
            Scope = scope;
            TemplateKey = templateKey;
            DisplayName = displayName;
            Hidden = hidden;
            Fields = fields;
            CopyInstanceOnItemCopy = copyInstanceOnItemCopy;
        }
    }
}