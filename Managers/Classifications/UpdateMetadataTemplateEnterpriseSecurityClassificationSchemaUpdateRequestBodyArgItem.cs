using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaUpdateRequestBodyArgItem {
        [JsonPropertyName("op")]
        public string Op { get; }

        [JsonPropertyName("fieldKey")]
        public string FieldKey { get; }

        [JsonPropertyName("enumOptionKey")]
        public string EnumOptionKey { get; }

        [JsonPropertyName("data")]
        public UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaUpdateRequestBodyArgItemDataField Data { get; }

        public UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaUpdateRequestBodyArgItem(string op, string fieldKey, string enumOptionKey, UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaUpdateRequestBodyArgItemDataField data) {
            Op = op;
            FieldKey = fieldKey;
            EnumOptionKey = enumOptionKey;
            Data = data;
        }
    }
}