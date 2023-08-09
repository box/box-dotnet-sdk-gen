using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SignRequestPrefillTag {
        [JsonPropertyName("document_tag_id")]
        public string DocumentTagId { get; }

        [JsonPropertyName("text_value")]
        public string TextValue { get; }

        [JsonPropertyName("checkbox_value")]
        public bool? CheckboxValue { get; }

        [JsonPropertyName("date_value")]
        public string DateValue { get; }

        public SignRequestPrefillTag(string documentTagId, string textValue, bool? checkboxValue, string dateValue) {
            DocumentTagId = documentTagId;
            TextValue = textValue;
            CheckboxValue = checkboxValue;
            DateValue = dateValue;
        }
    }
}