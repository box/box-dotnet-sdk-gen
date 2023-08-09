using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateMetadataTemplateSchemaClassificationRequestBodyArg {
        [JsonPropertyName("scope")]
        public CreateMetadataTemplateSchemaClassificationRequestBodyArgScopeField Scope { get; }

        [JsonPropertyName("templateKey")]
        public CreateMetadataTemplateSchemaClassificationRequestBodyArgTemplateKeyField TemplateKey { get; }

        [JsonPropertyName("displayName")]
        public CreateMetadataTemplateSchemaClassificationRequestBodyArgDisplayNameField DisplayName { get; }

        [JsonPropertyName("hidden")]
        public bool? Hidden { get; }

        [JsonPropertyName("copyInstanceOnItemCopy")]
        public bool? CopyInstanceOnItemCopy { get; }

        [JsonPropertyName("fields")]
        public IReadOnlyList<CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsField> Fields { get; }

        public CreateMetadataTemplateSchemaClassificationRequestBodyArg(CreateMetadataTemplateSchemaClassificationRequestBodyArgScopeField scope, CreateMetadataTemplateSchemaClassificationRequestBodyArgTemplateKeyField templateKey, CreateMetadataTemplateSchemaClassificationRequestBodyArgDisplayNameField displayName, bool? hidden, bool? copyInstanceOnItemCopy, IReadOnlyList<CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsField> fields) {
            Scope = scope;
            TemplateKey = templateKey;
            DisplayName = displayName;
            Hidden = hidden;
            CopyInstanceOnItemCopy = copyInstanceOnItemCopy;
            Fields = fields;
        }
    }
}