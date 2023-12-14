using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateClassificationRequestBody {
        /// <summary>
        /// The type of change to perform on the classification
        /// object.
        /// </summary>
        [JsonPropertyName("op")]
        public UpdateClassificationRequestBodyOpField Op { get; set; }

        /// <summary>
        /// Defines classifications 
        /// available in the enterprise.
        /// </summary>
        [JsonPropertyName("fieldKey")]
        public UpdateClassificationRequestBodyFieldKeyField FieldKey { get; set; }

        /// <summary>
        /// The original label of the classification to change.
        /// </summary>
        [JsonPropertyName("enumOptionKey")]
        public string EnumOptionKey { get; set; }

        /// <summary>
        /// The details of the updated classification.
        /// </summary>
        [JsonPropertyName("data")]
        public UpdateClassificationRequestBodyDataField Data { get; set; }

        public UpdateClassificationRequestBody(UpdateClassificationRequestBodyOpField op, UpdateClassificationRequestBodyFieldKeyField fieldKey, string enumOptionKey, UpdateClassificationRequestBodyDataField data) {
            Op = op;
            FieldKey = fieldKey;
            EnumOptionKey = enumOptionKey;
            Data = data;
        }
    }
}