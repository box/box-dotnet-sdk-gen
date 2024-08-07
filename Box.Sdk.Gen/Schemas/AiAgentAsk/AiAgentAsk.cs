using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class AiAgentAsk {
        /// <summary>
        /// The type of AI agent used to handle queries.
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<AiAgentAskTypeField>))]
        public StringEnum<AiAgentAskTypeField>? Type { get; init; }

        [JsonPropertyName("long_text")]
        public AiAgentLongTextTool? LongText { get; init; }

        [JsonPropertyName("basic_text")]
        public AiAgentBasicTextToolAsk? BasicText { get; init; }

        [JsonPropertyName("long_text_multi")]
        public AiAgentLongTextTool? LongTextMulti { get; init; }

        [JsonPropertyName("basic_text_multi")]
        public AiAgentBasicTextToolAsk? BasicTextMulti { get; init; }

        public AiAgentAsk() {
            
        }
    }
}