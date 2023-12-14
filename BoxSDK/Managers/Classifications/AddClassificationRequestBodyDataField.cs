using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class AddClassificationRequestBodyDataField {
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
        public AddClassificationRequestBodyDataStaticConfigField? StaticConfig { get; set; } = default;

        public AddClassificationRequestBodyDataField(string key) {
            Key = key;
        }
    }
}