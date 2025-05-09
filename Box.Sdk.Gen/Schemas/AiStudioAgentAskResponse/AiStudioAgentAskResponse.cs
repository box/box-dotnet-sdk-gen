using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class AiStudioAgentAskResponse : ISerializable {
        [JsonInclude]
        [JsonPropertyName("_iscustom_instructionsSet")]
        protected bool _isCustomInstructionsSet { get; set; }

        protected string? _customInstructions { get; set; }

        /// <summary>
        /// The type of AI agent used to handle queries.
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<AiStudioAgentAskResponseTypeField>))]
        public StringEnum<AiStudioAgentAskResponseTypeField> Type { get; }

        /// <summary>
        /// The state of the AI Agent capability. Possible values are: `enabled` and `disabled`.
        /// </summary>
        [JsonPropertyName("access_state")]
        public string AccessState { get; }

        /// <summary>
        /// The description of the AI Agent.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; }

        /// <summary>
        /// Custom instructions for the agent.
        /// </summary>
        [JsonPropertyName("custom_instructions")]
        public string? CustomInstructions { get => _customInstructions; init { _customInstructions = value; _isCustomInstructionsSet = true; } }

        [JsonPropertyName("long_text")]
        public AiStudioAgentLongTextToolResponse? LongText { get; init; }

        [JsonPropertyName("basic_text")]
        public AiStudioAgentBasicTextToolResponse? BasicText { get; init; }

        [JsonPropertyName("long_text_multi")]
        public AiStudioAgentLongTextToolResponse? LongTextMulti { get; init; }

        [JsonPropertyName("basic_text_multi")]
        public AiStudioAgentBasicTextToolResponse? BasicTextMulti { get; init; }

        public AiStudioAgentAskResponse(string accessState, string description, AiStudioAgentAskResponseTypeField type = AiStudioAgentAskResponseTypeField.AiAgentAsk) {
            Type = type;
            AccessState = accessState;
            Description = description;
        }
        
        [JsonConstructorAttribute]
        internal AiStudioAgentAskResponse(string accessState, string description, StringEnum<AiStudioAgentAskResponseTypeField> type) {
            Type = AiStudioAgentAskResponseTypeField.AiAgentAsk;
            AccessState = accessState;
            Description = description;
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