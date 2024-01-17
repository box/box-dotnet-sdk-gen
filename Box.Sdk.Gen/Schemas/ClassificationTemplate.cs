using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Sdk.Gen.Schemas {
    public class ClassificationTemplate {
        /// <summary>
        /// The ID of the classification template.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// `metadata_template`
        /// </summary>
        [JsonPropertyName("type")]
        public ClassificationTemplateTypeField Type { get; set; }

        /// <summary>
        /// The scope of the classification template. This is in the format
        /// `enterprise_{id}` where the `id` is the enterprise ID.
        /// </summary>
        [JsonPropertyName("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// `securityClassification-6VMVochwUWo`
        /// </summary>
        [JsonPropertyName("templateKey")]
        public ClassificationTemplateTemplateKeyField TemplateKey { get; set; }

        /// <summary>
        /// The name of this template as shown in web and mobile interfaces.
        /// </summary>
        [JsonPropertyName("displayName")]
        public ClassificationTemplateDisplayNameField DisplayName { get; set; }

        /// <summary>
        /// Determines if the
        /// template is always available in web and mobile interfaces.
        /// </summary>
        [JsonPropertyName("hidden")]
        public bool? Hidden { get; set; } = default;

        /// <summary>
        /// Determines if 
        /// classifications are
        /// copied along when the file or folder is
        /// copied.
        /// </summary>
        [JsonPropertyName("copyInstanceOnItemCopy")]
        public bool? CopyInstanceOnItemCopy { get; set; } = default;

        /// <summary>
        /// A list of fields for this classification template. This includes
        /// only one field, the `Box__Security__Classification__Key`, which defines
        /// the different classifications available in this enterprise.
        /// </summary>
        [JsonPropertyName("fields")]
        public IReadOnlyList<ClassificationTemplateFieldsField> Fields { get; set; }

        public ClassificationTemplate(string id, ClassificationTemplateTypeField type, string scope, ClassificationTemplateTemplateKeyField templateKey, ClassificationTemplateDisplayNameField displayName, IReadOnlyList<ClassificationTemplateFieldsField> fields) {
            Id = id;
            Type = type;
            Scope = scope;
            TemplateKey = templateKey;
            DisplayName = displayName;
            Fields = fields;
        }
    }
}