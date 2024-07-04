using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class SignRequestSignerInput : SignRequestPrefillTag {
        /// <summary>
        /// Type of input
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<SignRequestSignerInputTypeField>))]
        public StringEnum<SignRequestSignerInputTypeField>? Type { get; init; }

        /// <summary>
        /// Content type of input
        /// </summary>
        [JsonPropertyName("content_type")]
        [JsonConverter(typeof(StringEnumConverter<SignRequestSignerInputContentTypeField>))]
        public StringEnum<SignRequestSignerInputContentTypeField>? ContentType { get; init; }

        /// <summary>
        /// Index of page that the input is on
        /// </summary>
        [JsonPropertyName("page_index")]
        public long PageIndex { get; }

        /// <summary>
        /// Whether this input was defined as read-only(immutable by signers) or not
        /// </summary>
        [JsonPropertyName("read_only")]
        public bool? ReadOnly { get; init; }

        public SignRequestSignerInput(long pageIndex) {
            PageIndex = pageIndex;
        }
    }
}