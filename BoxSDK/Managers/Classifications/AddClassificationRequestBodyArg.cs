using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class AddClassificationRequestBodyArg {
        /// <summary>
        /// The type of change to perform on the classification
        /// object.
        /// </summary>
        [JsonPropertyName("op")]
        public AddClassificationRequestBodyArgOpField Op { get; set; }

        /// <summary>
        /// Defines classifications 
        /// available in the enterprise.
        /// </summary>
        [JsonPropertyName("fieldKey")]
        public AddClassificationRequestBodyArgFieldKeyField FieldKey { get; set; }

        /// <summary>
        /// The details of the classification to add.
        /// </summary>
        [JsonPropertyName("data")]
        public AddClassificationRequestBodyArgDataField Data { get; set; }

        public AddClassificationRequestBodyArg(AddClassificationRequestBodyArgOpField op, AddClassificationRequestBodyArgFieldKeyField fieldKey, AddClassificationRequestBodyArgDataField data) {
            Op = op;
            FieldKey = fieldKey;
            Data = data;
        }
    }
}