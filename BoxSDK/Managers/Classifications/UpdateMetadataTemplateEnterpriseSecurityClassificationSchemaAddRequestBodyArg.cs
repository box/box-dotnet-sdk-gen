using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArg {
        /// <summary>
        /// `addEnumOption`
        /// </summary>
        [JsonPropertyName("op")]
        public string Op { get; set; }

        /// <summary>
        /// `Box__Security__Classification__Key`
        /// </summary>
        [JsonPropertyName("fieldKey")]
        public string FieldKey { get; set; }

        /// <summary>
        /// The details of the classification to add.
        /// </summary>
        [JsonPropertyName("data")]
        public UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArgDataField Data { get; set; }

        public UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArg(string op, string fieldKey, UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArgDataField data) {
            Op = op;
            FieldKey = fieldKey;
            Data = data;
        }
    }
}