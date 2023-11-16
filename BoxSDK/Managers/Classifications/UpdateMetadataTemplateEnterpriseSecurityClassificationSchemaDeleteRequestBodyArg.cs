using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaDeleteRequestBodyArg {
        /// <summary>
        /// The type of change to perform on the classification
        /// object.
        /// </summary>
        [JsonPropertyName("op")]
        public UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaDeleteRequestBodyArgOpField Op { get; set; }

        /// <summary>
        /// Defines classifications 
        /// available in the enterprise.
        /// </summary>
        [JsonPropertyName("fieldKey")]
        public UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaDeleteRequestBodyArgFieldKeyField FieldKey { get; set; }

        /// <summary>
        /// The label of the classification to remove.
        /// </summary>
        [JsonPropertyName("enumOptionKey")]
        public string EnumOptionKey { get; set; }

        public UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaDeleteRequestBodyArg(UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaDeleteRequestBodyArgOpField op, UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaDeleteRequestBodyArgFieldKeyField fieldKey, string enumOptionKey) {
            Op = op;
            FieldKey = fieldKey;
            EnumOptionKey = enumOptionKey;
        }
    }
}