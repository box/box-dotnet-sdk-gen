using Unions;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Sdk.Gen.Schemas {
    public class AiAsk {
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
        public IReadOnlyList<AiAskItemsField> Items { get; }

        public AiAsk(string prompt, IReadOnlyList<AiAskItemsField> items) {
            Prompt = prompt;
            Items = items;
        }
    }
}