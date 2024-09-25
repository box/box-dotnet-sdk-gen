using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class AiAsk : ISerializable {
        /// <summary>
        /// The mode specifies if this request is for a single or multiple items. If you select `single_item_qa` the `items` array can have one element only. Selecting `multiple_item_qa` allows you to provide up to 25 items.
        /// </summary>
        [JsonPropertyName("mode")]
        [JsonConverter(typeof(StringEnumConverter<AiAskModeField>))]
        public StringEnum<AiAskModeField> Mode { get; }

        /// <summary>
        /// The prompt provided by the client to be answered by the LLM. The prompt's length is limited to 10000 characters.
        /// </summary>
        [JsonPropertyName("prompt")]
        public string Prompt { get; }

        /// <summary>
        /// The items to be processed by the LLM, often files.
        /// 
        /// **Note**: Box AI handles documents with text representations up to 1MB in size, or a maximum of 25 files, whichever comes first.
        /// If the file size exceeds 1MB, the first 1MB of text representation will be processed.
        /// If you set `mode` parameter to `single_item_qa`, the `items` array can have one element only. 
        /// </summary>
        [JsonPropertyName("items")]
        public IReadOnlyList<AiItemBase> Items { get; }

        /// <summary>
        /// The history of prompts and answers previously passed to the LLM. This provides additional context to the LLM in generating the response.
        /// </summary>
        [JsonPropertyName("dialogue_history")]
        public IReadOnlyList<AiDialogueHistory>? DialogueHistory { get; init; }

        /// <summary>
        /// A flag to indicate whether citations should be returned.
        /// </summary>
        [JsonPropertyName("include_citations")]
        public bool? IncludeCitations { get; init; }

        [JsonPropertyName("ai_agent")]
        public AiAgentAsk? AiAgent { get; init; }

        public AiAsk(AiAskModeField mode, string prompt, IReadOnlyList<AiItemBase> items) {
            Mode = mode;
            Prompt = prompt;
            Items = items;
        }
        
        [JsonConstructorAttribute]
        internal AiAsk(StringEnum<AiAskModeField> mode, string prompt, IReadOnlyList<AiItemBase> items) {
            Mode = mode;
            Prompt = prompt;
            Items = items;
        }
        internal string? RawJson { get; set; } = default;

        void ISerializable.SetJson(string json) {
            RawJson = json;
        }

        string? ISerializable.GetJson() {
            return RawJson;
        }

        /// <summary>
        /// Returns raw json response returned from the API.
        /// </summary>
        public Dictionary<string, object?>? GetRawData() {
            return SimpleJsonSerializer.GetAllFields(this);
        }

    }
}