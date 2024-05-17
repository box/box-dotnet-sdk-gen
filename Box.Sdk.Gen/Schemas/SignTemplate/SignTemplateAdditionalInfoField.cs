using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class SignTemplateAdditionalInfoField {
        /// <summary>
        /// Non editable fields.
        /// </summary>
        [JsonPropertyName("non_editable")]
        public IReadOnlyList<SignTemplateAdditionalInfoNonEditableField>? NonEditable { get; init; }

        /// <summary>
        /// Required fields.
        /// </summary>
        [JsonPropertyName("required")]
        public SignTemplateAdditionalInfoRequiredField? Required { get; init; }

        public SignTemplateAdditionalInfoField() {
            
        }
    }
}