using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArgItemDataField {
        [JsonPropertyName("key")]
        public string Key { get; }

        [JsonPropertyName("classification")]
        public UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArgItemDataFieldClassificationField Classification { get; }

        public UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArgItemDataField(string key, UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArgItemDataFieldClassificationField classification) {
            Key = key;
            Classification = classification;
        }
    }
}