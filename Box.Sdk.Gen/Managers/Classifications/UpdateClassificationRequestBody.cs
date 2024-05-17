using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class UpdateClassificationRequestBody {
        /// <summary>
        /// The type of change to perform on the classification
        /// object.
        /// </summary>
        [JsonPropertyName("op")]
        public UpdateClassificationRequestBodyOpField Op { get; }

        /// <summary>
        /// Defines classifications 
        /// available in the enterprise.
        /// </summary>
        [JsonPropertyName("fieldKey")]
        public UpdateClassificationRequestBodyFieldKeyField FieldKey { get; }

        /// <summary>
        /// The original label of the classification to change.
        /// </summary>
        [JsonPropertyName("enumOptionKey")]
        public string EnumOptionKey { get; }

        /// <summary>
        /// The details of the updated classification.
        /// </summary>
        [JsonPropertyName("data")]
        public UpdateClassificationRequestBodyDataField Data { get; }

        public UpdateClassificationRequestBody(string enumOptionKey, UpdateClassificationRequestBodyDataField data, UpdateClassificationRequestBodyOpField op = UpdateClassificationRequestBodyOpField.EditEnumOption, UpdateClassificationRequestBodyFieldKeyField fieldKey = UpdateClassificationRequestBodyFieldKeyField.BoxSecurityClassificationKey) {
            Op = op;
            FieldKey = fieldKey;
            EnumOptionKey = enumOptionKey;
            Data = data;
        }
    }
}