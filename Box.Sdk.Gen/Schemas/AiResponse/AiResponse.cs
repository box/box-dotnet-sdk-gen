using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class AiResponse {
        /// <summary>
        /// The answer provided by the LLM.
        /// </summary>
        [JsonPropertyName("answer")]
        public string Answer { get; set; }

        /// <summary>
        /// The ISO date formatted timestamp of when the answer to the prompt was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The reason the response finishes.
        /// </summary>
        [JsonPropertyName("completion_reason")]
        public string? CompletionReason { get; set; } = default;

        public AiResponse(string answer, System.DateTimeOffset createdAt) {
            Answer = answer;
            CreatedAt = createdAt;
        }
    }
}