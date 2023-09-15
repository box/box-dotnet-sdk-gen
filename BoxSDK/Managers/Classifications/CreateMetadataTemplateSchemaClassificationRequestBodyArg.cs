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
        /// `securityClassification-6VMVochwUWo`
        /// </summary>
        [JsonPropertyName("templateKey")]
        public CreateMetadataTemplateSchemaClassificationRequestBodyArgTemplateKeyField? TemplateKey { get; set; } = default;

        /// <summary>
        /// `Classification`
        /// </summary>
        [JsonPropertyName("displayName")]
        public CreateMetadataTemplateSchemaClassificationRequestBodyArgDisplayNameField DisplayName { get; set; }

        /// <summary>
        /// `false`
        /// </summary>
        [JsonPropertyName("hidden")]
        public bool? Hidden { get; set; } = default;

        /// <summary>
        /// `false`
        /// </summary>
        [JsonPropertyName("copyInstanceOnItemCopy")]
        public bool? CopyInstanceOnItemCopy { get; set; } = default;

        /// <summary>
        /// The classification template holds one field, which holds
        /// all the valid classification values.
        /// </summary>
        [JsonPropertyName("fields")]
        public IReadOnlyList<CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsField>? Fields { get; set; } = default;

        public CreateMetadataTemplateSchemaClassificationRequestBodyArg(CreateMetadataTemplateSchemaClassificationRequestBodyArgScopeField scope, CreateMetadataTemplateSchemaClassificationRequestBodyArgDisplayNameField displayName) {
            Scope = scope;
            DisplayName = displayName;
        }
    }
}