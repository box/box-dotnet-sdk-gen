using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaUpdateRequestBodyArg {
        [JsonPropertyName("op")]
        public string Op { get; }

        [JsonPropertyName("fieldKey")]
        public string FieldKey { get; }

        [JsonPropertyName("enumOptionKey")]
        public string EnumOptionKey { get; }

        [JsonPropertyName("data")]
        public UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaUpdateRequestBodyArgDataField Data { get; }

        public UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaUpdateRequestBodyArg(string op, string fieldKey, string enumOptionKey, UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaUpdateRequestBodyArgDataField data) {
            Op = op;
            FieldKey = fieldKey;
            EnumOptionKey = enumOptionKey;
            Data = data;
        }
    }
}