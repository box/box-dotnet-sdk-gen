using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class CreateClassificationTemplateRequestBodyFieldsOptionsField {
        /// <summary>
        /// The display name and key this classification. This
        /// will be show in the Box UI.
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; }

        /// <summary>
        /// Additional information about the classification.
        /// </summary>
        [JsonPropertyName("staticConfig")]
        public CreateClassificationTemplateRequestBodyFieldsOptionsStaticConfigField? StaticConfig { get; init; }

        public CreateClassificationTemplateRequestBodyFieldsOptionsField(string key) {
            Key = key;
        }
    }
}