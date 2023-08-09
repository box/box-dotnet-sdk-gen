using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaDeleteRequestBodyArgItem {
        [JsonPropertyName("op")]
        public string Op { get; }

        [JsonPropertyName("fieldKey")]
        public string FieldKey { get; }

        [JsonPropertyName("enumOptionKey")]
        public string EnumOptionKey { get; }

        public UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaDeleteRequestBodyArgItem(string op, string fieldKey, string enumOptionKey) {
            Op = op;
            FieldKey = fieldKey;
            EnumOptionKey = enumOptionKey;
        }
    }
}