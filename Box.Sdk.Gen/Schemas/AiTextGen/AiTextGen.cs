using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Sdk.Gen.Schemas {
    public class AiTextGen {
        /// <summary>
        /// The prompt provided by the client to be answered by the LLM. The prompt's length is limited to 10000 characters.
        /// </summary>
        [JsonPropertyName("prompt")]
        public string Prompt { get; }

        /// <summary>
        /// The items to be processed by the LLM, often files.
        /// The array can include **exactly one** element.
        /// 
        /// **Note**: Box AI handles documents with text representations up to 1MB in size.
        /// If the file size exceeds 1MB, the first 1MB of text representation will be processed.
        /// </summary>
        [JsonPropertyName("items")]
        public IReadOnlyList<AiTextGenItemsField> Items { get; }

        /// <summary>
        /// The history of prompts and answers previously passed to the LLM. This provides additional context to the LLM in generating the response.
        /// </summary>
        [JsonPropertyName("dialogue_history")]
        public IReadOnlyList<AiTextGenDialogueHistoryField>? DialogueHistory { get; init; }

        public AiTextGen(string prompt, IReadOnlyList<AiTextGenItemsField> items) {
            Prompt = prompt;
            Items = items;
        }
    }
}