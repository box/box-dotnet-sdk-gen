using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class AiTextGenDialogueHistoryField {
        /// <summary>
        /// The prompt previously provided by the client and answered by the LLM.
        /// </summary>
        [JsonPropertyName("prompt")]
        public string? Prompt { get; init; }

        /// <summary>
        /// The answer previously provided by the LLM.
        /// </summary>
        [JsonPropertyName("answer")]
        public string? Answer { get; init; }

        /// <summary>
        /// The ISO date formatted timestamp of when the previous answer to the prompt was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; init; }

        public AiTextGenDialogueHistoryField() {
            
        }
    }
}