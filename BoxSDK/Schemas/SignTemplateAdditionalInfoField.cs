using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SignTemplateAdditionalInfoField {
        /// <summary>
        /// Non editable fields.
        /// </summary>
        [JsonPropertyName("non_editable")]
        public IReadOnlyList<SignTemplateAdditionalInfoFieldNonEditableField>? NonEditable { get; set; } = default;

        /// <summary>
        /// Required fields.
        /// </summary>
        [JsonPropertyName("required")]
        public SignTemplateAdditionalInfoFieldRequiredField? Required { get; set; } = default;

        public SignTemplateAdditionalInfoField() {
            
        }
    }
}