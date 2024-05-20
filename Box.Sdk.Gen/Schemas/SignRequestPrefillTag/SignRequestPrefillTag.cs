using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class SignRequestPrefillTag {
        /// <summary>
        /// This references the ID of a specific tag contained in a file of the signature request.
        /// </summary>
        [JsonPropertyName("document_tag_id")]
        public string? DocumentTagId { get; init; }

        /// <summary>
        /// Text prefill value
        /// </summary>
        [JsonPropertyName("text_value")]
        public string? TextValue { get; init; }

        /// <summary>
        /// Checkbox prefill value
        /// </summary>
        [JsonPropertyName("checkbox_value")]
        public bool? CheckboxValue { get; init; }

        /// <summary>
        /// Date prefill value
        /// </summary>
        [JsonPropertyName("date_value")]
        public System.DateOnly? DateValue { get; init; }

        public SignRequestPrefillTag() {
            
        }
    }
}