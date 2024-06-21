using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;
using System.Linq;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class SignTemplateAdditionalInfoField {
        /// <summary>
        /// Non editable fields.
        /// </summary>
        [JsonPropertyName("non_editable")]
        [JsonConverter(typeof(StringEnumListConverter<SignTemplateAdditionalInfoNonEditableField>))]
        public IReadOnlyList<StringEnum<SignTemplateAdditionalInfoNonEditableField>> NonEditable { get; init; }

        /// <summary>
        /// Required fields.
        /// </summary>
        [JsonPropertyName("required")]
        public SignTemplateAdditionalInfoRequiredField? Required { get; init; }

        public SignTemplateAdditionalInfoField() {
            
        }
    }
}