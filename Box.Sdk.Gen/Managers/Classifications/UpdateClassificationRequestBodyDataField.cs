using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using System;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class UpdateClassificationRequestBodyDataField {
        /// <summary>
        /// A new label for the classification, as it will be
        /// shown in the web and mobile interfaces.
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; }

        /// <summary>
        /// A static configuration for the classification.
        /// </summary>
        [JsonPropertyName("staticConfig")]
        public UpdateClassificationRequestBodyDataStaticConfigField? StaticConfig { get; init; }

        public UpdateClassificationRequestBodyDataField(string key) {
            Key = key;
        }
    }
}