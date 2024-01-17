using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class CreateClassificationTemplateRequestBody {
        /// <summary>
        /// The scope in which to create the classifications. This should
        /// be `enterprise` or `enterprise_{id}` where `id` is the unique
        /// ID of the enterprise.
        /// </summary>
        [JsonPropertyName("scope")]
        public CreateClassificationTemplateRequestBodyScopeField Scope { get; set; }

        /// <summary>
        /// Defines the list of metadata templates.
        /// </summary>
        [JsonPropertyName("templateKey")]
        public CreateClassificationTemplateRequestBodyTemplateKeyField TemplateKey { get; set; }

        /// <summary>
        /// The name of the
        /// template as shown in web and mobile interfaces.
        /// </summary>
        [JsonPropertyName("displayName")]
        public CreateClassificationTemplateRequestBodyDisplayNameField DisplayName { get; set; }

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
        public IReadOnlyList<CreateClassificationTemplateRequestBodyFieldsField> Fields { get; set; }

        public CreateClassificationTemplateRequestBody(CreateClassificationTemplateRequestBodyScopeField scope, CreateClassificationTemplateRequestBodyTemplateKeyField templateKey, CreateClassificationTemplateRequestBodyDisplayNameField displayName, IReadOnlyList<CreateClassificationTemplateRequestBodyFieldsField> fields) {
            Scope = scope;
            TemplateKey = templateKey;
            DisplayName = displayName;
            Fields = fields;
        }
    }
}