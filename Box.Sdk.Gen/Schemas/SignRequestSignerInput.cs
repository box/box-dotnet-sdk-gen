using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
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
        public long PageIndex { get; set; }

        /// <summary>
        /// Whether this input was defined as read-only(immutable by signers) or not
        /// </summary>
        [JsonPropertyName("read_only")]
        public bool? ReadOnly { get; set; } = default;

        public SignRequestSignerInput(long pageIndex) {
            PageIndex = pageIndex;
        }
    }
}