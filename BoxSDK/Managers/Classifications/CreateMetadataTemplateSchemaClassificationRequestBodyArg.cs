using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateMetadataTemplateSchemaClassificationRequestBodyArg {
        /// <summary>
        /// The scope in which to create the classifications. This should
        /// be `enterprise` or `enterprise_{id}` where `id` is the unique
        /// ID of the enterprise.
        /// </summary>
        [JsonPropertyName("scope")]
        public CreateMetadataTemplateSchemaClassificationRequestBodyArgScopeField Scope { get; set; }

        /// <summary>
        /// Defines the list of metadata templates.
        /// </summary>
        [JsonPropertyName("templateKey")]
        public CreateMetadataTemplateSchemaClassificationRequestBodyArgTemplateKeyField TemplateKey { get; set; }

        /// <summary>
        /// The name of the
        /// template as shown in web and mobile interfaces.
        /// </summary>
        [JsonPropertyName("displayName")]
        public CreateMetadataTemplateSchemaClassificationRequestBodyArgDisplayNameField DisplayName { get; set; }

        /// <summary>
        /// Determines if the classification template is
        /// hidden or available on web and mobile
        /// devices.
        /// </summary>
        [JsonPropertyName("hidden")]
        public bool? Hidden { get; set; } = default;

        /// <summary>
        /// Determines if classifications are
        /// copied along when the file or folder is
        /// copied.
        /// </summary>
        [JsonPropertyName("copyInstanceOnItemCopy")]
        public bool? CopyInstanceOnItemCopy { get; set; } = default;

        /// <summary>
        /// The classification template requires exactly
        /// one field, which holds
        /// all the valid classification values.
        /// </summary>
        [JsonPropertyName("fields")]
        public IReadOnlyList<CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsField> Fields { get; set; }

        public CreateMetadataTemplateSchemaClassificationRequestBodyArg(CreateMetadataTemplateSchemaClassificationRequestBodyArgScopeField scope, CreateMetadataTemplateSchemaClassificationRequestBodyArgTemplateKeyField templateKey, CreateMetadataTemplateSchemaClassificationRequestBodyArgDisplayNameField displayName, IReadOnlyList<CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsField> fields) {
            Scope = scope;
            TemplateKey = templateKey;
            DisplayName = displayName;
            Fields = fields;
        }
    }
}