using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class UpdateClassificationOnFileRequestBody {
        /// <summary>
        /// `replace`
        /// </summary>
        [JsonPropertyName("op")]
        public UpdateClassificationOnFileRequestBodyOpField Op { get; }

        /// <summary>
        /// Defines classifications 
        /// available in the enterprise.
        /// </summary>
        [JsonPropertyName("path")]
        public UpdateClassificationOnFileRequestBodyPathField Path { get; }

        /// <summary>
        /// The name of the classification to apply to this file.
        /// 
        /// To list the available classifications in an enterprise,
        /// use the classification API to retrieve the
        /// [classification template](e://get_metadata_templates_enterprise_securityClassification-6VMVochwUWo_schema)
        /// which lists all available classification keys.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; }

        public UpdateClassificationOnFileRequestBody(string value, UpdateClassificationOnFileRequestBodyOpField op = UpdateClassificationOnFileRequestBodyOpField.Replace, UpdateClassificationOnFileRequestBodyPathField path = UpdateClassificationOnFileRequestBodyPathField.BoxSecurityClassificationKey) {
            Op = op;
            Path = path;
            Value = value;
        }
    }
}