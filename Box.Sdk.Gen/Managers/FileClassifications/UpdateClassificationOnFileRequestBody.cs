using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using System;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class UpdateClassificationOnFileRequestBody {
        /// <summary>
        /// `replace`
        /// </summary>
        [JsonPropertyName("op")]
        [JsonConverter(typeof(StringEnumConverter<UpdateClassificationOnFileRequestBodyOpField>))]
        public StringEnum<UpdateClassificationOnFileRequestBodyOpField> Op { get; }

        /// <summary>
        /// Defines classifications 
        /// available in the enterprise.
        /// </summary>
        [JsonPropertyName("path")]
        [JsonConverter(typeof(StringEnumConverter<UpdateClassificationOnFileRequestBodyPathField>))]
        public StringEnum<UpdateClassificationOnFileRequestBodyPathField> Path { get; }

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
        
        [JsonConstructorAttribute]
        internal UpdateClassificationOnFileRequestBody(string value, StringEnum<UpdateClassificationOnFileRequestBodyOpField> op, StringEnum<UpdateClassificationOnFileRequestBodyPathField> path) {
            Op = UpdateClassificationOnFileRequestBodyOpField.Replace;
            Path = UpdateClassificationOnFileRequestBodyPathField.BoxSecurityClassificationKey;
            Value = value;
        }
    }
}