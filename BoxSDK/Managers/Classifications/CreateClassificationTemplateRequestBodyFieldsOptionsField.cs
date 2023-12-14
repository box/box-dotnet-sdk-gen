using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateClassificationTemplateRequestBodyFieldsOptionsField {
        /// <summary>
        /// The display name and key this classification. This
        /// will be show in the Box UI.
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// Additional information about the classification.
        /// </summary>
        [JsonPropertyName("staticConfig")]
        public CreateClassificationTemplateRequestBodyFieldsOptionsStaticConfigField? StaticConfig { get; set; } = default;

        public CreateClassificationTemplateRequestBodyFieldsOptionsField(string key) {
            Key = key;
        }
    }
}