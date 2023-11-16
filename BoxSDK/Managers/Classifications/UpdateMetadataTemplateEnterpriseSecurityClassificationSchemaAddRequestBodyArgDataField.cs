using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArgDataField {
        /// <summary>
        /// The label of the classification as shown in the web and
        /// mobile interfaces. This is the only field required to
        /// add a classification.
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// A static configuration for the classification.
        /// </summary>
        [JsonPropertyName("staticConfig")]
        public UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArgDataFieldStaticConfigField? StaticConfig { get; set; } = default;

        public UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArgDataField(string key) {
            Key = key;
        }
    }
}