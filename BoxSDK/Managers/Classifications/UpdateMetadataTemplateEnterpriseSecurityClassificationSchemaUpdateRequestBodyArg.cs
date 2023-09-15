using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaUpdateRequestBodyArg {
        /// <summary>
        /// `editEnumOption`
        /// </summary>
        [JsonPropertyName("op")]
        public string Op { get; set; }

        /// <summary>
        /// `Box__Security__Classification__Key`
        /// </summary>
        [JsonPropertyName("fieldKey")]
        public string FieldKey { get; set; }

        /// <summary>
        /// The original label of the classification to change.
        /// </summary>
        [JsonPropertyName("enumOptionKey")]
        public string EnumOptionKey { get; set; }

        /// <summary>
        /// The details of the updated classification.
        /// </summary>
        [JsonPropertyName("data")]
        public UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaUpdateRequestBodyArgDataField Data { get; set; }

        public UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaUpdateRequestBodyArg(string op, string fieldKey, string enumOptionKey, UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaUpdateRequestBodyArgDataField data) {
            Op = op;
            FieldKey = fieldKey;
            EnumOptionKey = enumOptionKey;
            Data = data;
        }
    }
}