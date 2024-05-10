using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class ClientError {
        /// <summary>
        /// error
        /// </summary>
        [JsonPropertyName("type")]
        public ClientErrorTypeField? Type { get; set; } = default;

        /// <summary>
        /// The HTTP status of the response.
        /// </summary>
        [JsonPropertyName("status")]
        public int? Status { get; set; } = default;

        /// <summary>
        /// A Box-specific error code
        /// </summary>
        [JsonPropertyName("code")]
        public ClientErrorCodeField? Code { get; set; } = default;

        /// <summary>
        /// A short message describing the error.
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; } = default;

        /// <summary>
        /// A free-form object that contains additional context
        /// about the error. The possible fields are defined on
        /// a per-endpoint basis. `message` is only one example.
        /// </summary>
        [JsonPropertyName("context_info")]
        public ClientErrorContextInfoField? ContextInfo { get; set; } = default;

        /// <summary>
        /// A URL that links to more information about why this error occurred.
        /// </summary>
        [JsonPropertyName("help_url")]
        public string? HelpUrl { get; set; } = default;

        /// <summary>
        /// A unique identifier for this response, which can be used
        /// when contacting Box support.
        /// </summary>
        [JsonPropertyName("request_id")]
        public string? RequestId { get; set; } = default;

        public ClientError() {
            
        }
    }
}