using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArg {
        /// <summary>
        /// The type of change to perform on the classification
        /// object.
        /// </summary>
        [JsonPropertyName("op")]
        public UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArgOpField Op { get; set; }

        /// <summary>
        /// Defines classifications 
        /// available in the enterprise.
        /// </summary>
        [JsonPropertyName("fieldKey")]
        public UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArgFieldKeyField FieldKey { get; set; }

        /// <summary>
        /// The details of the classification to add.
        /// </summary>
        [JsonPropertyName("data")]
        public UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArgDataField Data { get; set; }

        public UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArg(UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArgOpField op, UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArgFieldKeyField fieldKey, UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArgDataField data) {
            Op = op;
            FieldKey = fieldKey;
            Data = data;
        }
    }
}