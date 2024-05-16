using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class ClientErrorContextInfoField {
        /// <summary>
        /// More details on the error.
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; } = default;

        public ClientErrorContextInfoField() {
            
        }
    }
}