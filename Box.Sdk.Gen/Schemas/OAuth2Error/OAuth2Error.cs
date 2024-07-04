using Box.Sdk.Gen;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class OAuth2Error {
        /// <summary>
        /// The type of the error returned.
        /// </summary>
        [JsonPropertyName("error")]
        public string? Error { get; init; }

        /// <summary>
        /// The type of the error returned.
        /// </summary>
        [JsonPropertyName("error_description")]
        public string? ErrorDescription { get; init; }

        public OAuth2Error() {
            
        }
    }
}