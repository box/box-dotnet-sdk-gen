using Box.Sdk.Gen;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class SessionTerminationMessage {
        /// <summary>
        /// The unique identifier for the termination job status
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; init; }

        public SessionTerminationMessage() {
            
        }
    }
}