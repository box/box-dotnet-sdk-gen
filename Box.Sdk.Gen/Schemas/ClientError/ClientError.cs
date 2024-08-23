using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    public class ClientError {
        [JsonInclude]
        [JsonPropertyName("_iscontext_infoSet")]
        protected bool _isContextInfoSet { get; set; }

        protected ClientErrorContextInfoField? _contextInfo { get; set; }

        /// <summary>
        /// error
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<ClientErrorTypeField>))]
        public StringEnum<ClientErrorTypeField>? Type { get; init; }

        /// <summary>
        /// The HTTP status of the response.
        /// </summary>
        [JsonPropertyName("status")]
        public int? Status { get; init; }

        /// <summary>
        /// A Box-specific error code
        /// </summary>
        [JsonPropertyName("code")]
        [JsonConverter(typeof(StringEnumConverter<ClientErrorCodeField>))]
        public StringEnum<ClientErrorCodeField>? Code { get; init; }

        /// <summary>
        /// A short message describing the error.
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; init; }

        /// <summary>
        /// A free-form object that contains additional context
        /// about the error. The possible fields are defined on
        /// a per-endpoint basis. `message` is only one example.
        /// </summary>
        [JsonPropertyName("context_info")]
        public ClientErrorContextInfoField? ContextInfo { get => _contextInfo; init { _contextInfo = value; _isContextInfoSet = true; } }

        /// <summary>
        /// A URL that links to more information about why this error occurred.
        /// </summary>
        [JsonPropertyName("help_url")]
        public string? HelpUrl { get; init; }

        /// <summary>
        /// A unique identifier for this response, which can be used
        /// when contacting Box support.
        /// </summary>
        [JsonPropertyName("request_id")]
        public string? RequestId { get; init; }

        public ClientError() {
            
        }
    }
}