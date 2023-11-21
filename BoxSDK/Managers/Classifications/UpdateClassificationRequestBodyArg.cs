using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateClassificationRequestBodyArg {
        /// <summary>
        /// The type of change to perform on the classification
        /// object.
        /// </summary>
        [JsonPropertyName("op")]
        public UpdateClassificationRequestBodyArgOpField Op { get; set; }

        /// <summary>
        /// Defines classifications 
        /// available in the enterprise.
        /// </summary>
        [JsonPropertyName("fieldKey")]
        public UpdateClassificationRequestBodyArgFieldKeyField FieldKey { get; set; }

        /// <summary>
        /// The original label of the classification to change.
        /// </summary>
        [JsonPropertyName("enumOptionKey")]
        public string EnumOptionKey { get; set; }

        /// <summary>
        /// The details of the updated classification.
        /// </summary>
        [JsonPropertyName("data")]
        public UpdateClassificationRequestBodyArgDataField Data { get; set; }

        public UpdateClassificationRequestBodyArg(UpdateClassificationRequestBodyArgOpField op, UpdateClassificationRequestBodyArgFieldKeyField fieldKey, string enumOptionKey, UpdateClassificationRequestBodyArgDataField data) {
            Op = op;
            FieldKey = fieldKey;
            EnumOptionKey = enumOptionKey;
            Data = data;
        }
    }
}