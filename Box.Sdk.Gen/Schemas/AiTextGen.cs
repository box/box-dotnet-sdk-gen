using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Sdk.Gen.Schemas {
    public class AiTextGen {
        /// <summary>
        /// The prompt provided by the client to be answered by the LLM.
        /// </summary>
        [JsonPropertyName("prompt")]
        public string Prompt { get; set; }

        /// <summary>
        /// The items to be processed by the LLM, often files.
        /// </summary>
        [JsonPropertyName("items")]
        public IReadOnlyList<AiTextGenItemsField> Items { get; set; }

        /// <summary>
        /// The history of prompts and answers previously passed to the LLM. This provides additional context to the LLM in generating the response.
        /// </summary>
        [JsonPropertyName("dialogue_history")]
        public IReadOnlyList<AiTextGenDialogueHistoryField>? DialogueHistory { get; set; } = default;

        public AiTextGen(string prompt, IReadOnlyList<AiTextGenItemsField> items) {
            Prompt = prompt;
            Items = items;
        }
    }
}