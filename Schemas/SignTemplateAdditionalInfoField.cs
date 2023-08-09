using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SignTemplateAdditionalInfoField {
        [JsonPropertyName("non_editable")]
        public IReadOnlyList<SignTemplateAdditionalInfoFieldNonEditableField> NonEditable { get; }

        [JsonPropertyName("required")]
        public SignTemplateAdditionalInfoFieldRequiredField Required { get; }

        public SignTemplateAdditionalInfoField(IReadOnlyList<SignTemplateAdditionalInfoFieldNonEditableField> nonEditable, SignTemplateAdditionalInfoFieldRequiredField required) {
            NonEditable = nonEditable;
            Required = required;
        }
    }
}