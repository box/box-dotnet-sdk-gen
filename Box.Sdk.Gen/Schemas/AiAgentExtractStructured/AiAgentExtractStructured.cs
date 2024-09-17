using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class AiAgentExtractStructured {
        /// <summary>
        /// The type of AI agent to be used for extraction.
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<AiAgentExtractStructuredTypeField>))]
        public StringEnum<AiAgentExtractStructuredTypeField> Type { get; }

        [JsonPropertyName("long_text")]
        public AiAgentLongTextTool? LongText { get; init; }

        [JsonPropertyName("basic_text")]
        public AiAgentBasicTextTool? BasicText { get; init; }

        public AiAgentExtractStructured(AiAgentExtractStructuredTypeField type = AiAgentExtractStructuredTypeField.AiAgentExtractStructured) {
            Type = type;
        }
        
        [JsonConstructorAttribute]
        internal AiAgentExtractStructured(StringEnum<AiAgentExtractStructuredTypeField> type) {
            Type = AiAgentExtractStructuredTypeField.AiAgentExtractStructured;
        }
    }
}