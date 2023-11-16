using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaUpdateRequestBodyArgDataFieldStaticConfigField {
        /// <summary>
        /// Additional details for the classification.
        /// </summary>
        [JsonPropertyName("classification")]
        public UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaUpdateRequestBodyArgDataFieldStaticConfigFieldClassificationField? Classification { get; set; } = default;

        public UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaUpdateRequestBodyArgDataFieldStaticConfigField() {
            
        }
    }
}