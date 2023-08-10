using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArg {
        [JsonPropertyName("op")]
        public string Op { get; }

        [JsonPropertyName("fieldKey")]
        public string FieldKey { get; }

        [JsonPropertyName("data")]
        public UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArgDataField Data { get; }

        public UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArg(string op, string fieldKey, UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArgDataField data) {
            Op = op;
            FieldKey = fieldKey;
            Data = data;
        }
    }
}