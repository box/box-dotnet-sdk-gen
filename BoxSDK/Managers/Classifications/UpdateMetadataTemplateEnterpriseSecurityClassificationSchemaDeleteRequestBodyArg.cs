using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaDeleteRequestBodyArg {
        /// <summary>
        /// `removeEnumOption`
        /// </summary>
        [JsonPropertyName("op")]
        public string Op { get; set; }

        /// <summary>
        /// `Box__Security__Classification__Key`
        /// </summary>
        [JsonPropertyName("fieldKey")]
        public string FieldKey { get; set; }

        /// <summary>
        /// The label of the classification to remove.
        /// </summary>
        [JsonPropertyName("enumOptionKey")]
        public string EnumOptionKey { get; set; }

        public UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaDeleteRequestBodyArg(string op, string fieldKey, string enumOptionKey) {
            Op = op;
            FieldKey = fieldKey;
            EnumOptionKey = enumOptionKey;
        }
    }
}