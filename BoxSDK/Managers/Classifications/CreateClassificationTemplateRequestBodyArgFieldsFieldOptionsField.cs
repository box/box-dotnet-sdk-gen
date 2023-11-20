using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateClassificationTemplateRequestBodyArgFieldsFieldOptionsField {
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
        public CreateClassificationTemplateRequestBodyArgFieldsFieldOptionsFieldStaticConfigField? StaticConfig { get; set; } = default;

        public CreateClassificationTemplateRequestBodyArgFieldsFieldOptionsField(string key) {
            Key = key;
        }
    }
}