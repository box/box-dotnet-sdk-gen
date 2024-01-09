using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class AddClassificationRequestBody {
        /// <summary>
        /// The type of change to perform on the classification
        /// object.
        /// </summary>
        [JsonPropertyName("op")]
        public AddClassificationRequestBodyOpField Op { get; set; }

        /// <summary>
        /// Defines classifications 
        /// available in the enterprise.
        /// </summary>
        [JsonPropertyName("fieldKey")]
        public AddClassificationRequestBodyFieldKeyField FieldKey { get; set; }

        /// <summary>
        /// The details of the classification to add.
        /// </summary>
        [JsonPropertyName("data")]
        public AddClassificationRequestBodyDataField Data { get; set; }

        public AddClassificationRequestBody(AddClassificationRequestBodyOpField op, AddClassificationRequestBodyFieldKeyField fieldKey, AddClassificationRequestBodyDataField data) {
            Op = op;
            FieldKey = fieldKey;
            Data = data;
        }
    }
}