using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class AiAgentTextGenResponse {
        /// <summary>
        /// The type of AI agent used for generating text.
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<AiAgentTextGenResponseTypeField>))]
        public StringEnum<AiAgentTextGenResponseTypeField>? Type { get; init; }

        [JsonPropertyName("basic_gen")]
        public AiAgentBasicGenTool? BasicGen { get; init; }

        public AiAgentTextGenResponse() {
            
        }
    }
}