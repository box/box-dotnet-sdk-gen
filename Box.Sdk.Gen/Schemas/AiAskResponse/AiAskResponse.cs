using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class AiAskResponse {
        /// <summary>
        /// The answer provided by the LLM.
        /// </summary>
        [JsonPropertyName("answer")]
        public string Answer { get; }

        /// <summary>
        /// The ISO date formatted timestamp of when the answer to the prompt was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset CreatedAt { get; }

        /// <summary>
        /// The reason the response finishes.
        /// </summary>
        [JsonPropertyName("completion_reason")]
        public string? CompletionReason { get; init; }

        /// <summary>
        /// The citations of the LLM's answer reference.
        /// </summary>
        [JsonPropertyName("citations")]
        public IReadOnlyList<AiCitation>? Citations { get; init; }

        public AiAskResponse(string answer, System.DateTimeOffset createdAt) {
            Answer = answer;
            CreatedAt = createdAt;
        }
    }
}