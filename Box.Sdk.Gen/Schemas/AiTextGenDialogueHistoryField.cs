using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Sdk.Gen.Schemas {
    public class AiTextGenDialogueHistoryField {
        /// <summary>
        /// The prompt previously provided by the client and answered by the LLM.
        /// </summary>
        [JsonPropertyName("prompt")]
        public string? Prompt { get; set; } = default;

        /// <summary>
        /// The answer previously provided by the LLM.
        /// </summary>
        [JsonPropertyName("answer")]
        public string? Answer { get; set; } = default;

        /// <summary>
        /// The ISO date formatted timestamp of when the previous answer to the prompt was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; set; } = default;

        public AiTextGenDialogueHistoryField() {
            
        }
    }
}