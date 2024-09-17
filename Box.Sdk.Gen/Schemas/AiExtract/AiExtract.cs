using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class AiExtract {
        /// <summary>
        /// The prompt provided to a Large Language Model (LLM) in the request. The prompt can be up to 10000 characters long and it can be an XML or a JSON schema.
        /// </summary>
        [JsonPropertyName("prompt")]
        public string Prompt { get; }

        /// <summary>
        /// The items that LLM will process. Currently, you can use files only.
        /// </summary>
        [JsonPropertyName("items")]
        public IReadOnlyList<AiItemBase> Items { get; }

        [JsonPropertyName("ai_agent")]
        public AiAgentExtract? AiAgent { get; init; }

        public AiExtract(string prompt, IReadOnlyList<AiItemBase> items) {
            Prompt = prompt;
            Items = items;
        }
    }
}