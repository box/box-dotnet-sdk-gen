using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class AiAgentTextGen {
        /// <summary>
        /// The type of AI agent used for generating text.
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<AiAgentTextGenTypeField>))]
        public StringEnum<AiAgentTextGenTypeField>? Type { get; init; }

        [JsonPropertyName("basic_gen")]
        public AiAgentBasicGenTool? BasicGen { get; init; }

        public AiAgentTextGen() {
            
        }
    }
}