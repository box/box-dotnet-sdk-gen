using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Sdk.Gen.Schemas {
    public class AiAsk {
        /// <summary>
        /// The mode specifies if this request is for a single or multiple items.
        /// </summary>
        [JsonPropertyName("mode")]
        public AiAskModeField Mode { get; set; }

        /// <summary>
        /// The prompt provided by the client to be answered by the LLM.
        /// </summary>
        [JsonPropertyName("prompt")]
        public string Prompt { get; set; }

        /// <summary>
        /// The items to be processed by the LLM, often files.
        /// </summary>
        [JsonPropertyName("items")]
        public IReadOnlyList<AiAskItemsField> Items { get; set; }

        public AiAsk(AiAskModeField mode, string prompt, IReadOnlyList<AiAskItemsField> items) {
            Mode = mode;
            Prompt = prompt;
            Items = items;
        }
    }
}