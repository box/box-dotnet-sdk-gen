using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class TemplateSignerInput : SignRequestPrefillTag {
        /// <summary>
        /// Type of input
        /// </summary>
        [JsonPropertyName("type")]
        public TemplateSignerInputTypeField? Type { get; init; }

        /// <summary>
        /// Content type of input
        /// </summary>
        [JsonPropertyName("content_type")]
        public TemplateSignerInputContentTypeField? ContentType { get; init; }

        /// <summary>
        /// Whether or not the input is required.
        /// </summary>
        [JsonPropertyName("is_required")]
        public bool? IsRequired { get; init; }

        /// <summary>
        /// Index of page that the input is on.
        /// </summary>
        [JsonPropertyName("page_index")]
        public long PageIndex { get; }

        /// <summary>
        /// Document identifier.
        /// </summary>
        [JsonPropertyName("document_id")]
        public string? DocumentId { get; init; }

        /// <summary>
        /// When the input is of the type `dropdown` this values will be filled with all the dropdown options.
        /// </summary>
        [JsonPropertyName("dropdown_choices")]
        public IReadOnlyList<string>? DropdownChoices { get; init; }

        /// <summary>
        /// When the input is of type `radio` they can be grouped to gather with this identifier.
        /// </summary>
        [JsonPropertyName("group_id")]
        public string? GroupId { get; init; }

        /// <summary>
        /// Where the input is located on a page.
        /// </summary>
        [JsonPropertyName("coordinates")]
        public TemplateSignerInputCoordinatesField? Coordinates { get; init; }

        /// <summary>
        /// The size of the input.
        /// </summary>
        [JsonPropertyName("dimensions")]
        public TemplateSignerInputDimensionsField? Dimensions { get; init; }

        /// <summary>
        /// The label field is used especially for text, attachment, radio, and checkbox type inputs.
        /// </summary>
        [JsonPropertyName("label")]
        public string? Label { get; init; }

        /// <summary>
        /// Whether this input was defined as read-only(immutable by signers) or not
        /// </summary>
        [JsonPropertyName("read_only")]
        public bool? ReadOnly { get; init; }

        public TemplateSignerInput(long pageIndex) {
            PageIndex = pageIndex;
        }
    }
}