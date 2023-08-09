using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArgItem {
        [JsonPropertyName("op")]
        public string Op { get; }

        [JsonPropertyName("fieldKey")]
        public string FieldKey { get; }

        [JsonPropertyName("data")]
        public UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArgItemDataField Data { get; }

        public UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArgItem(string op, string fieldKey, UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArgItemDataField data) {
            Op = op;
            FieldKey = fieldKey;
            Data = data;
        }
    }
}