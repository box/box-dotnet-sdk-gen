using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArgDataField {
        [JsonPropertyName("key")]
        public string Key { get; }

        [JsonPropertyName("classification")]
        public UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArgDataFieldClassificationField Classification { get; }

        public UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArgDataField(string key, UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArgDataFieldClassificationField classification) {
            Key = key;
            Classification = classification;
        }
    }
}