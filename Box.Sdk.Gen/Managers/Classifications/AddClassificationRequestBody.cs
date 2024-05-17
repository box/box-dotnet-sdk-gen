using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class AddClassificationRequestBody {
        /// <summary>
        /// The type of change to perform on the classification
        /// object.
        /// </summary>
        [JsonPropertyName("op")]
        public AddClassificationRequestBodyOpField Op { get; }

        /// <summary>
        /// Defines classifications 
        /// available in the enterprise.
        /// </summary>
        [JsonPropertyName("fieldKey")]
        public AddClassificationRequestBodyFieldKeyField FieldKey { get; }

        /// <summary>
        /// The details of the classification to add.
        /// </summary>
        [JsonPropertyName("data")]
        public AddClassificationRequestBodyDataField Data { get; }

        public AddClassificationRequestBody(AddClassificationRequestBodyDataField data, AddClassificationRequestBodyOpField op = AddClassificationRequestBodyOpField.AddEnumOption, AddClassificationRequestBodyFieldKeyField fieldKey = AddClassificationRequestBodyFieldKeyField.BoxSecurityClassificationKey) {
            Op = op;
            FieldKey = fieldKey;
            Data = data;
        }
    }
}