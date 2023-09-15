using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SignRequestSignerInput : SignRequestPrefillTag {
        /// <summary>
        /// Type of input
        /// </summary>
        [JsonPropertyName("type")]
        public SignRequestSignerInputTypeField? Type { get; set; } = default;

        /// <summary>
        /// Content type of input
        /// </summary>
        [JsonPropertyName("content_type")]
        public SignRequestSignerInputContentTypeField? ContentType { get; set; } = default;

        /// <summary>
        /// Index of page that the input is on
        /// </summary>
        [JsonPropertyName("page_index")]
        public int PageIndex { get; set; }

        public SignRequestSignerInput(int pageIndex) {
            PageIndex = pageIndex;
        }
    }
}