using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFileMetadataEnterpriseSecurityClassificationRequestBodyArg {
        /// <summary>
        /// `replace`
        /// </summary>
        [JsonPropertyName("op")]
        public UpdateFileMetadataEnterpriseSecurityClassificationRequestBodyArgOpField? Op { get; set; } = default;

        /// <summary>
        /// Defines classifications 
        /// available in the enterprise.
        /// </summary>
        [JsonPropertyName("path")]
        public UpdateFileMetadataEnterpriseSecurityClassificationRequestBodyArgPathField? Path { get; set; } = default;

        /// <summary>
        /// The name of the classification to apply to this file.
        /// 
        /// To list the available classifications in an enterprise,
        /// use the classification API to retrieve the
        /// [classification template](e://get_metadata_templates_enterprise_securityClassification-6VMVochwUWo_schema)
        /// which lists all available classification keys.
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get; set; } = default;

        public UpdateFileMetadataEnterpriseSecurityClassificationRequestBodyArg() {
            
        }
    }
}