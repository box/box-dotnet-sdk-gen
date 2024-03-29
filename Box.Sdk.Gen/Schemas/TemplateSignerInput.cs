using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class TemplateSignerInput : SignRequestPrefillTag {
        /// <summary>
        /// Type of input
        /// </summary>
        [JsonPropertyName("type")]
        public TemplateSignerInputTypeField? Type { get; set; } = default;

        /// <summary>
        /// Content type of input
        /// </summary>
        [JsonPropertyName("content_type")]
        public TemplateSignerInputContentTypeField? ContentType { get; set; } = default;

        /// <summary>
        /// Whether or not the input is required.
        /// </summary>
        [JsonPropertyName("is_required")]
        public bool? IsRequired { get; set; } = default;

        /// <summary>
        /// Index of page that the input is on.
        /// </summary>
        [JsonPropertyName("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// Document identifier.
        /// </summary>
        [JsonPropertyName("document_id")]
        public string? DocumentId { get; set; } = default;

        /// <summary>
        /// When the input is of the type `dropdown` this values will be filled with all the dropdown options.
        /// </summary>
        [JsonPropertyName("dropdown_choices")]
        public IReadOnlyList<string>? DropdownChoices { get; set; } = default;

        /// <summary>
        /// When the input is of type `radio` they can be grouped to gather with this identifier.
        /// </summary>
        [JsonPropertyName("group_id")]
        public string? GroupId { get; set; } = default;

        /// <summary>
        /// Where the input is located on a page.
        /// </summary>
        [JsonPropertyName("coordinates")]
        public TemplateSignerInputCoordinatesField? Coordinates { get; set; } = default;

        /// <summary>
        /// The size of the input.
        /// </summary>
        [JsonPropertyName("dimensions")]
        public TemplateSignerInputDimensionsField? Dimensions { get; set; } = default;

        /// <summary>
        /// The label field is used especially for text, attachment, radio, and checkbox type inputs.
        /// </summary>
        [JsonPropertyName("label")]
        public string? Label { get; set; } = default;

        /// <summary>
        /// Whether this input was defined as read-only(immutable by signers) or not
        /// </summary>
        [JsonPropertyName("read_only")]
        public bool? ReadOnly { get; set; } = default;

        public TemplateSignerInput(long pageIndex) {
            PageIndex = pageIndex;
        }
    }
}