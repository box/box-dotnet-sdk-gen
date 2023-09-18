using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SignRequestPrefillTag {
        /// <summary>
        /// This references the ID of a specific tag contained in a file of the sign request.
        /// </summary>
        [JsonPropertyName("document_tag_id")]
        public string? DocumentTagId { get; set; } = default;

        /// <summary>
        /// Text prefill value
        /// </summary>
        [JsonPropertyName("text_value")]
        public string? TextValue { get; set; } = default;

        /// <summary>
        /// Checkbox prefill value
        /// </summary>
        [JsonPropertyName("checkbox_value")]
        public bool? CheckboxValue { get; set; } = default;

        /// <summary>
        /// Date prefill value
        /// </summary>
        [JsonPropertyName("date_value")]
        public string? DateValue { get; set; } = default;

        public SignRequestPrefillTag() {
            
        }
    }
}